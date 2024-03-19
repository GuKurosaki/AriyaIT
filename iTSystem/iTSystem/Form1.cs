using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iTSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"\\192.168.105.199\Bell\Update\FOC V0.5.exe";
            Process.Start(startInfo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"\\192.168.105.199\Bell\Update\VatDLT V0.6.exe";
            Process.Start(startInfo);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"\\192.168.105.199\Bell\Update\RegCal Ver 0.6.exe";
            Process.Start(startInfo);
        }
    }
}
