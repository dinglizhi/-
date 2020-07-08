using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 测试
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new on());
            if(判断.panduan==2)
            {
                System.Environment.Exit(0);
            }
            Application.Run(new start());
            Application.Run(new main());
            Application.Run(new end());
        }
    }
}
public static class 判断
{
   public static bool ison=false;
   public static bool useron = false;
    public static int  panduan = 2;
}