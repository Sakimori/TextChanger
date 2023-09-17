using System.Collections.Generic;
using Modding;

/*Required References
 *
 *Assembly-Csharp.dll (Modding API)
 */


namespace TextChangerNS
{
    public class TextChanger : Mod
    {
        public TextChanger() : base("TextChanger") { 
        }
        public static TextChanger LoadedInstance;
        public override string GetVersion() => "1.0.0";
        public TextOverrides textOverrides = new TextOverrides();
        public override void Initialize()
        {
            if (TextChanger.LoadedInstance == null)
            {
                TextChanger.LoadedInstance = this;
                ModHooks.LanguageGetHook += this.LanguageGet;
            }

        }

        public void addOverride(string key, string sheet, string newText){
            if (!(textOverrides.changed.ContainsKey((key, sheet)))){
                textOverrides.changed.Add((key, sheet), newText);
            }
        }

        public string LanguageGet(string key, string sheet, string orig)
        {
            this.Log($"Sheet {sheet}, key {key} called.");
            if (textOverrides.changed.ContainsKey((key, sheet))){
                return textOverrides.changed[(key,sheet)];
            }
            else{
                return orig;
            }
        }
    }

    public class TextOverrides : object {
        public Dictionary<(string,string), string> changed = new Dictionary<(string,string), string>();
    }
}