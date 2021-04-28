using Modding;

/*Required References
 *
 *Assembly-Csharp.dll (Modding API)
 *
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
            string GameText = Language.Language.GetInternal(key, sheet);

            if (_gs.Original1 != "") if (GameText.Contains(_gs.Original1)) return GameText.Replace(_gs.Original1, _gs.NewWord1);
            
            if (_gs.Original2 != "") if (GameText.Contains(_gs.Original2)) return GameText.Replace(_gs.Original2, _gs.NewWord2);
            
            if (_gs.Original3 != "") if (GameText.Contains(_gs.Original3)) return GameText.Replace(_gs.Original3, _gs.NewWord3);
            
            if (_gs.Original4 != "") if (GameText.Contains(_gs.Original4)) return GameText.Replace(_gs.Original4, _gs.NewWord4);
            
            if (_gs.Original5 != "") if (GameText.Contains(_gs.Original5)) return GameText.Replace(_gs.Original5, _gs.NewWord5);
           
            if (_gs.Original6 != "") if (GameText.Contains(_gs.Original6)) return GameText.Replace(_gs.Original6, _gs.NewWord6);

            if (_gs.Original7 != "") if (GameText.Contains(_gs.Original7)) return GameText.Replace(_gs.Original7, _gs.NewWord7);
            
            if (_gs.Original8 != "") if (GameText.Contains(_gs.Original8)) return GameText.Replace(_gs.Original8, _gs.NewWord8);
            
            if (_gs.Original9 != "") if (GameText.Contains(_gs.Original9)) return GameText.Replace(_gs.Original9, _gs.NewWord9);
            
            if (_gs.Original10 != "") if (GameText.Contains(_gs.Original10)) return GameText.Replace(_gs.Original10, _gs.NewWord10);
           
            if (_gs.Original11 != "") if (GameText.Contains(_gs.Original11)) return GameText.Replace(_gs.Original11, _gs.NewWord11);
            
            if (_gs.Original12 != "") if (GameText.Contains(_gs.Original12)) return GameText.Replace(_gs.Original12, _gs.NewWord12);
            
            if (_gs.Original13 != "") if (GameText.Contains(_gs.Original13)) return GameText.Replace(_gs.Original13, _gs.NewWord13);
            
            if (_gs.Original14 != "") if (GameText.Contains(_gs.Original14)) return GameText.Replace(_gs.Original14, _gs.NewWord14);
           
            if (_gs.Original15 != "") if (GameText.Contains(_gs.Original15)) return GameText.Replace(_gs.Original15, _gs.NewWord15);
            
            if (_gs.Original16 != "") if (GameText.Contains(_gs.Original16)) return GameText.Replace(_gs.Original16, _gs.NewWord16);
            
            if (_gs.Original17 != "") if (GameText.Contains(_gs.Original17)) return GameText.Replace(_gs.Original17, _gs.NewWord17);
            
            if (_gs.Original18 != "") if (GameText.Contains(_gs.Original18)) return GameText.Replace(_gs.Original18, _gs.NewWord18);
            
            if (_gs.Original19 != "") if (GameText.Contains(_gs.Original19)) return GameText.Replace(_gs.Original19, _gs.NewWord19);

            if (_gs.Original20 != "") if (GameText.Contains(_gs.Original20)) return GameText.Replace(_gs.Original20, _gs.NewWord20);

            return Language.Language.GetInternal(key, sheet);
        }
    }
}
