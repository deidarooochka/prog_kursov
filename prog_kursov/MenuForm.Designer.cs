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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
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
            this.label1.Location = new System.Drawing.Point(248, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 63);
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
            this.label2.Location = new System.Drawing.Point(309, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Добро пожаловать в игру";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnStart.Font = new System.Drawing.Font("Bebas Neue Cyrillic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(289, 422);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(361, 110);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "НАЧАТЬ ИГРУ";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightPink;
            this.btnExit.Font = new System.Drawing.Font("Bebas Neue Cyrillic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(289, 554);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(361, 69);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "ВЫЙТИ";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // textPlayerName
            // 
            this.textPlayerName.BackColor = System.Drawing.SystemColors.Window;
            this.textPlayerName.Font = new System.Drawing.Font("Bebas Neue Cyrillic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textPlayerName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textPlayerName.Location = new System.Drawing.Point(289, 202);
            this.textPlayerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textPlayerName.Multiline = true;
            this.textPlayerName.Name = "textPlayerName";
            this.textPlayerName.Size = new System.Drawing.Size(360, 36);
            this.textPlayerName.TabIndex = 4;
            this.textPlayerName.Text = "Игрок";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.SeaShell;
            this.labelName.Font = new System.Drawing.Font("Bebas Neue Cyrillic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.ForeColor = System.Drawing.Color.IndianRed;
            this.labelName.Location = new System.Drawing.Point(283, 166);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(203, 33);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Введите своё имя:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SeaShell;
            this.label4.Font = new System.Drawing.Font("Bebas Neue Cyrillic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(32, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "РЕЙТИНГ ТОП-5 ИГРОКОВ";
            // 
            // listRecords
            // 
            this.listRecords.Font = new System.Drawing.Font("Bebas Neue Cyrillic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listRecords.FormattingEnabled = true;
            this.listRecords.ItemHeight = 22;
            this.listRecords.Location = new System.Drawing.Point(37, 454);
            this.listRecords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listRecords.Name = "listRecords";
            this.listRecords.Size = new System.Drawing.Size(219, 158);
            this.listRecords.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.btnMedium);
            this.panel1.Controls.Add(this.btnHard);
            this.panel1.Controls.Add(this.btnEasy);
            this.panel1.Location = new System.Drawing.Point(289, 284);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 114);
            this.panel1.TabIndex = 8;
            // 
            // btnMedium
            // 
            this.btnMedium.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMedium.BackColor = System.Drawing.Color.White;
            this.btnMedium.Location = new System.Drawing.Point(140, 25);
            this.btnMedium.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(75, 70);
            this.btnMedium.TabIndex = 2;
            this.btnMedium.Text = "4x5";
            this.btnMedium.UseVisualStyleBackColor = false;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            // 
            // btnHard
            // 
            this.btnHard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHard.BackColor = System.Drawing.Color.White;
            this.btnHard.Location = new System.Drawing.Point(249, 25);
            this.btnHard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(75, 70);
            this.btnHard.TabIndex = 1;
            this.btnHard.Text = "5x6";
            this.btnHard.UseVisualStyleBackColor = false;
            // 
            // btnEasy
            // 
            this.btnEasy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEasy.BackColor = System.Drawing.Color.White;
            this.btnEasy.Location = new System.Drawing.Point(28, 25);
            this.btnEasy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(75, 70);
            this.btnEasy.TabIndex = 0;
            this.btnEasy.Text = "4x4";
            this.btnEasy.UseVisualStyleBackColor = false;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SeaShell;
            this.label3.Font = new System.Drawing.Font("Bebas Neue Cyrillic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(289, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Выберите сложность:";
            // 
            // lblSelectedDifficulty
            // 
            this.lblSelectedDifficulty.AutoSize = true;
            this.lblSelectedDifficulty.BackColor = System.Drawing.Color.SeaShell;
            this.lblSelectedDifficulty.Font = new System.Drawing.Font("Bebas Neue Cyrillic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSelectedDifficulty.ForeColor = System.Drawing.Color.IndianRed;
            this.lblSelectedDifficulty.Location = new System.Drawing.Point(513, 252);
            this.lblSelectedDifficulty.Name = "lblSelectedDifficulty";
            this.lblSelectedDifficulty.Size = new System.Drawing.Size(90, 31);
            this.lblSelectedDifficulty.TabIndex = 10;
            this.lblSelectedDifficulty.Text = "простая";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(912, 690);
            this.Controls.Add(this.listRecords);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textPlayerName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSelectedDifficulty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuForm";
            this.Text = "Найди пару";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}