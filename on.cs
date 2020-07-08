using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 测试
{
    public partial class on : Form
    {
        public on()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            判断.ison = false;
            判断.panduan = 1;
            MessageBox.Show("欢迎使用试用版", "卧龙工具包");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string b = textBox2.Text;
            if(a== "tianxie")
            {
                if(b== "tianxielaji")
                {
                    MessageBox.Show("登录成功！", "提示");
                    判断.ison = true;
                    判断.useron = true;
                    判断.panduan = 1;
                    this.Close();
                    return;
                }
            }
            if (a == "暗影刺客")
            {
                if (b == "Life is short. I use Python")
                {
                    MessageBox.Show("登录成功！", "提示");
                    判断.ison = true;
                    判断.useron = true;
                    判断.panduan = 1;
                    this.Close();
                    return;
                }
            }
            if (a == "郜倩雪")
            {
                if (b == "Mobiwusi")
                {
                    MessageBox.Show("登录成功！", "提示");
                    判断.ison = true;
                    判断.useron = true;
                    判断.panduan = 1;
                    this.Close();
                    return;
                }
            }
            if (a == "秋风")
            {
                if (b == "qiufeng")
                {
                    MessageBox.Show("登录成功！", "提示");
                    判断.ison = true;
                    判断.useron = true;
                    判断.panduan = 1;
                    this.Close();
                    return;
                }
            }
            if (a == "丁丁")
            {
                if (b == "dinglz")
                {
                    MessageBox.Show("登录成功！", "提示");
                    判断.ison = true;
                    判断.useron = true;
                    判断.panduan = 1;
                    this.Close();
                    return;
                }
            }
            if (a == "hucmos")
            {
                if (b == "3.1415926hucmos")
                {
                    MessageBox.Show("登录成功！", "提示");
                    判断.ison = true;
                    判断.useron = true;
                    判断.panduan = 1;
                    this.Close();
                    return;
                }
            }
            if (a == "admin")
            {
                if (b == "152181")
                {
                    MessageBox.Show("登录成功！", "提示");
                    判断.ison = true;
                    判断.useron = true;
                    判断.panduan = 1;
                    this.Close();
                    return;
                }
            }
            if (a == "安静")
            {
                if (b == "anjing")
                {
                    MessageBox.Show("登录成功！", "提示");
                    判断.ison = true;
                    判断.useron = true;
                    判断.panduan = 1;
                    this.Close();
                    return;
                }
            }
            if (a == "冷月")
            {
                if (b == "lengyue")
                {
                    MessageBox.Show("登录成功！", "提示");
                    判断.ison = true;
                    判断.useron = true;
                    判断.panduan = 1;
                    this.Close();
                    return;
                }
            }
            if (a == "泉")
            {
                if (b == "quan")
                {
                    MessageBox.Show("登录成功！", "提示");
                    判断.ison = true;
                    判断.useron = true;
                    判断.panduan = 1;
                    this.Close();
                    return;
                }
            }
            if (a == "愚者")
            {
                if (b == "20040504")
                {
                    MessageBox.Show("登录成功！", "提示");
                    判断.ison = true;
                    判断.useron = true;
                    判断.panduan = 1;
                    this.Close();
                    return;
                }
            }
            if (a == "gmm_user")
            {
                if (b == "gmm_password")
                {
                    MessageBox.Show("登录成功！", "提示");
                    判断.ison = true;
                    判断.useron = true;
                    判断.panduan = 1;
                    this.Close();
                    return;
                }
            }
            if (a == "ericeric")
            {
                if (b == "ericeric")
                {
                    MessageBox.Show("登录成功！", "提示");
                    判断.ison = true;
                    判断.useron = true;
                    判断.panduan = 1;
                    this.Close();
                    return;
                }
            }
            /*判断登录部分*/
            MessageBox.Show("登录失败！", "提示");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
