using System;
using System.Drawing;
using System.Xml;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.IO;
using System.Threading;
using System.Net;

namespace Batch_Download
{
    public partial class Form1 : Form
    {
        //移动窗口
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        //cmd嵌入form
        [DllImport("User32.dll ", EntryPoint = "SetParent")]
        private static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        [DllImport("user32.dll ", EntryPoint = "ShowWindow")]
        public static extern int ShowWindow(IntPtr hwnd, int nCmdShow);


        string digit = "0";  //控制输出序号的位数
        Double size = 0; Double time = 0; //记录时长与大小,Double防止小数无法计算

        public Form1()
        {
            //高DPI禁用缩放
            Font = new Font(Font.Name, 8.25f * 96f / CreateGraphics().DpiX, Font.Style, 
                Font.Unit, Font.GdiCharSet, Font.GdiVerticalFont);

            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.SetBounds((Screen.GetBounds(this).Width / 2) - (this.Width / 2), 
                (Screen.GetBounds(this).Height / 2) - (this.Height / 2), 
                this.Width, this.Height, BoundsSpecified.Location);
            comboBox_digit.SelectedIndex = 0;  //默认选中位数
        }

        //不影响点击任务栏图标最大最小化
        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_MINIMIZEBOX = 0x00020000;  // Winuser.h中定义
                CreateParams cp = base.CreateParams;
                cp.Style = cp.Style | WS_MINIMIZEBOX;   // 允许最小化操作
                return cp;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox_main.Text = Regex.Replace(textBox_main.Text, @"\n\s*\r", string.Empty);//去除空行
            if (radioButton1.Checked == true)
            {
                Bat(" -c copy -bsf:a aac_adtstoasc ", ".mp4");
            }
            if (radioButton2.Checked == true)
            {
                Bat(" -c copy -bsf:a aac_adtstoasc ", ".mkv");
            }
            if (radioButton3.Checked == true)
            {
                Bat(" -c copy -f mpegts ", ".ts");
            }
            if (radioButton4.Checked == true)
            {
                Bat(" -c copy -f f4v -bsf:a aac_adtstoasc ", ".flv"); 
            }
        }

