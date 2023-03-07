import sys
import os
import sys
import subprocess

def PrintInformation(information:str)->None:
    print(f"\u001b[33m{information}\u001b[0m")

newFolder = sys.argv[1]
directory = os.path.abspath(os.getcwd())
allFolders = [f for f in next(os.walk('.'))[1] if f[0] != '.']

commands = ["dotnet new sln","dotnet new console --output ConsoleApplication","dotnet sln add ConsoleApplication"]

for f in allFolders:
    PrintInformation(f"Processing folder: {f}")
    currentFolder = f"{directory}\\{f}"
    subprocess.call(f"mkdir {newFolder}", shell=True, cwd=currentFolder)
    fullPath = f"{currentFolder}\\{newFolder}\\"   
    [subprocess.call(command, shell=True, cwd=fullPath) for command in commands]
    PrintInformation(f"Done processing folder {f}")
