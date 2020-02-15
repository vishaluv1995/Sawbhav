using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFile
{
    class Read
    {

        public string ReadFile(string strFilePath)
        {
            StreamReader sr = new StreamReader(strFilePath);
            int counter = 0;
            string ln;

            while ((ln = sr.ReadLine()) != null)
            {
                Console.WriteLine(ln);
                counter++;
            }
            sr.Close();

            return ln;
        }
    }
}
