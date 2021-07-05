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
            int randomRow = GetRandomRowNumber();


            using (var conn = new SqlConnection("Server=.;Database=MichaelMadLibs;Trusted_Connection=True;"))
            {
                conn.Open();

                var cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.CommandText = $"SELECT Story, Blanks FROM Prompts WHERE Id={randomRow}";

                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    prompt.Story = reader["Story"].ToString();
                    var blanksString = reader["Blanks"].ToString();
                    prompt.Blanks = blanksString.Split(",").ToList();
                    prompt.Answers = new List<string>();
                }
            }

            return prompt;
        }

        public int GetRandomRowNumber()
        {
            int RowCount = -1;

            using (var conn = new SqlConnection("Server=.;Database=MichaelMadLibs;Trusted_Connection=True;"))
            {
                conn.Open();

                var cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.CommandText = "SELECT COUNT(*) AS 'RowCount' FROM Prompts";

                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    RowCount = Convert.ToInt32(reader["RowCount"]);
                }
            }

            Random random = new Random();

            return random.Next(1, RowCount + 1);
        }
    }
}
