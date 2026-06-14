using System.Text;

namespace PointsBet_Backend_Online_Code_Test
{

    /*
    Improve a block of code as you see fit in C#.
    You may make any improvements you see fit, for example:
      - Cleaning up code
      - Removing redundancy
      - Refactoring / simplifying
      - Fixing typos
      - Any other light-weight optimisation
    */
    public static class StringFormatter
    {

        //Code to improve
        /// <summary>
        /// Converts an array of strings into a single string with each item separated by a comma and optionally enclosed in quotes.
        /// </summary>
        /// <param name="items">The array of strings to convert.</param>
        /// <param name="quote">The character to use for quoting each item.</param>
        /// <returns>A single string with the items separated by a comma and optionally enclosed in quotes.</returns>
        public static string ToQuotedCommaSeparatedString(string[] items, char quote = '\"')
        {
            if (items == null || items.Length == 0)
            {
                return string.Empty;
            }

            StringBuilder qry = new StringBuilder($"{quote}{items[0]?.Trim()}{quote}");
            
            for (int i = 1; i < items.Length; i++)
                {
                    qry.Append($", {quote}{items[i]?.Trim()}{quote}");
                }

            return qry.ToString();
        }
    }
}
