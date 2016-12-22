using System.Drawing;

namespace Batch_Download
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_main = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ffmpeg_path = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.linkLabel_ToMedia = new System.Windows.Forms.LinkLabel();
            this.linkLabel_ToM3u8 = new System.Windows.Forms.LinkLabel();
            this.checkBox_LieYing = new System.Windows.Forms.CheckBox();
            this.label_closeXmlIno = new System.Windows.Forms.Label();
            this.checkBox_Convert = new System.Windows.Forms.CheckBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.checkBox_Join = new System.Windows.Forms.CheckBox();
            this.label_xml_Info = new System.Windows.Forms.Label();
            this.linkLabel_Analyze = new System.Windows.Forms.LinkLabel();
            this.linkLabel_Clean = new System.Windows.Forms.LinkLabel();
            this.linkLabel_AddFile = new System.Windows.Forms.LinkLabel();
            this.textBox_XmlM3u8 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Output_Path = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_filename = new System.Windows.Forms.TextBox();
            this.comboBox_digit = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label10 = new System.Windows.Forms.Label();
            this.label_About = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label_Info = new System.Windows.Forms.Label();
            this.label_help = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_main
            // 
            this.textBox_main.AllowDrop = true;
            this.textBox_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.textBox_main.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_main.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_main.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.textBox_main.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.textBox_main.Location = new System.Drawing.Point(5, 35);
            this.textBox_main.Multiline = true;
            this.textBox_main.Name = "textBox_main";
            this.textBox_main.Size = new System.Drawing.Size(928, 395);
            this.textBox_main.TabIndex = 2;
            this.textBox_main.TextChanged += new System.EventHandler(this.textBox_main_TextChanged);
            this.textBox_main.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox1_DragDrop);
            this.textBox_main.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox1_DragEnter);
            this.textBox_main.DragOver += new System.Windows.Forms.DragEventHandler(this.textBox1_DragOver);
            this.textBox_main.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_main_KeyPress);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(814, 505);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 48);
            this.button2.TabIndex = 3;
            this.button2.Text = "生成批处理文件";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ffmpeg_path
            // 
            this.ffmpeg_path.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ffmpeg_path.AutoSize = true;
            this.ffmpeg_path.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ffmpeg_path.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ffmpeg_path.ForeColor = System.Drawing.Color.Lime;
            this.ffmpeg_path.Location = new System.Drawing.Point(122, 28);
            this.ffmpeg_path.Name = "ffmpeg_path";
            this.ffmpeg_path.Size = new System.Drawing.Size(110, 21);
            this.ffmpeg_path.TabIndex = 12;
            this.ffmpeg_path.Text = "\"ffmpeg.exe\"";
            this.ffmpeg_path.Click += new System.EventHandler(this.ffmpeg_path_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "拖入窗口自动获取路径，或点击上方绿色文字自选";
            // 
            // radioButton4
            // 
            this.radioButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.radioButton4.Location = new System.Drawing.Point(249, 160);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(56, 25);
            this.radioButton4.TabIndex = 16;
            this.radioButton4.Text = "FLV";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.radioButton3.Location = new System.Drawing.Point(439, 160);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(46, 25);
            this.radioButton3.TabIndex = 19;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "TS";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.radioButton2.Location = new System.Drawing.Point(370, 160);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 25);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.Text = "MKV";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.radioButton1.Location = new System.Drawing.Point(306, 160);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 25);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.Text = "MP4";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label2.Location = new System.Drawing.Point(8, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(397, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "Batch Download - 批处理生成器v4.2  by：nilaoda";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(858, 1);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 26);
            this.button3.TabIndex = 101;
            this.button3.Text = "EXIT";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(764, 1);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 26);
            this.button4.TabIndex = 100;
            this.button4.Text = "MIN";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(12, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 423);
            this.panel1.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-8, -24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(947, 456);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.tabPage1.Controls.Add(this.linkLabel_ToMedia);
            this.tabPage1.Controls.Add(this.linkLabel_ToM3u8);
            this.tabPage1.Controls.Add(this.checkBox_LieYing);
            this.tabPage1.Controls.Add(this.label_closeXmlIno);
            this.tabPage1.Controls.Add(this.checkBox_Convert);
            this.tabPage1.Controls.Add(this.radioButton7);
            this.tabPage1.Controls.Add(this.radioButton8);
            this.tabPage1.Controls.Add(this.checkBox_Join);
            this.tabPage1.Controls.Add(this.label_xml_Info);
            this.tabPage1.Controls.Add(this.linkLabel_Analyze);
            this.tabPage1.Controls.Add(this.linkLabel_Clean);
            this.tabPage1.Controls.Add(this.linkLabel_AddFile);
            this.tabPage1.Controls.Add(this.textBox_main);
            this.tabPage1.Controls.Add(this.textBox_XmlM3u8);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(939, 430);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabPage1_MouseDown);
            // 
            // linkLabel_ToMedia
            // 
            this.linkLabel_ToMedia.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.linkLabel_ToMedia.AutoSize = true;
            this.linkLabel_ToMedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.linkLabel_ToMedia.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.linkLabel_ToMedia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.linkLabel_ToMedia.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.linkLabel_ToMedia.Location = new System.Drawing.Point(744, 35);
            this.linkLabel_ToMedia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel_ToMedia.Name = "linkLabel_ToMedia";
            this.linkLabel_ToMedia.Size = new System.Drawing.Size(54, 16);
            this.linkLabel_ToMedia.TabIndex = 115;
            this.linkLabel_ToMedia.TabStop = true;
            this.linkLabel_ToMedia.Text = "ToMedia";
            this.linkLabel_ToMedia.Visible = false;
            this.linkLabel_ToMedia.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_ToMedia_LinkClicked);
            // 
            // linkLabel_ToM3u8
            // 
            this.linkLabel_ToM3u8.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.linkLabel_ToM3u8.AutoSize = true;
            this.linkLabel_ToM3u8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.linkLabel_ToM3u8.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.linkLabel_ToM3u8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.linkLabel_ToM3u8.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.linkLabel_ToM3u8.Location = new System.Drawing.Point(796, 35);
            this.linkLabel_ToM3u8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel_ToM3u8.Name = "linkLabel_ToM3u8";
            this.linkLabel_ToM3u8.Size = new System.Drawing.Size(51, 16);
            this.linkLabel_ToM3u8.TabIndex = 114;
            this.linkLabel_ToM3u8.TabStop = true;
            this.linkLabel_ToM3u8.Text = "ToM3u8";
            this.linkLabel_ToM3u8.Visible = false;
            this.linkLabel_ToM3u8.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_ToM3u8_LinkClicked);
            // 
            // checkBox_LieYing
            // 
            this.checkBox_LieYing.AutoSize = true;
            this.checkBox_LieYing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.checkBox_LieYing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_LieYing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_LieYing.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.checkBox_LieYing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.checkBox_LieYing.Location = new System.Drawing.Point(849, 35);
            this.checkBox_LieYing.Name = "checkBox_LieYing";
            this.checkBox_LieYing.Size = new System.Drawing.Size(68, 20);
            this.checkBox_LieYing.TabIndex = 113;
            this.checkBox_LieYing.Text = "调用猎影";
            this.checkBox_LieYing.UseVisualStyleBackColor = false;
            this.checkBox_LieYing.Visible = false;
            this.checkBox_LieYing.CheckedChanged += new System.EventHandler(this.checkBox_LieYing_CheckedChanged);
            // 
            // label_closeXmlIno
            // 
            this.label_closeXmlIno.AutoSize = true;
            this.label_closeXmlIno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_closeXmlIno.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.label_closeXmlIno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.label_closeXmlIno.Location = new System.Drawing.Point(915, 7);
            this.label_closeXmlIno.Name = "label_closeXmlIno";
            this.label_closeXmlIno.Size = new System.Drawing.Size(19, 19);
            this.label_closeXmlIno.TabIndex = 109;
            this.label_closeXmlIno.Text = "X";
            this.label_closeXmlIno.Visible = false;
            this.label_closeXmlIno.Click += new System.EventHandler(this.label_closeXmlIno_Click);
            // 
            // checkBox_Convert
            // 
            this.checkBox_Convert.AutoSize = true;
            this.checkBox_Convert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_Convert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_Convert.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.checkBox_Convert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.checkBox_Convert.Location = new System.Drawing.Point(241, 7);
            this.checkBox_Convert.Name = "checkBox_Convert";
            this.checkBox_Convert.Size = new System.Drawing.Size(81, 24);
            this.checkBox_Convert.TabIndex = 112;
            this.checkBox_Convert.Text = "批量转码";
            this.checkBox_Convert.UseVisualStyleBackColor = true;
            this.checkBox_Convert.CheckedChanged += new System.EventHandler(this.checkBox_Convert_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.radioButton7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.radioButton7.Location = new System.Drawing.Point(469, 7);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(135, 24);
            this.radioButton7.TabIndex = 40;
            this.radioButton7.Text = "仅合并(本地文件)";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.Visible = false;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Checked = true;
            this.radioButton8.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.radioButton8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.radioButton8.Location = new System.Drawing.Point(375, 7);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(97, 24);
            this.radioButton8.TabIndex = 39;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "任务完成后";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.Visible = false;
            // 
            // checkBox_Join
            // 
            this.checkBox_Join.AutoSize = true;
            this.checkBox_Join.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_Join.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_Join.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.checkBox_Join.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.checkBox_Join.Location = new System.Drawing.Point(323, 7);
            this.checkBox_Join.Name = "checkBox_Join";
            this.checkBox_Join.Size = new System.Drawing.Size(53, 24);
            this.checkBox_Join.TabIndex = 110;
            this.checkBox_Join.Text = "合并";
            this.checkBox_Join.UseVisualStyleBackColor = true;
            this.checkBox_Join.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // label_xml_Info
            // 
            this.label_xml_Info.AutoSize = true;
            this.label_xml_Info.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label_xml_Info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.label_xml_Info.Location = new System.Drawing.Point(668, 7);
            this.label_xml_Info.Name = "label_xml_Info";
            this.label_xml_Info.Size = new System.Drawing.Size(0, 20);
            this.label_xml_Info.TabIndex = 109;
            this.label_xml_Info.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_xml_Info_MouseDown);
            // 
            // linkLabel_Analyze
            // 
            this.linkLabel_Analyze.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.linkLabel_Analyze.AutoSize = true;
            this.linkLabel_Analyze.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.linkLabel_Analyze.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.linkLabel_Analyze.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.linkLabel_Analyze.Location = new System.Drawing.Point(174, 7);
            this.linkLabel_Analyze.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel_Analyze.Name = "linkLabel_Analyze";
            this.linkLabel_Analyze.Size = new System.Drawing.Size(61, 20);
            this.linkLabel_Analyze.TabIndex = 5;
            this.linkLabel_Analyze.TabStop = true;
            this.linkLabel_Analyze.Text = "分析xml";
            this.linkLabel_Analyze.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Analyze_LinkClicked);
            // 
            // linkLabel_Clean
            // 
            this.linkLabel_Clean.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.linkLabel_Clean.AutoSize = true;
            this.linkLabel_Clean.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.linkLabel_Clean.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.linkLabel_Clean.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.linkLabel_Clean.Location = new System.Drawing.Point(98, 7);
            this.linkLabel_Clean.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel_Clean.Name = "linkLabel_Clean";
            this.linkLabel_Clean.Size = new System.Drawing.Size(79, 20);
            this.linkLabel_Clean.TabIndex = 4;
            this.linkLabel_Clean.TabStop = true;
            this.linkLabel_Clean.Text = "清空输入框";
            this.linkLabel_Clean.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Clean_LinkClicked);
            // 
            // linkLabel_AddFile
            // 
            this.linkLabel_AddFile.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.linkLabel_AddFile.AutoSize = true;
            this.linkLabel_AddFile.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.linkLabel_AddFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.linkLabel_AddFile.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.linkLabel_AddFile.Location = new System.Drawing.Point(9, 7);
            this.linkLabel_AddFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel_AddFile.Name = "linkLabel_AddFile";
            this.linkLabel_AddFile.Size = new System.Drawing.Size(93, 20);
            this.linkLabel_AddFile.TabIndex = 3;
            this.linkLabel_AddFile.TabStop = true;
            this.linkLabel_AddFile.Text = "添加本地文件";
            this.linkLabel_AddFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_AddFile_LinkClicked);
            // 
            // textBox_XmlM3u8
            // 
            this.textBox_XmlM3u8.Location = new System.Drawing.Point(765, 215);
            this.textBox_XmlM3u8.Multiline = true;
            this.textBox_XmlM3u8.Name = "textBox_XmlM3u8";
            this.textBox_XmlM3u8.Size = new System.Drawing.Size(65, 45);
            this.textBox_XmlM3u8.TabIndex = 116;
            this.textBox_XmlM3u8.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.AllowDrop = true;
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.Output_Path);
            this.tabPage2.Controls.Add(this.label);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.radioButton1);
            this.tabPage2.Controls.Add(this.radioButton4);
            this.tabPage2.Controls.Add(this.radioButton3);
            this.tabPage2.Controls.Add(this.ffmpeg_path);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.radioButton2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(939, 430);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.DragDrop += new System.Windows.Forms.DragEventHandler(this.tabPage2_DragDrop);
            this.tabPage2.DragEnter += new System.Windows.Forms.DragEventHandler(this.tabPage2_DragEnter);
            this.tabPage2.DragOver += new System.Windows.Forms.DragEventHandler(this.tabPage2_DragOver);
            this.tabPage2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabPage2_MouseDown);
            // 
            // label15
            // 
            this.label15.AutoEllipsis = true;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label15.Location = new System.Drawing.Point(632, 401);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(286, 17);
            this.label15.TabIndex = 108;
            this.label15.Text = "*已保存ffmpeg路径、视频输出路径、视频封装格式.";
            // 
            // label13
            // 
            this.label13.AutoEllipsis = true;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label13.Location = new System.Drawing.Point(569, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(354, 42);
            this.label13.TabIndex = 107;
            this.label13.Text = "Tip：当你试图拖入多个文件，请多选后按住第一\r\n        个文件拖进来，否则可能会导致顺序错误。";
            this.label13.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label13_MouseDown);
            // 
            // Output_Path
            // 
            this.Output_Path.AutoSize = true;
            this.Output_Path.Location = new System.Drawing.Point(727, 35);
            this.Output_Path.Name = "Output_Path";
            this.Output_Path.Size = new System.Drawing.Size(0, 12);
            this.Output_Path.TabIndex = 37;
            this.Output_Path.Visible = false;
            // 
            // label
            // 
            this.label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label.AutoSize = true;
            this.label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label.ForeColor = System.Drawing.Color.Lime;
            this.label.Location = new System.Drawing.Point(240, 123);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(212, 21);
            this.label.TabIndex = 36;
            this.label.Text = "批处理所在文件夹(点击更改)";
            this.label.Click += new System.EventHandler(this.Output_Path_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label9.Location = new System.Drawing.Point(122, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 21);
            this.label9.TabIndex = 35;
            this.label9.Text = "视频输出路径：";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(37, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 21);
            this.label8.TabIndex = 34;
            this.label8.Text = "必要组件：";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.radioButton6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBox_filename);
            this.panel2.Controls.Add(this.comboBox_digit);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.radioButton5);
            this.panel2.Location = new System.Drawing.Point(158, 226);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(536, 120);
            this.panel2.TabIndex = 33;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label16.Location = new System.Drawing.Point(67, 59);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(136, 20);
            this.label16.TabIndex = 39;
            this.label16.Text = "例：青云志第一集_#";
            // 
            // textBox1
            // 
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.textBox1.Location = new System.Drawing.Point(296, 6);
            this.textBox1.MaxLength = 3;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(35, 21);
            this.textBox1.TabIndex = 38;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "1";
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label11.Location = new System.Drawing.Point(244, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 20);
            this.label11.TabIndex = 37;
            this.label11.Text = "起始：";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.radioButton6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.radioButton6.Location = new System.Drawing.Point(28, 87);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(271, 24);
            this.radioButton6.TabIndex = 23;
            this.radioButton6.Text = "原路径+原文件名(当用来批量转换封装)";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label7.Location = new System.Drawing.Point(355, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "程序将用序号代替字符\'#\'";
            // 
            // textBox_filename
            // 
            this.textBox_filename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.textBox_filename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_filename.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_filename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.textBox_filename.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.textBox_filename.Location = new System.Drawing.Point(70, 31);
            this.textBox_filename.Name = "textBox_filename";
            this.textBox_filename.Size = new System.Drawing.Size(279, 23);
            this.textBox_filename.TabIndex = 22;
            this.textBox_filename.Text = "#";
            // 
            // comboBox_digit
            // 
            this.comboBox_digit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_digit.FormattingEnabled = true;
            this.comboBox_digit.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox_digit.Location = new System.Drawing.Point(195, 6);
            this.comboBox_digit.Name = "comboBox_digit";
            this.comboBox_digit.Size = new System.Drawing.Size(35, 20);
            this.comboBox_digit.TabIndex = 21;
            this.comboBox_digit.TabStop = false;
            this.comboBox_digit.SelectedIndexChanged += new System.EventHandler(this.comboBox_digit_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label6.Location = new System.Drawing.Point(143, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "位数：";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Checked = true;
            this.radioButton5.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.radioButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.radioButton5.Location = new System.Drawing.Point(28, 4);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(111, 24);
            this.radioButton5.TabIndex = 20;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "高级自增序号";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label5.Location = new System.Drawing.Point(122, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 29;
            this.label5.Text = "命名规则：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(38, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 12);
            this.label4.TabIndex = 28;
            this.label4.Text = "-------------------------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label3.Location = new System.Drawing.Point(122, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "视频封装格式：";
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(777, 360);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(93, 31);
            this.button6.TabIndex = 24;
            this.button6.Text = "确认";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.tabPage3.Controls.Add(this.panel4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(939, 430);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Location = new System.Drawing.Point(8, 4);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(923, 423);
            this.panel4.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(338, 200);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 31);
            this.button1.TabIndex = 25;
            this.button1.Text = "这里本该显示cmd窗口。点此返回主页";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(686, 505);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 48);
            this.button5.TabIndex = 106;
            this.button5.Text = "输出选项";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label10
            // 
            this.label10.AutoEllipsis = true;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label10.Location = new System.Drawing.Point(19, 495);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(283, 63);
            this.label10.TabIndex = 27;
            this.label10.Text = "*一行一个链接或文件(可拖入文本文件)\r\n*批量下载HLS等流媒体\r\n*批量转换封装 *合并视频分段";
            this.label10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label10_MouseDown);
            // 
            // label_About
            // 
            this.label_About.AutoSize = true;
            this.label_About.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_About.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_About.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label_About.Location = new System.Drawing.Point(719, 7);
            this.label_About.Name = "label_About";
            this.label_About.Size = new System.Drawing.Size(32, 17);
            this.label_About.TabIndex = 102;
            this.label_About.Text = "关于";
            this.label_About.Click += new System.EventHandler(this.label_About_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label12.Location = new System.Drawing.Point(645, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 17);
            this.label12.TabIndex = 103;
            this.label12.Text = "更新";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label14.Location = new System.Drawing.Point(584, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 17);
            this.label14.TabIndex = 107;
            this.label14.Text = "FFmpeg";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label_Info
            // 
            this.label_Info.AutoEllipsis = true;
            this.label_Info.AutoSize = true;
            this.label_Info.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.label_Info.Location = new System.Drawing.Point(291, 485);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(0, 21);
            this.label_Info.TabIndex = 108;
            // 
            // label_help
            // 
            this.label_help.AutoSize = true;
            this.label_help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_help.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_help.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label_help.Location = new System.Drawing.Point(683, 7);
            this.label_help.Name = "label_help";
            this.label_help.Size = new System.Drawing.Size(32, 17);
            this.label_help.TabIndex = 109;
            this.label_help.Text = "帮助";
            this.label_help.Click += new System.EventHandler(this.label_help_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(952, 580);
            this.Controls.Add(this.label_help);
            this.Controls.Add(this.label_Info);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label_About);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batch Download - 批处理生成器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_main;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label ffmpeg_path;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.RadioButton radioButton4;
        public System.Windows.Forms.RadioButton radioButton3;
        public System.Windows.Forms.RadioButton radioButton2;
        public System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_digit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_filename;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        public System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.Label Output_Path;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_About;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel_AddFile;
        private System.Windows.Forms.LinkLabel linkLabel_Clean;
        private System.Windows.Forms.LinkLabel linkLabel_Analyze;
        private System.Windows.Forms.Label label_xml_Info;
        private System.Windows.Forms.CheckBox checkBox_Join;
        public System.Windows.Forms.RadioButton radioButton8;
        public System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox checkBox_Convert;
        private System.Windows.Forms.Label label_Info;
        private System.Windows.Forms.Label label_closeXmlIno;
        private System.Windows.Forms.CheckBox checkBox_LieYing;
        private System.Windows.Forms.LinkLabel linkLabel_ToM3u8;
        private System.Windows.Forms.LinkLabel linkLabel_ToMedia;
        private System.Windows.Forms.TextBox textBox_XmlM3u8;
        private System.Windows.Forms.Label label_help;
    }
}

