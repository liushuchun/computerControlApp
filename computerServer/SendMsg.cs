using System;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace WIFI
{
    public class SendMsg
    {
        [DllImport("user32.dll", EntryPoint = "keybd_event")]
        public static extern void keybd_event(
            byte bVk,
            byte bScan,
            int dwFlags,  //这里是整数类型  0 为按下，2为释放
            int dwExtraInfo  //这里是整数类型 一般情况下设成为 0
        );

        [DllImport("user32.dll")]
        public static extern bool LockWorkStation();
        [DllImport(@"AltCtrlDelCpp.dll")]
        static extern bool SimulateAltControlDel();
        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);
        [DllImport("user32.dll")]
        static extern byte MapVirtualKey(byte wCode, int wMap);
        [DllImport("user32.dll",EntryPoint = "PostMessage")]
        public static extern int PostMessage(
            IntPtr hwnd,
            int wMsg,
            uint wParam,
            uint lParam
        );
        //type:0 -----kugou;
        //type:1 -----QQmusic;
        //type:2 -----千千音乐
        //type:3 -----网易音乐
        //type:4 -----
        public static int MusicType = 0;
        
        IntPtr mainWindowHander;

        /// <summary>
        /// 遍历电脑所有的进程，获取暴风影音句柄
        /// </summary>
        public SendMsg()
        {
            Process[] allProcesses = Process.GetProcesses();
            foreach (Process p in allProcesses)
            {
                if (p.ProcessName == "KuGou")
                {
                    mainWindowHander = p.MainWindowHandle;
                    MusicType = 0;
                }else if (p.ProcessName == "QQMusic")
                {
                    MusicType = 1;
                }else if (p.ProcessName=="千千静听")
                {
                    MusicType = 2;
                }else if (p.ProcessName == "cloudmusic")
                {
                    MusicType = 3;
                }
            }
            if (mainWindowHander == IntPtr.Zero)
            {
                Process p = new Process();
                p.StartInfo.FileName = @"C:\Program Files (x86)\KuGou\KGMusic\KuGou.exe";
                p.Start();
                Thread.Sleep(3000);
                mainWindowHander = p.MainWindowHandle;
            }
        }

        /// <summary>
        /// 开始，暂停
        /// </summary>
        public void StartOrStop()
        {
            PostMessage(mainWindowHander, 0x0100, 0x20, 0x20390001);
            PostMessage(mainWindowHander, 0x0101, 0x20, 0x20390001);
        }

        /// <summary>
        /// 快退
        /// </summary>
        public void Back()
        {
            PostMessage(mainWindowHander, 0x0100, 0x25, 0x204b0001);
            PostMessage(mainWindowHander, 0x0101, 0x25, 0x204b0001);
        }

        /// <summary>
        /// 快进
        /// </summary>
        public void Qian()
        {
            PostMessage(mainWindowHander, 0x0100, 0x27, 0x204d0001);
            PostMessage(mainWindowHander, 0x0101, 0x27, 0x204d0001);
        }

        public void NextMusic()
        {
            keybd_event(18,0,0,0);
            keybd_event(37,0,0,0);
            keybd_event(37, 0, 2, 0);
            keybd_event(18,0,2,0);
        }

        public void StopMusic()
        {
            SendKeys.Send("%{F5}");

        }

        public void PreMusic()
        {
            keybd_event(18, 0, 0, 0);
            keybd_event(39, 0, 0, 0);
            keybd_event(39, 0, 2, 0);
            keybd_event(18, 0, 2, 0);
        }

        public void OpenLight()
        {
            
        }

        public void StartMusic()
        {
            PostMessage(mainWindowHander, 0x0100, 0x20, 0x20390001);
            PostMessage(mainWindowHander, 0x0101, 0x20, 0x20390001);
        }

        public void ShutLight()
        {
            
        }

        public void UpSound()
        {
            keybd_event(18, 0, 0, 0);
            keybd_event(38, 0, 0, 0);
            keybd_event(38, 0, 2, 0);
            keybd_event(18, 0, 2, 0);
        }
        public void DownSound()
        {
            keybd_event(18, 0, 0, 0);
            keybd_event(39, 0, 0, 0);
            keybd_event(39, 0, 2, 0);
            keybd_event(18, 0, 2, 0);
        }


        public void LockScreen()
        {

            LockWorkStation();
        }

        public void UnLock()
        {

          //  SimulateAltControlDel();
        }
    }
}
