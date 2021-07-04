using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    class PromptData
    {
        public Prompt GetPrompt()
        {
            var prompt = new Prompt();

            using (var conn = new SqlConnection("Server=.;Database=MichaelMadLibs;Trusted_Connection=True;"))
            {
                conn.Open();

                var cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.CommandText = "SELECT COUNT(*) FROM Prompts";
                int numRows = cmd.ExecuteReader();

                
            }
        }
    }
}
