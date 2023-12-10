using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static synchronization.Movement;
using System.IO;
using static synchronization.Discharge;
namespace synchronization
{
    public partial class synchronization : Form
    {
        public static BlockingCollection<string> collection = new BlockingCollection<string>();
        public static DateTime time = new DateTime();
        public synchronization()
        {
            InitializeComponent();
            Thread thread = new Thread(Movement.Movement_);
            thread.Start();
        }

        private void synchronization_MouseMove(object sender, MouseEventArgs e)
        {
            Thread thread_ = new Thread(Discharge.Discharge_);
            thread_.Start();
        }
    }
}