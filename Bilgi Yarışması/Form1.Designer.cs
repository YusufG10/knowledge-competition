namespace Bilgi_Yarışması
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            buttonA = new Button();
            buttonB = new Button();
            buttonC = new Button();
            buttonD = new Button();
            labelSoruNo = new Label();
            labelDogru = new Label();
            labelYanlis = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonSonraki = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(360, 177);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // buttonA
            // 
            buttonA.Location = new Point(12, 206);
            buttonA.Name = "buttonA";
            buttonA.Size = new Size(173, 37);
            buttonA.TabIndex = 1;
            buttonA.Text = "A";
            buttonA.UseVisualStyleBackColor = true;
            buttonA.Click += buttonA_Click;
            // 
            // buttonB
            // 
            buttonB.Location = new Point(199, 206);
            buttonB.Name = "buttonB";
            buttonB.Size = new Size(173, 37);
            buttonB.TabIndex = 2;
            buttonB.Text = "B";
            buttonB.UseVisualStyleBackColor = true;
            buttonB.Click += buttonB_Click;
            // 
            // buttonC
            // 
            buttonC.Location = new Point(12, 261);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(173, 37);
            buttonC.TabIndex = 3;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = true;
            buttonC.Click += buttonC_Click;
            // 
            // buttonD
            // 
            buttonD.Location = new Point(199, 261);
            buttonD.Name = "buttonD";
            buttonD.Size = new Size(173, 37);
            buttonD.TabIndex = 4;
            buttonD.Text = "D";
            buttonD.UseVisualStyleBackColor = true;
            buttonD.Click += buttonD_Click;
            // 
            // labelSoruNo
            // 
            labelSoruNo.AutoSize = true;
            labelSoruNo.Location = new Point(573, 32);
            labelSoruNo.Name = "labelSoruNo";
            labelSoruNo.Size = new Size(20, 23);
            labelSoruNo.TabIndex = 8;
            labelSoruNo.Text = "0";
            // 
            // labelDogru
            // 
            labelDogru.AutoSize = true;
            labelDogru.Location = new Point(574, 85);
            labelDogru.Name = "labelDogru";
            labelDogru.Size = new Size(20, 23);
            labelDogru.TabIndex = 9;
            labelDogru.Text = "0";
            // 
            // labelYanlis
            // 
            labelYanlis.AutoSize = true;
            labelYanlis.Location = new Point(573, 138);
            labelYanlis.Name = "labelYanlis";
            labelYanlis.Size = new Size(20, 23);
            labelYanlis.TabIndex = 10;
            labelYanlis.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(461, 32);
            label1.Name = "label1";
            label1.Size = new Size(78, 23);
            label1.TabIndex = 5;
            label1.Text = "Soru No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(475, 85);
            label2.Name = "label2";
            label2.Size = new Size(64, 23);
            label2.TabIndex = 6;
            label2.Text = "Doğru:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(484, 138);
            label3.Name = "label3";
            label3.Size = new Size(55, 23);
            label3.TabIndex = 7;
            label3.Text = "Yanlış";
            // 
            // buttonSonraki
            // 
            buttonSonraki.Location = new Point(465, 180);
            buttonSonraki.Name = "buttonSonraki";
            buttonSonraki.Size = new Size(158, 37);
            buttonSonraki.TabIndex = 11;
            buttonSonraki.Text = "Başlat";
            buttonSonraki.UseVisualStyleBackColor = true;
            buttonSonraki.Click += buttonSonraki_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(573, 237);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(83, 61);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(456, 237);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(129, 310);
            label4.Name = "label4";
            label4.Size = new Size(56, 23);
            label4.TabIndex = 14;
            label4.Text = "label4";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(199, 310);
            label5.Name = "label5";
            label5.Size = new Size(55, 23);
            label5.TabIndex = 15;
            label5.Text = "label5";
            label5.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 332);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(buttonSonraki);
            Controls.Add(labelYanlis);
            Controls.Add(labelDogru);
            Controls.Add(labelSoruNo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonD);
            Controls.Add(buttonC);
            Controls.Add(buttonB);
            Controls.Add(buttonA);
            Controls.Add(richTextBox1);
            Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button buttonA;
        private Button buttonB;
        private Button buttonC;
        private Button buttonD;
        private Label labelSoruNo;
        private Label labelDogru;
        private Label labelYanlis;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonSonraki;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label5;
    }
}