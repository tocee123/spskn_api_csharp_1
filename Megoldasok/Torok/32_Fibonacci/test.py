import os
import subprocess

import requests

def get_latest_nuget_versions(package_ids):
    versions = {}
    for package_id in package_ids:
        print(f"Processing {package_id}")
        url = f"https://api.nuget.org/v3-flatcontainer/{package_id}/index.json"
        response = requests.get(url)
        if response.status_code == 200:
            data = response.json()
            versions[package_id] = data["versions"][-1]
    return versions

def main():
    # Specify the solution and test project names
    solution_path = r'c:\\Users\\tamas.torok\Documents\\GitHub\spskn_api_csharp_1\\Megoldasok\\Torok\32_Fibonacci\32_Fibonacci.sln'
    test_project_name = 'ConsoleApplication.Tests'

    # Specify the NuGet packages to be installed
    nuget_packages = ['XUnit', 'Moq', 'NSubstitute', 'FluentAssertions', 'Microsoft.NET.Test.Sdk']

    # Create the test project directory
    test_project_directory = os.path.join(os.path.dirname(solution_path), test_project_name)
    os.makedirs(test_project_directory, exist_ok=True)

    # Change to the test project directory
    os.chdir(test_project_directory)

    # Create the test project file
    test_project_file = os.path.join(test_project_directory, f'{test_project_name}.csproj')
    with open(test_project_file, 'w') as file:
        file.write(get_test_project_file_content(nuget_packages))
    
    usingsFile = os.path.join(test_project_directory, 'Usings.cs')
    with open(usingsFile, 'w') as file:
        file.write(get_usings_file_content())
    
    testFilePath = os.path.join(test_project_directory, 'Test1.cs')
    with open(testFilePath, 'w') as file:
        file.write(get_first_test_file_content(test_project_name))

    # Add the test project to the solution
    execute_command(f'dotnet sln {solution_path} add {test_project_file}')

    # Install NuGet packages
    for package in nuget_packages:
        execute_command(f'dotnet add {test_project_file} package {package}')

    print('Test project created successfully.')

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
    packagesAndVersions = get_latest_nuget_versions(nuget_packages)
    packages_section = '\n'.join(f'<PackageReference Include="{package}" Version="{version}" />' for package, version in packagesAndVersions.items())

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
    main()
