namespace myactivepett
{
    partial class Stress
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
            panel1 = new Panel();
            lbl_constant = new Label();
            lbl_question = new Label();
            lbl_questionNumber = new Label();
            radioButton5 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            btn_Next1 = new Button();
            btn_Back1 = new Button();
            btn_Next = new Button();
            btn_Back = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Quiz;
            panel1.Controls.Add(lbl_constant);
            panel1.Controls.Add(lbl_question);
            panel1.Controls.Add(lbl_questionNumber);
            panel1.Controls.Add(radioButton5);
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(radioButton4);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(btn_Next1);
            panel1.Controls.Add(btn_Back1);
            panel1.Controls.Add(btn_Next);
            panel1.Controls.Add(btn_Back);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(2743, 1800);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // lbl_constant
            // 
            lbl_constant.AutoEllipsis = true;
            lbl_constant.BackColor = Color.Transparent;
            lbl_constant.FlatStyle = FlatStyle.Flat;
            lbl_constant.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_constant.Location = new Point(1503, 359);
            lbl_constant.Name = "lbl_constant";
            lbl_constant.Size = new Size(367, 187);
            lbl_constant.TabIndex = 11;
            lbl_constant.Text = "През последния месец, колко често сте:";
            lbl_constant.Click += lbl_constant_Click;
            // 
            // lbl_question
            // 
            lbl_question.BackColor = Color.Transparent;
            lbl_question.Font = new Font("Hip Horay", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_question.ForeColor = Color.FromArgb(253, 255, 206);
            lbl_question.Location = new Point(223, 293);
            lbl_question.Name = "lbl_question";
            lbl_question.Size = new Size(428, 206);
            lbl_question.TabIndex = 10;
            lbl_question.Text = "Били разстроени поради нещо, което се е случило неочаквано?";
            lbl_question.Click += lbl_question_Click;
            // 
            // lbl_questionNumber
            // 
            lbl_questionNumber.AutoSize = true;
            lbl_questionNumber.BackColor = Color.Transparent;
            lbl_questionNumber.Font = new Font("Hip Horay", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_questionNumber.Location = new Point(152, 319);
            lbl_questionNumber.Name = "lbl_questionNumber";
            lbl_questionNumber.Size = new Size(44, 42);
            lbl_questionNumber.TabIndex = 9;
            lbl_questionNumber.Text = "1.";
            lbl_questionNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.BackColor = Color.Transparent;
            radioButton5.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton5.Location = new Point(170, 657);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(182, 41);
            radioButton5.TabIndex = 8;
            radioButton5.TabStop = true;
            radioButton5.Text = "Понякога";
            radioButton5.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.BackColor = Color.Transparent;
            radioButton3.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton3.Location = new Point(170, 827);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(229, 41);
            radioButton3.TabIndex = 7;
            radioButton3.TabStop = true;
            radioButton3.Text = "Много често";
            radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.BackColor = Color.Transparent;
            radioButton4.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton4.Location = new Point(170, 743);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(132, 41);
            radioButton4.TabIndex = 6;
            radioButton4.TabStop = true;
            radioButton4.Text = "Често";
            radioButton4.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Transparent;
            radioButton2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2.Location = new Point(170, 571);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(241, 41);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "Почти никога";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.Location = new Point(170, 486);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(149, 41);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Никога";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // btn_Next1
            // 
            btn_Next1.BackColor = Color.Transparent;
            btn_Next1.FlatAppearance.BorderSize = 0;
            btn_Next1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_Next1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_Next1.FlatStyle = FlatStyle.Flat;
            btn_Next1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Next1.Location = new Point(476, 910);
            btn_Next1.Name = "btn_Next1";
            btn_Next1.Size = new Size(195, 65);
            btn_Next1.TabIndex = 3;
            btn_Next1.Text = "Следващ";
            btn_Next1.UseVisualStyleBackColor = false;
            btn_Next1.Click += btn_Next1_Click;
            // 
            // btn_Back1
            // 
            btn_Back1.BackColor = Color.Transparent;
            btn_Back1.FlatAppearance.BorderSize = 0;
            btn_Back1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_Back1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_Back1.FlatStyle = FlatStyle.Flat;
            btn_Back1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Back1.Location = new Point(144, 910);
            btn_Back1.Name = "btn_Back1";
            btn_Back1.Size = new Size(195, 65);
            btn_Back1.TabIndex = 2;
            btn_Back1.Text = "Предишен";
            btn_Back1.UseVisualStyleBackColor = false;
            btn_Back1.Click += btn_Back1_Click;
            // 
            // btn_Next
            // 
            btn_Next.BackColor = Color.Transparent;
            btn_Next.FlatAppearance.BorderSize = 0;
            btn_Next.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_Next.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_Next.FlatStyle = FlatStyle.Flat;
            btn_Next.Location = new Point(679, 1518);
            btn_Next.Margin = new Padding(4, 5, 4, 5);
            btn_Next.Name = "btn_Next";
            btn_Next.Size = new Size(283, 108);
            btn_Next.TabIndex = 1;
            btn_Next.Text = "button1";
            btn_Next.UseVisualStyleBackColor = false;
            btn_Next.Click += btn_Next_Click;
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.Transparent;
            btn_Back.FlatAppearance.BorderSize = 0;
            btn_Back.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_Back.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_Back.FlatStyle = FlatStyle.Flat;
            btn_Back.Location = new Point(206, 1518);
            btn_Back.Margin = new Padding(4, 5, 4, 5);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(283, 108);
            btn_Back.TabIndex = 0;
            btn_Back.Text = "button1";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // Stress
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1050);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Stress";
            Text = "Stress";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        public Button btn_Next;
        public Button btn_Back;
        public RadioButton radioButton5;
        public RadioButton radioButton3;
        public RadioButton radioButton4;
        public RadioButton radioButton2;
        public RadioButton radioButton1;
        public Button btn_Back1;
        public Button btn_Next1;
        public Label lbl_questionNumber;
        private Label lbl_constant;
        public Label lbl_question;
    }
}