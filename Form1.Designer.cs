namespace ClassmatesRpgBattleSim
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Text = "Classmates RPG Battle Simulator";
            this.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.ForeColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            // Player 1 GroupBox
            this.grpPlayer1 = new System.Windows.Forms.GroupBox();
            this.picPlayer1 = new System.Windows.Forms.PictureBox();
            this.lblPlayer1Health = new System.Windows.Forms.Label();
            this.healthBarPlayer1 = new System.Windows.Forms.ProgressBar();
            this.cmbPlayer1Type = new System.Windows.Forms.ComboBox();
            this.txtPlayer1Name = new System.Windows.Forms.TextBox();
            this.lblPlayer1Name = new System.Windows.Forms.Label();
            this.lblPlayer1Type = new System.Windows.Forms.Label();

            this.grpPlayer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1)).BeginInit();
            this.SuspendLayout();

            // grpPlayer1
            this.grpPlayer1.Controls.Add(this.picPlayer1);
            this.grpPlayer1.Controls.Add(this.lblPlayer1Health);
            this.grpPlayer1.Controls.Add(this.healthBarPlayer1);
            this.grpPlayer1.Controls.Add(this.cmbPlayer1Type);
            this.grpPlayer1.Controls.Add(this.txtPlayer1Name);
            this.grpPlayer1.Controls.Add(this.lblPlayer1Name);
            this.grpPlayer1.Controls.Add(this.lblPlayer1Type);
            this.grpPlayer1.ForeColor = System.Drawing.Color.White;
            this.grpPlayer1.Location = new System.Drawing.Point(20, 20);
            this.grpPlayer1.Name = "grpPlayer1";
            this.grpPlayer1.Size = new System.Drawing.Size(350, 220);
            this.grpPlayer1.TabIndex = 0;
            this.grpPlayer1.TabStop = false;
            this.grpPlayer1.Text = "Player 1";

            // picPlayer1
            this.picPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPlayer1.Location = new System.Drawing.Point(20, 25);
            this.picPlayer1.Name = "picPlayer1";
            this.picPlayer1.Size = new System.Drawing.Size(100, 100);
            this.picPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer1.TabIndex = 6;
            this.picPlayer1.TabStop = false;
            // You can set a default image here, e.g., this.picPlayer1.Image = Properties.Resources.DefaultImage;


            // lblPlayer1Name
            this.lblPlayer1Name.AutoSize = true;
            this.lblPlayer1Name.Location = new System.Drawing.Point(130, 25);
            this.lblPlayer1Name.Name = "lblPlayer1Name";
            this.lblPlayer1Name.Size = new System.Drawing.Size(42, 15);
            this.lblPlayer1Name.TabIndex = 0;
            this.lblPlayer1Name.Text = "Name:";

            // txtPlayer1Name
            this.txtPlayer1Name.BackColor = System.Drawing.Color.FromArgb(60, 60, 63);
            this.txtPlayer1Name.ForeColor = System.Drawing.Color.White;
            this.txtPlayer1Name.Location = new System.Drawing.Point(180, 22);
            this.txtPlayer1Name.Name = "txtPlayer1Name";
            this.txtPlayer1Name.Size = new System.Drawing.Size(150, 23);
            this.txtPlayer1Name.TabIndex = 1;

            // lblPlayer1Type
            this.lblPlayer1Type.AutoSize = true;
            this.lblPlayer1Type.Location = new System.Drawing.Point(130, 65);
            this.lblPlayer1Type.Name = "lblPlayer1Type";
            this.lblPlayer1Type.Size = new System.Drawing.Size(34, 15);
            this.lblPlayer1Type.TabIndex = 2;
            this.lblPlayer1Type.Text = "Type:";

            // cmbPlayer1Type
            this.cmbPlayer1Type.BackColor = System.Drawing.Color.FromArgb(60, 60, 63);
            this.cmbPlayer1Type.ForeColor = System.Drawing.Color.White;
            this.cmbPlayer1Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlayer1Type.FormattingEnabled = true;
            this.cmbPlayer1Type.Items.AddRange(new object[] {
            "CodeCrusher",
            "QuizMaster"});
            this.cmbPlayer1Type.Location = new System.Drawing.Point(180, 62);
            this.cmbPlayer1Type.Name = "cmbPlayer1Type";
            this.cmbPlayer1Type.Size = new System.Drawing.Size(150, 23);
            this.cmbPlayer1Type.TabIndex = 3;

            // healthBarPlayer1
            this.healthBarPlayer1.Location = new System.Drawing.Point(20, 140);
            this.healthBarPlayer1.Name = "healthBarPlayer1";
            this.healthBarPlayer1.Size = new System.Drawing.Size(310, 23);
            this.healthBarPlayer1.TabIndex = 4;

            // lblPlayer1Health
            this.lblPlayer1Health.AutoSize = true;
            this.lblPlayer1Health.Location = new System.Drawing.Point(20, 170);
            this.lblPlayer1Health.Name = "lblPlayer1Health";
            this.lblPlayer1Health.Size = new System.Drawing.Size(72, 15);
            this.lblPlayer1Health.TabIndex = 5;
            this.lblPlayer1Health.Text = "Health: 100";


            // Player 2 GroupBox
            this.grpPlayer2 = new System.Windows.Forms.GroupBox();
            this.picPlayer2 = new System.Windows.Forms.PictureBox();
            this.lblPlayer2Health = new System.Windows.Forms.Label();
            this.healthBarPlayer2 = new System.Windows.Forms.ProgressBar();
            this.cmbPlayer2Type = new System.Windows.Forms.ComboBox();
            this.txtPlayer2Name = new System.Windows.Forms.TextBox();
            this.lblPlayer2Name = new System.Windows.Forms.Label();
            this.lblPlayer2Type = new System.Windows.Forms.Label();

            this.grpPlayer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).BeginInit();
            this.SuspendLayout();

            // grpPlayer2
            this.grpPlayer2.Controls.Add(this.picPlayer2);
            this.grpPlayer2.Controls.Add(this.lblPlayer2Health);
            this.grpPlayer2.Controls.Add(this.healthBarPlayer2);
            this.grpPlayer2.Controls.Add(this.cmbPlayer2Type);
            this.grpPlayer2.Controls.Add(this.txtPlayer2Name);
            this.grpPlayer2.Controls.Add(this.lblPlayer2Name);
            this.grpPlayer2.Controls.Add(this.lblPlayer2Type);
            this.grpPlayer2.ForeColor = System.Drawing.Color.White;
            this.grpPlayer2.Location = new System.Drawing.Point(430, 20);
            this.grpPlayer2.Name = "grpPlayer2";
            this.grpPlayer2.Size = new System.Drawing.Size(350, 220);
            this.grpPlayer2.TabIndex = 1;
            this.grpPlayer2.TabStop = false;
            this.grpPlayer2.Text = "Player 2";

            // picPlayer2
            this.picPlayer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPlayer2.Location = new System.Drawing.Point(20, 25);
            this.picPlayer2.Name = "picPlayer2";
            this.picPlayer2.Size = new System.Drawing.Size(100, 100);
            this.picPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer2.TabIndex = 7;
            this.picPlayer2.TabStop = false;

            // lblPlayer2Name
            this.lblPlayer2Name.AutoSize = true;
            this.lblPlayer2Name.Location = new System.Drawing.Point(130, 25);
            this.lblPlayer2Name.Name = "lblPlayer2Name";
            this.lblPlayer2Name.Size = new System.Drawing.Size(42, 15);
            this.lblPlayer2Name.TabIndex = 0;
            this.lblPlayer2Name.Text = "Name:";

            // txtPlayer2Name
            this.txtPlayer2Name.BackColor = System.Drawing.Color.FromArgb(60, 60, 63);
            this.txtPlayer2Name.ForeColor = System.Drawing.Color.White;
            this.txtPlayer2Name.Location = new System.Drawing.Point(180, 22);
            this.txtPlayer2Name.Name = "txtPlayer2Name";
            this.txtPlayer2Name.Size = new System.Drawing.Size(150, 23);
            this.txtPlayer2Name.TabIndex = 1;

            // lblPlayer2Type
            this.lblPlayer2Type.AutoSize = true;
            this.lblPlayer2Type.Location = new System.Drawing.Point(130, 65);
            this.lblPlayer2Type.Name = "lblPlayer2Type";
            this.lblPlayer2Type.Size = new System.Drawing.Size(34, 15);
            this.lblPlayer2Type.TabIndex = 2;
            this.lblPlayer2Type.Text = "Type:";

            // cmbPlayer2Type
            this.cmbPlayer2Type.BackColor = System.Drawing.Color.FromArgb(60, 60, 63);
            this.cmbPlayer2Type.ForeColor = System.Drawing.Color.White;
            this.cmbPlayer2Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlayer2Type.FormattingEnabled = true;
            this.cmbPlayer2Type.Items.AddRange(new object[] {
            "CodeCrusher",
            "QuizMaster"});
            this.cmbPlayer2Type.Location = new System.Drawing.Point(180, 62);
            this.cmbPlayer2Type.Name = "cmbPlayer2Type";
            this.cmbPlayer2Type.Size = new System.Drawing.Size(150, 23);
            this.cmbPlayer2Type.TabIndex = 3;

            // healthBarPlayer2
            this.healthBarPlayer2.Location = new System.Drawing.Point(20, 140);
            this.healthBarPlayer2.Name = "healthBarPlayer2";
            this.healthBarPlayer2.Size = new System.Drawing.Size(310, 23);
            this.healthBarPlayer2.TabIndex = 4;

            // lblPlayer2Health
            this.lblPlayer2Health.AutoSize = true;
            this.lblPlayer2Health.Location = new System.Drawing.Point(20, 170);
            this.lblPlayer2Health.Name = "lblPlayer2Health";
            this.lblPlayer2Health.Size = new System.Drawing.Size(72, 15);
            this.lblPlayer2Health.TabIndex = 5;
            this.lblPlayer2Health.Text = "Health: 100";

            // btnStartBattle
            this.btnStartBattle = new System.Windows.Forms.Button();
            this.btnStartBattle.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnStartBattle.FlatAppearance.BorderSize = 0;
            this.btnStartBattle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartBattle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnStartBattle.Location = new System.Drawing.Point(325, 250);
            this.btnStartBattle.Name = "btnStartBattle";
            this.btnStartBattle.Size = new System.Drawing.Size(150, 40);
            this.btnStartBattle.TabIndex = 2;
            this.btnStartBattle.Text = "Start Battle";
            this.btnStartBattle.UseVisualStyleBackColor = false;
            this.btnStartBattle.Click += new System.EventHandler(this.BtnStartBattle_Click);


            // txtBattleLog
            this.txtBattleLog = new System.Windows.Forms.TextBox();
            this.txtBattleLog.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.txtBattleLog.ForeColor = System.Drawing.Color.FromArgb(0, 255, 136); // Greenish text
            this.txtBattleLog.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.txtBattleLog.Location = new System.Drawing.Point(20, 300);
            this.txtBattleLog.Multiline = true;
            this.txtBattleLog.Name = "txtBattleLog";
            this.txtBattleLog.ReadOnly = true;
            this.txtBattleLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBattleLog.Size = new System.Drawing.Size(760, 280);
            this.txtBattleLog.TabIndex = 3;


            // Form1
            this.Controls.Add(this.grpPlayer1);
            this.Controls.Add(this.grpPlayer2);
            this.Controls.Add(this.btnStartBattle);
            this.Controls.Add(this.txtBattleLog);
            this.Name = "Form1";

            this.grpPlayer1.ResumeLayout(false);
            this.grpPlayer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1)).EndInit();
            this.grpPlayer2.ResumeLayout(false);
            this.grpPlayer2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpPlayer1;
        private System.Windows.Forms.PictureBox picPlayer1;
        private System.Windows.Forms.Label lblPlayer1Health;
        private System.Windows.Forms.ProgressBar healthBarPlayer1;
        private System.Windows.Forms.ComboBox cmbPlayer1Type;
        private System.Windows.Forms.TextBox txtPlayer1Name;
        private System.Windows.Forms.Label lblPlayer1Name;
        private System.Windows.Forms.Label lblPlayer1Type;

        private System.Windows.Forms.GroupBox grpPlayer2;
        private System.Windows.Forms.PictureBox picPlayer2;
        private System.Windows.Forms.Label lblPlayer2Health;
        private System.Windows.Forms.ProgressBar healthBarPlayer2;
        private System.Windows.Forms.ComboBox cmbPlayer2Type;
        private System.Windows.Forms.TextBox txtPlayer2Name;
        private System.Windows.Forms.Label lblPlayer2Name;
        private System.Windows.Forms.Label lblPlayer2Type;

        private System.Windows.Forms.Button btnStartBattle;
        private System.Windows.Forms.TextBox txtBattleLog;
    }
}