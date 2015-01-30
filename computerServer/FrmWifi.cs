using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;
using System.IO;

namespace WIFI
{
    partial class FrmWifi : Form
    {
        //动画窗体调用,关闭时将向上移出屏幕
        [System.Runtime.InteropServices.DllImport("user32")]
        private static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);
        const int AW_HOR_POSITIVE = 0x0001;
        const int AW_HOR_NEGATIVE = 0x0002;
        const int AW_VER_POSITIVE = 0x0004;
        const int AW_VER_NEGATIVE = 0x0008;
        const int AW_CENTER = 0x0010;
        const int AW_HIDE = 0x10000;
        const int AW_ACTIVATE = 0x20000;
        const int AW_SLIDE = 0x40000;
        const int AW_BLEND = 0x80000;
        //…………………………………………………………
        public FrmWifi()
        {
            InitializeComponent();
            this.skinEngine1.SkinFile = "DeepCyan.ssk";
        }
        #region 最小化按键划过与点击时效果
        //划过时
        private void zuixiao_MouseHover(object sender, EventArgs e)
        {
            imgzuixiao.BackgroundImage = zxHover;
        }

        //按下时
        private void zuixiao_MouseDown(object sender, MouseEventArgs e)
        {
            imgzuixiao.BackgroundImage = zxDown;
        }

        //离开时
        private void zuixiao_MouseLeave(object sender, EventArgs e)
        {
            imgzuixiao.BackgroundImage = zxleave;
        }

        //点击链接
        private void zuixiao_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region X按键划过与点击时效果
        //划过时
        private void X_MouseHover(object sender, EventArgs e)
        {
            imgX.BackgroundImage = Xhover;
        }

        //按下时
        private void X_MouseDown(object sender, MouseEventArgs e)
        {
            imgX.BackgroundImage = XDown;
        }

        //离开时
        private void X_MouseLeave(object sender, EventArgs e)
        {
            imgX.BackgroundImage = Xleave;
        }

        //点击链接
        private void imgX_Click(object sender, EventArgs e)
        {
            AnimateWindow(this.Handle, 1000, AW_SLIDE | AW_HIDE | AW_VER_NEGATIVE);
            this.Hide();  
        }
        #endregion

