namespace ChappellEberleAstorga_Assign4
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
            this.CoordinatePlane = new System.Windows.Forms.PictureBox();
            this.linearM = new System.Windows.Forms.TextBox();
            this.linearB = new System.Windows.Forms.TextBox();
            this.quadB = new System.Windows.Forms.TextBox();
            this.quadA = new System.Windows.Forms.TextBox();
            this.quadC = new System.Windows.Forms.TextBox();
            this.cubicA = new System.Windows.Forms.TextBox();
            this.cubicD = new System.Windows.Forms.TextBox();
            this.cubicC = new System.Windows.Forms.TextBox();
            this.cubicB = new System.Windows.Forms.TextBox();
            this.circleR = new System.Windows.Forms.TextBox();
            this.circleK = new System.Windows.Forms.TextBox();
            this.circleH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.displayBoxBottom = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.linearColor = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.quadColor = new System.Windows.Forms.ComboBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.cubicColor = new System.Windows.Forms.ComboBox();
            this.circleColor = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.xMinRange = new System.Windows.Forms.NumericUpDown();
            this.yInterval = new System.Windows.Forms.NumericUpDown();
            this.xInterval = new System.Windows.Forms.NumericUpDown();
            this.yMaxRange = new System.Windows.Forms.NumericUpDown();
            this.yMinRange = new System.Windows.Forms.NumericUpDown();
            this.xMaxRange = new System.Windows.Forms.NumericUpDown();
            this.button10 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CoordinatePlane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMinRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yMaxRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yMinRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMaxRange)).BeginInit();
            this.SuspendLayout();
            // 
            // CoordinatePlane
            // 
            this.CoordinatePlane.BackColor = System.Drawing.Color.Black;
            this.CoordinatePlane.Location = new System.Drawing.Point(371, 11);
            this.CoordinatePlane.Name = "CoordinatePlane";
            this.CoordinatePlane.Size = new System.Drawing.Size(600, 600);
            this.CoordinatePlane.TabIndex = 0;
            this.CoordinatePlane.TabStop = false;
            this.CoordinatePlane.Click += new System.EventHandler(this.Coordinate_Click);
            this.CoordinatePlane.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawAxes);
            // 
            // linearM
            // 
            this.linearM.ForeColor = System.Drawing.SystemColors.WindowText;
            this.linearM.Location = new System.Drawing.Point(70, 120);
            this.linearM.Name = "linearM";
            this.linearM.Size = new System.Drawing.Size(23, 20);
            this.linearM.TabIndex = 4;
            this.linearM.TextChanged += new System.EventHandler(this.linearMTxtChange);
            this.linearM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.linearMKeyPress);
            // 
            // linearB
            // 
            this.linearB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.linearB.Location = new System.Drawing.Point(126, 121);
            this.linearB.Name = "linearB";
            this.linearB.Size = new System.Drawing.Size(25, 20);
            this.linearB.TabIndex = 5;
            this.linearB.TextChanged += new System.EventHandler(this.linearBTxtChange);
            this.linearB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.linearBKeyPress);
            // 
            // quadB
            // 
            this.quadB.Location = new System.Drawing.Point(132, 199);
            this.quadB.Name = "quadB";
            this.quadB.Size = new System.Drawing.Size(25, 20);
            this.quadB.TabIndex = 7;
            this.quadB.TextChanged += new System.EventHandler(this.quadBTxtChange);
            this.quadB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quadBKeyPress);
            // 
            // quadA
            // 
            this.quadA.Location = new System.Drawing.Point(68, 199);
            this.quadA.Name = "quadA";
            this.quadA.Size = new System.Drawing.Size(25, 20);
            this.quadA.TabIndex = 6;
            this.quadA.TextChanged += new System.EventHandler(this.quadATxtChange);
            this.quadA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quadAKeyPress);
            // 
            // quadC
            // 
            this.quadC.Location = new System.Drawing.Point(187, 199);
            this.quadC.Name = "quadC";
            this.quadC.Size = new System.Drawing.Size(25, 20);
            this.quadC.TabIndex = 8;
            this.quadC.TextChanged += new System.EventHandler(this.quadCTxtChange);
            this.quadC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quadCKeyPress);
            // 
            // cubicA
            // 
            this.cubicA.Location = new System.Drawing.Point(63, 289);
            this.cubicA.Name = "cubicA";
            this.cubicA.Size = new System.Drawing.Size(25, 20);
            this.cubicA.TabIndex = 9;
            this.cubicA.TextChanged += new System.EventHandler(this.cubicA_TextChanged);
            this.cubicA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cubicA_KeyPress);
            // 
            // cubicD
            // 
            this.cubicD.Location = new System.Drawing.Point(254, 289);
            this.cubicD.Name = "cubicD";
            this.cubicD.Size = new System.Drawing.Size(25, 20);
            this.cubicD.TabIndex = 12;
            this.cubicD.TextChanged += new System.EventHandler(this.cubicD_TextChanged);
            this.cubicD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cubicD_KeyPress);
            // 
            // cubicC
            // 
            this.cubicC.Location = new System.Drawing.Point(200, 290);
            this.cubicC.Name = "cubicC";
            this.cubicC.Size = new System.Drawing.Size(25, 20);
            this.cubicC.TabIndex = 11;
            this.cubicC.TextChanged += new System.EventHandler(this.cubicC_TextChanged);
            this.cubicC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cubicC_KeyPress);
            // 
            // cubicB
            // 
            this.cubicB.Location = new System.Drawing.Point(130, 290);
            this.cubicB.Name = "cubicB";
            this.cubicB.Size = new System.Drawing.Size(25, 20);
            this.cubicB.TabIndex = 10;
            this.cubicB.TextChanged += new System.EventHandler(this.cubicB_TextChanged);
            this.cubicB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cubicB_KeyPress);
            // 
            // circleR
            // 
            this.circleR.Location = new System.Drawing.Point(213, 378);
            this.circleR.Name = "circleR";
            this.circleR.Size = new System.Drawing.Size(25, 20);
            this.circleR.TabIndex = 15;
            this.circleR.TextChanged += new System.EventHandler(this.circleR_TextChanged);
            this.circleR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.circleR_KeyPress);
            // 
            // circleK
            // 
            this.circleK.Location = new System.Drawing.Point(147, 379);
            this.circleK.Name = "circleK";
            this.circleK.Size = new System.Drawing.Size(25, 20);
            this.circleK.TabIndex = 14;
            this.circleK.TextChanged += new System.EventHandler(this.circleK_TextChanged);
            this.circleK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.circleK_KeyPress);
            // 
            // circleH
            // 
            this.circleH.Location = new System.Drawing.Point(65, 378);
            this.circleH.Name = "circleH";
            this.circleH.Size = new System.Drawing.Size(25, 20);
            this.circleH.TabIndex = 13;
            this.circleH.TextChanged += new System.EventHandler(this.circleH_TextChanged);
            this.circleH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.circleH_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Y =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "x +";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "m";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "a";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "b";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(266, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "d";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(212, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "c";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(140, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "b";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(75, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "a";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(217, 362);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "r";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(150, 362);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "k";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(75, 362);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "h";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 273);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Cubic:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 183);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Quad:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(9, 104);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Linear:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 361);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 13);
            this.label17.TabIndex = 28;
            this.label17.Text = "Circle:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 23);
            this.button2.TabIndex = 32;
            this.button2.Text = "Hint";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.LinEqHint);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 227);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 23);
            this.button3.TabIndex = 33;
            this.button3.Text = "Hint";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.QuadEqHint);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(16, 312);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(53, 23);
            this.button4.TabIndex = 34;
            this.button4.Text = "Hint";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.CubEqHint);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(15, 416);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(53, 23);
            this.button5.TabIndex = 35;
            this.button5.Text = "Hint";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.CirEqHint);
            // 
            // displayBoxBottom
            // 
            this.displayBoxBottom.Location = new System.Drawing.Point(15, 522);
            this.displayBoxBottom.Name = "displayBoxBottom";
            this.displayBoxBottom.Size = new System.Drawing.Size(311, 92);
            this.displayBoxBottom.TabIndex = 36;
            this.displayBoxBottom.Text = "";
     
      
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 23);
            this.button1.TabIndex = 39;
            this.button1.Text = "Graph";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.linearGraph);
            // 
            // linearColor
            // 
            this.linearColor.FormattingEnabled = true;
            this.linearColor.Location = new System.Drawing.Point(164, 148);
            this.linearColor.Name = "linearColor";
            this.linearColor.Size = new System.Drawing.Size(87, 21);
            this.linearColor.TabIndex = 40;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(41, 206);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(23, 13);
            this.label18.TabIndex = 41;
            this.label18.Text = "Y =";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(36, 297);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(23, 13);
            this.label19.TabIndex = 42;
            this.label19.Text = "Y =";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(41, 384);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(24, 13);
            this.label20.TabIndex = 43;
            this.label20.Text = "(( x-";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(94, 296);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(33, 13);
            this.label21.TabIndex = 44;
            this.label21.Text = "x^3 +";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(144, 183);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(13, 13);
            this.label22.TabIndex = 45;
            this.label22.Text = "b";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(160, 206);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(21, 13);
            this.label23.TabIndex = 46;
            this.label23.Text = "x +";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(199, 183);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(13, 13);
            this.label24.TabIndex = 47;
            this.label24.Text = "c";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(292, 199);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(51, 23);
            this.button6.TabIndex = 48;
            this.button6.Text = "Graph";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.quadGraph);
            // 
            // quadColor
            // 
            this.quadColor.FormattingEnabled = true;
            this.quadColor.Location = new System.Drawing.Point(164, 229);
            this.quadColor.Name = "quadColor";
            this.quadColor.Size = new System.Drawing.Size(87, 21);
            this.quadColor.TabIndex = 49;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(293, 286);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(51, 23);
            this.button7.TabIndex = 50;
            this.button7.Text = "Graph";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.cubicGraph);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(98, 206);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(33, 13);
            this.label25.TabIndex = 51;
            this.label25.Text = "x^2 +";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(161, 297);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(33, 13);
            this.label26.TabIndex = 52;
            this.label26.Text = "x^2 +";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(231, 297);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(21, 13);
            this.label27.TabIndex = 53;
            this.label27.Text = "x +";
            // 
            // cubicColor
            // 
            this.cubicColor.FormattingEnabled = true;
            this.cubicColor.Location = new System.Drawing.Point(165, 316);
            this.cubicColor.Name = "cubicColor";
            this.cubicColor.Size = new System.Drawing.Size(87, 21);
            this.cubicColor.TabIndex = 54;
            // 
            // circleColor
            // 
            this.circleColor.FormattingEnabled = true;
            this.circleColor.Location = new System.Drawing.Point(164, 418);
            this.circleColor.Name = "circleColor";
            this.circleColor.Size = new System.Drawing.Size(87, 21);
            this.circleColor.TabIndex = 55;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(95, 385);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(45, 13);
            this.label28.TabIndex = 56;
            this.label28.Text = ")^2+( y -";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(176, 385);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(34, 13);
            this.label29.TabIndex = 57;
            this.label29.Text = ")^2) =";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(292, 377);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(51, 23);
            this.button8.TabIndex = 59;
            this.button8.Text = "Graph";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.circleGraph);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(129, 151);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(31, 13);
            this.label31.TabIndex = 60;
            this.label31.Text = "Color";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(129, 232);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(31, 13);
            this.label32.TabIndex = 61;
            this.label32.Text = "Color";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(130, 319);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(31, 13);
            this.label33.TabIndex = 62;
            this.label33.Text = "Color";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(129, 421);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(31, 13);
            this.label34.TabIndex = 63;
            this.label34.Text = "Color";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(129, 20);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(117, 43);
            this.button9.TabIndex = 64;
            this.button9.Text = "Clear Graph";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.clearGraph);
            // 
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 453);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Range";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(7, 466);
            this.label35.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(67, 13);
            this.label35.TabIndex = 70;
            this.label35.Text = "x-min   x-max";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(77, 466);
            this.label36.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(76, 13);
            this.label36.TabIndex = 71;
            this.label36.Text = "y-min      y-max";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(187, 453);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(42, 13);
            this.label37.TabIndex = 72;
            this.label37.Text = "Interval";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(187, 466);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(47, 13);
            this.label38.TabIndex = 73;
            this.label38.Text = "x          y";
            // 
            // xMinRange
            // 
            this.xMinRange.Location = new System.Drawing.Point(10, 481);
            this.xMinRange.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.xMinRange.Name = "xMinRange";
            this.xMinRange.Size = new System.Drawing.Size(39, 20);
            this.xMinRange.TabIndex = 74;
            this.xMinRange.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.xMinRange.ValueChanged += new System.EventHandler(this.xMinChanged);
            // 
            // yInterval
            // 
            this.yInterval.Location = new System.Drawing.Point(215, 482);
            this.yInterval.Name = "yInterval";
            this.yInterval.Size = new System.Drawing.Size(32, 20);
            this.yInterval.TabIndex = 76;
            this.yInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // xInterval
            // 
            this.xInterval.Location = new System.Drawing.Point(180, 482);
            this.xInterval.Name = "xInterval";
            this.xInterval.Size = new System.Drawing.Size(32, 20);
            this.xInterval.TabIndex = 77;
            this.xInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // yMaxRange
            // 
            this.yMaxRange.Location = new System.Drawing.Point(116, 482);
            this.yMaxRange.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.yMaxRange.Name = "yMaxRange";
            this.yMaxRange.Size = new System.Drawing.Size(41, 20);
            this.yMaxRange.TabIndex = 78;
            this.yMaxRange.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.yMaxRange.ValueChanged += new System.EventHandler(this.yMaxChanged);
            // 
            // yMinRange
            // 
            this.yMinRange.Location = new System.Drawing.Point(80, 482);
            this.yMinRange.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.yMinRange.Name = "yMinRange";
            this.yMinRange.Size = new System.Drawing.Size(38, 20);
            this.yMinRange.TabIndex = 79;
            this.yMinRange.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.yMinRange.ValueChanged += new System.EventHandler(this.yMinChanged);
            // 
            // xMaxRange
            // 
            this.xMaxRange.Location = new System.Drawing.Point(44, 482);
            this.xMaxRange.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.xMaxRange.Name = "xMaxRange";
            this.xMaxRange.Size = new System.Drawing.Size(36, 20);
            this.xMaxRange.TabIndex = 80;
            this.xMaxRange.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.xMaxRange.ValueChanged += new System.EventHandler(this.xMaxChanged);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(269, 461);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(74, 23);
            this.button10.TabIndex = 81;
            this.button10.Text = "Set Bounds";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Set_Bounds);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(978, 620);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.xMaxRange);
            this.Controls.Add(this.yMinRange);
            this.Controls.Add(this.yMaxRange);
            this.Controls.Add(this.xInterval);
            this.Controls.Add(this.yInterval);
            this.Controls.Add(this.xMinRange);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.circleColor);
            this.Controls.Add(this.cubicColor);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.quadColor);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.linearColor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.displayBoxBottom);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.circleR);
            this.Controls.Add(this.circleK);
            this.Controls.Add(this.circleH);
            this.Controls.Add(this.cubicD);
            this.Controls.Add(this.cubicC);
            this.Controls.Add(this.cubicB);
            this.Controls.Add(this.cubicA);
            this.Controls.Add(this.quadC);
            this.Controls.Add(this.quadB);
            this.Controls.Add(this.quadA);
            this.Controls.Add(this.linearB);
            this.Controls.Add(this.linearM);
            this.Controls.Add(this.CoordinatePlane);
            this.Name = "Form1";
            this.Text = "Graphing Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CoordinatePlane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMinRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yMaxRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yMinRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMaxRange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CoordinatePlane;
        private System.Windows.Forms.TextBox linearM;
        private System.Windows.Forms.TextBox linearB;
        private System.Windows.Forms.TextBox quadB;
        private System.Windows.Forms.TextBox quadA;
        private System.Windows.Forms.TextBox quadC;
        private System.Windows.Forms.TextBox cubicA;
        private System.Windows.Forms.TextBox cubicD;
        private System.Windows.Forms.TextBox cubicC;
        private System.Windows.Forms.TextBox cubicB;
        private System.Windows.Forms.TextBox circleR;
        private System.Windows.Forms.TextBox circleK;
        private System.Windows.Forms.TextBox circleH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.RichTextBox displayBoxBottom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox linearColor;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox quadColor;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox cubicColor;
        private System.Windows.Forms.ComboBox circleColor;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.NumericUpDown xMinRange;
        private System.Windows.Forms.NumericUpDown yInterval;
        private System.Windows.Forms.NumericUpDown xInterval;
        private System.Windows.Forms.NumericUpDown yMaxRange;
        private System.Windows.Forms.NumericUpDown yMinRange;
        private System.Windows.Forms.NumericUpDown xMaxRange;
        private System.Windows.Forms.Button button10;
    }
}
