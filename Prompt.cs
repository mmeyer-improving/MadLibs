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

        public Prompt ()
        {
            //TODO: Refactor to initialize prompt with values pulled from ADO.NET
            this.Story = "My friend's name is {0}. They like {1}. They are {2}.";
            this.Blanks = new List<string>() { 
                "Friend's Name",
                "Noun",
                "Adjective"
            };
            this.Answers = new List<string>();
        }

        public void FillInBlanks()
        {
            foreach (var blank in Blanks)
            {
                Console.Write($"Give me a {blank}: ");
                string answer = Console.ReadLine();
                Answers.Add(answer);
            }
        }

        public void DisplayMadLib()
        {
            Console.WriteLine(String.Format(Story, Answers.ToArray()));
        }
    }
}
