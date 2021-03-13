
namespace SE_Garage
{
    partial class GamingForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.question1Label = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.question2Label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Ebrima", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(186, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(393, 47);
            this.titleLabel.TabIndex = 7;
            this.titleLabel.Text = "SE GARAGE - GAMING";
            // 
            // question1Label
            // 
            this.question1Label.AutoSize = true;
            this.question1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question1Label.Location = new System.Drawing.Point(36, 154);
            this.question1Label.Name = "question1Label";
            this.question1Label.Size = new System.Drawing.Size(223, 24);
            this.question1Label.TabIndex = 8;
            this.question1Label.Text = "Ce jocuri ati dori sa rulati?";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Items.AddRange(new object[] {
            "Grand Theft Auto V",
            "Minecraft",
            "Fortnite",
            "League of Legends",
            "Counter-Strike: Global Offensive",
            "PlayerUnknown\'s Battlegrounds 2017",
            "Apex Legends",
            "Overwatch",
            "Rocket League",
            "Cyberpunk 2077",
            "Call of Duty: Modern Warfare 2019",
            "The Witcher 3: Wild Hunt 2015",
            "Terraria",
            "Borderlands 3",
            "Star Wars Battlefront II 2017"});
            this.listBox1.Location = new System.Drawing.Point(298, 91);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(298, 184);
            this.listBox1.TabIndex = 9;
            // 
            // question2Label
            // 
            this.question2Label.AutoSize = true;
            this.question2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question2Label.Location = new System.Drawing.Point(36, 331);
            this.question2Label.Name = "question2Label";
            this.question2Label.Size = new System.Drawing.Size(263, 24);
            this.question2Label.TabIndex = 10;
            this.question2Label.Text = "Cat de bine sa ruleze jocurile?";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(632, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 42);
            this.button1.TabIndex = 11;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Decent",
            "Bine",
            "Foarte bine"});
            this.comboBox1.Location = new System.Drawing.Point(363, 331);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 28);
            this.comboBox1.TabIndex = 12;
            // 
            // GamingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 459);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.question2Label);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.question1Label);
            this.Controls.Add(this.titleLabel);
            this.Name = "GamingForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label question1Label;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label question2Label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}