        private void Bat(string command,string houzhui)
        {
            string s = textBox_filename.Text;
            Regex regex=new Regex("#");//以#分割
            string[] bit = regex.Split(s);
            string[] data = textBox_main.Text.Replace("%", "%%").Split('\n');  //批处理中%%显示为%，特此批注。

            String batpath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\批处理-" + 
                System.DateTime.Now.ToString("yyyy.MM.dd-HH.mm.ss") + ".bat";
            StreamWriter log = new StreamWriter(batpath, false, System.Text.Encoding.Default);
            log.WriteLine("@echo off\r\ncolor 0F\r\n:: 本批处理由 Batch Download 生成.\r\n");

            if (Output_Path.Text != ""&& radioButton6.Checked==false)
            {
                log.WriteLine("if not exist \"" + Output_Path.Text.Replace("%", "%%") + "\" (\r\n"
                + "echo 文件夹不存在！按任意键创建文件夹并继续。\r\n pause>nul\r\n"
                + "md \"" + Output_Path.Text.Replace("%", "%%") + "\"\r\n"
                + ")\r\n");
            }

            if (radioButton8.Checked == true)
            {
                int k = data.Length; //获取总个数
                for (int i = 0; i < data.Length; i++)
                {
                    if (data[i].Length == 0)
                        k -= 1;
                }
                for (int i = 0; i < data.Length; i++)
                {
                    if (data[i].Length == 0)  //排除空数据
                        continue;
                    if (radioButton5.Checked == true)
                    {
                        log.WriteLine("TITLE Batch Download - " + "[" + (i + 1) + "/" + k + "]" + 
                            "    (Ctrl + S 暂停 Ctrl + Q 继续)");
                        log.WriteLine(ffmpeg_path.Text.Replace("%", "%%") + " -threads 0 -i " + "\"" + 
                            data[i] + "\"" + command + "\"" + Output_Path.Text.Replace("%", "%%") + bit[0].Replace("%", "%%") + 
                            (i + Convert.ToInt32(textBox1.Text)).ToString(digit) + bit[1].Replace("%", "%%") + houzhui + "\"");
                    }
                    if (radioButton6.Checked == true)
                    {
                        int position = data[i].LastIndexOf(".") + 1;
                        string fileName = data[i].Substring(0, position - 1);
                        log.WriteLine("TITLE Batch Download - " + "[" + (i + 1) + "/" + k + "]" + 
                            "    (Ctrl + S 暂停 Ctrl + Q 继续)");
                        log.WriteLine(ffmpeg_path.Text.Replace("%", "%%") + " -threads 0 -i " + "\"" + 
                            data[i] + "\"" + command.Replace(" -bsf:a aac_adtstoasc", "") + "\"" + 
                            fileName.Replace("%", "%%") + houzhui + "\"");  // 批量转封装取消-bsf:a aac_adtstoasc参数  ---2016/12/3
                    }
                }
            }

            if (checkBox_Join.CheckState == CheckState.Checked)
            {
                if (radioButton8.Checked == true)
                {
                    string filelistpath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\filelist.txt";
                    StreamWriter writer = new StreamWriter(filelistpath, false);  //false代表替换而不是追加
                    for (int i = 0; i < data.Length; i++)
                    {
                        if (data[i].Length == 0) //空行不生成命令
                            continue;
                        if (radioButton5.Checked == true)
                        {
                            writer.WriteLine("file \'" + Output_Path.Text + bit[0] + 
                                (i + Convert.ToInt32(textBox1.Text)).ToString(digit) + bit[1] + houzhui + "\'");
                        }
                        if (radioButton6.Checked == true)
                        {
                            int position = data[i].LastIndexOf(".") + 1;
                            string fileName = data[i].Substring(0, position - 1);
                            writer.WriteLine("file \'" + fileName + houzhui + "\'");
                        }
                    }
                    writer.Close();
                 }
                if (radioButton7.Checked == true)
                {
                    string filelistpath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\filelist.txt";
                    StreamWriter writer = new StreamWriter(filelistpath, false);  //false代表替换而不是追加
                    for (int i = 0; i < data.Length; i++)
                    {
                        if (data[i].Length == 0) //空行不生成命令
                            continue;
                        writer.WriteLine("file \'" + data[i].Substring(0, data[i].Length - 1) + "\'");  //特别注意：字符串截取问题，由于data是按换行符分割，所以造成一些问题，需要删除那个字符
                    }
                    writer.Close();
                }
                log.WriteLine("\r\n::合并\r\nTITLE Batch Download - 合并    (Ctrl + S 暂停 Ctrl + Q 继续)\r\n" + 
                    ffmpeg_path.Text + " -f concat -safe 0 -i " + "\"" + (Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + 
                    @"\filelist.txt").Replace("%", "%%") + "\"" + 
                    " -threads 0" + command.Replace(" -bsf:a aac_adtstoasc", "") + "\"" + Output_Path.Text + "Join" + houzhui + "\""); // 合并时 取消-bsf:a aac_adtstoasc参数 没必要  ---2016/12/3
                log.WriteLine("\r\necho.\r\nset /p choice=合并结束，是否删除源文件(Y/N)？\r\n" + 
                              "if /i %choice% equ n goto :exit");
                log.WriteLine("del \""+ (Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + 
                    @"\filelist.txt").Replace("%", "%%") + "\"");

                for (int i = 0; i < data.Length; i++)
                {
                    if (data[i].Length == 0)  //空行不生成命令
                        continue;
                    if (radioButton5.Checked == true && radioButton7.Checked == false)
                    {
                        log.WriteLine("del \"" + Output_Path.Text + bit[0] + (i + Convert.ToInt32(textBox1.Text)).ToString(digit) + 
                            bit[1] + houzhui + "\"");
                    }
                    if (radioButton6.Checked == true && radioButton7.Checked == false)
                    {
                        int position = data[i].LastIndexOf(".") + 1;
                        string fileName = data[i].Substring(0, position - 1);
                        log.WriteLine("del \"" + fileName + houzhui + "\"");
                    }
                    if (radioButton7.Checked == true)
                    {
                        log.WriteLine("del \"" + data[i] + "\"");
                    }
                }
            }
            log.WriteLine("\r\n:exit\r\nTITLE Batch Download - 任务完成！\r\necho.\r\necho 所有任务完成！\r\necho.\r\npause");
            log.Close();

            if (MessageBox.Show("批处理文件已生成到桌面！\n是否立即运行？", "请确认您的操作", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                tabControl1.SelectedTab = tabPage3;
                Process p = new Process();
                p.StartInfo.FileName = batpath;
                p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Minimized;
                p.Start();
                Thread.Sleep(100);
                SetParent(p.MainWindowHandle, panel4.Handle); 
                ShowWindow(p.MainWindowHandle, 3);
            }
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void textBox1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            var filenames = (string[])e.Data.GetData(DataFormats.FileDrop);
            var hz = filenames[0].LastIndexOf('.') + 1;
            var houzhui = filenames[0].Substring(hz);//文件后缀名

            if (houzhui == "m3u8" || houzhui == "mkv" || houzhui == "avi" || houzhui == "mp4" || houzhui == "ts" || houzhui == "flv" || houzhui == "f4v" ||
                houzhui == "wmv" || houzhui == "wm" || houzhui == "mpeg" || houzhui == "mpg" || houzhui == "m4v" || houzhui == "3gp" || houzhui == "rm" ||
                houzhui == "rmvb" || houzhui == "mov" || houzhui == "qt" || houzhui == "m2ts" || houzhui == "m3u" || houzhui == "mts" || houzhui == "txt" || houzhui == "webm") //只允许拖入部分文件
            {
                e.Effect = DragDropEffects.All;
                String[] files = (String[])e.Data.GetData(DataFormats.FileDrop);
                for (int i = 0; i < files.Length; i++)
                    textBox_main.Text += files.GetValue(i).ToString() + "\r\n";
            }
            else
            {
                using (StreamReader sr = new StreamReader(filenames[0], Encoding.UTF8))
                {
                    textBox_main.Text = sr.ReadToEnd();
                }
            }
            
        }

        private void textBox_main_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox == null)
                return;

