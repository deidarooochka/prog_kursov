namespace prog_kursov
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textPlayerName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listRecords = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.btnEasy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSelectedDifficulty = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SeaShell;
            this.label1.Font = new System.Drawing.Font("ARCO", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(186, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Найди пару";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SeaShell;
            this.label2.Font = new System.Drawing.Font("Bebas Neue Cyrillic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(232, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Добро пожаловать в игру";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.Font = new System.Drawing.Font("Bebas Neue Cyrillic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(217, 343);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 89);
            this.button1.TabIndex = 2;
            this.button1.Text = "НАЧАТЬ ИГРУ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightPink;
            this.button2.Font = new System.Drawing.Font("Bebas Neue Cyrillic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(217, 450);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(271, 56);
            this.button2.TabIndex = 3;
            this.button2.Text = "ВЫЙТИ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // textPlayerName
            // 
            this.textPlayerName.BackColor = System.Drawing.SystemColors.Window;
            this.textPlayerName.Font = new System.Drawing.Font("Bebas Neue Cyrillic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textPlayerName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textPlayerName.Location = new System.Drawing.Point(217, 164);
            this.textPlayerName.Margin = new System.Windows.Forms.Padding(2);
            this.textPlayerName.Multiline = true;
            this.textPlayerName.Name = "textPlayerName";
            this.textPlayerName.Size = new System.Drawing.Size(271, 30);
            this.textPlayerName.TabIndex = 4;
            this.textPlayerName.Text = "Игрок";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.SeaShell;
            this.labelName.Font = new System.Drawing.Font("Bebas Neue Cyrillic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.ForeColor = System.Drawing.Color.IndianRed;
            this.labelName.Location = new System.Drawing.Point(212, 135);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(166, 27);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Введите своё имя:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SeaShell;
            this.label4.Font = new System.Drawing.Font("Bebas Neue Cyrillic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(24, 343);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "РЕЙТИНГ ТОП-5 ИГРОКОВ";
            // 
            // listRecords
            // 
            this.listRecords.Font = new System.Drawing.Font("Bebas Neue Cyrillic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listRecords.FormattingEnabled = true;
            this.listRecords.ItemHeight = 19;
            this.listRecords.Location = new System.Drawing.Point(28, 369);
            this.listRecords.Margin = new System.Windows.Forms.Padding(2);
            this.listRecords.Name = "listRecords";
            this.listRecords.Size = new System.Drawing.Size(165, 137);
            this.listRecords.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.btnMedium);
            this.panel1.Controls.Add(this.btnHard);
            this.panel1.Controls.Add(this.btnEasy);
            this.panel1.Location = new System.Drawing.Point(217, 231);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 93);
            this.panel1.TabIndex = 8;
            // 
            // btnMedium
            // 
            this.btnMedium.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMedium.BackColor = System.Drawing.Color.White;
            this.btnMedium.Location = new System.Drawing.Point(105, 20);
            this.btnMedium.Margin = new System.Windows.Forms.Padding(2);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(56, 57);
            this.btnMedium.TabIndex = 2;
            this.btnMedium.Text = "4x5";
            this.btnMedium.UseVisualStyleBackColor = false;
            // 
            // btnHard
            // 
            this.btnHard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHard.BackColor = System.Drawing.Color.White;
            this.btnHard.Location = new System.Drawing.Point(187, 20);
            this.btnHard.Margin = new System.Windows.Forms.Padding(2);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(56, 57);
            this.btnHard.TabIndex = 1;
            this.btnHard.Text = "5x6";
            this.btnHard.UseVisualStyleBackColor = false;
            // 
            // btnEasy
            // 
            this.btnEasy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEasy.BackColor = System.Drawing.Color.White;
            this.btnEasy.Location = new System.Drawing.Point(21, 20);
            this.btnEasy.Margin = new System.Windows.Forms.Padding(2);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(56, 57);
            this.btnEasy.TabIndex = 0;
            this.btnEasy.Text = "4x4";
            this.btnEasy.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SeaShell;
            this.label3.Font = new System.Drawing.Font("Bebas Neue Cyrillic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(217, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Выберите сложность:";
            // 
            // lblSelectedDifficulty
            // 
            this.lblSelectedDifficulty.AutoSize = true;
            this.lblSelectedDifficulty.BackColor = System.Drawing.Color.SeaShell;
            this.lblSelectedDifficulty.Font = new System.Drawing.Font("Bebas Neue Cyrillic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSelectedDifficulty.ForeColor = System.Drawing.Color.IndianRed;
            this.lblSelectedDifficulty.Location = new System.Drawing.Point(385, 205);
            this.lblSelectedDifficulty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectedDifficulty.Name = "lblSelectedDifficulty";
            this.lblSelectedDifficulty.Size = new System.Drawing.Size(68, 24);
            this.lblSelectedDifficulty.TabIndex = 10;
            this.lblSelectedDifficulty.Text = "простая";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.listRecords);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textPlayerName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSelectedDifficulty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuForm";
            this.Text = "Найди пару";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textPlayerName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listRecords;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSelectedDifficulty;
        private System.Windows.Forms.Label label1;
    }
}