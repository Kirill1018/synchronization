using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Windows.Forms;
namespace synchronization
{
    internal class Movement : synchronization
    {
        public static void Movement_()
        {
            string record = Cursor.Position.X.ToString() + ' ' + Cursor.Position.Y.ToString() + ' ' + time.ToString() + "   ";
            collection.Add(record);
        }
    }
}