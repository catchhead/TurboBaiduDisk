﻿using APIClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurboBaiduDisk
{
    static class Program
    {
        public static GlobalConfig Config;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Control.CheckForIllegalCrossThreadCalls = false;
#if !DEBUG
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
#endif

            Config = GlobalConfig.Load();

            Task.Run(new Action(StartSpeedTest));

            if(Config.SavedCredential != null)
            {
                Client.Authentication = Config.SavedCredential;
                Client client = new Client();

                if (client.CheckIsLogined())
                {
                    Run();
                }
            }

            Client clientLogin = new Client();
            if (clientLogin.Login())
            {
                Config.SavedCredential = Client.Authentication;
                Config.Save();
                Run();
            }
        }

        static void StartSpeedTest()
        {
            if (Config.MaxSpeed != 0 && (DateTime.Now - Config.LastSpeedTest).Days > 3)
                return;

            HttpWebRequest r = WebRequest.CreateHttp("http://dldir1.qq.com/qqfile/qq/QQ8.9.3/21159/QQ8.9.3.exe");
            HttpWebResponse rp = (HttpWebResponse)r.GetResponse();
            Stream rpStream = rp.GetResponseStream();
            Stopwatch sw = Stopwatch.StartNew();
            byte[] buffer = new byte[1024 * 8];
            int read = 0;
            long totalRead = 0;
            while ((read = rpStream.Read(buffer, 0, buffer.Length)) > 0)
                totalRead += read;
            rpStream.Close();
            r.Abort();

            Config.MaxSpeed = (long)(rp.ContentLength / (sw.Elapsed.TotalMilliseconds / (double)1000));
            Config.LastSpeedTest = DateTime.Now;
            Config.Save();
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            ExceptionHandler(e.ExceptionObject as Exception);
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            ExceptionHandler(e.Exception);
        }

        private static void ExceptionHandler(Exception ex)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Time: {DateTime.Now}");
            sb.AppendLine($"Exception:\r\n{ex.ToString()}");
            string filename = $"crush_{DateTime.Now:yyyyMMdd_hhmmss}.txt";
            File.WriteAllText(filename, sb.ToString());
            MessageBox.Show($"一个未知的严重错误在运行时出现。强烈建议您把下面的错误信息通过Issues或其他方式报告给作者：{sb.ToString()}\r\n 错误信息已保存到程序目录下。如果下载正在运行，数据可能会丢失。", "Crush", MessageBoxButtons.OK, MessageBoxIcon.Error);
            System.Diagnostics.Process.Start("explorer.exe", $"/select,\"{Path.Combine(Environment.CurrentDirectory, filename)}\"");
            Environment.Exit(0);
        }

        static void Run()
        {
            Application.Run(new MainForm());
            Environment.Exit(0);
        }
    }
}
