using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace WIFI
{
    class NetControl
    {
        SendMsg sendMsg = new SendMsg();
        TextBox textBox;
        private Dictionary<string,string> Dict=new Dictionary<string, string>();
         
        public NetControl(TextBox tmpTextBox)
        {
            textBox = tmpTextBox;
            Dict.Add("qian","下一首");
            Dict.Add("back","前一首");
            Dict.Add("up","调高音量");
            Dict.Add("down","调低音量");
            Dict.Add("stsp","暂停开始");
            Dict.Add("lock","锁屏");
            Dict.Add("prePic","上一张");
            Dict.Add("nextPic","下一张");
            Dict.Add("fullScreen","全屏");
            Dict.Add("mute","静音");
        }

        public void BeginListen()
        {
            Thread.CurrentThread.IsBackground = true;
            TcpListener server = new TcpListener(IPAddress.Any, 12121);
            server.Start();
            while (true)
            {
                TcpClient client= server.AcceptTcpClient();
                Thread clientThread = new Thread(new ParameterizedThreadStart(receiveMsg));
                clientThread.Start(client);
            }
        }

        /// <summary>
        /// 服务器侦听
        /// </summary>
        /// <param name="result"></param>
        private void receiveMsg(Object obj)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            Thread.CurrentThread.IsBackground = true;
            using (TcpClient client =(TcpClient)obj)
            {
                using (NetworkStream stream = client.GetStream())
                {
                    int dataLength = 0;
                    string str;
                    string msg;
                    do
                    {
                        byte[] buffer = new byte[32];
                        dataLength = stream.Read(buffer, 0, buffer.Length);
                        str = Encoding.ASCII.GetString(buffer, 0, dataLength);
                        msg = Encoding.ASCII.GetString(buffer);
                        sendMessage(msg);
                        textBox.Text += "\r\n" +DateTime.Now.ToString("yy-MM-dd hh:mm:ss")+": "+ Dict[msg.Substring(0,4)] + "------------------------";
                    } while (client.Connected && msg.Substring(0, 4)!="over");
                }
            }
        }

        /// <summary>
        /// 根据收到信息，使用不同的功能(快进，暂停等)
        /// </summary>
        private void sendMessage(string msg)
        {
            string res=msg.Substring(0,4);
            switch (res)
            { 
                case "back":
                    sendMsg.PreMusic();
                    break;
                case "qian":
                    sendMsg.NextMusic();
                    break;
                case "stsp":
                    sendMsg.StartOrStop();
                    break;
                case "nextmusic":
                    sendMsg.NextMusic();
                    break;
                case "premusic":
                    sendMsg.PreMusic();
                    break;
                case "startmusic":
                    sendMsg.StartMusic();
                    break;
                case "endmusic":
                    sendMsg.StopMusic();
                    break;
                case "openlight":
                    sendMsg.OpenLight();
                    break;
                case "shutlight":
                    sendMsg.ShutLight();
                    break;

            }
        }
    }
}
