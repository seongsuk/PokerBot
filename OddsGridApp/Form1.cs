// This application is covered by the LGPL Gnu license. See http://www.gnu.org/copyleft/lesser.html 
// for more information on this license.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace OddsGridApp
{
    
    delegate void SetTextCallback(string text);

    /// <summary>
    /// 
    /// </summary>
    public partial class Form1 : Form
    {
        string previous = "";
        Boolean gameRunning = false;
        
        [DllImport("user32.dll")] // Pvinvoke mouse-event
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData,
          int dwExtraInfo);


        [DllImport("user32.dll")]
        static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("user32.dll")]
        static extern Int32 ReleaseDC(IntPtr hwnd, IntPtr hdc);

        [DllImport("gdi32.dll")]
        static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg,
    IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", EntryPoint = "WindowFromPoint",
            CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr WindowFromPoint(Point point);
        private const int BM_CLICK = 0x00F5;

        const uint MOUSEEVENTF_ABSOLUTE = 0x8000;
        const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        const uint MOUSEEVENTF_LEFTUP = 0x0004;
        const uint MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        const uint MOUSEEVENTF_MIDDLEUP = 0x0040;
        const uint MOUSEEVENTF_MOVE = 0x0001;
        const uint MOUSEEVENTF_RIGHTDOWN = 0x0008;
        const uint MOUSEEVENTF_RIGHTUP = 0x0010;
        const uint MOUSEEVENTF_XDOWN = 0x0080;
        const uint MOUSEEVENTF_XUP = 0x0100;
        const uint MOUSEEVENTF_WHEEL = 0x0800;
        const uint MOUSEEVENTF_HWHEEL = 0x01000;
        



        private const int firstButtonX = 459;
        private const int firstButtonY = 460;
        private const int secondButtonX = 504;
        private const int secondButtonY = 460;
        private const int thirdButtonX = 598;
        private const int thirdButtonY = 460;

        /// <summary>
        /// 
        /// </summary>
        public Form1()
        {
            
            InitializeComponent();
          //  System.Timers.Timer aTimer = new System.Timers.Timer(1000);
           // aTimer.Elapsed += timerFunction;
           // aTimer.Enabled = true;
        }

        /*
        private void timerFunction(object sender, System.Timers.ElapsedEventArgs e)
        {
            //throw new NotImplementedException();
           setTextBox3(Cursor.Position.X.ToString() + " " + Cursor.Position.Y.ToString());

           // setTextbox_color(Cursor.Position.X +" " + Cursor.Position.Y);

        }
       */
        /*
        private void setTextbox_color(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.textBox1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(setTextbox_color);
                try
                {
                    this.Invoke(d, new object[] { text });
                }
                catch { }
            }
            else
            {
                
                this.textBox3.BackColor = checkPixelColor(Int32.Parse(text.Split(' ')[0]), Int32.Parse(text.Split(' ')[1]));
                this.textBox2.Text = ""+checkPixelColor(Int32.Parse(text.Split(' ')[0]), Int32.Parse(text.Split(' ')[1])).ToArgb();
            }
        }
        */
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PocketCards_TextChanged(object sender, EventArgs e)
        {

            this.oddsGrid1.Pocket = this.PocketCards.Text;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Board_TextChanged(object sender, EventArgs e)
        {
            this.oddsGrid1.Board = this.Board.Text;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.oddsGrid1.Pocket = this.PocketCards.Text;
            this.oddsGrid1.Board = this.Board.Text;
        }



        /*
        private void loadCard_Click(object sender, EventArgs e)
        {
            
            loadCardFill();
            int i = checkCurrentBoard();
            textBox3.Text = "" + i;
            //this.PocketCards.Text = poket;

            //this.Board.Text = board;

        }
        */

        private void loadCardFill()
        {
            LoadCard lc = new LoadCard();
            Queue<String> result = new Queue<string>();
            // Thread FirstThread = new Thread(() => {
          //  do
           // {
                result = lc.loadCardFromFile();
                this.setText_Hand(result.Dequeue());

            //  } while (result.Peek().Length == checkCurrentBoard() * 3);
            //  int current = checkCurrentBoard();
            int sss = result.Peek().Length;
            this.setText_Board(result.Dequeue());
            //int i = result.Peek().Length;
            //    if (current * 3 == result.Peek().Length)
            //  {


            //   }
            //poket = result.Dequeue();
            //board = result.Dequeue();

            //  });
            //  FirstThread.Start();
        }

        private void setText_Board(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.PocketCards.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(setText_Board);
                try
                {
                    this.Invoke(d, new object[] { text });
                }
                catch { }
            }
            else
            {
                this.Board.Text = text;
            }
        }


        private void setText_Hand(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.PocketCards.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(setText_Hand);
                try
                {
                    this.Invoke(d, new object[] { text });
                }
                catch { }
            }
            else
            {
                this.PocketCards.Text = text;
            }
        }
        /*
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            IntPtr hdc = GetDC(IntPtr.Zero);
            uint pixel = GetPixel(hdc, Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text));
            ReleaseDC(IntPtr.Zero, hdc);
            Color color = Color.FromArgb((int)(pixel & 0x000000FF),
                         (int)(pixel & 0x0000FF00) >> 8,
                         (int)(pixel & 0x00FF0000) >> 16);
           textBox1.BackColor = color;

            textBox3.Text = "" + color.ToArgb();

        }
        */

        private void setMyTurn(String s)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.turnStatus.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(setMyTurn);
                try
                {
                    this.Invoke(d, new object[] { s });
                }
                catch { }
            }
            else
            {
                this.turnStatus.Text = "Turn statue: " + s;
            }


        }

        /*

        private void setTextBox3(String s)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.turnStatus.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(setTextBox3);
                try
                {
                    this.Invoke(d, new object[] { s });
                }
                catch { }
            }
            else
            {
                this.textBox3.Text = "" + s;
            }


        }*/


        private void enableTextBox4(string s)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.turnStatus.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(enableTextBox4);
                try
                {
                    this.Invoke(d, new object[] { s });
                }
                catch { }
            }
            else
            {
                this.textBox4.Enabled = true;
                this.checkBox1.Enabled = true;
            }


        }

        private int checkCurrentBoard() // Checks the number of cards on the board
        {
            if (checkPixelColor(514, 250).ToArgb() == -1)
            {
                return 5;
            }
            else if (checkPixelColor(467, 247).ToArgb() == -1)
            {
                return 4;
            }
            else if (checkPixelColor(414, 246).ToArgb() == -1)
            {
                return 3;
            }
            return 0;
        }
    
        
        private Color checkPixelColor(int x, int y)
        {
            IntPtr hdc = GetDC(IntPtr.Zero);
            uint pixel = GetPixel(hdc, x,y);
            ReleaseDC(IntPtr.Zero, hdc);
            Color color = Color.FromArgb((int)(pixel & 0x000000FF),
                     (int)(pixel & 0x0000FF00) >> 8,
                     (int)(pixel & 0x00FF0000) >> 16);
            return color;
        }

        private Boolean checkMyTurn()
        {
            Color myPanel = checkPixelColor(424, 545);
            if (myPanel.ToArgb() == -657931) //-16777216black
            {
                return true;
            }
            return false;

        }
        /// <summary>
        /// Simulates a mouse click
        /// </summary>
        private void mouseClick(int x, int y)
        {
            // mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP,
            //    (uint)Cursor.Position.X+100, (uint)Cursor.Position.Y+100, 0, 0);
            // mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint)705, (uint)390, 0, 0);
            //mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, (uint)705, (uint)390, 0, 0);
            Cursor.Position = new Point(x, y);
            mouse_event((uint)MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            Thread.Sleep((new Random()).Next(20, 30));
            mouse_event((uint)MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

        }

        private Object _locker = new Object();

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!gameRunning)
            {
                textBox4.Enabled = false;
                checkBox1.Enabled = false;
                LoadCard temp = new LoadCard();
                temp.moveWindow();
                gameRunning = true;
                int limit1 = 90;
                int limit2 = 60;
                int limit3 = 55;
                bool aggre = aggreButton1.Checked;
                bool safe = safeButton1.Checked;
                if (aggre)
                {
                    limit1 -= 5;
                    limit2 -= 5;
                    limit3 -= 5;
                }
                else if (safe)
                {
                    limit2 += 5;
                    limit3 += 5;
                }


                Thread infinite = new Thread(() =>
                {    // Get the color of my panel
                while (true)
                    {
                        Thread.Sleep(2000);


                    //PushBullet
                    if (checkBox1.Checked == true && textBox4.Text.Length != 0)
                        {
                            if (receivePushBullet(textBox4.Text) == 1)
                            {
                                gameRunning = false;
                                enableTextBox4("");
                            }
                        }



                        if (checkMyTurn()) // Checks the turn
                    {
                            setMyTurn("My turn");

                        //lock (_locker) { 
                        // {
                        loadCardFill();
                        // setTextBox3("" + this.oddsGrid1.PlayerWins);
                        if (this.oddsGrid1.PlayerWins >= limit1)
                            {
                            // if (checkPixelColor(thirdButtonX, thirdButtonY) == Color.FromArgb(255, 70, 24, 10)) 
                            // {
                            mouseClick(thirdButtonX, thirdButtonY);
                                mouseClick(thirdButtonX, thirdButtonY - 10);
                                mouseClick(100, firstButtonY);
                            // }
                            // else if(checkPixelColor(secondButtonX, secondButtonY) == Color.FromArgb(255, 70, 24, 10))
                            // {
                            mouseClick(secondButtonX, secondButtonY);
                                mouseClick(secondButtonX, secondButtonY - 10);
                                mouseClick(100, firstButtonY);
                            //  }
                        }
                            else if (this.oddsGrid1.PlayerWins >= limit2 || (this.Board.Text == "" && this.oddsGrid1.PlayerWins >= limit3))
                            {
                            // if (checkPixelColor(secondButtonX, secondButtonY) == Color.FromArgb(255, 70, 24, 10))
                            //  {
                            mouseClick(secondButtonX, secondButtonY);
                                mouseClick(secondButtonX, secondButtonY - 10);
                                mouseClick(100, firstButtonY);
                            //   }
                            //  else
                            //  {
                            mouseClick(thirdButtonX, thirdButtonY);
                                mouseClick(thirdButtonX, thirdButtonY - 10);
                                mouseClick(100, firstButtonY);
                            // }
                        }
                            else
                            {
                            // if (checkPixelColor(firstButtonX, firstButtonY) == Color.FromArgb(255, 70, 24, 10)) 
                            // {
                            mouseClick(firstButtonX, firstButtonY);
                                mouseClick(firstButtonX, firstButtonY - 10);
                                mouseClick(100, firstButtonY);
                            //  }
                        }
                        // }
                    }
                        else
                        {
                            setMyTurn("Not my turn");
                        }

                        if (!gameRunning)
                        {
                            enableTextBox4("");
                            setMyTurn("Not Running");
                            break;

                        }

                    }

                });
                infinite.Start();

            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {

            //  textBox1.Text = "" + checkPixelColor(firstButtonX, firstButtonY).R
            //      + " " + checkPixelColor(firstButtonX, firstButtonY).G
            //     + " "+ checkPixelColor(firstButtonX, firstButtonY).B
            //     + " "+ checkPixelColor(firstButtonX, firstButtonY).A
            //    + " ";
            //  if (checkPixelColor(firstButtonX, firstButtonY) == Color.FromArgb(255,70, 24, 10))
            //  {
            //      mouseClick(firstButtonX, firstButtonY);
            // }

            gameRunning = false;
        }



        //1. Stop 2.Start 
        private int receivePushBullet(string token)
        {
            WebRequest request = WebRequest.Create("https://api.pushbullet.com/v2/pushes?active=true&limit=1");
            request.Method = "GET";
            request.Headers.Add("Authorization", "Bearer "+ token);
            request.ContentType = "application/json; charset=UTF-8";

            Stream dataStream = request.GetResponse().GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            String responseFromServer = reader.ReadToEnd();
            int index1 = responseFromServer.IndexOf("\"body\":\"") + 8;
            string[] result = responseFromServer.Substring(index1).Split('"');
            if (result[0].Equals(previous))
            {
                return 0;
            }
            else if (result[0].ToLower().Contains("stop"))
            {
                previous = result[0];
                return 1;
            }
            else if (result[0].ToLower().Contains("start"))
            {
                previous = result[0];
                return 2;
            }
            dataStream.Close();
            return 0;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Enabled = true;
            }
            else
            {
                textBox4.Enabled = false;
            }
        }
    }
}