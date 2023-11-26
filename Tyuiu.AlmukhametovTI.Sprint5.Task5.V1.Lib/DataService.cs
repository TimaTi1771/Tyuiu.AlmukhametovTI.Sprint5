using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;


namespace Tyuiu.AlmukhametovTI.Sprint5.Task5.V1.Lib
{
    public class DataService : ISprint5Task5V1
    {
        public double LoadFromDataFile(string path)
        {
            double sum = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    double number = Math.Round(double.Parse(line));                   
                    {
                        if (number % 2 == 0) 
                        {
                            sum += number; 
                        }   
                    }                   
                }              
            }
            return sum;
        }                                                                                                    
    } 
}
