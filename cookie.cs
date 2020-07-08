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

namespace 测试
{
    public partial class cookie : Form
    {
        public cookie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = System.Environment.CurrentDirectory;
            string b = "\\gongj\\cookie\\cookie.exe";
            string c = a + b;
            Process.Start(c);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = System.Environment.CurrentDirectory;
            string b = "\\gongj\\cookie\\cookie2.exe";
            string c = a + b;
            Process.Start(c);
        }
    }
}
