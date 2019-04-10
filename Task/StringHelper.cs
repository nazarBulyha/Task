namespace Task
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class StringHelper
    {
        public static (int, IList<char>) SplitStringByChars(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentException("Text can not be empty or null.");
            }

            if (text.Any(char.IsDigit))
            {
                throw new ArgumentException("Text can not contain numbers.");
            }

            // TODO: fix regex
            /*  Also we can group our string by chars with regex pattern:
                
                var regex = new Regex("(?<=(.))(?!\\1|$)");
                var groupedMembers = regex.Split(text);
            */

            // group from smth like xyxzyz => xxyyzz
            var groupedMembers = text.GroupBy(x => x).Select(group => new {
                CharValue = group.Key,
                CharCount = group.Count()
            }).OrderByDescending(x => x.CharCount);

            // get longest char chain in string
            var maxCharCount = groupedMembers.First().CharCount;

            // also check if there are another char with the same longest chain
            var resultChars = groupedMembers.Where(x => x.CharCount == maxCharCount)
                .Select(x => x.CharValue)
                .ToList();

            return (maxCharCount, resultChars);
        }
    }
}
