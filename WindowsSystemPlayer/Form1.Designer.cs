namespace WindowsSystemPlayer
{
    partial class UserCfg_Form
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
            label1 = new Label();
            path_TB = new TextBox();
            label2 = new Label();
            minutes_TB = new TextBox();
            hours_TB = new TextBox();
            seconds_TB = new TextBox();
            label5 = new Label();
            label4 = new Label();
            save_Button = new Button();
            Volume_TB = new TextBox();
            label3 = new Label();
            label6 = new Label();
            ImagePath_TB = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(14, 57);
            label1.Name = "label1";
            label1.Size = new Size(81, 16);
            label1.TabIndex = 0;
            label1.Text = "Sound path";
            // 
            // path_TB
            // 
            path_TB.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            path_TB.ForeColor = Color.Green;
            path_TB.Location = new Point(103, 54);
            path_TB.Name = "path_TB";
            path_TB.Size = new Size(204, 23);
            path_TB.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(15, 10);
            label2.Name = "label2";
            label2.Size = new Size(37, 16);
            label2.TabIndex = 2;
            label2.Text = "Time";
            // 
            // minutes_TB
            // 
            minutes_TB.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            minutes_TB.ForeColor = Color.Green;
            minutes_TB.Location = new Point(174, 12);
            minutes_TB.MaxLength = 2;
            minutes_TB.Name = "minutes_TB";
            minutes_TB.Size = new Size(34, 23);
            minutes_TB.TabIndex = 5;
            minutes_TB.Text = "MM";
            minutes_TB.MouseClick += minutes_TB_MouseClick;
            // 
            // hours_TB
            // 
            hours_TB.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            hours_TB.ForeColor = Color.Green;
            hours_TB.Location = new Point(119, 12);
            hours_TB.MaxLength = 2;
            hours_TB.Name = "hours_TB";
            hours_TB.Size = new Size(34, 23);
            hours_TB.TabIndex = 6;
            hours_TB.Text = "HH";
            hours_TB.MouseClick += hours_TB_MouseClick;
            // 
            // seconds_TB
            // 
            seconds_TB.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            seconds_TB.ForeColor = Color.Green;
            seconds_TB.Location = new Point(230, 12);
            seconds_TB.MaxLength = 2;
            seconds_TB.Name = "seconds_TB";
            seconds_TB.Size = new Size(34, 23);
            seconds_TB.TabIndex = 7;
            seconds_TB.Text = "SS";
            seconds_TB.MouseClick += seconds_TB_MouseClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.Green;
            label5.Location = new Point(214, 20);
            label5.Name = "label5";
            label5.Size = new Size(11, 16);
            label5.TabIndex = 10;
            label5.Text = ":";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.Green;
            label4.Location = new Point(158, 20);
            label4.Name = "label4";
            label4.Size = new Size(11, 16);
            label4.TabIndex = 12;
            label4.Text = ":";
            // 
            // save_Button
            // 
            save_Button.BackColor = Color.Linen;
            save_Button.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            save_Button.ForeColor = Color.Green;
            save_Button.Location = new Point(133, 178);
            save_Button.Name = "save_Button";
            save_Button.Size = new Size(75, 23);
            save_Button.TabIndex = 13;
            save_Button.Text = "SAVE";
            save_Button.UseVisualStyleBackColor = false;
            save_Button.Click += save_Button_Click;
            // 
            // Volume_TB
            // 
            Volume_TB.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            Volume_TB.ForeColor = Color.Green;
            Volume_TB.Location = new Point(103, 96);
            Volume_TB.MaxLength = 2;
            Volume_TB.Name = "Volume_TB";
            Volume_TB.Size = new Size(57, 23);
            Volume_TB.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(14, 103);
            label3.Name = "label3";
            label3.Size = new Size(56, 16);
            label3.TabIndex = 14;
            label3.Text = "Volume";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label6.ForeColor = Color.Green;
            label6.Location = new Point(166, 99);
            label6.Name = "label6";
            label6.Size = new Size(18, 16);
            label6.TabIndex = 16;
            label6.Text = "%";
            // 
            // ImagePath_TB
            // 
            ImagePath_TB.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            ImagePath_TB.ForeColor = Color.Green;
            ImagePath_TB.Location = new Point(103, 139);
            ImagePath_TB.Name = "ImagePath_TB";
            ImagePath_TB.Size = new Size(204, 23);
            ImagePath_TB.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label7.ForeColor = Color.Green;
            label7.Location = new Point(14, 142);
            label7.Name = "label7";
            label7.Size = new Size(83, 16);
            label7.TabIndex = 17;
            label7.Text = "Image path";
            // 
            // UserCfg_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(328, 210);
            Controls.Add(ImagePath_TB);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(Volume_TB);
            Controls.Add(label3);
            Controls.Add(save_Button);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(seconds_TB);
            Controls.Add(hours_TB);
            Controls.Add(minutes_TB);
            Controls.Add(label2);
            Controls.Add(path_TB);
            Controls.Add(label1);
            Name = "UserCfg_Form";
            Text = "USER_CFG";
            Load += UserCfg_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox path_TB;
        private Label label2;
        private TextBox minutes_TB;
        private TextBox hours_TB;
        private TextBox seconds_TB;
        private Label label5;
        private Label label4;
        private Button save_Button;
        private TextBox Volume_TB;
        private Label label3;
        private Label label6;
        private TextBox ImagePath_TB;
        private Label label7;
    }
}
