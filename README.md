# Change Ingame Text Mod
A mod that allows you to change specific ingame words/sentences. The mod allows upto 20 changes.

### Note: If your word/sentence didn't get changed, check the captitalization.
- The mod checks for the text provided, and the full upper and lower case version of the text provided. So putting in "soul" wouldn't change the word "Soul" (but the other way around would) so put the text properly

## How to use
- [Download the mod](https://github.com/TheMulhima/Misc-Mods/releases/download/v1.0/ChangeIngameText.dll) and follow the [instructions on how to install it](https://github.com/TheMulhima/HollowKnight-ChangeIngameTextMod/blob/main/README.md#to-download-a-mod).
- Follow instructions on [how to generate the settings file](https://github.com/TheMulhima/HollowKnight-ChangeIngameTextMod/blob/main/README.md#how-to-generate-settings-file) for the mod.
- When you open the file, you'll see something like this:
```
  "TextToChange": {
    "Dummy1": "Dummy_Text",
    "Dummy2": "Dummy_Text"
```
- Replace the `"Dummy1"` with the word that is currently in the game.
- Replace the `"Dummy_Text"` with the word that you want to change to.
- I have provided 20 texts to change. if for some reason you want more, copy the `"Dummy1": "Dummy_Text",` format making sure to put commas between each of them.
- Save the settings file and run the game.
- Enjoy.

## How to download
- Download the modding API by using the Modinstaller which can be found in the hollow knight discord.
- Open the releases tab and download the one you want from there.
- Place the `.dll` file in: 
  - Windows: `Hollow Knight\hollow_knight_Data\Managed\Mods`.
  - Mac `hollow_knight.app\contents\Resources\Data\Managed\Mods`.
- To get to the Hollow knight folder / hollow_knight.app:
  - Steam: Go to your Library -> Right Click Hollow Knight -> Click on Properties-> Local Files -> Browse.
  - GoG: Select the symbol next to the play button -> Click on Manage Installation -> Show Folder.
- Then run the game and enjoy using the mod.

#### How to generate Settings file
- Some of them might require you to change a value in a settings file. To generate the file run the game once with the mod installed and verify that it is installed by seeing if it appears on the top left of the title screen. Then load a save file, close it, and then close the game and open the .json file in the saves folder.
- To get to saves folder:
  - Windows: `%APPDATA%\..\LocalLow\Team Cherry\Hollow Knight\`
  - Mac: `~/Library/Application Support/unity.Team Cherry.Hollow Knight/`
