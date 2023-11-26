using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using static System.Net.Mime.MediaTypeNames;


namespace Tyuiu.AlmukhametovTI.Sprint5.Task6.V11.Lib
{
    public class DataService : ISprint5Task6V11
    {
        public int LoadFromDataFile(string path)
        {

            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    char[] s = { ' ', ',', '.', '\n', '\r' };
                    string[] words = line.Split(s, StringSplitOptions.RemoveEmptyEntries);
                    for ( int i = 0; i < words.Length; i++)
                    {
                        if (words[i].Length == 6)
                        {
                            count++;
                        }
                    }





                }

            }
            return count;
        }
    }
}
