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
        public List<KeyValuePair<string, string>> Blanks { get; set; }
    }
}
