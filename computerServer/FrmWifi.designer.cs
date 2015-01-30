namespace WIFI
{
    partial class FrmWifi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWifi));
            this.imgzuixiao = new System.Windows.Forms.PictureBox();
            this.imgX = new System.Windows.Forms.PictureBox();
            this.imgICO = new System.Windows.Forms.PictureBox();
            this.lblshezhi = new System.Windows.Forms.Label();
            this.btnQi = new System.Windows.Forms.Button();
            this.btnqx2 = new System.Windows.Forms.Button();
            this.jianbian = new System.Windows.Forms.Timer(this.components);
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.txtWIFIPwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDateNow = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.停止WIFIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.启动WIFIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtWIFIName = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_startOrStop = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.btn_test = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgzuixiao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgICO)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgzuixiao
            // 
            this.imgzuixiao.BackColor = System.Drawing.Color.Transparent;
            this.imgzuixiao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgzuixiao.BackgroundImage")));
            this.imgzuixiao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgzuixiao.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imgzuixiao.ErrorImage")));
            this.imgzuixiao.Location = new System.Drawing.Point(788, -1);
            this.imgzuixiao.Margin = new System.Windows.Forms.Padding(0);
            this.imgzuixiao.Name = "imgzuixiao";
            this.imgzuixiao.Size = new System.Drawing.Size(39, 31);
            this.imgzuixiao.TabIndex = 17;
            this.imgzuixiao.TabStop = false;
            this.imgzuixiao.Click += new System.EventHandler(this.zuixiao_Click);
            this.imgzuixiao.MouseDown += new System.Windows.Forms.MouseEventHandler(this.zuixiao_MouseDown);
            this.imgzuixiao.MouseLeave += new System.EventHandler(this.zuixiao_MouseLeave);
            this.imgzuixiao.MouseHover += new System.EventHandler(this.zuixiao_MouseHover);
            // 
            // imgX
            // 
            this.imgX.BackColor = System.Drawing.Color.Transparent;
            this.imgX.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgX.BackgroundImage")));
            this.imgX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgX.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imgX.ErrorImage")));
            this.imgX.Location = new System.Drawing.Point(827, -1);
            this.imgX.Margin = new System.Windows.Forms.Padding(0);
            this.imgX.Name = "imgX";
            this.imgX.Size = new System.Drawing.Size(49, 31);
            this.imgX.TabIndex = 16;
            this.imgX.TabStop = false;
            this.imgX.Click += new System.EventHandler(this.imgX_Click);
            this.imgX.MouseDown += new System.Windows.Forms.MouseEventHandler(this.X_MouseDown);
            this.imgX.MouseLeave += new System.EventHandler(this.X_MouseLeave);
            this.imgX.MouseHover += new System.EventHandler(this.X_MouseHover);
            // 
            // imgICO
            // 
            this.imgICO.BackColor = System.Drawing.Color.Transparent;
            this.imgICO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgICO.Image = ((System.Drawing.Image)(resources.GetObject("imgICO.Image")));
            this.imgICO.Location = new System.Drawing.Point(13, 12);
            this.imgICO.Margin = new System.Windows.Forms.Padding(0);
            this.imgICO.Name = "imgICO";
            this.imgICO.Size = new System.Drawing.Size(21, 21);
            this.imgICO.TabIndex = 18;
            this.imgICO.TabStop = false;
            // 
            // lblshezhi
            // 
            this.lblshezhi.AutoSize = true;
            this.lblshezhi.BackColor = System.Drawing.Color.Transparent;
            this.lblshezhi.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblshezhi.Location = new System.Drawing.Point(36, 11);
            this.lblshezhi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblshezhi.Name = "lblshezhi";
            this.lblshezhi.Size = new System.Drawing.Size(69, 20);
            this.lblshezhi.TabIndex = 19;
            this.lblshezhi.Text = "懒人音控";
            // 
            // btnQi
            // 
            this.btnQi.BackColor = System.Drawing.Color.Transparent;
            this.btnQi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQi.BackgroundImage")));
            this.btnQi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQi.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnQi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQi.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQi.ForeColor = System.Drawing.Color.Black;
            this.btnQi.Location = new System.Drawing.Point(477, 613);
            this.btnQi.Margin = new System.Windows.Forms.Padding(4);
            this.btnQi.Name = "btnQi";
            this.btnQi.Size = new System.Drawing.Size(121, 37);
            this.btnQi.TabIndex = 8;
            this.btnQi.Text = "启动WIFI(&Q)";
            this.btnQi.UseVisualStyleBackColor = false;
            this.btnQi.Click += new System.EventHandler(this.btnQi_Click);
            // 
            // btnqx2
            // 
            this.btnqx2.BackColor = System.Drawing.Color.Transparent;
            this.btnqx2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnqx2.BackgroundImage")));
            this.btnqx2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnqx2.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnqx2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnqx2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnqx2.ForeColor = System.Drawing.Color.Black;
            this.btnqx2.Location = new System.Drawing.Point(737, 613);
            this.btnqx2.Margin = new System.Windows.Forms.Padding(4);
            this.btnqx2.Name = "btnqx2";
            this.btnqx2.Size = new System.Drawing.Size(121, 37);
            this.btnqx2.TabIndex = 22;
            this.btnqx2.Text = "关闭(&C)";
            this.btnqx2.UseVisualStyleBackColor = false;
            this.btnqx2.Click += new System.EventHandler(this.imgX_Click);
            // 
            // jianbian
            // 
            this.jianbian.Enabled = true;
            this.jianbian.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // skinEngine1
            // 
            this.skinEngine1.@__DrawButtonFocusRectangle = true;
            this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // txtWIFIPwd
            // 
            this.txtWIFIPwd.Location = new System.Drawing.Point(573, 539);
            this.txtWIFIPwd.Margin = new System.Windows.Forms.Padding(4);
            this.txtWIFIPwd.Name = "txtWIFIPwd";
            this.txtWIFIPwd.Size = new System.Drawing.Size(285, 22);
            this.txtWIFIPwd.TabIndex = 25;
            this.txtWIFIPwd.Text = "123456789";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(28, 539);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "WIFI账号：";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.Location = new System.Drawing.Point(25, 630);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(129, 20);
            this.linkLabel1.TabIndex = 27;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "树春出品必属精品";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(458, 536);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "WIFI密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(557, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "当前时间：";
            // 
            // lblDateNow
            // 
            this.lblDateNow.AutoSize = true;
            this.lblDateNow.BackColor = System.Drawing.Color.Transparent;
            this.lblDateNow.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDateNow.Location = new System.Drawing.Point(129, 105);
            this.lblDateNow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateNow.Name = "lblDateNow";
            this.lblDateNow.Size = new System.Drawing.Size(0, 24);
            this.lblDateNow.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(336, 613);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 37);
            this.button1.TabIndex = 33;
            this.button1.Text = "设置账户(&S)";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(607, 613);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 37);
            this.button2.TabIndex = 34;
            this.button2.Text = "停止WIFI(&Q)";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(32, 584);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(86, 21);
            this.checkBox1.TabIndex = 35;
            this.checkBox1.Text = "自动启动";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "无极伤感套装 - WIFI";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.停止WIFIToolStripMenuItem,
            this.启动WIFIToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(138, 76);
            // 
            // 停止WIFIToolStripMenuItem
            // 
            this.停止WIFIToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("停止WIFIToolStripMenuItem.Image")));
            this.停止WIFIToolStripMenuItem.Name = "停止WIFIToolStripMenuItem";
            this.停止WIFIToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.停止WIFIToolStripMenuItem.Text = "停止WIFI";
            this.停止WIFIToolStripMenuItem.Click += new System.EventHandler(this.button2_Click);
            // 
            // 启动WIFIToolStripMenuItem
            // 
            this.启动WIFIToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("启动WIFIToolStripMenuItem.Image")));
            this.启动WIFIToolStripMenuItem.Name = "启动WIFIToolStripMenuItem";
            this.启动WIFIToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.启动WIFIToolStripMenuItem.Text = "启动WIFI";
            this.启动WIFIToolStripMenuItem.Click += new System.EventHandler(this.btnQi_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("退出ToolStripMenuItem.Image")));
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // txtWIFIName
            // 
            this.txtWIFIName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtWIFIName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtWIFIName.FormattingEnabled = true;
            this.txtWIFIName.Location = new System.Drawing.Point(145, 539);
            this.txtWIFIName.Margin = new System.Windows.Forms.Padding(4);
            this.txtWIFIName.Name = "txtWIFIName";
            this.txtWIFIName.Size = new System.Drawing.Size(285, 24);
            this.txtWIFIName.TabIndex = 36;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(22, 107);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(836, 357);
            this.textBox1.TabIndex = 37;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_back.ForeColor = System.Drawing.Color.Black;
            this.btn_back.Location = new System.Drawing.Point(49, 477);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(121, 37);
            this.btn_back.TabIndex = 43;
            this.btn_back.Text = "|<-";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_startOrStop
            // 
            this.btn_startOrStop.BackColor = System.Drawing.Color.Transparent;
            this.btn_startOrStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_startOrStop.BackgroundImage")));
            this.btn_startOrStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_startOrStop.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_startOrStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_startOrStop.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_startOrStop.ForeColor = System.Drawing.Color.Black;
            this.btn_startOrStop.Location = new System.Drawing.Point(169, 477);
            this.btn_startOrStop.Margin = new System.Windows.Forms.Padding(4);
            this.btn_startOrStop.Name = "btn_startOrStop";
            this.btn_startOrStop.Size = new System.Drawing.Size(121, 37);
            this.btn_startOrStop.TabIndex = 44;
            this.btn_startOrStop.Text = "||";
            this.btn_startOrStop.UseVisualStyleBackColor = false;
            this.btn_startOrStop.Click += new System.EventHandler(this.btn_startOrStop_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(289, 477);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 37);
            this.button3.TabIndex = 45;
            this.button3.Text = "->|";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_up
            // 
            this.btn_up.BackColor = System.Drawing.Color.Transparent;
            this.btn_up.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_up.BackgroundImage")));
            this.btn_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_up.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_up.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_up.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_up.ForeColor = System.Drawing.Color.Black;
            this.btn_up.Location = new System.Drawing.Point(408, 477);
            this.btn_up.Margin = new System.Windows.Forms.Padding(4);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(121, 37);
            this.btn_up.TabIndex = 46;
            this.btn_up.Text = "up";
            this.btn_up.UseVisualStyleBackColor = false;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_down
            // 
            this.btn_down.BackColor = System.Drawing.Color.Transparent;
            this.btn_down.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_down.BackgroundImage")));
            this.btn_down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_down.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_down.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_down.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_down.ForeColor = System.Drawing.Color.Black;
            this.btn_down.Location = new System.Drawing.Point(527, 477);
            this.btn_down.Margin = new System.Windows.Forms.Padding(4);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(121, 37);
            this.btn_down.TabIndex = 47;
            this.btn_down.Text = "down";
            this.btn_down.UseVisualStyleBackColor = false;
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // btn_test
            // 
            this.btn_test.BackColor = System.Drawing.Color.Transparent;
            this.btn_test.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_test.BackgroundImage")));
            this.btn_test.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_test.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_test.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_test.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_test.ForeColor = System.Drawing.Color.Black;
            this.btn_test.Location = new System.Drawing.Point(647, 477);
            this.btn_test.Margin = new System.Windows.Forms.Padding(4);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(121, 37);
            this.btn_test.TabIndex = 48;
            this.btn_test.Text = "test";
            this.btn_test.UseVisualStyleBackColor = false;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(36, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 49;
            this.label4.Text = "日志：";
            // 
            // FrmWifi
            // 
            this.AcceptButton = this.btnQi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 667);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_test);
            this.Controls.Add(this.btn_down);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_startOrStop);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtWIFIName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDateNow);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnqx2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblshezhi);
            this.Controls.Add(this.btnQi);
            this.Controls.Add(this.imgICO);
            this.Controls.Add(this.txtWIFIPwd);
            this.Controls.Add(this.imgX);
            this.Controls.Add(this.imgzuixiao);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmWifi";
            this.ShowInTaskbar = false;
            this.Text = " ";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmWifi_FormClosing);
            this.Load += new System.EventHandler(this.Loginsz_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Loginsz_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Loginsz_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Loginsz_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.imgzuixiao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgICO)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgzuixiao;
        private System.Windows.Forms.PictureBox imgX;
        private System.Windows.Forms.PictureBox imgICO;
        private System.Windows.Forms.Label lblshezhi;
        private System.Windows.Forms.Button btnQi;
        private System.Windows.Forms.Button btnqx2;
        private System.Windows.Forms.Timer jianbian;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.TextBox txtWIFIPwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDateNow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 停止WIFIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 启动WIFIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ComboBox txtWIFIName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_startOrStop;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.Label label4;
    }
}