namespace ExtensionLibTest {
    public static class StringExtLib {
        public static void WriteLn(this string s, string Prefix="", string Suffix="") {
            Console.WriteLine($"{Prefix}{s}{Suffix}");
        }
        public static decimal ToDecimal(this string IN) {
            string s = IN;
            s = s.Trim();
            if (s[0]=='$') {
                s = s.Substring(1);
            }
            s = s.Replace(",","");
            decimal rtn;
            var rc = decimal.TryParse(s, out rtn);
            if (!rc) {
                throw new Exception("String contains Non-Numeric characters");
            }
            return rtn;
        }
        public static string AllCaps(this string IN) {
            return IN.ToUpper();
        }
        public static string AllSmall(this string IN) {
            return IN.ToLower();
        }
    }
}