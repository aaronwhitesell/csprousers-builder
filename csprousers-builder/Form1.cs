using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csprousers_builder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonServeLocalBuild_Click(object sender, EventArgs e)
        {
            var process = new System.Diagnostics.Process();
            var startInfo = new System.Diagnostics.ProcessStartInfo
            {
                FileName = "cmd.exe",
                WorkingDirectory = @"D:\dev\work\github\csprousers",
                Arguments = "/k jekyll serve",
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal,
                UseShellExecute = false
            };

            process.StartInfo = startInfo;
            process.Start();
        }

        private void buttonOpenBrowse_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://localhost:4000");
        }

        private void buttonCleanBuild_Click(object sender, EventArgs e)
        {
            var process = new System.Diagnostics.Process();
            var startInfo = new System.Diagnostics.ProcessStartInfo
            {
                FileName = "cmd.exe",
                WorkingDirectory = @"D:\dev\work\github\csprousers",
                Arguments = "/k jekyll clean",
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal,
                UseShellExecute = false
            };

            process.StartInfo = startInfo;
            process.Start();
        }

        private void buttonProductionBuild_Click(object sender, EventArgs e)
        {
            var process = new System.Diagnostics.Process();
            var startInfo = new System.Diagnostics.ProcessStartInfo
            {
                FileName = "cmd.exe",
                WorkingDirectory = @"D:\dev\work\github\csprousers",
                Arguments = "/k jekyll clean&jekyll build",
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal,
                UseShellExecute = false
            };

            process.StartInfo = startInfo;
            process.Start();
        }
    }
}
