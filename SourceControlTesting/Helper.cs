using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SourceControlTesting
{
    // purpose of this class is to add helper functions.
    public class Helper
    {
        public enum CharCase { upper = 0, lower = 1, title = 2 };

        public static string ToChangeCase(string data, CharCase charCase)
        {
            switch (charCase)
            {
                case CharCase.lower: return data.ToLower();
                case CharCase.upper: return data.ToUpper();
                default: return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(data);
            }
        }
    }
}
