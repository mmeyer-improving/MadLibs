using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    class Prompt
    {
        public string Story { get; set; }
        public List<string> Blanks { get; set; }
        public List<string> Answers { get; set; }

        public void FillInBlanks()
        {
            foreach (var blank in Blanks)
            {
                Console.Write($"Give me a {blank}: ");
                string answer = Console.ReadLine();
                Console.WriteLine(answer);
                Answers.Add(answer);
            }
        }

        public void DisplayMadLib()
        {
            Console.WriteLine(String.Format(Story, Answers.ToArray()));
        }
    }
}
