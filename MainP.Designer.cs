namespace myactivepett
{
    partial class MainP
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
            btn_sport = new Button();
            btn_cup = new Button();
            btn_paw = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.dog;
            panel1.Controls.Add(btn_sport);
            panel1.Controls.Add(btn_cup);
            panel1.Controls.Add(btn_paw);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1920, 1080);
            panel1.TabIndex = 0;
            // 
            // btn_sport
            // 
            btn_sport.BackColor = Color.Transparent;
            btn_sport.FlatAppearance.BorderSize = 0;
            btn_sport.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_sport.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_sport.FlatStyle = FlatStyle.Flat;
            btn_sport.Location = new Point(1116, 674);
            btn_sport.Name = "btn_sport";
            btn_sport.Size = new Size(156, 138);
            btn_sport.TabIndex = 2;
            btn_sport.UseVisualStyleBackColor = false;
            btn_sport.Click += btn_sport_Click;
            // 
            // btn_cup
            // 
            btn_cup.BackColor = Color.Transparent;
            btn_cup.FlatAppearance.BorderSize = 0;
            btn_cup.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_cup.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_cup.FlatStyle = FlatStyle.Flat;
            btn_cup.Location = new Point(890, 287);
            btn_cup.Name = "btn_cup";
            btn_cup.Size = new Size(156, 138);
            btn_cup.TabIndex = 1;
            btn_cup.UseVisualStyleBackColor = false;
            btn_cup.Click += btn_cup_Click;
            // 
            // btn_paw
            // 
            btn_paw.BackColor = Color.Transparent;
            btn_paw.FlatAppearance.BorderSize = 0;
            btn_paw.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_paw.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_paw.FlatStyle = FlatStyle.Flat;
            btn_paw.Location = new Point(671, 674);
            btn_paw.Name = "btn_paw";
            btn_paw.Size = new Size(156, 138);
            btn_paw.TabIndex = 0;
            btn_paw.UseVisualStyleBackColor = false;
            btn_paw.Click += btn_paw_Click;
            // 
            // MainP
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(panel1);
            Name = "MainP";
            Text = "Form2";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public Panel panel1;
        private Button btn_sport;
        private Button btn_cup;
        private Button btn_paw;
    }
}