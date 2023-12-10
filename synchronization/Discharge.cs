using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace synchronization
{
    internal class Discharge : synchronization
    {
        public static void Discharge_()
        {
            byte[] buffer = new byte[1024];
            using (Stream stream = File.Create("synchronization.txt"))
            {
                foreach(string record in collection)
                {
                    string read = record;
                    stream.Write(buffer, 0, read.Length);
                }
            }
        }
    }
}