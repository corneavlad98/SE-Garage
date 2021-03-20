
namespace SE_Garage
{
    partial class MainForm
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
            this.question1Label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.question2Label = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.currency1Label = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.result1Label = new System.Windows.Forms.Label();
            this.result2Label = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.testButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // question1Label
            // 
            this.question1Label.AutoSize = true;
            this.question1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question1Label.Location = new System.Drawing.Point(38, 104);
            this.question1Label.Name = "question1Label";
            this.question1Label.Size = new System.Drawing.Size(168, 24);
            this.question1Label.TabIndex = 0;
            this.question1Label.Text = "Care este bugetul?";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(355, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Ebrima", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(170, 7);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(211, 47);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "SE GARAGE";
            // 
            // question2Label
            // 
            this.question2Label.AutoSize = true;
            this.question2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question2Label.Location = new System.Drawing.Point(38, 188);
            this.question2Label.Name = "question2Label";
            this.question2Label.Size = new System.Drawing.Size(139, 24);
            this.question2Label.TabIndex = 7;
            this.question2Label.Text = "Tipul aplicatiei?";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Office",
            "Gaming",
            "Design"});
            this.comboBox1.Location = new System.Drawing.Point(223, 188);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 28);
            this.comboBox1.TabIndex = 11;
            // 
            // currency1Label
            // 
            this.currency1Label.AutoSize = true;
            this.currency1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currency1Label.Location = new System.Drawing.Point(385, 105);
            this.currency1Label.Name = "currency1Label";
            this.currency1Label.Size = new System.Drawing.Size(29, 24);
            this.currency1Label.TabIndex = 12;
            this.currency1Label.Text = "lei";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(223, 105);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(144, 26);
            this.numericUpDown1.TabIndex = 13;
            // 
            // result1Label
            // 
            this.result1Label.AutoSize = true;
            this.result1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result1Label.Location = new System.Drawing.Point(75, 406);
            this.result1Label.Name = "result1Label";
            this.result1Label.Size = new System.Drawing.Size(69, 24);
            this.result1Label.TabIndex = 14;
            this.result1Label.Text = "(woop)";
            // 
            // result2Label
            // 
            this.result2Label.AutoSize = true;
            this.result2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result2Label.Location = new System.Drawing.Point(396, 406);
            this.result2Label.Name = "result2Label";
            this.result2Label.Size = new System.Drawing.Size(69, 24);
            this.result2Label.TabIndex = 15;
            this.result2Label.Text = "(woop)";
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(79, 301);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(108, 42);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // testButton
            // 
            this.testButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testButton.Location = new System.Drawing.Point(223, 388);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(108, 42);
            this.testButton.TabIndex = 17;
            this.testButton.Text = "TEST";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 475);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.result2Label);
            this.Controls.Add(this.result1Label);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.currency1Label);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.question2Label);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.question1Label);
            this.Name = "MainForm";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label question1Label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label question2Label;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label currency1Label;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label result1Label;
        private System.Windows.Forms.Label result2Label;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button testButton;
    }
}

