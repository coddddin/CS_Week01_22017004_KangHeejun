namespace MyBusinessCard
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(35, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 268);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("휴먼둥근헤드라인", 48F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(342, 63);
            label1.Name = "label1";
            label1.Size = new Size(221, 67);
            label1.TabIndex = 1;
            label1.Text = "강희준";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(342, 139);
            label2.Name = "label2";
            label2.Size = new Size(201, 50);
            label2.TabIndex = 2;
            label2.Text = "컴퓨터 SW";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("한컴 고딕", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(342, 212);
            label3.Name = "label3";
            label3.Size = new Size(425, 48);
            label3.TabIndex = 3;
            label3.Text = "heejun081@naver.com";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(342, 335);
            button1.Name = "button1";
            button1.Size = new Size(327, 66);
            button1.TabIndex = 4;
            button1.Text = "배경색상 변경";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSteelBlue;
            button2.Location = new Point(342, 279);
            button2.Name = "button2";
            button2.Size = new Size(185, 35);
            button2.TabIndex = 5;
            button2.Text = "GIthub";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Coral;
            button3.Font = new Font("휴먼둥근헤드라인", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            button3.Location = new Point(76, 335);
            button3.Name = "button3";
            button3.Size = new Size(156, 50);
            button3.TabIndex = 6;
            button3.Text = "사진 변경";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
