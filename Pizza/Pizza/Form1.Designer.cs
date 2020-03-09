namespace Pizza
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkMush = new System.Windows.Forms.CheckBox();
            this.chkJal = new System.Windows.Forms.CheckBox();
            this.chkPep = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radLarge = new System.Windows.Forms.RadioButton();
            this.radMed = new System.Windows.Forms.RadioButton();
            this.radSmall = new System.Windows.Forms.RadioButton();
            this.comboSauce = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.radThin = new System.Windows.Forms.RadioButton();
            this.radPan = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Panucci\'s Pizza";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(583, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Extras";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // chkMush
            // 
            this.chkMush.AutoSize = true;
            this.chkMush.Location = new System.Drawing.Point(29, 177);
            this.chkMush.Name = "chkMush";
            this.chkMush.Size = new System.Drawing.Size(80, 17);
            this.chkMush.TabIndex = 3;
            this.chkMush.Text = "Mushrooms";
            this.chkMush.UseVisualStyleBackColor = true;
            this.chkMush.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkJal
            // 
            this.chkJal.AutoSize = true;
            this.chkJal.Location = new System.Drawing.Point(29, 201);
            this.chkJal.Name = "chkJal";
            this.chkJal.Size = new System.Drawing.Size(74, 17);
            this.chkJal.TabIndex = 4;
            this.chkJal.Text = "Jalapenos";
            this.chkJal.UseVisualStyleBackColor = true;
            // 
            // chkPep
            // 
            this.chkPep.AutoSize = true;
            this.chkPep.Location = new System.Drawing.Point(29, 225);
            this.chkPep.Name = "chkPep";
            this.chkPep.Size = new System.Drawing.Size(85, 17);
            this.chkPep.TabIndex = 5;
            this.chkPep.Text = "Bell Peppers";
            this.chkPep.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Type of Base";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radLarge);
            this.groupBox1.Controls.Add(this.radMed);
            this.groupBox1.Controls.Add(this.radSmall);
            this.groupBox1.Location = new System.Drawing.Point(351, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 101);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size";
            // 
            // radLarge
            // 
            this.radLarge.AutoSize = true;
            this.radLarge.Location = new System.Drawing.Point(7, 68);
            this.radLarge.Name = "radLarge";
            this.radLarge.Size = new System.Drawing.Size(52, 17);
            this.radLarge.TabIndex = 2;
            this.radLarge.TabStop = true;
            this.radLarge.Text = "Large";
            this.radLarge.UseVisualStyleBackColor = true;
            // 
            // radMed
            // 
            this.radMed.AutoSize = true;
            this.radMed.Location = new System.Drawing.Point(7, 44);
            this.radMed.Name = "radMed";
            this.radMed.Size = new System.Drawing.Size(62, 17);
            this.radMed.TabIndex = 1;
            this.radMed.TabStop = true;
            this.radMed.Text = "Medium";
            this.radMed.UseVisualStyleBackColor = true;
            // 
            // radSmall
            // 
            this.radSmall.AutoSize = true;
            this.radSmall.Location = new System.Drawing.Point(7, 20);
            this.radSmall.Name = "radSmall";
            this.radSmall.Size = new System.Drawing.Size(50, 17);
            this.radSmall.TabIndex = 0;
            this.radSmall.TabStop = true;
            this.radSmall.Text = "Small";
            this.radSmall.UseVisualStyleBackColor = true;
            // 
            // comboSauce
            // 
            this.comboSauce.FormattingEnabled = true;
            this.comboSauce.Items.AddRange(new object[] {
            "BBQ Sauce",
            "Chilli Sauce",
            "Tomato Sauce",
            "Madras Sauce"});
            this.comboSauce.Location = new System.Drawing.Point(351, 302);
            this.comboSauce.Name = "comboSauce";
            this.comboSauce.Size = new System.Drawing.Size(121, 21);
            this.comboSauce.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(345, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 33);
            this.label4.TabIndex = 11;
            this.label4.Text = "Base Sauce";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(619, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 48);
            this.button1.TabIndex = 12;
            this.button1.Text = "Place Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radThin
            // 
            this.radThin.AutoSize = true;
            this.radThin.Location = new System.Drawing.Point(29, 307);
            this.radThin.Name = "radThin";
            this.radThin.Size = new System.Drawing.Size(98, 17);
            this.radThin.TabIndex = 14;
            this.radThin.TabStop = true;
            this.radThin.Text = "Thin and Crispy";
            this.radThin.UseVisualStyleBackColor = true;
            // 
            // radPan
            // 
            this.radPan.AutoSize = true;
            this.radPan.Location = new System.Drawing.Point(29, 331);
            this.radPan.Name = "radPan";
            this.radPan.Size = new System.Drawing.Size(73, 17);
            this.radPan.TabIndex = 15;
            this.radPan.TabStop = true;
            this.radPan.Text = "Deep Pan";
            this.radPan.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radPan);
            this.Controls.Add(this.radThin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboSauce);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkPep);
            this.Controls.Add(this.chkJal);
            this.Controls.Add(this.chkMush);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Panucci\'s Pizza";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkMush;
        private System.Windows.Forms.CheckBox chkJal;
        private System.Windows.Forms.CheckBox chkPep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radLarge;
        private System.Windows.Forms.RadioButton radMed;
        private System.Windows.Forms.RadioButton radSmall;
        private System.Windows.Forms.ComboBox comboSauce;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radThin;
        private System.Windows.Forms.RadioButton radPan;
    }
}

