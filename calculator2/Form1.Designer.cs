namespace calculator2
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.historybtn = new System.Windows.Forms.Button();
            this.cebtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.minbtn = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.dotbtn = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.eqbtn = new System.Windows.Forms.Button();
            this.adminbtn = new System.Windows.Forms.Button();
            this.adbtn = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.mulbtn = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.divbtn = new System.Windows.Forms.Button();
            this.delbtn = new System.Windows.Forms.Button();
            this.clrbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.hist_text = new System.Windows.Forms.TextBox();
            this.sliderpanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.sliderpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 100);
            this.panel1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox2.Location = new System.Drawing.Point(214, 52);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox2.Size = new System.Drawing.Size(407, 40);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(214, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(408, 37);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // historybtn
            // 
            this.historybtn.FlatAppearance.BorderSize = 0;
            this.historybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historybtn.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historybtn.Location = new System.Drawing.Point(12, 106);
            this.historybtn.Name = "historybtn";
            this.historybtn.Size = new System.Drawing.Size(181, 54);
            this.historybtn.TabIndex = 3;
            this.historybtn.Text = "History";
            this.historybtn.UseVisualStyleBackColor = true;
            this.historybtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // cebtn
            // 
            this.cebtn.FlatAppearance.BorderSize = 0;
            this.cebtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.cebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.cebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.cebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cebtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cebtn.Location = new System.Drawing.Point(12, 25);
            this.cebtn.Name = "cebtn";
            this.cebtn.Size = new System.Drawing.Size(86, 81);
            this.cebtn.TabIndex = 2;
            this.cebtn.Text = "CE";
            this.cebtn.UseVisualStyleBackColor = true;
            this.cebtn.Click += new System.EventHandler(this.ALLbttn_click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.minbtn);
            this.panel2.Controls.Add(this.num6);
            this.panel2.Controls.Add(this.dotbtn);
            this.panel2.Controls.Add(this.num4);
            this.panel2.Controls.Add(this.num0);
            this.panel2.Controls.Add(this.num5);
            this.panel2.Controls.Add(this.eqbtn);
            this.panel2.Controls.Add(this.adminbtn);
            this.panel2.Controls.Add(this.adbtn);
            this.panel2.Controls.Add(this.num3);
            this.panel2.Controls.Add(this.num2);
            this.panel2.Controls.Add(this.num1);
            this.panel2.Controls.Add(this.mulbtn);
            this.panel2.Controls.Add(this.num9);
            this.panel2.Controls.Add(this.num8);
            this.panel2.Controls.Add(this.num7);
            this.panel2.Controls.Add(this.divbtn);
            this.panel2.Controls.Add(this.delbtn);
            this.panel2.Controls.Add(this.clrbtn);
            this.panel2.Controls.Add(this.cebtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(214, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 516);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // minbtn
            // 
            this.minbtn.FlatAppearance.BorderSize = 0;
            this.minbtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.minbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.minbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.minbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minbtn.Location = new System.Drawing.Point(322, 224);
            this.minbtn.Name = "minbtn";
            this.minbtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.minbtn.Size = new System.Drawing.Size(86, 85);
            this.minbtn.TabIndex = 21;
            this.minbtn.Text = "-";
            this.minbtn.UseVisualStyleBackColor = true;
            this.minbtn.Click += new System.EventHandler(this.Operation_click);
            // 
            // num6
            // 
            this.num6.FlatAppearance.BorderSize = 0;
            this.num6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.num6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.num6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.num6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6.Location = new System.Drawing.Point(218, 222);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(86, 85);
            this.num6.TabIndex = 12;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.ALLbttn_click);
            // 
            // dotbtn
            // 
            this.dotbtn.FlatAppearance.BorderSize = 0;
            this.dotbtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.dotbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.dotbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.dotbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dotbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dotbtn.Location = new System.Drawing.Point(218, 416);
            this.dotbtn.Name = "dotbtn";
            this.dotbtn.Size = new System.Drawing.Size(86, 85);
            this.dotbtn.TabIndex = 20;
            this.dotbtn.Text = ".";
            this.dotbtn.UseVisualStyleBackColor = true;
            this.dotbtn.Click += new System.EventHandler(this.ALLbttn_click);
            // 
            // num4
            // 
            this.num4.FlatAppearance.BorderSize = 0;
            this.num4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.num4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.num4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.num4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4.Location = new System.Drawing.Point(12, 222);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(86, 81);
            this.num4.TabIndex = 10;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.ALLbttn_click);
            // 
            // num0
            // 
            this.num0.FlatAppearance.BorderSize = 0;
            this.num0.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.num0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.num0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.num0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num0.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num0.Location = new System.Drawing.Point(114, 416);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(86, 85);
            this.num0.TabIndex = 19;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.ALLbttn_click);
            // 
            // num5
            // 
            this.num5.FlatAppearance.BorderSize = 0;
            this.num5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.num5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.num5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.num5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5.Location = new System.Drawing.Point(114, 222);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(86, 85);
            this.num5.TabIndex = 11;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.ALLbttn_click);
            // 
            // eqbtn
            // 
            this.eqbtn.FlatAppearance.BorderSize = 0;
            this.eqbtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.eqbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.eqbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.eqbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eqbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eqbtn.Location = new System.Drawing.Point(322, 418);
            this.eqbtn.Name = "eqbtn";
            this.eqbtn.Size = new System.Drawing.Size(86, 85);
            this.eqbtn.TabIndex = 13;
            this.eqbtn.Text = "=";
            this.eqbtn.UseVisualStyleBackColor = true;
            this.eqbtn.Click += new System.EventHandler(this.Operation_click);
            // 
            // adminbtn
            // 
            this.adminbtn.FlatAppearance.BorderSize = 0;
            this.adminbtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.adminbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.adminbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.adminbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminbtn.Location = new System.Drawing.Point(14, 416);
            this.adminbtn.Name = "adminbtn";
            this.adminbtn.Size = new System.Drawing.Size(86, 81);
            this.adminbtn.TabIndex = 18;
            this.adminbtn.Text = "+/-";
            this.adminbtn.UseVisualStyleBackColor = true;
            this.adminbtn.Click += new System.EventHandler(this.ALLbttn_click);
            // 
            // adbtn
            // 
            this.adbtn.FlatAppearance.BorderSize = 0;
            this.adbtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.adbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.adbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.adbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adbtn.Location = new System.Drawing.Point(322, 321);
            this.adbtn.Name = "adbtn";
            this.adbtn.Size = new System.Drawing.Size(86, 85);
            this.adbtn.TabIndex = 17;
            this.adbtn.Text = "+";
            this.adbtn.UseVisualStyleBackColor = true;
            this.adbtn.Click += new System.EventHandler(this.Operation_click);
            // 
            // num3
            // 
            this.num3.FlatAppearance.BorderSize = 0;
            this.num3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.num3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.num3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.num3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.Location = new System.Drawing.Point(218, 319);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(86, 85);
            this.num3.TabIndex = 16;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.ALLbttn_click);
            // 
            // num2
            // 
            this.num2.FlatAppearance.BorderSize = 0;
            this.num2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.num2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.num2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.num2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(114, 319);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(86, 85);
            this.num2.TabIndex = 15;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.ALLbttn_click);
            // 
            // num1
            // 
            this.num1.FlatAppearance.BorderSize = 0;
            this.num1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.num1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.num1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.num1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(12, 319);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(86, 81);
            this.num1.TabIndex = 14;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.ALLbttn_click);
            // 
            // mulbtn
            // 
            this.mulbtn.FlatAppearance.BorderSize = 0;
            this.mulbtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.mulbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.mulbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.mulbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mulbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mulbtn.Location = new System.Drawing.Point(322, 127);
            this.mulbtn.Name = "mulbtn";
            this.mulbtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mulbtn.Size = new System.Drawing.Size(86, 85);
            this.mulbtn.TabIndex = 9;
            this.mulbtn.Text = "*";
            this.mulbtn.UseVisualStyleBackColor = true;
            this.mulbtn.Click += new System.EventHandler(this.Operation_click);
            // 
            // num9
            // 
            this.num9.FlatAppearance.BorderSize = 0;
            this.num9.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.num9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.num9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.num9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9.Location = new System.Drawing.Point(218, 125);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(86, 85);
            this.num9.TabIndex = 8;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.ALLbttn_click);
            // 
            // num8
            // 
            this.num8.FlatAppearance.BorderSize = 0;
            this.num8.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.num8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.num8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.num8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8.Location = new System.Drawing.Point(114, 125);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(86, 85);
            this.num8.TabIndex = 7;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.ALLbttn_click);
            // 
            // num7
            // 
            this.num7.FlatAppearance.BorderSize = 0;
            this.num7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.num7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.num7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.num7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7.Location = new System.Drawing.Point(12, 125);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(86, 81);
            this.num7.TabIndex = 6;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.ALLbttn_click);
            // 
            // divbtn
            // 
            this.divbtn.FlatAppearance.BorderSize = 0;
            this.divbtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.divbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.divbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.divbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divbtn.Location = new System.Drawing.Point(322, 23);
            this.divbtn.Name = "divbtn";
            this.divbtn.Size = new System.Drawing.Size(86, 85);
            this.divbtn.TabIndex = 5;
            this.divbtn.Text = "/";
            this.divbtn.UseVisualStyleBackColor = true;
            this.divbtn.Click += new System.EventHandler(this.Operation_click);
            // 
            // delbtn
            // 
            this.delbtn.FlatAppearance.BorderSize = 0;
            this.delbtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.delbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.delbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.delbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delbtn.Location = new System.Drawing.Point(218, 22);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(86, 85);
            this.delbtn.TabIndex = 4;
            this.delbtn.Text = "DEL";
            this.delbtn.UseVisualStyleBackColor = true;
            this.delbtn.Click += new System.EventHandler(this.ALLbttn_click);
            // 
            // clrbtn
            // 
            this.clrbtn.FlatAppearance.BorderSize = 0;
            this.clrbtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.clrbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.clrbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.clrbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clrbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clrbtn.Location = new System.Drawing.Point(114, 23);
            this.clrbtn.Name = "clrbtn";
            this.clrbtn.Size = new System.Drawing.Size(86, 85);
            this.clrbtn.TabIndex = 3;
            this.clrbtn.Text = "C";
            this.clrbtn.UseVisualStyleBackColor = true;
            this.clrbtn.Click += new System.EventHandler(this.ALLbttn_click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 568);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // hist_text
            // 
            this.hist_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hist_text.Location = new System.Drawing.Point(0, 0);
            this.hist_text.Multiline = true;
            this.hist_text.Name = "hist_text";
            this.hist_text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.hist_text.Size = new System.Drawing.Size(208, 392);
            this.hist_text.TabIndex = 0;
            // 
            // sliderpanel
            // 
            this.sliderpanel.Controls.Add(this.hist_text);
            this.sliderpanel.Location = new System.Drawing.Point(0, 174);
            this.sliderpanel.Name = "sliderpanel";
            this.sliderpanel.Size = new System.Drawing.Size(208, 392);
            this.sliderpanel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 616);
            this.Controls.Add(this.sliderpanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.historybtn);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.sliderpanel.ResumeLayout(false);
            this.sliderpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button cebtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button minbtn;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button dotbtn;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button eqbtn;
        private System.Windows.Forms.Button adminbtn;
        private System.Windows.Forms.Button adbtn;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button mulbtn;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button divbtn;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.Button clrbtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button historybtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox hist_text;
        private System.Windows.Forms.Panel sliderpanel;
    }
}

