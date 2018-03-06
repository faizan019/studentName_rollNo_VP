using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assign
{
    class deleteSt
    {
        public void delete(StreamReader srObj, StreamWriter swObj, string str)
        {

            string line = null;
            while (!srObj.EndOfStream)
            {
                line = srObj.ReadLine();
                string subSt = line.Substring(0, 5);
                string refineSt = subSt.Trim();
                if (refineSt == str)
                {
                    swObj.WriteLine(line);
                }


                //{
                //    if (String.Compare(line, str) == 0)
                //        continue;
                //    swObj.WriteLine(line);
                //}

            }
        }
    }
}
