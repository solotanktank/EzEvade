using System.Collections.Generic;

namespace ezEvade.Languages
{
    public abstract class LanguageAddon
    {
        public Dictionary<Config.ConfigValue, string> LangDictionary { get; set; }
    }
}