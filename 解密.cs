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
    public partial class 解密 : Form
    {
        public 解密()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = System.Environment.CurrentDirectory;
            string b = "\\gongj\\base64.exe";
            string c = a + b;
            Process.Start(c);
        }
    }
}
