using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.AlmukhametovTI.Sprint5.Task1.V18.Lib
{
    public class DataService : ISprint5Task1V18
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";

            FileInfo frt = new FileInfo(path);
            bool fileExists = frt.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            double y;
            string stry;
            for( int x = startValue; x <= stopValue; x++)
            {               
                if ( x != 0)
                {
                    y = Math.Round(3 * x + 2 - (2 * x - x) / (Math.Cos(x) + 1), 2);                  
                }              
                else
                {
                    y = 0;
                    
                }

                stry = Convert.ToString(y);

                if ( x != stopValue)
                {
                    File.AppendAllText(path, stry + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, stry);
                }
            }
            return path;           
        }
    }
}
