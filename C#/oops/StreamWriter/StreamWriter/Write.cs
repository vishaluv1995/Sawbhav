using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamWrite
{
    class Write
    {
        StringBuilder sb = new StringBuilder();
        StreamWriter sw;

        public string WriteText(string strfilepath, string strtext)
        {
            if (!File.Exists(strfilepath))
            {
                FileInfo fileinfo = new FileInfo(strfilepath);

                if (!fileinfo.Exists)
                {
                    fileinfo.CreateText();
                }
            }
            sb.Clear();
            sb.Append(File.ReadAllText(strfilepath));
            sb.Append(strtext);
            sw = new StreamWriter(strfilepath);
            sw.WriteLine(sb);
            sw.Close();

            string readfiletxt = File.ReadAllText(strfilepath);
            return readfiletxt;
        }
    }
}
