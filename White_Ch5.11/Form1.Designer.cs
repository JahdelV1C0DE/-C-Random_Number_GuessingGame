namespace White_Ch5._11
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
            GuessBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            GenerateBtn = new Button();
            UserGuessBox = new TextBox();
            button2 = new Button();
            RevealBtn = new Button();
            label3 = new Label();
            RevealLbl = new Label();
            SuspendLayout();
            // 
            // GuessBtn
            // 
            GuessBtn.Location = new Point(128, 278);
            GuessBtn.Margin = new Padding(2);
            GuessBtn.Name = "GuessBtn";
            GuessBtn.Size = new Size(93, 38);
            GuessBtn.TabIndex = 0;
            GuessBtn.Text = "Submit Guess";
            GuessBtn.UseVisualStyleBackColor = true;
            GuessBtn.Click += GuessBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 88);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(602, 15);
            label1.TabIndex = 2;
            label1.Text = "Generate Your Number By Pressing the \"Generate\" Button and Submit Your Guess (1-100) Using the Button Below\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(253, 49);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(244, 21);
            label2.TabIndex = 4;
            label2.Text = "Random Number Guessing Game";
            // 
            // GenerateBtn
            // 
            GenerateBtn.Location = new Point(344, 137);
            GenerateBtn.Margin = new Padding(2);
            GenerateBtn.Name = "GenerateBtn";
            GenerateBtn.Size = new Size(93, 38);
            GenerateBtn.TabIndex = 5;
            GenerateBtn.Text = "Generate Number";
            GenerateBtn.UseVisualStyleBackColor = true;
            GenerateBtn.Click += GenerateBtn_Click;
            // 
            // UserGuessBox
            // 
            UserGuessBox.Location = new Point(332, 209);
            UserGuessBox.Margin = new Padding(2);
            UserGuessBox.Name = "UserGuessBox";
            UserGuessBox.Size = new Size(106, 23);
            UserGuessBox.TabIndex = 6;
            UserGuessBox.KeyPress += UserGuessBox_KeyPress;
            // 
            // button2
            // 
            button2.Location = new Point(582, 278);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(93, 38);
            button2.TabIndex = 7;
            button2.Text = "Exit Game";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // RevealBtn
            // 
            RevealBtn.Location = new Point(344, 278);
            RevealBtn.Margin = new Padding(2);
            RevealBtn.Name = "RevealBtn";
            RevealBtn.Size = new Size(93, 38);
            RevealBtn.TabIndex = 8;
            RevealBtn.Text = "Reveal/Give Up";
            RevealBtn.UseVisualStyleBackColor = true;
            RevealBtn.Click += RevealBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(253, 348);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 30);
            label3.TabIndex = 9;
            label3.Text = "Revealed Number: \r\n\r\n";
            // 
            // RevealLbl
            // 
            RevealLbl.AutoSize = true;
            RevealLbl.Location = new Point(370, 348);
            RevealLbl.Margin = new Padding(2, 0, 2, 0);
            RevealLbl.Name = "RevealLbl";
            RevealLbl.Size = new Size(14, 15);
            RevealLbl.TabIndex = 10;
            RevealLbl.Text = "#";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 406);
            Controls.Add(RevealLbl);
            Controls.Add(label3);
            Controls.Add(RevealBtn);
            Controls.Add(button2);
            Controls.Add(UserGuessBox);
            Controls.Add(GenerateBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(GuessBtn);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Random Number Generator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GuessBtn;
        private Label label1;
        private Label label2;
        private Button GenerateBtn;
        private TextBox UserGuessBox;
        private Button button2;
        private Button RevealBtn;
        private Label label3;
        private Label RevealLbl;
    }
}
