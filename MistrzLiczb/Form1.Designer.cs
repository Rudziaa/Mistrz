namespace MistrzLiczb
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.tableBtn = new System.Windows.Forms.Button();
            this.newGameBtn = new System.Windows.Forms.Button();
            this.selectNameBtn = new System.Windows.Forms.Button();
            this.nameMenu = new System.Windows.Forms.Panel();
            this.nameBtn = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableMenu = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.tableLabel = new System.Windows.Forms.Label();
            this.diffMenu = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backBtn2 = new System.Windows.Forms.Button();
            this.hardBtn = new System.Windows.Forms.Button();
            this.medBtn = new System.Windows.Forms.Button();
            this.easyBtn = new System.Windows.Forms.Button();
            this.gameMenu = new System.Windows.Forms.Panel();
            this.punktyLabel = new System.Windows.Forms.Label();
            this.startkoniec = new System.Windows.Forms.Button();
            this.czasLabel = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Button();
            this.dzialanieLabel = new System.Windows.Forms.Label();
            this.wynik = new System.Windows.Forms.TextBox();
            this.scoreMenu = new System.Windows.Forms.Panel();
            this.historyBox = new System.Windows.Forms.ListBox();
            this.backMainMenu = new System.Windows.Forms.Button();
            this.mainMenu.SuspendLayout();
            this.nameMenu.SuspendLayout();
            this.tableMenu.SuspendLayout();
            this.diffMenu.SuspendLayout();
            this.gameMenu.SuspendLayout();
            this.scoreMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Controls.Add(this.label2);
            this.mainMenu.Controls.Add(this.exitBtn);
            this.mainMenu.Controls.Add(this.tableBtn);
            this.mainMenu.Controls.Add(this.newGameBtn);
            this.mainMenu.Controls.Add(this.selectNameBtn);
            this.mainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(367, 300);
            this.mainMenu.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Witaj Gracz w Mistrzu Liczb!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(68, 220);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(209, 36);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Zakończ";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // tableBtn
            // 
            this.tableBtn.Location = new System.Drawing.Point(68, 160);
            this.tableBtn.Name = "tableBtn";
            this.tableBtn.Size = new System.Drawing.Size(209, 36);
            this.tableBtn.TabIndex = 2;
            this.tableBtn.Text = "Tabela wyników";
            this.tableBtn.UseVisualStyleBackColor = true;
            this.tableBtn.Click += new System.EventHandler(this.tableBtn_Click);
            // 
            // newGameBtn
            // 
            this.newGameBtn.Location = new System.Drawing.Point(68, 100);
            this.newGameBtn.Name = "newGameBtn";
            this.newGameBtn.Size = new System.Drawing.Size(209, 36);
            this.newGameBtn.TabIndex = 1;
            this.newGameBtn.Text = "Nowa gra";
            this.newGameBtn.UseVisualStyleBackColor = true;
            this.newGameBtn.Click += new System.EventHandler(this.newGameBtn_Click);
            // 
            // selectNameBtn
            // 
            this.selectNameBtn.Location = new System.Drawing.Point(68, 40);
            this.selectNameBtn.Name = "selectNameBtn";
            this.selectNameBtn.Size = new System.Drawing.Size(209, 36);
            this.selectNameBtn.TabIndex = 0;
            this.selectNameBtn.Text = "Wybierz nazwę użytkownika";
            this.selectNameBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.selectNameBtn.UseVisualStyleBackColor = true;
            this.selectNameBtn.Click += new System.EventHandler(this.selectNameBtn_Click);
            // 
            // nameMenu
            // 
            this.nameMenu.Controls.Add(this.nameBtn);
            this.nameMenu.Controls.Add(this.nameBox);
            this.nameMenu.Controls.Add(this.label1);
            this.nameMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameMenu.Location = new System.Drawing.Point(0, 0);
            this.nameMenu.Name = "nameMenu";
            this.nameMenu.Size = new System.Drawing.Size(367, 300);
            this.nameMenu.TabIndex = 1;
            // 
            // nameBtn
            // 
            this.nameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameBtn.Location = new System.Drawing.Point(71, 126);
            this.nameBtn.Name = "nameBtn";
            this.nameBtn.Size = new System.Drawing.Size(187, 36);
            this.nameBtn.TabIndex = 2;
            this.nameBtn.Text = "Zatwierdz";
            this.nameBtn.UseVisualStyleBackColor = true;
            this.nameBtn.Click += new System.EventHandler(this.nameBtn_Click);
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameBox.Location = new System.Drawing.Point(71, 65);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(187, 30);
            this.nameBox.TabIndex = 1;
            this.nameBox.Text = "Gracz";
            this.nameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wprowadź nazwe użytkownika:";
            // 
            // tableMenu
            // 
            this.tableMenu.Controls.Add(this.button3);
            this.tableMenu.Controls.Add(this.backBtn);
            this.tableMenu.Controls.Add(this.tableLabel);
            this.tableMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMenu.Location = new System.Drawing.Point(0, 0);
            this.tableMenu.Name = "tableMenu";
            this.tableMenu.Size = new System.Drawing.Size(367, 300);
            this.tableMenu.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(182, 252);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 36);
            this.button3.TabIndex = 2;
            this.button3.Text = "Zmień strone";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(10, 252);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(165, 36);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "Wróć";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // tableLabel
            // 
            this.tableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tableLabel.Location = new System.Drawing.Point(9, 10);
            this.tableLabel.Name = "tableLabel";
            this.tableLabel.Size = new System.Drawing.Size(314, 220);
            this.tableLabel.TabIndex = 0;
            this.tableLabel.Text = "1.\r\n2.\r\n3.\r\n4.\r\n5.\r\n6.\r\n7.\r\n8.\r\n9.\r\n10.";
            this.tableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // diffMenu
            // 
            this.diffMenu.Controls.Add(this.label5);
            this.diffMenu.Controls.Add(this.label4);
            this.diffMenu.Controls.Add(this.label3);
            this.diffMenu.Controls.Add(this.backBtn2);
            this.diffMenu.Controls.Add(this.hardBtn);
            this.diffMenu.Controls.Add(this.medBtn);
            this.diffMenu.Controls.Add(this.easyBtn);
            this.diffMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diffMenu.Location = new System.Drawing.Point(0, 0);
            this.diffMenu.Name = "diffMenu";
            this.diffMenu.Size = new System.Drawing.Size(367, 300);
            this.diffMenu.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "-dodawanie i odejmowanie (zakres liczb 1-250) \r\n-mnożenie i dzielenie (zakres lic" +
    "zb 1-150)\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "-dodawanie i odejmowanie (zakres liczb 1-200) \r\n-mnożenie i dzielenie (zakres lic" +
    "zb 1-100)\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "-dodawanie i odejmowanie (zakres liczb 1-100) \r\n-mnożenie i dzielenie (zakres lic" +
    "zb 1-20)\r\n";
            // 
            // backBtn2
            // 
            this.backBtn2.Location = new System.Drawing.Point(115, 265);
            this.backBtn2.Name = "backBtn2";
            this.backBtn2.Size = new System.Drawing.Size(108, 23);
            this.backBtn2.TabIndex = 3;
            this.backBtn2.Text = "Wróć";
            this.backBtn2.UseVisualStyleBackColor = true;
            this.backBtn2.Click += new System.EventHandler(this.backBtn2_Click);
            // 
            // hardBtn
            // 
            this.hardBtn.Location = new System.Drawing.Point(115, 173);
            this.hardBtn.Name = "hardBtn";
            this.hardBtn.Size = new System.Drawing.Size(108, 23);
            this.hardBtn.TabIndex = 2;
            this.hardBtn.Text = "Trudny";
            this.hardBtn.UseVisualStyleBackColor = true;
            this.hardBtn.Click += new System.EventHandler(this.hardBtn_Click);
            // 
            // medBtn
            // 
            this.medBtn.Location = new System.Drawing.Point(115, 97);
            this.medBtn.Name = "medBtn";
            this.medBtn.Size = new System.Drawing.Size(108, 23);
            this.medBtn.TabIndex = 1;
            this.medBtn.Text = "Średni";
            this.medBtn.UseVisualStyleBackColor = true;
            this.medBtn.Click += new System.EventHandler(this.medBtn_Click);
            // 
            // easyBtn
            // 
            this.easyBtn.Location = new System.Drawing.Point(115, 23);
            this.easyBtn.Name = "easyBtn";
            this.easyBtn.Size = new System.Drawing.Size(108, 24);
            this.easyBtn.TabIndex = 0;
            this.easyBtn.Text = "Łatwy";
            this.easyBtn.UseVisualStyleBackColor = true;
            this.easyBtn.Click += new System.EventHandler(this.easyBtn_Click);
            // 
            // gameMenu
            // 
            this.gameMenu.Controls.Add(this.punktyLabel);
            this.gameMenu.Controls.Add(this.startkoniec);
            this.gameMenu.Controls.Add(this.czasLabel);
            this.gameMenu.Controls.Add(this.next);
            this.gameMenu.Controls.Add(this.dzialanieLabel);
            this.gameMenu.Controls.Add(this.wynik);
            this.gameMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameMenu.Location = new System.Drawing.Point(0, 0);
            this.gameMenu.Name = "gameMenu";
            this.gameMenu.Size = new System.Drawing.Size(367, 300);
            this.gameMenu.TabIndex = 7;
            // 
            // punktyLabel
            // 
            this.punktyLabel.AutoSize = true;
            this.punktyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.punktyLabel.Location = new System.Drawing.Point(23, 126);
            this.punktyLabel.Name = "punktyLabel";
            this.punktyLabel.Size = new System.Drawing.Size(131, 18);
            this.punktyLabel.TabIndex = 5;
            this.punktyLabel.Text = "Aktualne punkty:  0";
            // 
            // startkoniec
            // 
            this.startkoniec.Location = new System.Drawing.Point(215, 165);
            this.startkoniec.Name = "startkoniec";
            this.startkoniec.Size = new System.Drawing.Size(105, 49);
            this.startkoniec.TabIndex = 4;
            this.startkoniec.Text = "START";
            this.startkoniec.UseVisualStyleBackColor = true;
            this.startkoniec.Click += new System.EventHandler(this.startkoniec_Click);
            // 
            // czasLabel
            // 
            this.czasLabel.AutoSize = true;
            this.czasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.czasLabel.Location = new System.Drawing.Point(123, 13);
            this.czasLabel.Name = "czasLabel";
            this.czasLabel.Size = new System.Drawing.Size(100, 24);
            this.czasLabel.TabIndex = 3;
            this.czasLabel.Text = "Czas: 120s";
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(251, 79);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 2;
            this.next.Text = "Dalej";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // dzialanieLabel
            // 
            this.dzialanieLabel.AutoSize = true;
            this.dzialanieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dzialanieLabel.Location = new System.Drawing.Point(23, 50);
            this.dzialanieLabel.Name = "dzialanieLabel";
            this.dzialanieLabel.Size = new System.Drawing.Size(152, 18);
            this.dzialanieLabel.TabIndex = 1;
            this.dzialanieLabel.Text = "Podaj wynik działania:";
            // 
            // wynik
            // 
            this.wynik.Enabled = false;
            this.wynik.Location = new System.Drawing.Point(26, 79);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(219, 20);
            this.wynik.TabIndex = 0;
            // 
            // scoreMenu
            // 
            this.scoreMenu.Controls.Add(this.backMainMenu);
            this.scoreMenu.Controls.Add(this.historyBox);
            this.scoreMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreMenu.Location = new System.Drawing.Point(0, 0);
            this.scoreMenu.Name = "scoreMenu";
            this.scoreMenu.Size = new System.Drawing.Size(367, 300);
            this.scoreMenu.TabIndex = 6;
            // 
            // historyBox
            // 
            this.historyBox.FormattingEnabled = true;
            this.historyBox.Location = new System.Drawing.Point(13, 13);
            this.historyBox.Name = "historyBox";
            this.historyBox.Size = new System.Drawing.Size(342, 212);
            this.historyBox.TabIndex = 0;
            // 
            // backMainMenu
            // 
            this.backMainMenu.Location = new System.Drawing.Point(245, 236);
            this.backMainMenu.Name = "backMainMenu";
            this.backMainMenu.Size = new System.Drawing.Size(110, 30);
            this.backMainMenu.TabIndex = 1;
            this.backMainMenu.Text = "Menu główne";
            this.backMainMenu.UseVisualStyleBackColor = true;
            this.backMainMenu.Click += new System.EventHandler(this.backMainMenu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 300);
            this.Controls.Add(this.scoreMenu);
            this.Controls.Add(this.gameMenu);
            this.Controls.Add(this.tableMenu);
            this.Controls.Add(this.diffMenu);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.nameMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainMenu.ResumeLayout(false);
            this.nameMenu.ResumeLayout(false);
            this.nameMenu.PerformLayout();
            this.tableMenu.ResumeLayout(false);
            this.diffMenu.ResumeLayout(false);
            this.diffMenu.PerformLayout();
            this.gameMenu.ResumeLayout(false);
            this.gameMenu.PerformLayout();
            this.scoreMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainMenu;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button tableBtn;
        private System.Windows.Forms.Button newGameBtn;
        private System.Windows.Forms.Button selectNameBtn;
        private System.Windows.Forms.Panel nameMenu;
        private System.Windows.Forms.Button nameBtn;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel tableMenu;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label tableLabel;
        private System.Windows.Forms.Panel diffMenu;
        private System.Windows.Forms.Button backBtn2;
        private System.Windows.Forms.Button hardBtn;
        private System.Windows.Forms.Button medBtn;
        private System.Windows.Forms.Button easyBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel gameMenu;
        private System.Windows.Forms.Label punktyLabel;
        private System.Windows.Forms.Button startkoniec;
        private System.Windows.Forms.Label czasLabel;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label dzialanieLabel;
        private System.Windows.Forms.TextBox wynik;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel scoreMenu;
        private System.Windows.Forms.Button backMainMenu;
        private System.Windows.Forms.ListBox historyBox;
    }
}