            if (e.KeyChar == (char)1)       // Ctrl-A 相当于输入了AscII=1的控制字符
            {
                textBox.SelectAll();
                e.Handled = true;      // 不再发出“噔”的声音
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void SaveSettings()
        {
            string ExtendName = "";

            if (radioButton1.Checked == true) { ExtendName = "MP4"; }
            if (radioButton2.Checked == true) { ExtendName = "MKV"; }
            if (radioButton3.Checked == true) { ExtendName = "TS"; }
            if (radioButton4.Checked == true) { ExtendName = "FLV"; }

            XmlTextWriter xml = new XmlTextWriter(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + 
                "\\Batch_Download_Settings.xml", Encoding.UTF8);
            xml.Formatting = Formatting.Indented;
            xml.WriteStartDocument();
            xml.WriteStartElement("Settings");
            
            xml.WriteStartElement("FFmpegPath"); xml.WriteCData(ffmpeg_path.Text); xml.WriteEndElement();
            xml.WriteStartElement("ExtendName"); xml.WriteCData(ExtendName); xml.WriteEndElement();
            xml.WriteStartElement("OutputPath"); xml.WriteCData(Output_Path.Text); xml.WriteEndElement();

            xml.WriteEndElement();
            xml.WriteEndDocument();
            xml.Flush();
            xml.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Dispose();
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void tabPage2_DragDrop(object sender, DragEventArgs e)
        {
            var filenames = (string[])e.Data.GetData(DataFormats.FileDrop);
            var filename = filenames[0].LastIndexOf('\\') + 1;
            var houzhui = filenames[0].Substring(filename);//文件后缀名

            if (houzhui == "ffmpeg.exe") //只允许拖入ffmpeg.exe
            {
                e.Effect = DragDropEffects.All;
                String[] files = (String[])e.Data.GetData(DataFormats.FileDrop);
                ffmpeg_path.Text = "\"" + files.GetValue(0).ToString() + "\"";
            }
        }

        private void tabPage2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void tabPage2_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void ffmpeg_path_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择ffmpeg.exe的位置";
            fileDialog.Filter = "FFmpeg|ffmpeg.exe";
            fileDialog.FilterIndex = 1;
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string fs = fileDialog.FileName;
                ffmpeg_path.Text = "\"" + fs + "\"";
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == false) { textBox_filename.Enabled = false; label9.Visible = false; label.Visible = false; }
            if (radioButton5.Checked == true) { textBox_filename.Enabled = true; label9.Visible = true; label.Visible = true; }
        }

