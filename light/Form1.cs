using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Globalization;

namespace light
{
    public partial class Form1 : Form
    {
        SerialClass sc;
        public static string read = "";

        //语音识别
        private string Text;
        private SpeechRecognitionEngine recognizer;
        private DictationGrammar dictationGrammar;

        /// <summary>
        /// 16进制控制码
        /// </summary>
        byte[] data1_1= { 0xFD, 0x03, 0x07, 0x04, 0x01, 0x40, 0xDF };
        byte[] data1_0= { 0xFD, 0x03, 0x07, 0x04, 0x02, 0x40, 0xDF };
        byte[] data2_1= { 0xFD, 0x03, 0x07, 0x04, 0x03, 0x40, 0xDF };
        byte[] data2_0= { 0xFD, 0x03, 0x07, 0x04, 0x04, 0x40, 0xDF };
        byte[] data3_1= { 0xFD, 0x03, 0x07, 0x04, 0x05, 0x40, 0xDF };
        byte[] data3_0= { 0xFD, 0x03, 0x07, 0x04, 0x06, 0x40, 0xDF };
        byte[] data4_1= { 0xFD, 0x03, 0x07, 0x04, 0x07, 0x40, 0xDF };
        byte[] data4_0= { 0xFD, 0x03, 0x07, 0x04, 0x08, 0x40, 0xDF };
        byte[] data5_1= { 0xFD, 0x03, 0x07, 0x04, 0x09, 0x40, 0xDF };
        byte[] data5_0= { 0xFD, 0x03, 0x07, 0x04, 0x0A, 0x40, 0xDF };
        byte[] data6_1= { 0xFD, 0x03, 0x07, 0x04, 0x0B, 0x40, 0xDF };
        byte[] data6_0= { 0xFD, 0x03, 0x07, 0x04, 0x0C, 0x40, 0xDF };
        byte[] data7_1= { 0xFD, 0x03, 0x07, 0x04, 0x0D, 0x40, 0xDF };
        byte[] data7_0= { 0xFD, 0x03, 0x07, 0x04, 0x0E, 0x40, 0xDF };
        byte[] data8_1= { 0xFD, 0x03, 0x07, 0x04, 0x0F, 0x40, 0xDF };
        byte[] data8_0= { 0xFD, 0x03, 0x07, 0x04, 0x10, 0x40, 0xDF };

        public Form1()
        {
            InitializeComponent();

            string[] a = { };
            SRecognition(a, 1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sc = new SerialClass();
            sc.setSerialPort("COM3",9600);//串口号，波特率
            sc.openPort();

            //语音控制
            recognizer.RecognizeAsync(RecognizeMode.Multiple);
        }

        private Point mPoint;

        /// <summary>
        /// 显示时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            labdate.Text = DateTime.Now.ToLongDateString().ToString();
            labtime.Text = DateTime.Now.ToString("hh:mm:ss");
            Application.DoEvents();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            sc.closePort();
        }

       
        private void btn_on_Click(object sender, EventArgs e)
        {
            sc.SendData(data1_1, 0, data1_1.Length);
            System.Threading.Thread.Sleep(1000);
            sc.SendData(data2_1, 0, data2_1.Length);
            System.Threading.Thread.Sleep(1000);
            sc.SendData(data3_1, 0, data3_1.Length);
            System.Threading.Thread.Sleep(1000);
            sc.SendData(data4_1, 0, data4_1.Length);
            System.Threading.Thread.Sleep(1000);
            sc.SendData(data5_1, 0, data5_1.Length);
            System.Threading.Thread.Sleep(1000);
            sc.SendData(data6_1, 0, data6_1.Length);
            System.Threading.Thread.Sleep(1000);
            sc.SendData(data7_1, 0, data7_1.Length);
            System.Threading.Thread.Sleep(1000);
        }

        private void btn_off_Click(object sender, EventArgs e)
        {
            sc.SendData(data1_0, 0, data1_0.Length);
            System.Threading.Thread.Sleep(1000);
            sc.SendData(data2_0, 0, data2_0.Length);
            System.Threading.Thread.Sleep(1000);
            sc.SendData(data3_0, 0, data3_0.Length);
            System.Threading.Thread.Sleep(1000);
            sc.SendData(data4_0, 0, data4_0.Length);
            System.Threading.Thread.Sleep(1000);
            sc.SendData(data5_0, 0, data5_0.Length);
            System.Threading.Thread.Sleep(1000);
            sc.SendData(data6_0, 0, data6_0.Length);
            System.Threading.Thread.Sleep(1000);
            sc.SendData(data7_0, 0, data7_0.Length);
            System.Threading.Thread.Sleep(1000);
        }
        private void btn1_on_Click(object sender, EventArgs e)
        {
            sc.SendData(data1_1, 0, data1_1.Length);
        }

        private void btn1_off_Click(object sender, EventArgs e)
        {
            sc.SendData(data1_0, 0, data1_0.Length);
        }


        private void btn1_1_on_Click(object sender, EventArgs e)
        {
            sc.SendData(data2_1, 0, data2_1.Length);
        }

        private void btn1_1_off_Click(object sender, EventArgs e)
        {
            sc.SendData(data2_0, 0, data2_0.Length);
        }
 
