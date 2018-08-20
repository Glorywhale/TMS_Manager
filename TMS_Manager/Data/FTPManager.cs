using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace TMS_Manager
{
    public class FTPManager
    {
        string ftpPath = "ftp://112.175.184.86/TMS/tms.db";
        string id = "glorywhale";
        string pw = "1q2w3e4r";

        WebClient cli;
        string _localPath = "";
        public void UpAndDownloadFile(string filePath, bool isDownload)
        {
            try
            {
                FtpWebRequest req = (FtpWebRequest)WebRequest.Create(ftpPath);
                req.Method = WebRequestMethods.Ftp.DownloadFile;
                // 익명 로그인이 아닌 경우 로그인/암호를 제공해야
                req.Credentials = new NetworkCredential(id, pw);
                _localPath = filePath;
                if (cli == null)
                {
                    cli = new WebClient();
                    cli.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler(cli_DownloadFileCompleted);                    
                }

                // WebClient 객체 생성
                using (cli)
                {
                    // FTP 사용자 설정
                    cli.Credentials = new NetworkCredential(id, pw);

                    if (isDownload)
                    {
                        // FTP 다운로드 실행
                        cli.DownloadFileAsync(new Uri(ftpPath), filePath);
                    }
                    else
                    {
                        // FTP 업로드 실행
                        cli.UploadFile(ftpPath, filePath);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Instance.ErrorLog(ex);
            }
        }


        public delegate void OnDownloadCompeleteHandler(string downloadPath);
        public event OnDownloadCompeleteHandler OnDownloadedEvent;
        void cli_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (OnDownloadedEvent != null)
            {                
                OnDownloadedEvent(_localPath);
            }
        }
    }
}
