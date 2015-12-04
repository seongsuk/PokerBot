using System.Windows.Forms;

namespace OddsGridApp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.PocketCards = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Board = new System.Windows.Forms.TextBox();
            this.r14 = new System.Windows.Forms.Label();
            this.r12 = new System.Windows.Forms.Label();
            this.turnStatus = new System.Windows.Forms.Label();
            this.oddsGrid1 = new OddsGrid.OddsGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.normalButton2 = new System.Windows.Forms.RadioButton();
            this.safeButton1 = new System.Windows.Forms.RadioButton();
            this.aggreButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pocket:";
            // 
            // PocketCards
            // 
            this.PocketCards.Location = new System.Drawing.Point(74, 8);
            this.PocketCards.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.PocketCards.Name = "PocketCards";
            this.PocketCards.Size = new System.Drawing.Size(56, 21);
            this.PocketCards.TabIndex = 2;
            this.PocketCards.Text = "As Ks";
            this.PocketCards.TextChanged += new System.EventHandler(this.PocketCards_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Board:";
            // 
            // Board
            // 
            this.Board.Location = new System.Drawing.Point(196, 8);
            this.Board.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Board.Name = "Board";
            this.Board.Size = new System.Drawing.Size(116, 21);
            this.Board.TabIndex = 4;
            this.Board.Text = "Ts Qs 2d";
            this.Board.TextChanged += new System.EventHandler(this.Board_TextChanged);
            // 
            // r14
            // 
            this.r14.AutoSize = true;
            this.r14.Location = new System.Drawing.Point(381, 249);
            this.r14.Name = "r14";
            this.r14.Size = new System.Drawing.Size(0, 12);
            this.r14.TabIndex = 44;
            // 
            // r12
            // 
            this.r12.AutoSize = true;
            this.r12.Location = new System.Drawing.Point(364, 175);
            this.r12.Name = "r12";
            this.r12.Size = new System.Drawing.Size(0, 12);
            this.r12.TabIndex = 43;
            // 
            // turnStatus
            // 
            this.turnStatus.AutoSize = true;
            this.turnStatus.Location = new System.Drawing.Point(321, 13);
            this.turnStatus.Name = "turnStatus";
            this.turnStatus.Size = new System.Drawing.Size(104, 12);
            this.turnStatus.TabIndex = 50;
            this.turnStatus.Text = "Bot is not running";
            // 
            // oddsGrid1
            // 
            this.oddsGrid1.AllowDrop = true;
            this.oddsGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oddsGrid1.Board = "";
            this.oddsGrid1.Location = new System.Drawing.Point(9, 40);
            this.oddsGrid1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.oddsGrid1.Name = "oddsGrid1";
            this.oddsGrid1.Pocket = "";
            this.oddsGrid1.Size = new System.Drawing.Size(304, 210);
            this.oddsGrid1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Location = new System.Drawing.Point(12, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 58);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remote Control";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(209, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 12);
            this.label3.TabIndex = 56;
            this.label3.Text = "Access Token";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox1.Image = global::OddsGridApp.Properties.Resources.logo1;
            this.checkBox1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox1.Location = new System.Drawing.Point(7, 13);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.MaximumSize = new System.Drawing.Size(300, 0);
            this.checkBox1.MinimumSize = new System.Drawing.Size(0, 40);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox1.Size = new System.Drawing.Size(168, 40);
            this.checkBox1.TabIndex = 55;
            this.checkBox1.Text = "     Enable Pushbullet";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(209, 29);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(193, 21);
            this.textBox4.TabIndex = 54;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.normalButton2);
            this.groupBox2.Controls.Add(this.safeButton1);
            this.groupBox2.Controls.Add(this.aggreButton1);
            this.groupBox2.Location = new System.Drawing.Point(289, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 99);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bot Mode";
            // 
            // normalButton2
            // 
            this.normalButton2.AutoSize = true;
            this.normalButton2.Checked = true;
            this.normalButton2.Location = new System.Drawing.Point(6, 70);
            this.normalButton2.Name = "normalButton2";
            this.normalButton2.Size = new System.Drawing.Size(64, 16);
            this.normalButton2.TabIndex = 2;
            this.normalButton2.TabStop = true;
            this.normalButton2.Text = "Normal";
            this.normalButton2.UseVisualStyleBackColor = true;
            // 
            // safeButton1
            // 
            this.safeButton1.AutoSize = true;
            this.safeButton1.Location = new System.Drawing.Point(6, 45);
            this.safeButton1.Name = "safeButton1";
            this.safeButton1.Size = new System.Drawing.Size(48, 16);
            this.safeButton1.TabIndex = 1;
            this.safeButton1.Text = "Safe";
            this.safeButton1.UseVisualStyleBackColor = true;
            // 
            // aggreButton1
            // 
            this.aggreButton1.AutoSize = true;
            this.aggreButton1.Location = new System.Drawing.Point(6, 21);
            this.aggreButton1.Name = "aggreButton1";
            this.aggreButton1.Size = new System.Drawing.Size(86, 16);
            this.aggreButton1.TabIndex = 0;
            this.aggreButton1.Text = "Aggressive";
            this.aggreButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.stopButton);
            this.groupBox3.Controls.Add(this.startButton);
            this.groupBox3.Location = new System.Drawing.Point(289, 145);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(169, 105);
            this.groupBox3.TabIndex = 54;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Poker Bot";
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.stopButton.Location = new System.Drawing.Point(51, 58);
            this.stopButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(73, 19);
            this.stopButton.TabIndex = 53;
            this.stopButton.Text = "Stop Bot";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.startButton.Location = new System.Drawing.Point(51, 28);
            this.startButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(73, 19);
            this.startButton.TabIndex = 52;
            this.startButton.Text = "Start Bot";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(464, 326);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.turnStatus);
            this.Controls.Add(this.r14);
            this.Controls.Add(this.r12);
            this.Controls.Add(this.Board);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PocketCards);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oddsGrid1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(100, 0);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 365);
            this.MinimumSize = new System.Drawing.Size(480, 365);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Ful tilt poker bot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OddsGrid.OddsGrid oddsGrid1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PocketCards;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Board;
        private System.Windows.Forms.Label r14;
        private System.Windows.Forms.Label r12;
        private Label turnStatus;
        private GroupBox groupBox1;
        private Label label3;
        private CheckBox checkBox1;
        private TextBox textBox4;
        private GroupBox groupBox2;
        private RadioButton normalButton2;
        private RadioButton safeButton1;
        private RadioButton aggreButton1;
        private GroupBox groupBox3;
        private Button stopButton;
        private Button startButton;
    }
}