        private void btn1_2_on_Click(object sender, EventArgs e)
        {
            sc.SendData(data3_1, 0, data3_1.Length);
        }

        private void btn1_2_off_Click_1(object sender, EventArgs e)
        {
            sc.SendData(data3_0, 0, data3_0.Length);
        }

        private void btn2_1_on_Click(object sender, EventArgs e)
        {
            sc.SendData(data4_1, 0, data4_1.Length);
        }

        private void btn2_1_off_Click(object sender, EventArgs e)
        {
            sc.SendData(data4_0, 0, data4_0.Length);
        }

        private void btn2_2_on_Click(object sender, EventArgs e)
        {
            sc.SendData(data5_1, 0, data5_1.Length);
        }

        private void btn2_2_off_Click(object sender, EventArgs e)
        {
            sc.SendData(data5_0, 0, data5_0.Length);
        }

        private void btn3_1_on_Click(object sender, EventArgs e)
        {
            sc.SendData(data6_1, 0, data6_1.Length);
        }

        private void btn3_1_off_Click(object sender, EventArgs e)
        {
            sc.SendData(data6_0, 0, data6_0.Length);
        }

        private void btn3_2_on_Click(object sender, EventArgs e)
        {
            sc.SendData(data7_1, 0, data7_1.Length);
        }

        private void btn3_2_off_Click(object sender, EventArgs e)
        {
            sc.SendData(data7_0, 0, data7_0.Length);
        }

        /// <summary>
        /// 窗体随鼠标移动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }

        /// <summary>
        /// 关闭窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //语音控制
        public void SRecognition(string[] fg, int i) //创建关键词语列表  
        {
            CultureInfo myCIintl = new CultureInfo("zh-CN");
            foreach (RecognizerInfo config in SpeechRecognitionEngine.InstalledRecognizers())//获取所有语音引擎  
            {
                Console.WriteLine(config.Culture.EnglishName);
                if (config.Culture.Equals(myCIintl))
                {
                    recognizer = new SpeechRecognitionEngine(config);
                    break;
                }//选择识别引擎
            }
            if (recognizer != null)
            {
                InitializeSpeechRecognitionEngine(fg);//初始化语音识别引擎  
                dictationGrammar = new DictationGrammar();
            }
            else
            {
                MessageBox.Show("创建语音识别失败");
            }
        }

        void InitializeSpeechRecognitionEngine(string[] s)
        {
            // Create and load a dictation grammar.
            //recognizer.LoadGrammar(new DictationGrammar());

            // Configure input to the speech recognizer.
            recognizer.SetInputToDefaultAudioDevice();

            // Modify the initial silence time-out value.
            recognizer.InitialSilenceTimeout = TimeSpan.FromSeconds(5);

            GrammarBuilder GB = new GrammarBuilder();
            GB.Append("打开");
            GB.Append(new Choices(new string[] { "前排灯","后排灯" }));
            Grammar G = new Grammar(GB);
            Console.WriteLine(G.RuleName);
            G.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(G_SpeechRecognized);
            recognizer.LoadGrammar(G);

            GrammarBuilder GB2 = new GrammarBuilder();
            GB2.Append("关闭");
            GB2.Append(new Choices(new string[] { "前排灯", "后排灯" }));
            Grammar G2 = new Grammar(GB2);
            Console.WriteLine(G.RuleName);
            G2.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(G_SpeechRecognized);
            recognizer.LoadGrammar(G2);
        }


        void G_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            Text = e.Result.Text;
            switch (e.Result.Text)
            {
                case "打开前排灯":
                    //textBox1.Text = "开灯";
                    sc.SendData(data1_1, 0, data1_1.Length);
                    System.Threading.Thread.Sleep(1000);
                    sc.SendData(data2_1, 0, data2_1.Length);
                    System.Threading.Thread.Sleep(1000);
                    sc.SendData(data4_1, 0, data4_1.Length);
                    System.Threading.Thread.Sleep(1000);
                    sc.SendData(data6_1, 0, data6_1.Length);

                    break;
                case "关闭前排灯":
                    //textBox1.Text = "关灯";
                    sc.SendData(data1_0, 0, data1_0.Length);
                    System.Threading.Thread.Sleep(1000);
                    sc.SendData(data2_0, 0, data2_0.Length);
                    System.Threading.Thread.Sleep(1000);
                    sc.SendData(data4_0, 0, data4_0.Length);
                    System.Threading.Thread.Sleep(1000);
                    sc.SendData(data6_0, 0, data6_0.Length);
                    break;
                case "打开后排灯":
                    sc.SendData(data3_1, 0, data3_1.Length);
                    System.Threading.Thread.Sleep(1000);
                    sc.SendData(data5_1, 0, data5_1.Length);
                    System.Threading.Thread.Sleep(1000);
                    sc.SendData(data7_1, 0, data7_1.Length);
                    break;
                case "关闭后排灯":
                    sc.SendData(data3_0, 0, data3_0.Length);
                    System.Threading.Thread.Sleep(1000);
                    sc.SendData(data5_0, 0, data5_0.Length);
                    System.Threading.Thread.Sleep(1000);
                    sc.SendData(data7_0, 0, data7_0.Length);
                    break;

            }
        }
    }

}
