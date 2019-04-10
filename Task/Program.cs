namespace Task
{
    using System;

    class Program
    {
        static void Main()
        {
            string sampleText = "aaaabbbcccccaaddddddcfggghhhh";

            var resultSplit = StringHelper.SplitStringByChars(sampleText);
            var charOrChars = resultSplit.Item2.Count == 1 ? "Char" : "Chars";

            Console.WriteLine($"{charOrChars} count in string: {resultSplit.Item1}");
            Console.Write($"{charOrChars}: ");

            foreach (var symbols in resultSplit.Item2)
            {
                Console.Write(symbols + " ");
            }

            Console.ReadKey();
        }
    }
}
