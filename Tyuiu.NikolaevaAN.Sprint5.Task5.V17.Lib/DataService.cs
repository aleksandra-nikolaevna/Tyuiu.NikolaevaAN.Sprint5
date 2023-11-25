using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.NikolaevaAN.Sprint5.Task5.V17.Lib
{
    public class DataService : ISprint5Task5V17
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                double n;
                int c;
                while ((line = reader.ReadLine()) != null)
                {
                    c = 0;
                    n = Convert.ToDouble(line);
                    for (int i = 1; i <= n; i++)
                    {
                        if (n % i == 0)
                        {
                            c++;
                        }
                    }
                    if (c == 2)
                    {
                        res += n;
                    }
                }
                return res;
            }
        }
    }
}
