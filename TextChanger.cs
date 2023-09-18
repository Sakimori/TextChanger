using System.Collections.Generic;
using Modding;
using UnityEngine;

/*Required References
 *
 *Assembly-Csharp.dll (Modding API)
 */


namespace TextChanger
{
    public class TextChanger : Mod, ILocalSettings<CustomLocalSaveData>
    {
        public TextChanger() : base("TextChanger") { 
        }
        public static TextChanger LoadedInstance;
        public override string GetVersion() => "1.0.0";
        public Dictionary<(string, string), string> textOverrides = new Dictionary<(string, string), string>();

        public CustomLocalSaveData LocalSaveData = new CustomLocalSaveData();

        public void OnLoadLocal(CustomLocalSaveData s){
            this.LocalSaveData = s;
        }
        public CustomLocalSaveData OnSaveLocal() {
            return this.LocalSaveData;
        }
        public override void Initialize()
        {
            if (TextChanger.LoadedInstance == null)
            {
                TextChanger.LoadedInstance = this;
                ModHooks.LanguageGetHook += this.LanguageGet;
                ModHooks.SavegameLoadHook += slot =>{
                    this.textOverrides = new Dictionary<(string, string), string>();
                    foreach ((string,string) keySheetTuple in LocalSaveData.overrides.Keys)
                    {
                        this.addOverride(keySheetTuple.Item1, keySheetTuple.Item2, LocalSaveData.overrides[keySheetTuple]);
                    }
                };
                Logger.Log("TextChanger hooked.");
            }
        }

        public void addOverride(string key, string sheet, string newText){
            textOverrides[(key, sheet)] = newText;
            this.LocalSaveData.overrides[(key, sheet)] = newText;
        }

        public string LanguageGet(string key, string sheet, string orig)
        {
            if (textOverrides != null){
                if (textOverrides.ContainsKey((key, sheet))){
                    return textOverrides[(key,sheet)];
                }
                else{
                    return orig;
                }
            }
            else{
                return orig;
            }
        }
    }

    public class CustomLocalSaveData {
        public Dictionary<(string, string), string> overrides;

        public CustomLocalSaveData(){
            overrides = new Dictionary<(string, string), string>();
        }
    }
}