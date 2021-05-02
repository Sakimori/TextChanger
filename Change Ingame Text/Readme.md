# Change Ingame Text Mod
A mod that allows you to change specific ingame words/sentences. The mod allows upto 20 changes.

### Note: If your word/sentence didn't get changed, check the captitalization.
- The mod checks for the text provided, and the full upper and lower case version of the text provided. So putting in "soul" wouldn't change the word "Soul" (but the other way around would) so put the text properly

## How to use
- [Download the mod](https://github.com/TheMulhima/Misc-Mods/releases/download/v1.0/ChangeIngameText.dll) and follow the [instructions on how to install it](https://github.com/TheMulhima/Misc-Mods#to-download-a-mod).
- Follow instructions on [how to generate the settings file](https://github.com/TheMulhima/Misc-Mods/blob/main/README.md#how-to-generate-settings-file) for the mod.
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
