import sys
import os
import subprocess
import requests
from colorama import init
from termcolor import cprint
from colorist import Color

Test = True


def PrintInformation(information:str)->None:
    cprint(information, "green")

def get_latest_nuget_versions(package_ids):
    cprint("Getting nuget packages' latest version", "green")
    versions = {}
    for package_id in package_ids:
        cprint(f"\tProcessing {package_id}", "yellow")
        url = f"https://api.nuget.org/v3-flatcontainer/{package_id}/index.json"
        response = requests.get(url)
        if response.status_code == 200:
            data = response.json()
            versions[package_id] = data["versions"][-1]
    return versions

def main():
    newProjectName = "TEst" if Test else sys.argv[1]
    test_project_name = f'{newProjectName}.Tests'
    directory = os.path.abspath(os.getcwd())
    allFolders = [f for f in next(os.walk('.'))[1] if f[0] != '.'][:1]
    allFolders = allFolders[:1] if Test else allFolders
    nuget_packages = ['XUnit', 'Moq', 'NSubstitute', 'FluentAssertions', 'Microsoft.NET.Test.Sdk']
    packagesAndVersions = get_latest_nuget_versions(nuget_packages)
    
    commands = ["dotnet new sln",f"dotnet new console --output {newProjectName}.Console",f"dotnet sln add {newProjectName}.Console"]

    for f in allFolders:
        PrintInformation(f"Processing folder: {f}")
        currentFolder = f"{directory}\\{f}"
        subprocess.call(f"mkdir {newProjectName}", shell=True, cwd=currentFolder)
        fullPath = f"{currentFolder}\\{newProjectName}\\ ".strip() 
        [subprocess.call(command, shell=True, cwd=fullPath) for command in commands]
        solution_path = f'{fullPath}\\{newProjectName}.sln'
        test_project_directory = os.path.join(os.path.dirname(solution_path), test_project_name)
        os.makedirs(test_project_directory, exist_ok=True)
        os.chdir(test_project_directory)

        PrintInformation(f"Adding test project")
        test_project_file = os.path.join(test_project_directory, f'{test_project_name}.csproj')
        with open(test_project_file, 'w') as file:
            file.write(get_test_project_file_content(packagesAndVersions))
    
        usingsFile = os.path.join(test_project_directory, 'Usings.cs')
        with open(usingsFile, 'w') as file:
            file.write(get_usings_file_content())
    
        testFilePath = os.path.join(test_project_directory, 'Test1.cs')
        with open(testFilePath, 'w') as file:
            file.write(get_first_test_file_content(test_project_name))
        execute_command(f'dotnet sln {solution_path} add {test_project_file}')

        PrintInformation(f"Adding nuget packages")
        for package in nuget_packages:
            execute_command(f'dotnet add {test_project_file} package {package}')
        PrintInformation(f"Done processing folder {f}")

def get_usings_file_content():
    return '''global using Xunit;
global using FluentAssertions;
global using ConsoleApplication;
'''

def get_first_test_file_content(namespace):
    return f'''namespace {namespace};

public class PalindromCheckerTests
{{
    [Fact]
    public void Test()
    {{
    }}
}}
'''

def get_test_project_file_content(nuget_packages):
    packages_section = '\n'.join(f'<PackageReference Include="{package}" Version="{version}" />' for package, version in nuget_packages.items())

    return f'''<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <TargetFramework>net7.0</TargetFramework>
  </PropertyGroup>

  <ItemGroup>
    {packages_section}
  </ItemGroup>
  <ItemGroup>
  <ProjectReference Include="..\ConsoleApplication\ConsoleApplication.csproj" />
</ItemGroup>
</Project>'''

def execute_command(command):
    process = subprocess.Popen(command, stdout=subprocess.PIPE, shell=True)
    output, _ = process.communicate()
    print(output.decode())

if __name__ == '__main__':
    init()
    main()
