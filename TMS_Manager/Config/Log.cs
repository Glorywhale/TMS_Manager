using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows;
using System.Windows.Forms;

namespace TMS_Manager
{
    public class Log
    {
        private static volatile Log _instance = null;
        private static object syncRoot = new Object();

        private string LogFilePath = string.Empty;

        /// <summary>
        /// LogHelper singleton Instance
        /// </summary>
        public static Log Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (syncRoot)
                    {
                        if (_instance == null)
                            _instance = new Log();
                    }
                }

                return _instance;
            }
        }

        /// <summary>
        /// ms까지 시간을 구하는 함수
        /// </summary>
        /// <returns></returns>
        public string GetDateTime()
        {
            DateTime NowDate = DateTime.Now;
            return NowDate.ToString("yyyy-MM-dd HH:mm:ss") + ":" + NowDate.Millisecond.ToString("000");
        }

        /// <summary>
        /// 에러 로그 기록
        /// </summary>
        /// <param name="str">로그내용</param>
        public void ErrorLog(Exception ex)
        {
            string str = string.Format("{0} - {1}", ex.Message, ex.StackTrace);

            string FilePath = System.AppDomain.CurrentDomain.BaseDirectory + @"\Logs\" + "Error_" + DateTime.Today.ToString("yyyyMMdd") + ".log";
            string DirPath = System.AppDomain.CurrentDomain.BaseDirectory + @"\Logs";
            string temp;

            DirectoryInfo di = new DirectoryInfo(DirPath);
            FileInfo fi = new FileInfo(FilePath);

            try
            {
                if (di.Exists != true) Directory.CreateDirectory(DirPath);

                if (fi.Exists != true)
                {
                    using (StreamWriter sw = new StreamWriter(FilePath))
                    {
                        temp = string.Format("[{0}] : {1}", GetDateTime(), str);
                        sw.WriteLine(temp);
                        sw.Close();
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(FilePath))
                    {
                        temp = string.Format("[{0}] : {1}", GetDateTime(), str);
                        sw.WriteLine(temp);
                        sw.Close();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }


        /// <summary>
        /// 로그 기록
        /// </summary>
        /// <param name="str">로그내용</param>
        public void sLog(string str, bool isException = false)
        {
            string prefix = !isException ? "Log" : "ErrorLog";

            string FilePath = System.AppDomain.CurrentDomain.BaseDirectory + @"\Logs\" + prefix + DateTime.Today.ToString("yyyyMMdd") + ".log";
            string DirPath = System.AppDomain.CurrentDomain.BaseDirectory + @"\Logs";
            string temp;

            DirectoryInfo di = new DirectoryInfo(DirPath);
            FileInfo fi = new FileInfo(FilePath);

            try
            {
                if (di.Exists != true) Directory.CreateDirectory(DirPath);

                if (fi.Exists != true)
                {
                    using (StreamWriter sw = new StreamWriter(FilePath))
                    {
                        temp = string.Format("[{0}] : {1}", GetDateTime(), str);
                        sw.WriteLine(temp);
                        sw.Close();
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(FilePath))
                    {
                        temp = string.Format("[{0}] : {1}", GetDateTime(), str);
                        sw.WriteLine(temp);
                        sw.Close();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
