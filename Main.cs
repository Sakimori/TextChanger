using System.Collections.Generic;
using Modding;

/*Required References
 *
 *Assembly-Csharp.dll (Modding API)
 */


namespace ChangeIngameTextMod
{
    public class ChangeIngameTextMod : Mod
    {
        public ChangeIngameTextMod() : base("Change Ingame Text") { }
        public override string GetVersion() => "1.0";
        public GlobalModSettings _gs = new GlobalModSettings();
        public override void Initialize()
        {
            ModHooks.Instance.LanguageGetHook += LanguageGet;
        }
        public override ModSettings GlobalSettings
        {
            get => _gs;
            set => _gs = (GlobalModSettings)value;
        }
        public string LanguageGet(string key, string sheet)
        {
            var GameText = Language.Language.GetInternal(key, sheet);

            foreach (KeyValuePair<string, string> kvp in _gs.TextToChange)
            {
                string original_text = kvp.Key;
                string new_text = kvp.Value;
                if (GameText.Contains(original_text)) return GameText.Replace(original_text, new_text);
                
                original_text = original_text.ToUpper();
                new_text = new_text.ToUpper();
                if (GameText.Contains(original_text)) return GameText.Replace(original_text, new_text);
                
                original_text = original_text.ToLower();
                new_text = new_text.ToLower();
                if (GameText.Contains(original_text)) return GameText.Replace(original_text, new_text);
            }

            return Language.Language.GetInternal(key, sheet);
        }
    }
}
