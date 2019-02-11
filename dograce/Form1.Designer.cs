namespace dograce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rTrack = new System.Windows.Forms.PictureBox();
            this.racer1 = new System.Windows.Forms.PictureBox();
            this.racer2 = new System.Windows.Forms.PictureBox();
            this.racer3 = new System.Windows.Forms.PictureBox();
            this.racer4 = new System.Windows.Forms.PictureBox();
            this.rbJoe = new System.Windows.Forms.RadioButton();
            this.rbAl = new System.Windows.Forms.RadioButton();
            this.rbBob = new System.Windows.Forms.RadioButton();
            this.but_Bet = new System.Windows.Forms.Button();
            this.but_Rac = new System.Windows.Forms.Button();
            this.Joebet = new System.Windows.Forms.Label();
            this.Bobbet = new System.Windows.Forms.Label();
            this.Aibet = new System.Windows.Forms.Label();
            this.nUD_bet = new System.Windows.Forms.NumericUpDown();
            this.nUD_dog = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.but_Res = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racer4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_bet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_dog)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rTrack
            // 
            this.rTrack.Image = ((System.Drawing.Image)(resources.GetObject("rTrack.Image")));
            this.rTrack.Location = new System.Drawing.Point(62, 203);
            this.rTrack.Name = "rTrack";
            this.rTrack.Size = new System.Drawing.Size(866, 367);
            this.rTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rTrack.TabIndex = 0;
            this.rTrack.TabStop = false;
            // 
            // racer1
            // 
            this.racer1.Image = ((System.Drawing.Image)(resources.GetObject("racer1.Image")));
            this.racer1.Location = new System.Drawing.Point(62, 219);
            this.racer1.Name = "racer1";
            this.racer1.Size = new System.Drawing.Size(94, 49);
            this.racer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racer1.TabIndex = 1;
            this.racer1.TabStop = false;
            // 
            // racer2
            // 
            this.racer2.Image = ((System.Drawing.Image)(resources.GetObject("racer2.Image")));
            this.racer2.Location = new System.Drawing.Point(62, 312);
            this.racer2.Name = "racer2";
            this.racer2.Size = new System.Drawing.Size(94, 49);
            this.racer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racer2.TabIndex = 2;
            this.racer2.TabStop = false;
            // 
            // racer3
            // 
            this.racer3.Image = ((System.Drawing.Image)(resources.GetObject("racer3.Image")));
            this.racer3.Location = new System.Drawing.Point(62, 402);
            this.racer3.Name = "racer3";
            this.racer3.Size = new System.Drawing.Size(94, 49);
            this.racer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racer3.TabIndex = 3;
            this.racer3.TabStop = false;
            // 
            // racer4
            // 
            this.racer4.Image = ((System.Drawing.Image)(resources.GetObject("racer4.Image")));
            this.racer4.Location = new System.Drawing.Point(62, 500);
            this.racer4.Name = "racer4";
            this.racer4.Size = new System.Drawing.Size(94, 49);
            this.racer4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racer4.TabIndex = 4;
            this.racer4.TabStop = false;
            // 
            // rbJoe
            // 
            this.rbJoe.AutoSize = true;
            this.rbJoe.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbJoe.Location = new System.Drawing.Point(9, 15);
            this.rbJoe.Name = "rbJoe";
            this.rbJoe.Size = new System.Drawing.Size(55, 24);
            this.rbJoe.TabIndex = 5;
            this.rbJoe.TabStop = true;
            this.rbJoe.Text = "Joe";
            this.rbJoe.UseVisualStyleBackColor = true;
            this.rbJoe.CheckedChanged += new System.EventHandler(this.rbJoe_CheckedChanged);
            // 
            // rbAl
            // 
            this.rbAl.AutoSize = true;
            this.rbAl.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAl.Location = new System.Drawing.Point(9, 83);
            this.rbAl.Name = "rbAl";
            this.rbAl.Size = new System.Drawing.Size(43, 24);
            this.rbAl.TabIndex = 6;
            this.rbAl.TabStop = true;
            this.rbAl.Text = "AI";
            this.rbAl.UseVisualStyleBackColor = true;
            this.rbAl.CheckedChanged += new System.EventHandler(this.rbAl_CheckedChanged);
            // 
            // rbBob
            // 
            this.rbBob.AutoSize = true;
            this.rbBob.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBob.Location = new System.Drawing.Point(9, 49);
            this.rbBob.Name = "rbBob";
            this.rbBob.Size = new System.Drawing.Size(58, 24);
            this.rbBob.TabIndex = 7;
            this.rbBob.TabStop = true;
            this.rbBob.Text = "Bob";
            this.rbBob.UseVisualStyleBackColor = true;
            this.rbBob.CheckedChanged += new System.EventHandler(this.rbBob_CheckedChanged);
            // 
            // but_Bet
            // 
            this.but_Bet.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Bet.Location = new System.Drawing.Point(92, 139);
            this.but_Bet.Name = "but_Bet";
            this.but_Bet.Size = new System.Drawing.Size(183, 49);
            this.but_Bet.TabIndex = 8;
            this.but_Bet.Text = "Place Bet";
            this.but_Bet.UseVisualStyleBackColor = true;
            this.but_Bet.Click += new System.EventHandler(this.but_Bet_Click);
            // 
            // but_Rac
            // 
            this.but_Rac.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Rac.Location = new System.Drawing.Point(811, 139);
            this.but_Rac.Name = "but_Rac";
            this.but_Rac.Size = new System.Drawing.Size(117, 49);
            this.but_Rac.TabIndex = 9;
            this.but_Rac.Text = "Race";
            this.but_Rac.UseVisualStyleBackColor = true;
            this.but_Rac.Click += new System.EventHandler(this.button2_Click);
            // 
            // Joebet
            // 
            this.Joebet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Joebet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Joebet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Joebet.ForeColor = System.Drawing.Color.Red;
            this.Joebet.Location = new System.Drawing.Point(478, 14);
            this.Joebet.Name = "Joebet";
            this.Joebet.Size = new System.Drawing.Size(370, 23);
            this.Joebet.TabIndex = 10;
            // 
            // Bobbet
            // 
            this.Bobbet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Bobbet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Bobbet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bobbet.ForeColor = System.Drawing.Color.Red;
            this.Bobbet.Location = new System.Drawing.Point(478, 46);
            this.Bobbet.Name = "Bobbet";
            this.Bobbet.Size = new System.Drawing.Size(370, 23);
            this.Bobbet.TabIndex = 11;
            // 
            // Aibet
            // 
            this.Aibet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Aibet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Aibet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aibet.ForeColor = System.Drawing.Color.Red;
            this.Aibet.Location = new System.Drawing.Point(478, 78);
            this.Aibet.Name = "Aibet";
            this.Aibet.Size = new System.Drawing.Size(370, 23);
            this.Aibet.TabIndex = 12;
            // 
            // nUD_bet
            // 
            this.nUD_bet.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUD_bet.Location = new System.Drawing.Point(400, 19);
            this.nUD_bet.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUD_bet.Name = "nUD_bet";
            this.nUD_bet.Size = new System.Drawing.Size(61, 29);
            this.nUD_bet.TabIndex = 13;
            this.nUD_bet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nUD_dog
            // 
            this.nUD_dog.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUD_dog.Location = new System.Drawing.Point(400, 58);
            this.nUD_dog.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nUD_dog.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_dog.Name = "nUD_dog";
            this.nUD_dog.Size = new System.Drawing.Size(61, 29);
            this.nUD_dog.TabIndex = 14;
            this.nUD_dog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUD_dog.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(335, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Max Bet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(313, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "on Dog    #";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(318, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Bettor    $";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nUD_dog);
            this.groupBox1.Controls.Add(this.nUD_bet);
            this.groupBox1.Controls.Add(this.Aibet);
            this.groupBox1.Controls.Add(this.Bobbet);
            this.groupBox1.Controls.Add(this.Joebet);
            this.groupBox1.Controls.Add(this.rbBob);
            this.groupBox1.Controls.Add(this.rbAl);
            this.groupBox1.Controls.Add(this.rbJoe);
            this.groupBox1.Location = new System.Drawing.Point(62, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(866, 112);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // but_Res
            // 
            this.but_Res.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Res.Location = new System.Drawing.Point(631, 139);
            this.but_Res.Name = "but_Res";
            this.but_Res.Size = new System.Drawing.Size(117, 49);
            this.but_Res.TabIndex = 19;
            this.but_Res.Text = "Reset";
            this.but_Res.UseVisualStyleBackColor = true;
            this.but_Res.Click += new System.EventHandler(this.but_Res_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 588);
            this.Controls.Add(this.but_Res);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.but_Rac);
            this.Controls.Add(this.but_Bet);
            this.Controls.Add(this.racer4);
            this.Controls.Add(this.racer3);
            this.Controls.Add(this.racer2);
            this.Controls.Add(this.racer1);
            this.Controls.Add(this.rTrack);
            this.Name = "Form1";
            this.Text = "Dogs  Racing........";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racer4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_bet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_dog)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox rTrack;
        private System.Windows.Forms.PictureBox racer1;
        private System.Windows.Forms.PictureBox racer2;
        private System.Windows.Forms.PictureBox racer3;
        private System.Windows.Forms.PictureBox racer4;
        private System.Windows.Forms.RadioButton rbJoe;
        private System.Windows.Forms.RadioButton rbAl;
        private System.Windows.Forms.RadioButton rbBob;
        private System.Windows.Forms.Button but_Bet;
        private System.Windows.Forms.Button but_Rac;
        private System.Windows.Forms.Label Joebet;
        private System.Windows.Forms.Label Bobbet;
        private System.Windows.Forms.Label Aibet;
        private System.Windows.Forms.NumericUpDown nUD_bet;
        private System.Windows.Forms.NumericUpDown nUD_dog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button but_Res;
    }
}

