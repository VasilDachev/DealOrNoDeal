namespace DealOrNoDeal
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnResetGame = new System.Windows.Forms.Button();
            this.btnBox1 = new System.Windows.Forms.Button();
            this.btnBox2 = new System.Windows.Forms.Button();
            this.btnBox3 = new System.Windows.Forms.Button();
            this.btnBox4 = new System.Windows.Forms.Button();
            this.btnBox5 = new System.Windows.Forms.Button();
            this.btnBox6 = new System.Windows.Forms.Button();
            this.btnBox12 = new System.Windows.Forms.Button();
            this.btnBox11 = new System.Windows.Forms.Button();
            this.btnBox10 = new System.Windows.Forms.Button();
            this.btnBox9 = new System.Windows.Forms.Button();
            this.btnBox8 = new System.Windows.Forms.Button();
            this.btnBox7 = new System.Windows.Forms.Button();
            this.btnBox26 = new System.Windows.Forms.Button();
            this.btnBox25 = new System.Windows.Forms.Button();
            this.btnBox24 = new System.Windows.Forms.Button();
            this.btnBox23 = new System.Windows.Forms.Button();
            this.btnBox22 = new System.Windows.Forms.Button();
            this.btnBox21 = new System.Windows.Forms.Button();
            this.btnBox13 = new System.Windows.Forms.Button();
            this.btnBox20 = new System.Windows.Forms.Button();
            this.btnBox19 = new System.Windows.Forms.Button();
            this.btnBox18 = new System.Windows.Forms.Button();
            this.btnBox17 = new System.Windows.Forms.Button();
            this.btnBox16 = new System.Windows.Forms.Button();
            this.btnBox15 = new System.Windows.Forms.Button();
            this.btnBox14 = new System.Windows.Forms.Button();
            this.lbLeftSums = new System.Windows.Forms.ListBox();
            this.lbRightSums = new System.Windows.Forms.ListBox();
            this.lblChoose = new System.Windows.Forms.Label();
            this.tbChoseBox = new System.Windows.Forms.TextBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.lblYourBox = new System.Windows.Forms.Label();
            this.lblMyBox = new System.Windows.Forms.Label();
            this.lblBoxRange = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblYouWon = new System.Windows.Forms.Label();
            this.lblWonSum = new System.Windows.Forms.Label();
            this.lblSwappedyours = new System.Windows.Forms.Label();
            this.lblswappedsum = new System.Windows.Forms.Label();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkHighscoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSubmitScore = new System.Windows.Forms.Button();
            this.tbPlayerName = new System.Windows.Forms.TextBox();
            this.pbMan = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBoxesUntilOffer = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.Chartreuse;
            this.btnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStartGame.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.Location = new System.Drawing.Point(327, 166);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(448, 52);
            this.btnStartGame.TabIndex = 0;
            this.btnStartGame.Text = "START";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnResetGame
            // 
            this.btnResetGame.BackColor = System.Drawing.Color.Tomato;
            this.btnResetGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetGame.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnResetGame.Location = new System.Drawing.Point(327, 166);
            this.btnResetGame.Name = "btnResetGame";
            this.btnResetGame.Size = new System.Drawing.Size(448, 52);
            this.btnResetGame.TabIndex = 1;
            this.btnResetGame.Text = "RESET";
            this.btnResetGame.UseVisualStyleBackColor = false;
            this.btnResetGame.Visible = false;
            this.btnResetGame.Click += new System.EventHandler(this.btnResetGame_Click);
            // 
            // btnBox1
            // 
            this.btnBox1.BackColor = System.Drawing.Color.Tomato;
            this.btnBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBox1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBox1.Location = new System.Drawing.Point(270, 238);
            this.btnBox1.Name = "btnBox1";
            this.btnBox1.Size = new System.Drawing.Size(89, 83);
            this.btnBox1.TabIndex = 2;
            this.btnBox1.Text = "1";
            this.btnBox1.UseVisualStyleBackColor = false;
            this.btnBox1.Visible = false;
            this.btnBox1.Click += new System.EventHandler(this.btnBox1_Click);
            // 
            // btnBox2
            // 
            this.btnBox2.BackColor = System.Drawing.Color.Tomato;
            this.btnBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBox2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBox2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBox2.Location = new System.Drawing.Point(365, 238);
            this.btnBox2.Name = "btnBox2";
            this.btnBox2.Size = new System.Drawing.Size(89, 83);
            this.btnBox2.TabIndex = 3;
            this.btnBox2.Text = "2";
            this.btnBox2.UseVisualStyleBackColor = false;
            this.btnBox2.Visible = false;
            this.btnBox2.Click += new System.EventHandler(this.btnBox2_Click);
            // 
            // btnBox3
            // 
            this.btnBox3.BackColor = System.Drawing.Color.Tomato;
            this.btnBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBox3.Font = new System.Drawing.Font("Berlin Sans FB Demi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBox3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBox3.Location = new System.Drawing.Point(460, 238);
            this.btnBox3.Name = "btnBox3";
            this.btnBox3.Size = new System.Drawing.Size(89, 83);
            this.btnBox3.TabIndex = 4;
            this.btnBox3.Text = "3";
            this.btnBox3.UseVisualStyleBackColor = false;
            this.btnBox3.Visible = false;
            this.btnBox3.Click += new System.EventHandler(this.btnBox3_Click);
            // 
            // btnBox4
            // 
            this.btnBox4.BackColor = System.Drawing.Color.Tomato;
            this.btnBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBox4.Font = new System.Drawing.Font("Berlin Sans FB Demi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBox4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBox4.Location = new System.Drawing.Point(555, 238);
            this.btnBox4.Name = "btnBox4";
            this.btnBox4.Size = new System.Drawing.Size(89, 83);
            this.btnBox4.TabIndex = 5;
            this.btnBox4.Text = "4";
            this.btnBox4.UseVisualStyleBackColor = false;
            this.btnBox4.Visible = false;
            this.btnBox4.Click += new System.EventHandler(this.btnBox4_Click);
            // 
            // btnBox5
            // 
            this.btnBox5.BackColor = System.Drawing.Color.Tomato;
            this.btnBox5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBox5.Font = new System.Drawing.Font("Berlin Sans FB Demi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBox5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBox5.Location = new System.Drawing.Point(650, 238);
            this.btnBox5.Name = "btnBox5";
            this.btnBox5.Size = new System.Drawing.Size(89, 83);
            this.btnBox5.TabIndex = 6;
            this.btnBox5.Text = "5";
            this.btnBox5.UseVisualStyleBackColor = false;
            this.btnBox5.Visible = false;
            this.btnBox5.Click += new System.EventHandler(this.btnBox5_Click);
            // 
            // btnBox6
            // 
            this.btnBox6.BackColor = System.Drawing.Color.Tomato;
            this.btnBox6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBox6.Font = new System.Drawing.Font("Berlin Sans FB Demi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBox6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBox6.Location = new System.Drawing.Point(745, 238);
            this.btnBox6.Name = "btnBox6";
            this.btnBox6.Size = new System.Drawing.Size(89, 83);
            this.btnBox6.TabIndex = 7;
            this.btnBox6.Text = "6";
            this.btnBox6.UseVisualStyleBackColor = false;
            this.btnBox6.Visible = false;
            this.btnBox6.Click += new System.EventHandler(this.btnBox6_Click);
            // 
            // btnBox12
            // 
            this.btnBox12.BackColor = System.Drawing.Color.Tomato;
            this.btnBox12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBox12.Font = new System.Drawing.Font("Berlin Sans FB Demi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBox12.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBox12.Location = new System.Drawing.Point(700, 332);
            this.btnBox12.Name = "btnBox12";
            this.btnBox12.Size = new System.Drawing.Size(89, 83);
            this.btnBox12.TabIndex = 13;
            this.btnBox12.Text = "12";
            this.btnBox12.UseVisualStyleBackColor = false;
            this.btnBox12.Visible = false;
            this.btnBox12.Click += new System.EventHandler(this.btnBox12_Click);
            // 
            // btnBox11
            // 
            this.btnBox11.BackColor = System.Drawing.Color.Tomato;
            this.btnBox11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBox11.Font = new System.Drawing.Font("Berlin Sans FB Demi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBox11.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBox11.Location = new System.Drawing.Point(605, 332);
            this.btnBox11.Name = "btnBox11";
            this.btnBox11.Size = new System.Drawing.Size(89, 83);
            this.btnBox11.TabIndex = 12;
            this.btnBox11.Text = "11";
            this.btnBox11.UseVisualStyleBackColor = false;
            this.btnBox11.Visible = false;
            this.btnBox11.Click += new System.EventHandler(this.btnBox11_Click);
            // 
            // btnBox10
            // 
            this.btnBox10.BackColor = System.Drawing.Color.Tomato;
            this.btnBox10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBox10.Font = new System.Drawing.Font("Berlin Sans FB Demi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBox10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBox10.Location = new System.Drawing.Point(510, 332);
            this.btnBox10.Name = "btnBox10";
            this.btnBox10.Size = new System.Drawing.Size(89, 83);
            this.btnBox10.TabIndex = 11;
            this.btnBox10.Text = "10";
            this.btnBox10.UseVisualStyleBackColor = false;
            this.btnBox10.Visible = false;
            this.btnBox10.Click += new System.EventHandler(this.btnBox10_Click);
            // 
            // btnBox9
            // 
            this.btnBox9.BackColor = System.Drawing.Color.Tomato;
            this.btnBox9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBox9.Font = new System.Drawing.Font("Berlin Sans FB Demi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBox9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBox9.Location = new System.Drawing.Point(415, 332);
            this.btnBox9.Name = "btnBox9";
            this.btnBox9.Size = new System.Drawing.Size(89, 83);
            this.btnBox9.TabIndex = 10;
            this.btnBox9.Text = "9";
            this.btnBox9.UseVisualStyleBackColor = false;
            this.btnBox9.Visible = false;
            this.btnBox9.Click += new System.EventHandler(this.btnBox9_Click);
            // 
            // btnBox8
            // 
            this.btnBox8.BackColor = System.Drawing.Color.Tomato;
            this.btnBox8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBox8.Font = new System.Drawing.Font("Berlin Sans FB Demi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBox8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBox8.Location = new System.Drawing.Point(320, 332);
            this.btnBox8.Name = "btnBox8";
            this.btnBox8.Size = new System.Drawing.Size(89, 83);
            this.btnBox8.TabIndex = 9;
            this.btnBox8.Text = "8";
            this.btnBox8.UseVisualStyleBackColor = false;
            this.btnBox8.Visible = false;
            this.btnBox8.Click += new System.EventHandler(this.btnBox8_Click);
            // 
            // btnBox7
            // 
            this.btnBox7.BackColor = System.Drawing.Color.Tomato;
            this.btnBox7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBox7.Font = new System.Drawing.Font("Berlin Sans FB Demi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBox7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBox7.Location = new System.Drawing.Point(225, 332);
            this.btnBox7.Name = "btnBox7";
            this.btnBox7.Size = new System.Drawing.Size(89, 83);
            this.btnBox7.TabIndex = 8;
            this.btnBox7.Text = "7";
            this.btnBox7.UseVisualStyleBackColor = false;
            this.btnBox7.Visible = false;
            this.btnBox7.Click += new System.EventHandler(this.btnBox7_Click);
            // 
            // btnBox26
            // 
            this.btnBox26.BackColor = System.Drawing.Color.Tomato;
            this.btnBox26.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBox26.Font = new System.Drawing.Font("Berlin Sans FB Demi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBox26.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBox26.Location = new System.Drawing.Point(745, 520);
            this.btnBox26.Name = "btnBox26";
            this.btnBox26.Size = new System.Drawing.Size(89, 83);
            this.btnBox26.TabIndex = 25;
            this.btnBox26.Text = "26";
            this.btnBox26.UseVisualStyleBackColor = false;
            this.btnBox26.Visible = false;
            this.btnBox26.Click += new System.EventHandler(this.btnBox26_Click);
            // 
            // btnBox25
            // 
            this.btnBox25.BackColor = System.Drawing.Color.Tomato;
            this.btnBox25.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBox25.Font = new System.Drawing.Font("Berlin Sans FB Demi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBox25.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBox25.Location = new System.Drawing.Point(650, 520);
            this.btnBox25.Name = "btnBox25";
            this.btnBox25.Size = new System.Drawing.Size(89, 83);
            this.btnBox25.TabIndex = 24;
            this.btnBox25.Text = "25";
            this.btnBox25.UseVisualStyleBackColor = false;
            this.btnBox25.Visible = false;
            this.btnBox25.Click += new System.EventHandler(this.btnBox25_Click);
            // 
            // btnBox24
            // 
            this.btnBox24.BackColor = System.Drawing.Color.Tomato;
            this.btnBox24.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBox24.Font = new System.Drawing.Font("Berlin Sans FB Demi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBox24.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBox24.Location = new System.Drawing.Point(555, 520);
            this.btnBox24.Name = "btnBox24";
            this.btnBox24.Size = new System.Drawing.Size(89, 83);
            this.btnBox24.TabIndex = 23;
            this.btnBox24.Text = "24";
            this.btnBox24.UseVisualStyleBackColor = false;
            this.btnBox24.Visible = false;
            this.btnBox24.Click += new System.EventHandler(this.btnBox24_Click);
            // 
            // btnBox23
            // 
            this.btnBox23.BackColor = System.Drawing.Color.Tomato;
            this.btnBox23.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBox23.Font = new System.Drawing.Font("Berlin Sans FB Demi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBox23.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBox23.Location = new System.Drawing.Point(460, 520);
            this.btnBox23.Name = "btnBox23";
            this.btnBox23.Size = new System.Drawing.Size(89, 83);
            this.btnBox23.TabIndex = 22;
            this.btnBox23.Text = "23";
            this.btnBox23.UseVisualStyleBackColor = false;
            this.btnBox23.Visible = false;
            this.btnBox23.Click += new System.EventHandler(this.btnBox23_Click);
            // 
            // btnBox22
            // 
            this.btnBox22.BackColor = System.Drawing.Color.Tomato;
            this.btnBox22.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBox22.Font = new System.Drawing.Font("Berlin Sans FB Demi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBox22.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBox22.Location = new System.Drawing.Point(365, 520);
            this.btnBox22.Name = "btnBox22";
            this.btnBox22.Size = new System.Drawing.Size(89, 83);
            this.btnBox22.TabIndex = 21;
            this.btnBox22.Text = "22";
            this.btnBox22.UseVisualStyleBackColor = false;
            this.btnBox22.Visible = false;
            this.btnBox22.Click += new System.EventHandler(this.btnBox22_Click);
            // 
            // btnBox21
            // 
            this.btnBox21.BackColor = System.Drawing.Color.Tomato;
            this.btnBox21.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBox21.Font = new System.Drawing.Font("Berlin Sans FB Demi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBox21.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBox21.Location = new System.Drawing.Point(270, 520);
            this.btnBox21.Name = "btnBox21";
            this.btnBox21.Size = new System.Drawing.Size(89, 83);
            this.btnBox21.TabIndex = 20;
            this.btnBox21.Text = "21";
            this.btnBox21.UseVisualStyleBackColor = false;
            this.btnBox21.Visible = false;
            this.btnBox21.Click += new System.EventHandler(this.btnBox21_Click);
            // 
            // btnBox13
            // 
            this.btnBox13.BackColor = System.Drawing.Color.Tomato;
            this.btnBox13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBox13.Font = new System.Drawing.Font("Berlin Sans FB Demi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBox13.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBox13.Location = new System.Drawing.Point(795, 332);
            this.btnBox13.Name = "btnBox13";
            this.btnBox13.Size = new System.Drawing.Size(89, 83);
            this.btnBox13.TabIndex = 26;
            this.btnBox13.Text = "13";
            this.btnBox13.UseVisualStyleBackColor = false;
            this.btnBox13.Visible = false;
            this.btnBox13.Click += new System.EventHandler(this.btnBox13_Click);
            // 
            // btnBox20
            // 
            this.btnBox20.BackColor = System.Drawing.Color.Tomato;
            this.btnBox20.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBox20.Font = new System.Drawing.Font("Berlin Sans FB Demi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBox20.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBox20.Location = new System.Drawing.Point(795, 426);
            this.btnBox20.Name = "btnBox20";
            this.btnBox20.Size = new System.Drawing.Size(89, 83);
            this.btnBox20.TabIndex = 33;
            this.btnBox20.Text = "20";
            this.btnBox20.UseVisualStyleBackColor = false;
            this.btnBox20.Visible = false;
            this.btnBox20.Click += new System.EventHandler(this.btnBox20_Click);
            // 
            // btnBox19
            // 
            this.btnBox19.BackColor = System.Drawing.Color.Tomato;
            this.btnBox19.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBox19.Font = new System.Drawing.Font("Berlin Sans FB Demi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBox19.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBox19.Location = new System.Drawing.Point(700, 426);
            this.btnBox19.Name = "btnBox19";
            this.btnBox19.Size = new System.Drawing.Size(89, 83);
            this.btnBox19.TabIndex = 32;
            this.btnBox19.Text = "19";
            this.btnBox19.UseVisualStyleBackColor = false;
            this.btnBox19.Visible = false;
            this.btnBox19.Click += new System.EventHandler(this.btnBox19_Click);
            // 
            // btnBox18
            // 
            this.btnBox18.BackColor = System.Drawing.Color.Tomato;
            this.btnBox18.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBox18.Font = new System.Drawing.Font("Berlin Sans FB Demi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBox18.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBox18.Location = new System.Drawing.Point(605, 426);
            this.btnBox18.Name = "btnBox18";
            this.btnBox18.Size = new System.Drawing.Size(89, 83);
            this.btnBox18.TabIndex = 31;
            this.btnBox18.Text = "18";
            this.btnBox18.UseVisualStyleBackColor = false;
            this.btnBox18.Visible = false;
            this.btnBox18.Click += new System.EventHandler(this.btnBox18_Click);
            // 
            // btnBox17
            // 
            this.btnBox17.BackColor = System.Drawing.Color.Tomato;
            this.btnBox17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBox17.Font = new System.Drawing.Font("Berlin Sans FB Demi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBox17.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBox17.Location = new System.Drawing.Point(510, 426);
            this.btnBox17.Name = "btnBox17";
            this.btnBox17.Size = new System.Drawing.Size(89, 83);
            this.btnBox17.TabIndex = 30;
            this.btnBox17.Text = "17";
            this.btnBox17.UseVisualStyleBackColor = false;
            this.btnBox17.Visible = false;
            this.btnBox17.Click += new System.EventHandler(this.btnBox17_Click);
            // 
            // btnBox16
            // 
            this.btnBox16.BackColor = System.Drawing.Color.Tomato;
            this.btnBox16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBox16.Font = new System.Drawing.Font("Berlin Sans FB Demi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBox16.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBox16.Location = new System.Drawing.Point(415, 426);
            this.btnBox16.Name = "btnBox16";
            this.btnBox16.Size = new System.Drawing.Size(89, 83);
            this.btnBox16.TabIndex = 29;
            this.btnBox16.Text = "16";
            this.btnBox16.UseVisualStyleBackColor = false;
            this.btnBox16.Visible = false;
            this.btnBox16.Click += new System.EventHandler(this.btnBox16_Click);
            // 
            // btnBox15
            // 
            this.btnBox15.BackColor = System.Drawing.Color.Tomato;
            this.btnBox15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBox15.Font = new System.Drawing.Font("Berlin Sans FB Demi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBox15.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBox15.Location = new System.Drawing.Point(320, 426);
            this.btnBox15.Name = "btnBox15";
            this.btnBox15.Size = new System.Drawing.Size(89, 83);
            this.btnBox15.TabIndex = 28;
            this.btnBox15.Text = "15";
            this.btnBox15.UseVisualStyleBackColor = false;
            this.btnBox15.Visible = false;
            this.btnBox15.Click += new System.EventHandler(this.btnBox15_Click);
            // 
            // btnBox14
            // 
            this.btnBox14.BackColor = System.Drawing.Color.Tomato;
            this.btnBox14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBox14.Font = new System.Drawing.Font("Berlin Sans FB Demi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBox14.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBox14.Location = new System.Drawing.Point(225, 426);
            this.btnBox14.Name = "btnBox14";
            this.btnBox14.Size = new System.Drawing.Size(89, 83);
            this.btnBox14.TabIndex = 27;
            this.btnBox14.Text = "14";
            this.btnBox14.UseVisualStyleBackColor = false;
            this.btnBox14.Visible = false;
            this.btnBox14.Click += new System.EventHandler(this.btnBox14_Click);
            // 
            // lbLeftSums
            // 
            this.lbLeftSums.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbLeftSums.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLeftSums.ForeColor = System.Drawing.Color.Tomato;
            this.lbLeftSums.FormattingEnabled = true;
            this.lbLeftSums.ItemHeight = 30;
            this.lbLeftSums.Location = new System.Drawing.Point(12, 209);
            this.lbLeftSums.Name = "lbLeftSums";
            this.lbLeftSums.Size = new System.Drawing.Size(163, 394);
            this.lbLeftSums.TabIndex = 35;
            // 
            // lbRightSums
            // 
            this.lbRightSums.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbRightSums.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRightSums.ForeColor = System.Drawing.Color.Chartreuse;
            this.lbRightSums.FormattingEnabled = true;
            this.lbRightSums.ItemHeight = 30;
            this.lbRightSums.Location = new System.Drawing.Point(929, 209);
            this.lbRightSums.Name = "lbRightSums";
            this.lbRightSums.Size = new System.Drawing.Size(163, 394);
            this.lbRightSums.TabIndex = 36;
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.Font = new System.Drawing.Font("Berlin Sans FB Demi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblChoose.Location = new System.Drawing.Point(655, 650);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(204, 27);
            this.lblChoose.TabIndex = 38;
            this.lblChoose.Text = "Choose your box :";
            this.lblChoose.Visible = false;
            // 
            // tbChoseBox
            // 
            this.tbChoseBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbChoseBox.Location = new System.Drawing.Point(881, 652);
            this.tbChoseBox.Name = "tbChoseBox";
            this.tbChoseBox.Size = new System.Drawing.Size(94, 22);
            this.tbChoseBox.TabIndex = 39;
            this.tbChoseBox.Visible = false;
            // 
            // btnChoose
            // 
            this.btnChoose.BackColor = System.Drawing.Color.Tomato;
            this.btnChoose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChoose.Font = new System.Drawing.Font("Berlin Sans FB Demi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoose.ForeColor = System.Drawing.SystemColors.Info;
            this.btnChoose.Location = new System.Drawing.Point(987, 652);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(75, 23);
            this.btnChoose.TabIndex = 40;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = false;
            this.btnChoose.Visible = false;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // lblYourBox
            // 
            this.lblYourBox.AutoSize = true;
            this.lblYourBox.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblYourBox.Location = new System.Drawing.Point(806, 643);
            this.lblYourBox.Name = "lblYourBox";
            this.lblYourBox.Size = new System.Drawing.Size(137, 33);
            this.lblYourBox.TabIndex = 41;
            this.lblYourBox.Text = "Your Box ";
            this.lblYourBox.Visible = false;
            // 
            // lblMyBox
            // 
            this.lblMyBox.AutoSize = true;
            this.lblMyBox.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMyBox.Location = new System.Drawing.Point(949, 643);
            this.lblMyBox.Name = "lblMyBox";
            this.lblMyBox.Size = new System.Drawing.Size(42, 33);
            this.lblMyBox.TabIndex = 42;
            this.lblMyBox.Text = "№";
            this.lblMyBox.Visible = false;
            // 
            // lblBoxRange
            // 
            this.lblBoxRange.AutoSize = true;
            this.lblBoxRange.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoxRange.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBoxRange.Location = new System.Drawing.Point(904, 631);
            this.lblBoxRange.Name = "lblBoxRange";
            this.lblBoxRange.Size = new System.Drawing.Size(39, 19);
            this.lblBoxRange.TabIndex = 43;
            this.lblBoxRange.Text = "1-26";
            this.lblBoxRange.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 44;
            // 
            // lblYouWon
            // 
            this.lblYouWon.AutoSize = true;
            this.lblYouWon.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYouWon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblYouWon.Location = new System.Drawing.Point(22, 643);
            this.lblYouWon.Name = "lblYouWon";
            this.lblYouWon.Size = new System.Drawing.Size(184, 33);
            this.lblYouWon.TabIndex = 45;
            this.lblYouWon.Text = "You just won:";
            this.lblYouWon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblYouWon.Visible = false;
            // 
            // lblWonSum
            // 
            this.lblWonSum.AutoSize = true;
            this.lblWonSum.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWonSum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWonSum.Location = new System.Drawing.Point(212, 643);
            this.lblWonSum.Name = "lblWonSum";
            this.lblWonSum.Size = new System.Drawing.Size(29, 33);
            this.lblWonSum.TabIndex = 46;
            this.lblWonSum.Text = "$";
            this.lblWonSum.Visible = false;
            // 
            // lblSwappedyours
            // 
            this.lblSwappedyours.AutoSize = true;
            this.lblSwappedyours.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSwappedyours.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSwappedyours.Location = new System.Drawing.Point(819, 166);
            this.lblSwappedyours.Name = "lblSwappedyours";
            this.lblSwappedyours.Size = new System.Drawing.Size(146, 24);
            this.lblSwappedyours.TabIndex = 47;
            this.lblSwappedyours.Text = "Swapped yours";
            this.lblSwappedyours.Visible = false;
            // 
            // lblswappedsum
            // 
            this.lblswappedsum.AutoSize = true;
            this.lblswappedsum.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblswappedsum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblswappedsum.Location = new System.Drawing.Point(974, 166);
            this.lblswappedsum.Name = "lblswappedsum";
            this.lblswappedsum.Size = new System.Drawing.Size(16, 24);
            this.lblswappedsum.TabIndex = 48;
            this.lblswappedsum.Text = ".";
            this.lblswappedsum.Visible = false;
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.Chartreuse;
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1104, 26);
            this.MainMenu.TabIndex = 49;
            this.MainMenu.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkHighscoresToolStripMenuItem,
            this.aboutMeToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 22);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // checkHighscoresToolStripMenuItem
            // 
            this.checkHighscoresToolStripMenuItem.Name = "checkHighscoresToolStripMenuItem";
            this.checkHighscoresToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.checkHighscoresToolStripMenuItem.Text = "Check highscores";
            this.checkHighscoresToolStripMenuItem.Click += new System.EventHandler(this.checkHighscoresToolStripMenuItem_Click);
            // 
            // aboutMeToolStripMenuItem
            // 
            this.aboutMeToolStripMenuItem.Name = "aboutMeToolStripMenuItem";
            this.aboutMeToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.aboutMeToolStripMenuItem.Text = "About me ";
            this.aboutMeToolStripMenuItem.Click += new System.EventHandler(this.aboutMeToolStripMenuItem_Click);
            // 
            // btnSubmitScore
            // 
            this.btnSubmitScore.BackColor = System.Drawing.Color.Chartreuse;
            this.btnSubmitScore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmitScore.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitScore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSubmitScore.Location = new System.Drawing.Point(474, 618);
            this.btnSubmitScore.Name = "btnSubmitScore";
            this.btnSubmitScore.Size = new System.Drawing.Size(160, 57);
            this.btnSubmitScore.TabIndex = 50;
            this.btnSubmitScore.Text = "Submit Score";
            this.btnSubmitScore.UseVisualStyleBackColor = false;
            this.btnSubmitScore.Visible = false;
            this.btnSubmitScore.Click += new System.EventHandler(this.btnSubmitScore_Click);
            // 
            // tbPlayerName
            // 
            this.tbPlayerName.Location = new System.Drawing.Point(486, 589);
            this.tbPlayerName.Name = "tbPlayerName";
            this.tbPlayerName.Size = new System.Drawing.Size(136, 22);
            this.tbPlayerName.TabIndex = 51;
            this.tbPlayerName.Visible = false;
            // 
            // pbMan
            // 
            this.pbMan.Image = global::DealOrNoDeal.Properties.Resources.Deal_or_No_Deal;
            this.pbMan.Location = new System.Drawing.Point(0, 29);
            this.pbMan.Name = "pbMan";
            this.pbMan.Size = new System.Drawing.Size(1106, 665);
            this.pbMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMan.TabIndex = 53;
            this.pbMan.TabStop = false;
            this.pbMan.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DealOrNoDeal.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(243, -17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(616, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // lblBoxesUntilOffer
            // 
            this.lblBoxesUntilOffer.AutoSize = true;
            this.lblBoxesUntilOffer.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoxesUntilOffer.Location = new System.Drawing.Point(8, 185);
            this.lblBoxesUntilOffer.Name = "lblBoxesUntilOffer";
            this.lblBoxesUntilOffer.Size = new System.Drawing.Size(145, 19);
            this.lblBoxesUntilOffer.TabIndex = 54;
            this.lblBoxesUntilOffer.Text = "Boxes until offer: ";
            this.lblBoxesUntilOffer.Visible = false;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(159, 185);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(14, 19);
            this.lblCount.TabIndex = 55;
            this.lblCount.Text = ".";
            this.lblCount.Visible = false;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1104, 692);
            this.Controls.Add(this.pbMan);
            this.Controls.Add(this.tbPlayerName);
            this.Controls.Add(this.btnSubmitScore);
            this.Controls.Add(this.lblswappedsum);
            this.Controls.Add(this.lblSwappedyours);
            this.Controls.Add(this.lblWonSum);
            this.Controls.Add(this.lblYouWon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBoxRange);
            this.Controls.Add(this.lblMyBox);
            this.Controls.Add(this.lblYourBox);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.tbChoseBox);
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.lbRightSums);
            this.Controls.Add(this.lbLeftSums);
            this.Controls.Add(this.btnBox20);
            this.Controls.Add(this.btnBox19);
            this.Controls.Add(this.btnBox18);
            this.Controls.Add(this.btnBox17);
            this.Controls.Add(this.btnBox16);
            this.Controls.Add(this.btnBox15);
            this.Controls.Add(this.btnBox14);
            this.Controls.Add(this.btnBox13);
            this.Controls.Add(this.btnBox26);
            this.Controls.Add(this.btnBox25);
            this.Controls.Add(this.btnBox24);
            this.Controls.Add(this.btnBox23);
            this.Controls.Add(this.btnBox22);
            this.Controls.Add(this.btnBox21);
            this.Controls.Add(this.btnBox12);
            this.Controls.Add(this.btnBox11);
            this.Controls.Add(this.btnBox10);
            this.Controls.Add(this.btnBox9);
            this.Controls.Add(this.btnBox8);
            this.Controls.Add(this.btnBox7);
            this.Controls.Add(this.btnBox6);
            this.Controls.Add(this.btnBox5);
            this.Controls.Add(this.btnBox4);
            this.Controls.Add(this.btnBox3);
            this.Controls.Add(this.btnBox2);
            this.Controls.Add(this.btnBox1);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.btnResetGame);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblBoxesUntilOffer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Deal or No Deal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnResetGame;
        private System.Windows.Forms.Button btnBox1;
        private System.Windows.Forms.Button btnBox2;
        private System.Windows.Forms.Button btnBox3;
        private System.Windows.Forms.Button btnBox4;
        private System.Windows.Forms.Button btnBox5;
        private System.Windows.Forms.Button btnBox6;
        private System.Windows.Forms.Button btnBox12;
        private System.Windows.Forms.Button btnBox11;
        private System.Windows.Forms.Button btnBox10;
        private System.Windows.Forms.Button btnBox9;
        private System.Windows.Forms.Button btnBox8;
        private System.Windows.Forms.Button btnBox7;
        private System.Windows.Forms.Button btnBox26;
        private System.Windows.Forms.Button btnBox25;
        private System.Windows.Forms.Button btnBox24;
        private System.Windows.Forms.Button btnBox23;
        private System.Windows.Forms.Button btnBox22;
        private System.Windows.Forms.Button btnBox21;
        private System.Windows.Forms.Button btnBox13;
        private System.Windows.Forms.Button btnBox20;
        private System.Windows.Forms.Button btnBox19;
        private System.Windows.Forms.Button btnBox18;
        private System.Windows.Forms.Button btnBox17;
        private System.Windows.Forms.Button btnBox16;
        private System.Windows.Forms.Button btnBox15;
        private System.Windows.Forms.Button btnBox14;
        private System.Windows.Forms.ListBox lbLeftSums;
        private System.Windows.Forms.ListBox lbRightSums;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.TextBox tbChoseBox;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Label lblYourBox;
        private System.Windows.Forms.Label lblMyBox;
        private System.Windows.Forms.Label lblBoxRange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblYouWon;
        private System.Windows.Forms.Label lblWonSum;
        private System.Windows.Forms.Label lblSwappedyours;
        private System.Windows.Forms.Label lblswappedsum;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkHighscoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMeToolStripMenuItem;
        private System.Windows.Forms.Button btnSubmitScore;
        private System.Windows.Forms.TextBox tbPlayerName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbMan;
        private System.Windows.Forms.Label lblBoxesUntilOffer;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

