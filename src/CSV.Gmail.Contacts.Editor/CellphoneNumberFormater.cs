using System.Text.RegularExpressions;

namespace CSV.Gmail.Contacts.Editor
{
    public static class CellphoneNumberFormater
    {
        public static string FormatNumber(string number, string localCodePrefix, string prefixFormat)
        {
            if (number.StartsWith("+"))
                return number;

            Regex reg = new Regex(@"[^0-9]");
            var normalizedNumber = reg.Replace(number, string.Empty);

            if (normalizedNumber.Length > 8)
            {
                if (normalizedNumber.Length == 14 && normalizedNumber.StartsWith("015"))
                    return FormatNumber(normalizedNumber.Substring(3), localCodePrefix, prefixFormat);

                if (normalizedNumber.Length == 9 && normalizedNumber.StartsWith("9"))
                    return $"+5531{normalizedNumber}";

                if (normalizedNumber.StartsWith($"0{localCodePrefix}"))
                {
                    return RegexReplace($"0{localCodePrefix}", normalizedNumber, prefixFormat);
                }
                else if (normalizedNumber.StartsWith($"{localCodePrefix}"))
                {
                    return RegexReplace(localCodePrefix, normalizedNumber, prefixFormat);
                }
                return normalizedNumber;
            }

            if (StartsAsOldCellphone(normalizedNumber))
                return $"+55319{normalizedNumber}";

            return normalizedNumber;
        }

        private static bool StartsAsOldCellphone(string normalizedNumber)
        {
            if (normalizedNumber.Length == 8)
            {
                string[] cellphoneStarts = new string[] {
                    "9", "8", "7"
                };

                foreach (var item in cellphoneStarts)
                {
                    if (normalizedNumber.StartsWith(item))
                        return true;
                }
            }

            return false;
        }

        private static string RegexReplace(string localCodePrefix, string normalizedNumber, string prefixFormat)
        {
            var regex = new Regex(Regex.Escape(localCodePrefix));
            var newNormalizedNumber = regex.Replace(normalizedNumber, prefixFormat, 1);
            return newNormalizedNumber;
        }
    }
}