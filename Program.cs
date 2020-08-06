using System;
using System.Text.RegularExpressions;


namespace Regularexp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            string textToSearch = "This is Sparta!";
            string regex = "[a-z]";
            MatchCollection matchResults = Regex.Matches(textToSearch, regex);
            foreach(Match m in matchResults)
            {
                Console.WriteLine(m);
            }

            string textToSearch1 = "afgkk24679ggZXVFcatcat9970b02dogMaryxxxxbbbb22FHDFISHMOTHERfaskldjflasjfjasdfjzxcv xcEYERTR345262372546vbcvb0000000carTT2356236623732623462366johnxcxcxvbdfsdgvxc vC#00002499xbvvcfgooglecvcvxzvdfgsdjiiruewortuiwerioptunvxn990348590234523907854034s dnskfshwateririweotowyuwerituwreutpwetuwertueryuwertwerutpweurtpuweptnvmxcvnnxcxcxvb ";
            string regex1 = "[a-z]at";
            MatchCollection matchResults1 = Regex.Matches(textToSearch1, regex1);
            foreach (Match m in matchResults1)
            {
                Console.WriteLine(m);
            }
            

        }
    }
}
