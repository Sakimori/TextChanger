# Misc-Mods
A collections of miscellaneous, semi-useful mods for Hollow Knight

### The Readmes for the specific mods can be found in their coressponding folders

## How to Use
### To download a mod 
- Download the modding API by using the Modinstaller which can be found in the hollow knight discord.
- Open the releases tab and download the one you want from there.
- Place the `.dll` file in: 
  - Windows: `Hollow Knight\hollow_knight_Data\Managed\Mods`.
  - Mac `hollow_knight.app\contents\Resources\Data\Managed\Mods`.
- To get to the Hollow knight folder / hollow_knight.app:
  - Steam: Go to your Library -> Right Click Hollow Knight -> Click on Properties-> Local Files -> Browse.
  - GoG: Select the symbol next to the play button -> Click on Manage Installation -> Show Folder.
- Then run the game and enjoy using the mod.

- Some of them might require you to change a value in a settings file. To generate the file run the game once with the mod installed and verify that it is installed by seeing if it appears on the top left of the title screen. Then close the game and open the .json file in the saves folder.
- To get to saves folder:
  - Windows: `%APPDATA%\..\LocalLow\Team Cherry\Hollow Knight\`
  - Mac: `~/Library/Application Support/unity.Team Cherry.Hollow Knight/`

### Read the code the mod (idk why you would but it doesnt hurt to include how)
- Open the folder to that mod and read the `.cs` files.

### Re-Code the mod
- To compile the mod (to change it or to make the mod yourself because you dont trust me):
  - Make a new C# Class Library project in .NET Framework 3.5.
  - Add reference to the modding API (`Asembly-Csharp.dll`) and any other references specified in the comment of the top of the main mod file.
  - Build it and add it to your mods folder and enjoy.
