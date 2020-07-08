using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 测试
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = System.Environment.CurrentDirectory;
            string b = "\\gongj\\LOIC.exe";
            string c = a + b;
            Process.Start(c);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var a = new show())
            {
                a.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string a = System.Environment.CurrentDirectory;
            string b = "\\gongj\\ddos.zip";
            string c = a + b;
            Process.Start(c);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string a = System.Environment.CurrentDirectory;
            string b = "\\gongj\\sqlmap\\Run.exe";
            string c = a + b;
            Process.Start(c);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string a = System.Environment.CurrentDirectory;
            string b = "\\gongj\\maren.exe";
            string c = a + b;
            Process.Start(c);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string a = System.Environment.CurrentDirectory;
            string b = "\\gongj\\yujian\\御剑后台扫描工具.exe";
            string c = a + b;
            Process.Start(c);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string a = System.Environment.CurrentDirectory;
            string b = "\\gongj\\vpn\\vpngate-client-v4.22-9634-beta-2016.11.27.exe";
            string c = a + b;
            Process.Start(c);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            using (var a = new shegong())
            {
                a.ShowDialog();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string a = System.Environment.CurrentDirectory;
            string b = "\\gongj\\进程抓包.exe";
            string c = a + b;
            Process.Start(c);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            using (var a = new ip())
            {
                a.ShowDialog();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string a = System.Environment.CurrentDirectory;
            string b = "\\gongj\\渗透\\渗透系统.exe";
            string c = a + b;
            if(判断.ison)
            {
                Process.Start(c);
            }
            else
            {
                MessageBox.Show("您没有足够的权限", "提示");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            using (var a = new 装机())
            {
                a.ShowDialog();
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if(判断.ison)
            {
                using (var a = new liulan())
                {
                  a.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("您没有足够的权限", "提示");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            using (var a = new 赞助())
            {
                a.Show();
                MessageBox.Show("谢谢您使用本功能！", "卧龙工具箱");
            }
            using (var a = new zanzhu())
            {
                a.ShowDialog();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
           
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://dinglz.aote.xyz/");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            using(var a=new 解密())
            {
                a.ShowDialog();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if(判断.ison)
            {
                using(var a=new cookie())
                {
                    MessageBox.Show("尝尝丁丁制作的小饼干吗？", "卧龙工具箱");
                    a.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("您没有足够的权限", "卧龙工具箱");
            }
        }
    }
}
