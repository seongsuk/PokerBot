using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Threading;

namespace autoPoker

{
    public partial class Form1 : Form
    {
        static Point pointNull = new Point(-1, -1);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hwnd, ref Rect rectangle);

        public struct Rect
        {
            public int Left { get; set; }
            public int Top { get; set; }
            public int Right { get; set; }
            public int Bottom { get; set; }
        }
        public static IntPtr WinGetHandle(string wName) // Find the window with the partial title
        {
            IntPtr hwnd = IntPtr.Zero;
            foreach (Process pList in Process.GetProcesses())
            {
                if (pList.MainWindowTitle.Contains(wName))
                {
                    hwnd = pList.MainWindowHandle;
                }
            }
            return hwnd;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void saveSmallImage()
        {
            IntPtr temp = WinGetHandle("Hold");
            Rect rct = new Rect();
            GetWindowRect(temp, ref rct);
            if (!temp.ToString().Equals("0"))
            {
                MoveWindow(temp, 0, 0, 650, 475, true);
                loadStatus.Text = "Game Loaded";
            }
            //loadStatus.Text = ""+rct.Left;
            Bitmap[] bb = { new Bitmap(13,14), new Bitmap(13, 14), new Bitmap(13, 14), new Bitmap(13, 14), new Bitmap(13, 14) };

            for (int i = 0; i < 5; i++)
            {

                using (Bitmap bmpScreenshot = Screenshot(275 + i * 54, 247, 13, 14))
                {
                    bmpScreenshot.Save("C:\\save\\" + (i + 5) + ".bmp");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) // Load the game
        {
            saveSmallImage();
            //loadStatus.Text = ""+FindBitmap(Properties.Resources.BK, Properties.Resources.sample, out location);

        }




        private Bitmap Screenshot(int x, int y, int w, int h) // Take a screenshot of the screen
        {

            //Bitmap bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Bitmap bmpScreenshot = new Bitmap(w, h);
            Graphics g = Graphics.FromImage(bmpScreenshot);

            //Copy from the screen
            //g.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size);
            IntPtr temp = WinGetHandle("Hold");
            Rect rct = new Rect();
            GetWindowRect(temp, ref rct);

            //for(int i = 0; i < 5; i++)
            //{
            //    g.CopyFromScreen(rct.Left + 271+i*100, rct.Top + 243, 0, 0, new Size(25, 25));
            g.CopyFromScreen(x, y, 0, 0, new Size(w, h));


            return bmpScreenshot;
        }



        private void check_button_Click(object sender, EventArgs e)
        {
            Bitmap image1 = (Bitmap)Image.FromFile(@"C:\save\" + textBox1.Text + ".bmp", true);
            Bitmap image2 = (Bitmap)Image.FromFile(@"C:\save\" + textBox2.Text + ".bmp", true);
            D3_Bot_Tool.ImageChecker checker = new D3_Bot_Tool.ImageChecker(image1, image2);

            label1.Text = "" + checker.bigContainsSmall();
        }
        private void saveSmallShape()
        {
            IntPtr temp = WinGetHandle("Hold");
            Rect rct = new Rect();
            GetWindowRect(temp, ref rct);
            if (!temp.ToString().Equals("0"))
            {
                MoveWindow(temp, 0, 0, 650, 475, true);
                loadStatus.Text = "Game Loaded";
            }
            //loadStatus.Text = ""+rct.Left;
            Bitmap[] bb = { new Bitmap(13, 14), new Bitmap(13, 14), new Bitmap(13, 14), new Bitmap(13, 14), new Bitmap(13, 14) };

            for (int i = 0; i < 5; i++)
            {

                using (Bitmap bmpScreenshot = Screenshot(275 + i * 54, 262, 13, 14))
                {
                    bmpScreenshot.Save("C:\\save\\Y" + (i + 5) + ".bmp");
                }
            }
        }

        private void saveBigShape()
        {
            IntPtr temp = WinGetHandle("Hold");
            Rect rct = new Rect();
            GetWindowRect(temp, ref rct);
            if (!temp.ToString().Equals("0"))
            {
                MoveWindow(temp, 0, 0, 650, 475, true);
                loadStatus.Text = "Game Loaded";
            }
            //loadStatus.Text = ""+rct.Left;
            Bitmap[] bb = { new Bitmap(25, 25), new Bitmap(25, 25), new Bitmap(25, 25), new Bitmap(25, 25), new Bitmap(25, 25) };
            String[] result = { "", "", "", "", "" };
            for (int i = 0; i < 5; i++)
            {

                using (Bitmap bmpScreenshot = Screenshot(271 + i * 54, 259, 25, 25))
                {
                    try
                    {
                        bmpScreenshot.Save("C:\\save\\" + i + ".bmp");
                    }
                    catch
                    {
                        label1.Text = "Too fast";
                    }
                }
                //bmpScreenshot.Save("C:\\save\\" + (i + 5) + ".bmp");

                //using (var fs = new System.IO.FileStream("C:\\save\\" + (i + 5) + ".bmp", System.IO.FileMode.Open))
                //{
                //     var bmp = new Bitmap(fs);
                //  }

            }
        }
        private void saveBigShape_hand()
        {
            IntPtr temp = WinGetHandle("Hold");
            if (!temp.ToString().Equals("0"))
            {
                MoveWindow(temp, 0, 0, 650, 475, true);
                loadStatus.Text = "Game Loaded";
            }
            //loadStatus.Text = ""+rct.Left;
            for (int i = 2; i < 4; i++)
            {

                using (Bitmap bmpScreenshot = Screenshot(372 + (i-2) * 15, 500, 25, 25))
                {
                    try
                    {
                        bmpScreenshot.Save("C:\\save\\hand" + i + ".bmp");
                    }
                    catch
                    {
                        label1.Text = "Too fast";
                    }
                }
                //bmpScreenshot.Save("C:\\save\\" + (i + 5) + ".bmp");

                //using (var fs = new System.IO.FileStream("C:\\save\\" + (i + 5) + ".bmp", System.IO.FileMode.Open))
                //{
                //     var bmp = new Bitmap(fs);
                //  }

            }
        }
        private void saveBigImage_hand()
        {
            IntPtr temp = WinGetHandle("Hold");
            if (!temp.ToString().Equals("0"))
            {
                MoveWindow(temp, 0, 0, 650, 475, true);
                loadStatus.Text = "Game Loaded";
            }
            //loadStatus.Text = ""+rct.Left;
            for (int i = 0; i < 2; i++)
            {

                using (Bitmap bmpScreenshot = Screenshot(372 + i * 15, 485, 25, 25))
                {
                    try
                    {
                        bmpScreenshot.Save("C:\\save\\hand" + i + ".bmp");
                    }
                    catch
                    {
                        label1.Text = "Too fast";
                    }
                }
                //bmpScreenshot.Save("C:\\save\\" + (i + 5) + ".bmp");

                //using (var fs = new System.IO.FileStream("C:\\save\\" + (i + 5) + ".bmp", System.IO.FileMode.Open))
                //{
                //     var bmp = new Bitmap(fs);
                //  }

            }

        }
        private void saveBigImage() 
        {
            IntPtr temp = WinGetHandle("Hold");
            if (!temp.ToString().Equals("0"))
            {
                MoveWindow(temp, 0, 0, 650, 475, true);
                loadStatus.Text = "Game Loaded";
            }
            //loadStatus.Text = ""+rct.Left;
            Bitmap[] bb = { new Bitmap(25, 25), new Bitmap(25, 25), new Bitmap(25, 25), new Bitmap(25, 25), new Bitmap(25, 25) };
            String[] result = { "", "", "", "", "" };
            for (int i = 0; i < 5; i++)
            {
                
                using (Bitmap bmpScreenshot = Screenshot(271 + i * 54, 241, 25, 25))
                {
                    try {
                        bmpScreenshot.Save("C:\\save\\" + (i + 5) + ".bmp"); }
                    catch
                    {
                        label1.Text = "Too fast";
                    }
                }
                //bmpScreenshot.Save("C:\\save\\" + (i + 5) + ".bmp");
                
                //using (var fs = new System.IO.FileStream("C:\\save\\" + (i + 5) + ".bmp", System.IO.FileMode.Open))
                //{
               //     var bmp = new Bitmap(fs);
              //  }

            }

        }
        private void bigImage_Click(object sender, EventArgs e)
        {
            saveBigImage();
        }

        private Queue<String> loadCardFromFile()
        {
            
            saveBigImage();
            saveBigShape();
            saveBigImage_hand();
            saveBigShape_hand();
            Label[] ll = { r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14 };
            Queue<String> al1 = new Queue<String>(); // board shapes
            Queue<String> al2 = new Queue<String>(); // board numbers
            Queue<String> al3 = new Queue<String>(); // hand shapes
            Queue<String> al4 = new Queue<String>(); // hand numbers
            for (int i = 0; i < ll.Length; i++) // Reset
            {
                ll[i].Text = "";
            }
            var ResourceManager = new System.Resources.ResourceManager("autoPoker.Properties.Resources",
                        typeof(Properties.Resources).Assembly);
            int numCount = 0;
            int shapeCount = 5;

            for (int i = 0; i < 4; i++) // Hand cards
            {
                foreach (PropertyInfo property in typeof(Properties.Resources).GetProperties
    (BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic))
                {

                    if (i <= 1)
                    {
                        if (property.Name.Length == 2) //Number
                        {
                            Bitmap image1 = (Bitmap)Image.FromFile(@"C:\save\hand" + i + ".bmp", true);
                            Bitmap fromResource = (System.Drawing.Bitmap)(ResourceManager.GetObject(property.Name)); // Load an image from the resources
                            D3_Bot_Tool.ImageChecker checker = new D3_Bot_Tool.ImageChecker(image1, fromResource); // Checks number
                            if (checker.bigContainsSmall() != pointNull)
                            {
                                if (property.Name.Substring(property.Name.Length - 1) == "0")
                                {
                                    ll[i * 2 + 11].Text = "10";
                                    al4.Enqueue("10");
                                }
                                else
                                {
                                    ll[i * 2 + 11].Text = property.Name.Substring(property.Name.Length - 1);
                                    al4.Enqueue("" + property.Name.Substring(property.Name.Length - 1));
                                }
                            }

                        }
                    }
                    else
                    {
                        if (property.Name.Length == 1) //Shape
                        {
                            Bitmap image1 = (Bitmap)Image.FromFile(@"C:\save\hand" + i + ".bmp", true);
                            Bitmap fromResource = (System.Drawing.Bitmap)(ResourceManager.GetObject(property.Name)); // Load an image from the resources
                            D3_Bot_Tool.ImageChecker checker = new D3_Bot_Tool.ImageChecker(image1, fromResource); // Checks number
                            if (checker.bigContainsSmall() != pointNull)
                            {
                                ll[(i - 2) * 2 + 10].ForeColor = System.Drawing.Color.Red;
                                al3.Enqueue(property.Name.ToLower());
                                ll[(i - 2) * 2 + 10].Text = property.Name;
                            }

                        }

                    }
                }
            }

            for (int i = 0; i < 10; i++) // Board cards
            {
                foreach (PropertyInfo property in typeof(Properties.Resources).GetProperties
    (BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic))
                {
                    if (i <= 4 && i >= 0)
                    {
                        if (property.Name.Length == 1) //Shape
                        {
                            Bitmap image1 = (Bitmap)Image.FromFile(@"C:\save\" + i + ".bmp", true);
                            Bitmap fromResource = (System.Drawing.Bitmap)(ResourceManager.GetObject(property.Name)); // Load an image from the resources
                            D3_Bot_Tool.ImageChecker checker = new D3_Bot_Tool.ImageChecker(image1, fromResource); // Checks number
                            if (checker.bigContainsSmall() != pointNull)
                            {
                                ll[shapeCount].ForeColor = System.Drawing.Color.Red;
                                al1.Enqueue(property.Name.ToLower());
                                ll[shapeCount++].Text = property.Name;
                            }
                        }
                    }
                    else
                    {
                        if (property.Name.Length == 2) //Number
                        {
                            Bitmap image1 = (Bitmap)Image.FromFile(@"C:\save\" + i + ".bmp", true);
                            Bitmap fromResource = (System.Drawing.Bitmap)(ResourceManager.GetObject(property.Name)); // Load an image from the resources
                            D3_Bot_Tool.ImageChecker checker = new D3_Bot_Tool.ImageChecker(image1, fromResource); // Checks number
                            if (checker.bigContainsSmall() != pointNull)
                            {
                                if (property.Name.Substring(property.Name.Length - 1) == "0")
                                {
                                    ll[numCount++].Text = "10";
                                    al2.Enqueue("10");
                                }
                                else
                                {
                                    ll[numCount++].Text = property.Name.Substring(property.Name.Length - 1);
                                    al2.Enqueue("" + property.Name.Substring(property.Name.Length - 1));
                                }
                            }
                        }
                    }


                }

            }
            String temp = "";
            if (al1 != null && al1.Count == al2.Count)
            {
                while (al1.Count != 0)
                {
                    temp += al2.Dequeue() + al1.Dequeue() + " ";
                }

            }
            textBox3.Text = temp;

            String temp2 = "";
            if (al3 != null && al3.Count == al4.Count)
            {
                while (al3.Count != 0)
                {
                    temp2 += al4.Dequeue() + al3.Dequeue() + " ";
                }

            }
            textBox4.Text = temp2;
            Queue<String> result = new Queue<String>();
            result.Enqueue(temp2);
            result.Enqueue(temp);
            return result;
        }

   

        private void loadCard_Click(object sender, EventArgs e) // Read cards from board
        {
            Queue<String> temp = loadCardFromFile();
            

        }

        private void smallShape_Click(object sender, EventArgs e)
        {
            saveSmallShape();
        }

        private void bigShape_Click(object sender, EventArgs e)
        {
            saveBigShape();
        }

        private void handBig_Click(object sender, EventArgs e)
        {
            saveBigImage_hand();
        }
    }


}














namespace D3_Bot_Tool
{
    class LockedFastImage
    {
        private Bitmap image;
        private byte[] rgbValues;
        private System.Drawing.Imaging.BitmapData bmpData;

        private IntPtr ptr;
        private int bytes;

        public LockedFastImage(Bitmap image)
        {
            this.image = image;
            Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);
             bmpData = image.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, image.PixelFormat);

            ptr = bmpData.Scan0;
            bytes = Math.Abs(bmpData.Stride) * image.Height;
            rgbValues = new byte[bytes];
            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);
        }

        ~LockedFastImage()
        {
            // Try to unlock the bits. Who cares if it dont work...
            try
            {
                image.UnlockBits(bmpData);
            }
            catch { }
        }

        /// <summary>
        /// Returns or sets a pixel of the image. 
        /// </summary>
        /// <param name="x">x parameter of the pixel</param>
        /// <param name="y">y parameter of the pixel</param>
        public Color this[int x, int y]
        {
            get
            {
                int index = (x + (y * image.Width)) * 4;
                return Color.FromArgb(rgbValues[index + 3], rgbValues[index + 2], rgbValues[index + 1], rgbValues[index]);
            }

            set
            {
                int index = (x + (y * image.Width)) * 4;
                rgbValues[index] = value.B;
                rgbValues[index + 1] = value.G;
                rgbValues[index + 2] = value.R;
                rgbValues[index + 3] = value.A;
            }
        }

        /// <summary>
        /// Width of the image. 
        /// </summary>
        public int Width
        {
            get
            {
                return image.Width;
            }
        }

        /// <summary>
        /// Height of the image. 
        /// </summary>
        public int Height
        {
            get
            {
                return image.Height;
            }
        }

        /// <summary>
        /// Returns the modified Bitmap. 
        /// </summary>
        public Bitmap asBitmap()
        {
            
            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);
            return image;
        }
    }

    class ImageChecker
    {

        private LockedFastImage big_image;
        private LockedFastImage small_image;
        /// <summary>
        /// The time needed for last operation.
        /// </summary>
        public TimeSpan time_needed = new TimeSpan();

        /// <summary>
        /// Error return value.
        /// </summary>
        static public Point CHECKFAILED = new Point(-1, -1);

        /// <summary>
        /// Constructor of the ImageChecker
        /// </summary>
        /// <param name="big_image">The image containing the small image.</param>
        /// <param name="small_image">The image located in the big image.</param>
        public ImageChecker(Bitmap big_image, Bitmap small_image)
        {
            this.big_image = new LockedFastImage(big_image);
            this.small_image = new LockedFastImage(small_image);
        }

        /// <summary>
        /// Returns the location of the small image in the big image. Returns CHECKFAILED if not found.
        /// </summary>
        /// <param name="x_speedUp">speeding up at x achsis.</param>
        /// <param name="y_speedUp">speeding up at y achsis.</param>
        /// <param name="begin_percent_x">Reduces the search rect. 0 - 100</param>
        /// <param name="end_percent_x">Reduces the search rect. 0 - 100</param>
        /// <param name="begin_percent_x">Reduces the search rect. 0 - 100</param>
        /// <param name="end_percent_y">Reduces the search rect. 0 - 100</param>
        public Point bigContainsSmall(int x_speedUp = 1, int y_speedUp = 1, int begin_percent_x = 0, int end_percent_x = 100, int begin_percent_y = 0, int end_percent_y = 100)
        {
            /*
             * SPEEDUP PARAMETER
             * It might be enough to check each second or third pixel in the small picture.
             * However... In most cases it would be enough to check 4 pixels of the small image for diablo porposes.
             * */

            /*
             * BEGIN, END PARAMETER
             * In most cases we know where the image is located, for this we have the begin and end paramenters.
             * */

            DateTime begin = DateTime.Now;

            if (x_speedUp < 1) x_speedUp = 1;
            if (y_speedUp < 1) y_speedUp = 1;
            if (begin_percent_x < 0 || begin_percent_x > 100) begin_percent_x = 0;
            if (begin_percent_y < 0 || begin_percent_y > 100) begin_percent_y = 0;
            if (end_percent_x < 0 || end_percent_x > 100) end_percent_x = 100;
            if (end_percent_y < 0 || end_percent_y > 100) end_percent_y = 100;

            int x_start = (int)((double)big_image.Width * ((double)begin_percent_x / 100.0));
            int x_end = (int)((double)big_image.Width * ((double)end_percent_x / 100.0));
            int y_start = (int)((double)big_image.Height * ((double)begin_percent_y / 100.0));
            int y_end = (int)((double)big_image.Height * ((double)end_percent_y / 100.0));

            /*
             * We cant speed up the big picture, because then we have to check pixels in the small picture equal to the speeded up size 
             * for each pixel in the big picture.
             * Would give no speed improvement.
             * */

            //+ 1 because first pixel is in picture. - small because image have to be fully in the other image
            for (int x = x_start; x < x_end - small_image.Width + 1; x++)
                for (int y = y_start; y < y_end - small_image.Height + 1; y++)
                {
                    //now we check if all pixels matches
                    for (int sx = 0; sx < small_image.Width; sx += x_speedUp)
                        for (int sy = 0; sy < small_image.Height; sy += y_speedUp)
                        {
                            if (small_image[sx, sy] != big_image[x + sx, y + sy])
                                goto CheckFailed;
                        }

                    //check ok
                    time_needed = DateTime.Now - begin;
                    return new Point(x, y);

                CheckFailed:;
                }

            time_needed = DateTime.Now - begin;
            return CHECKFAILED;
        }
    }
}