        #region 无标题栏的窗口移动
        /// <summary>
        /// 无标题栏的窗口移动
        /// </summary>
        private Point mouseOffset; //记录鼠标指针的坐标
        private bool isMouseDown = false; //记录鼠标按键是否按下
        private void Loginsz_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;
            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X;
                yOffset = -e.Y;
                mouseOffset = new Point(xOffset, yOffset);
                isMouseDown = true;
            }
        }

        private void Loginsz_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void Loginsz_MouseUp(object sender, MouseEventArgs e)
        {
            // 修改鼠标状态isMouseDown的值
            // 确保只有鼠标左键按下并移动时，才移动窗体
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }
        #endregion

        #region 窗口加载时
        //定义
        Image Xhover;
        Image XDown;
        Image Xleave;
        Image zxHover;
        Image zxDown;
        Image zxleave;
        Image rdoxz1Click;
        Image rdoxz2Click;

        SendMsg sendMsg;
        //窗口加载时
        private void Loginsz_Load(object sender, EventArgs e)
        {
            //动画由小渐大,现在取消
            AnimateWindow(this.Handle, 1000, AW_CENTER | AW_ACTIVATE);

            //主界面渐变设置
            this.jianbian.Enabled = true;//让jianbian的timer值有效
            this.Opacity = 0;
            //………………………………………………

            Xhover = Image.FromFile(Application.StartupPath + "/img/btn_close_highlight.png");
            XDown = Image.FromFile(Application.StartupPath + "/img/btn_close_down.png");
            Xleave = Image.FromFile(Application.StartupPath + "/img/btn_close_normal.png");
            zxHover = Image.FromFile(Application.StartupPath + "/img/btn_mini_highlight.png");
            zxDown = Image.FromFile(Application.StartupPath + "/img/btn_mini_down.png");
            zxleave = Image.FromFile(Application.StartupPath + "/img/btn_mini_normal.png");
            rdoxz1Click = Image.FromFile(Application.StartupPath + "/img/MX8_2012.bmp");
            rdoxz2Click = Image.FromFile(Application.StartupPath + "/img/MX8经典_.bmp");

            NetControl netControl = new NetControl(textBox1);
            Thread netControlThread = new Thread(new ThreadStart(netControl.BeginListen));
            netControlThread.Start();
            sendMsg = new SendMsg();


            string path = "";
            string dos = "netsh wlan start hostednetwork";
            int mile = 0;
            Execute(path, dos, mile);

            ReadHostrity();
        }
        #endregion

        #region 窗体隐藏
        class Win32API
        {
            [DllImport("User32.dll")]
            public static extern bool PtInRect(ref Rectangle r, Point p);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            System.Drawing.Point pp = new Point(Cursor.Position.X, Cursor.Position.Y);//获取鼠标在屏幕的坐标点
            Rectangle Rects = new Rectangle(this.Left, this.Top, this.Left + this.Width, this.Top + this.Height);//存储当前窗体在屏幕的所在区域
            if ((this.Top < 0) && Win32API.PtInRect(ref Rects, pp))//当鼠标在当前窗体内，并且窗体的Top属性小于0
                this.Top = 0;//设置窗体的Top属性为0
            else
                //当窗体的上边框与屏幕的顶端的距离小于5时
                if (this.Top > -5 && this.Top < 5 && !(Win32API.PtInRect(ref Rects, pp)))
                    this.Top = 5 - this.Height;//将QQ窗体隐藏到屏幕的顶端
            this.lblDateNow.Text = System.DateTime.Now.ToString("yyyy - MM - dd  HH:mm:ss");

            //让背景由0变到1
            if (this.Opacity < 1)
            {
                this.Opacity = this.Opacity + 0.05;
            }
        }
        #endregion
        //设置WIFI账户

        private void button1_Click(object sender, EventArgs e)
        {
            string Name=this.txtWIFIName.Text;
            string Pwd=this.txtWIFIPwd.Text;
            string path = "";
            string dos = "netsh wlan set hostednetwork mode=allow ssid="+Name+" key="+Pwd+"";
            int mile = 0;
          //  Execute(path,dos,mile);
            this.txtWIFIName.AutoCompleteCustomSource.Add(this.txtWIFIName.Text);
            MessageBox.Show("设置成功！WIFI账号为：" + Name + ",  密码为:" + Pwd + "", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static string Execute(string path, string dosCommand, int milliseconds)
        {
            string output = "";//输出字符串             
            if (dosCommand != null && dosCommand != "")             
            {                 
                Process process = new Process();     //创建进程对象                 
                ProcessStartInfo startInfo = new ProcessStartInfo();                 
                startInfo.FileName = "cmd.exe";      //设定需要执行的命令                 
                startInfo.Arguments = "/C " + dosCommand;   //设定参数，其中的“/C”表示执行完命令后马上退出                 
                startInfo.UseShellExecute = false;     //不使用系统外壳程序启动                 
                startInfo.RedirectStandardInput = false;   //不重定向输入                 
                startInfo.RedirectStandardOutput = true;   //重定向输出                 
                startInfo.CreateNoWindow = true;     //不创建窗口                 
                startInfo.WorkingDirectory = path;                 
                process.StartInfo = startInfo;                 
                try                
                {                     
                    if (process.Start())       //开始进程                     
                    {                         
                        if (milliseconds == 0)                             
                            process.WaitForExit();     //这里无限等待进程结束                         
                        else                            
                            process.WaitForExit(milliseconds);  //这里等待进程结束，等待时间为指定的毫秒                         
                            output = process.StandardOutput.ReadToEnd();//读取进程的输出                     
                    }                 
                }                 
                catch                
                {                 
                }                 
                finally               
                {                     
                    if (process != null)                        
                        process.Close();                 
                }             
            }            
            return output;         
        }

        private void btnQi_Click(object sender, EventArgs e)
        {
            Qidong();
        }

        private void Qidong()
        {
            string path = "";
            string dos = "netsh wlan start hostednetwork";
            int mile = 0;
            Execute(path, dos, mile);
            MessageBox.Show("启动成功，尽情冲浪吧！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void WIFIStop()
        {
            if (MessageBox.Show(" 退出", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string path = "";
                string dos = "netsh wlan stop hostednetwork";
                int mile = 0;
                Execute(path, dos, mile);
                MessageBox.Show("先撤了，下次记得找我哦！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WIFIStop();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnimateWindow(this.Handle, 1000, AW_SLIDE | AW_HIDE | AW_VER_NEGATIVE);
            string path = "";
            string dos = "netsh wlan stop hostednetwork";
            int mile = 0;
            Execute(path, dos, mile);
            Application.Exit();    
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("");
        }

        private void Hostrity()
        {
            string filename = Path.Combine(Application.StartupPath,"name.txt");
            StreamWriter sw = new StreamWriter(filename,false,Encoding.Default);
            foreach (string item in this.txtWIFIName.AutoCompleteCustomSource)
            {
                sw.WriteLine(item);
            }
            sw.Flush();
            sw.Close();
        }

        private void ReadHostrity()
        {
            string filename = Path.Combine(Application.StartupPath, "name.txt");
            StreamReader sr = new StreamReader(filename,Encoding.Default);
            string name = sr.ReadLine();
            while (name != null)
            {
                this.txtWIFIName.AutoCompleteCustomSource.Add(name);
                this.txtWIFIName.Items.Add(name);
                this.txtWIFIName.Text = name;
                name = sr.ReadLine();
            }
            sr.Close();
        }
        //窗体
        private void FrmWifi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hostrity();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            sendMsg.Back();
        }

        private void btn_startOrStop_Click(object sender, EventArgs e)
        {
            sendMsg.StartOrStop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sendMsg.Qian();
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            sendMsg.UpSound();
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            sendMsg.DownSound();
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox1.Text = Test.log;
        }
    }
}