        private void comboBox_digit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_digit.SelectedItem.ToString() == "1")  digit = "0";
            if (comboBox_digit.SelectedItem.ToString() == "2") digit = "00";
            if (comboBox_digit.SelectedItem.ToString() == "3") digit = "000";
        }

        private void Output_Path_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                label.Text = folderBrowserDialog1.SelectedPath + "\\";
                Output_Path.Text = folderBrowserDialog1.SelectedPath + "\\";
            }
        }

        private void label10_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "1";
        }

        private void label_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("nilaoda 编译于 2016/12/03\nCopyright ©  2016", "关于", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Process.Start("http://pan.baidu.com/s/1skDlWlv");
        }
        
        private void tabPage2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        //此函数用于格式化输出时长
        public static String FormatTime(Int32 time)
        {
            TimeSpan ts = new TimeSpan(0, 0, time);
            string str = "";
            str = ts.Hours.ToString("00") + ":" + ts.Minutes.ToString("00") + ":" + ts.Seconds.ToString("00");
            return str;
        }

        //此函数用于格式化输出文件大小
        public static String FormatFileSize(Double fileSize)
        {
            if (fileSize < 0)
            {
                throw new ArgumentOutOfRangeException("fileSize");
            }
            else if (fileSize >= 1024 * 1024 * 1024)
            {
                return string.Format("{0:########0.00} GB", ((Double)fileSize) / (1024 * 1024 * 1024));
            }
            else if (fileSize >= 1024 * 1024)
            {
                return string.Format("{0:####0.00} MB", ((Double)fileSize) / (1024 * 1024));
            }
            else if (fileSize >= 1024)
            {
                return string.Format("{0:####0.00} KB", ((Double)fileSize) / 1024);
            }
            else
            {
                return string.Format("{0} bytes", fileSize);
            }
        }

        private void label13_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Process.Start("https://ffmpeg.zeranoe.com/builds/win32/static/");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //实例化ToolTip控件
            ToolTip tooltip1 = new ToolTip();
            //设置提示框显示时间，默认5000，最大为32767，超过此数，将以默认5000显示           
            tooltip1.AutoPopDelay = 30000;
            //是否以球状显示提示框            
            tooltip1.IsBalloon = true;
            //设置要显示提示框的控件 button1按钮
            tooltip1.SetToolTip(this.linkLabel_Analyze, "分析文本框中的Xml内容并返回所有URL以及视频信息.\n(可填入直接返回Xml字符串的网址)");
            tooltip1.SetToolTip(this.checkBox_LieYing, "勾选此项将调用猎影视频下载软件进行后续作业.");
            tooltip1.SetToolTip(this.linkLabel_AddFile, "添加文件以批量转码或合并视频分段.");
            tooltip1.SetToolTip(this.radioButton8, "程序将在执行任务后执行合并作业.");
            tooltip1.SetToolTip(this.radioButton7, "程序将直接执行合并作业.");

            if (File.Exists(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + 
                "\\Batch_Download_Settings.xml"))  //判断程序目录有无配置文件，并读取文件
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + 
                    "\\Batch_Download_Settings.xml");    //加载Xml文件  
                XmlNodeList topM = doc.SelectNodes("Settings");
                foreach (XmlElement element in topM)
                {
                    if (element.GetElementsByTagName("OutputPath")[0].InnerText.Length != 0)
                        label.Text=Output_Path.Text = element.GetElementsByTagName("OutputPath")[0].InnerText;
                    Output_Path.Text = element.GetElementsByTagName("OutputPath")[0].InnerText;
                    if (element.GetElementsByTagName("FFmpegPath")[0].InnerText != "\"ffmpeg.exe\"")
                        ffmpeg_path.Text = element.GetElementsByTagName("FFmpegPath")[0].InnerText;
                    if (element.GetElementsByTagName("ExtendName")[0].InnerText == "MP4") { radioButton1.Checked = true; }
                    if (element.GetElementsByTagName("ExtendName")[0].InnerText == "MKV") { radioButton2.Checked = true; }
                    if (element.GetElementsByTagName("ExtendName")[0].InnerText == "TS") { radioButton3.Checked = true; }
                    if (element.GetElementsByTagName("ExtendName")[0].InnerText == "FLV") { radioButton4.Checked = true; }
                }
            }
        }

        private void textBox_main_TextChanged(object sender, EventArgs e)
        {
            if (textBox_main.GetLineFromCharIndex(textBox_main.TextLength) + 1 > 23)
                textBox_main.ScrollBars = ScrollBars.Vertical;
            if (textBox_main.GetLineFromCharIndex(textBox_main.TextLength) + 1 <= 23)
                textBox_main.ScrollBars = ScrollBars.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void tabPage1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void linkLabel_Analyze_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                WebClient down = new WebClient();
                down.Encoding = Encoding.UTF8;
                if (textBox_main.Lines.Length == 1 && textBox_main.Text.Length >= 7 && textBox_main.Text.Contains("<ckplayer>") == false)  //大于等于7是 "http://" 的字长
                {
                    try
                    {
                        if(down.DownloadString(textBox_main.Text).Contains("#EXTM3U"))
                        {
                            MessageBox.Show("该链接或许指向一个m3u8，请直接下载！", "从网址加载Xml文件出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            textBox_main.Text = down.DownloadString(textBox_main.Text);  //从网址加载Xml文件
                        }
                    }
                    catch(Exception)
                    {
                        MessageBox.Show("未知错误", "从网址加载Xml文件出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                LoadXml();
            }
            catch(Exception)
            {
                LoadXml();
            }
        }

        private void LoadXml()
        {
            try
            {
                XmlDocument doc = new XmlDocument();

                //若无 CDATA 区段，则修正一些转义字符，防止解析xml出错。 ---- 2016/12/2日
                //加载Xml，同时去除flashvars标签中可能存在的特殊字符对结果造成的影响
                if (textBox_main.Text.Contains("![CDATA"))
                {
                    doc.Load(new StringReader(Regex.Replace(textBox_main.Text,
                    @"<flashvars>.+?</flashvars>", string.Empty)));
                }
                else
                {
                    doc.Load(new StringReader(Regex.Replace(textBox_main.Text.Replace("&", "&amp;"),
                    @"<flashvars>.+?</flashvars>", string.Empty)));
                }

                if (textBox_main.Text.Contains("m3u8.swf"))
                {
                    textBox_main.Text = textBox_main.Text.Replace("m3u8.swf", "");
                    textBox_main.Text = Regex.Match(textBox_main.Text.Replace("m3u8.swf", ""),
                        @"((http|ftp|https):\/\/)?[\w\-_]+(\.[\w\-_]+)+([\w\-\.,@?^=%&amp;:/~\+#]*[\w\-\@?^=%&amp;/~\+#])?").ToString();
                }
                else
                {
                    XmlNodeList urlList = doc.GetElementsByTagName("file");
                    XmlNodeList timeList = doc.GetElementsByTagName("seconds");
                    XmlNodeList sizeList = doc.GetElementsByTagName("size");

                    size = 0;
                    time = 0;

                    for (int i = 0; i < urlList.Count; i++)
                    {
                        if (i == 0)
                        {
                            for (int k = 0; k < urlList.Count; k++)
                            {
                                size += Convert.ToDouble(sizeList[i].InnerText);
                                time += Convert.ToDouble(timeList[i].InnerText);
                                textBox_main.Text = "";
                            }
                        }
                        textBox_main.AppendText(urlList[i].InnerText + "\r\n");
                    }
                    label_xml_Info.Text = "#时长：" + FormatTime(Convert.ToInt32(time)) +
                                    "  #大小：" + FormatFileSize(size);

                    //写入m3u8信息
                    textBox_XmlM3u8.Text = "";

                    for (int i = 0; i < urlList.Count; i++)
                    {
                        if (i == 0)
                        {
                            textBox_XmlM3u8.AppendText(
                                "#Duration:" + FormatTime(Convert.ToInt32(time)) +
                                "\r\n#Size:" + FormatFileSize(size) +
                                "\r\n#Created by [Batch Download  by：nilaoda]\r\n\r\n" +
                                "#EXTM3U\r\n" +
                                "#EXT-X-ALLOW-CACHE:YES\r\n"
                                );
                        }

                        textBox_XmlM3u8.AppendText(
                        "\r\n" + "#EXT-SIZE:" + sizeList[i].InnerText + "\r\n" +
                        "#EXTINF:" + timeList[i].InnerText + ",\r\n" +
                        urlList[i].InnerText
                        );
                    }

                    textBox_XmlM3u8.AppendText(
                        "\r\n#EXT-X-ENDLIST"
                        );
                    label_closeXmlIno.Visible = true;
                    linkLabel_ToM3u8.Visible = true;
                    linkLabel_ToMedia.Visible = true;
                    checkBox_LieYing.Visible = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("(仅接受直接返回xml字符串的网址或xml内容).~~\n\n可以识别的Xml：\n<ckplayer>\n<file><![CDATA[http://xxx]]></file>\n<size>100</size>\n<seconds>100</seconds>\n</ckplayer> ", "分析Xml出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel_AddFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "视频文件 (*.mkv;*.mp4 等)|*.avi;*.wmv;*.wmp;*.wm;*.asf;*.mpg;*.mpeg;*.mpe;*.m1v;"
                + "*.m2v;*.mpv2;*.mp2v;*.ts;*.tp;*.tpr;*.trp;*.vob;*.ifo;*.ogm;*.ogv;*.mp4;*.m4v;*.m4p;*.m4b;*.3gp;*.3gpp;"
                + "*.3g2;*.3gp2;*.mkv;*.rm;*.ram;*.rmvb;*.rpm;*.flv;*.swf;*.mov;*.qt;*.amr;*.nsv;*.dpg;*.m2ts;*.m2t;*.mts;"
                + "*.dvr-ms;*.k3g;*.skm;*.evo;*.nsr;*.amv;*.divx;*.webm;*.wtv;*.f4v|所有文件|*.*";
            fileDialog.FilterIndex = 1;
            fileDialog.RestoreDirectory = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] fs = fileDialog.FileNames;
                foreach (string ff in fs)
                    textBox_main.AppendText(ff + "\r\n");
            }
        }

        private void linkLabel_Clean_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBox_main.Text = "";
        }

        private void label_xml_Info_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox_Join.CheckState == CheckState.Checked)
            {
                checkBox_Join.ForeColor = Color.FromArgb(46, 204, 113);
                radioButton7.Visible = true; radioButton8.Visible = true;
                radioButton8.Checked = true;
            }
            if (checkBox_Join.CheckState == CheckState.Unchecked)
            {
                checkBox_Join.ForeColor = Color.FromArgb(52, 152, 219);
                radioButton7.Visible = false; radioButton8.Visible = false;
                radioButton8.Checked = true;
            }
        }

        private void checkBox_Convert_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Convert.CheckState == CheckState.Checked)
            {
                checkBox_Convert.ForeColor = Color.FromArgb(46, 204, 113);
                radioButton6.Checked = true;
                label_Info.Text = "确保你导入的是本地文件。\n程序将按原路径+原文件名转换封装后输出！\n还可添加合并(完成后)选项\n已经去掉 -bsf:a aac_adtstoasc 参数";
            }
            if (checkBox_Convert.CheckState == CheckState.Unchecked)
            {
                checkBox_Convert.ForeColor = Color.FromArgb(52, 152, 219);
                radioButton5.Checked = true;
                label_Info.Text = "";
            }
        }

        private void label_closeXmlIno_Click(object sender, EventArgs e)
        {
            label_xml_Info.Text = "";
            label_closeXmlIno.Visible=false;
            linkLabel_ToM3u8.Visible = false;
            linkLabel_ToMedia.Visible = false;
            checkBox_LieYing.Visible = false;
        }

        private void checkBox_LieYing_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_LieYing.CheckState == CheckState.Checked)
            {
                checkBox_LieYing.ForeColor = Color.FromArgb(46, 204, 113);
            }
            if (checkBox_LieYing.CheckState == CheckState.Unchecked)
            {
                checkBox_LieYing.ForeColor = Color.FromArgb(231, 76, 60);
            }
        }

        private void linkLabel_ToMedia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            String urlsList = "";
            urlsList = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                "\\Urls-" + System.DateTime.Now.ToString("yyyy.MM.dd-HH.mm.ss") + ".media";
            StreamWriter urls = new StreamWriter(urlsList);
            urls.WriteLine("<Duration:" + FormatTime(Convert.ToInt32(time)) + ">" +
                            "\r\n<Size:" + FormatFileSize(size) + ">" +
                            "\r\n<Created by [Batch Download  by：nilaoda]>\r\n\r\n" + 
                            textBox_main.Text);
            urls.Close();
            MessageBox.Show("已输出至桌面.");

            if (checkBox_LieYing.Checked == true)
            {
                string LieYing_Path = "";
                Process[] ps = Process.GetProcessesByName("LYDown");
                foreach (Process p in ps)
                {
                    LieYing_Path = p.MainModule.FileName.ToString();
                }
                if (LieYing_Path != "")
                {
                    Process.Start("\"" + LieYing_Path + "\"", "\"" + urlsList + "\"");  //调起猎影
                }
                else
                {
                    MessageBox.Show("没有找到 LYDown.exe.");
                }
            }
        }

        private void linkLabel_ToM3u8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            String urlsList = "";
            urlsList = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                "\\Urls-" + System.DateTime.Now.ToString("yyyy.MM.dd-HH.mm.ss") + ".m3u8";
            StreamWriter urls = new StreamWriter(urlsList);
            urls.WriteLine(textBox_XmlM3u8.Text);
            urls.Close();
            MessageBox.Show("已输出至桌面.");

            if (checkBox_LieYing.Checked == true)
            {
                string LieYing_Path = "";
                Process[] ps = Process.GetProcessesByName("LYDown");
                foreach (Process p in ps)
                {
                    LieYing_Path = p.MainModule.FileName.ToString();
                }
                if (LieYing_Path != "")
                {
                    Process.Start("\"" + LieYing_Path + "\"", "\"" + urlsList + "\"");  //调起猎影
                }
                else
                {
                    MessageBox.Show("没有找到 LYDown.exe.");
                }
            }

        }

        private void label_help_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/nilaoda/Batch-Download/blob/master/Readme.md");
        }
    }
}