using System.Text.RegularExpressions;

namespace LibreriaNet
{
    public class Utils
    {
        public static int CountRegexMatchs(string text, string regex)
        {
            int count = Regex.Count(text, regex);

            return count;
        }
    }
}