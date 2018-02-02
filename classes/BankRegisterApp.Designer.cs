namespace BankRegisterApp
{
    partial class BankRegisterApp
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
            this.acctNameBox = new System.Windows.Forms.TextBox();
            this.acctNameLabel = new System.Windows.Forms.Label();
            this.acctNumberLabel = new System.Windows.Forms.Label();
            this.acctNumBox = new System.Windows.Forms.TextBox();
            this.initBalLabel = new System.Windows.Forms.Label();
            this.iniBalBox = new System.Windows.Forms.TextBox();
            this.createAcctButton = new System.Windows.Forms.Button();
            this.withdrawBox = new System.Windows.Forms.TextBox();
            this.withdrawLabel = new System.Windows.Forms.Label();
            this.depositLabel = new System.Windows.Forms.Label();
            this.depositBox = new System.Windows.Forms.TextBox();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.balanceBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // acctNameBox
            // 
            this.acctNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acctNameBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.acctNameBox.Location = new System.Drawing.Point(21, 51);
            this.acctNameBox.Name = "acctNameBox";
            this.acctNameBox.Size = new System.Drawing.Size(100, 21);
            this.acctNameBox.TabIndex = 1;
            // 
            // acctNameLabel
            // 
            this.acctNameLabel.AutoSize = true;
            this.acctNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acctNameLabel.Location = new System.Drawing.Point(28, 22);
            this.acctNameLabel.Name = "acctNameLabel";
            this.acctNameLabel.Size = new System.Drawing.Size(87, 15);
            this.acctNameLabel.TabIndex = 0;
            this.acctNameLabel.Text = "Account Name";
            // 
            // acctNumberLabel
            // 
            this.acctNumberLabel.AutoSize = true;
            this.acctNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acctNumberLabel.Location = new System.Drawing.Point(182, 22);
            this.acctNumberLabel.Name = "acctNumberLabel";
            this.acctNumberLabel.Size = new System.Drawing.Size(98, 15);
            this.acctNumberLabel.TabIndex = 0;
            this.acctNumberLabel.Text = "Account Number";
            // 
            // acctNumBox
            // 
            this.acctNumBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acctNumBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.acctNumBox.Location = new System.Drawing.Point(181, 51);
            this.acctNumBox.Name = "acctNumBox";
            this.acctNumBox.Size = new System.Drawing.Size(100, 21);
            this.acctNumBox.TabIndex = 2;
            // 
            // initBalLabel
            // 
            this.initBalLabel.AutoSize = true;
            this.initBalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initBalLabel.Location = new System.Drawing.Point(350, 22);
            this.initBalLabel.Name = "initBalLabel";
            this.initBalLabel.Size = new System.Drawing.Size(84, 15);
            this.initBalLabel.TabIndex = 0;
            this.initBalLabel.Text = "Initial Balance";
            // 
            // iniBalBox
            // 
            this.iniBalBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniBalBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.iniBalBox.Location = new System.Drawing.Point(342, 51);
            this.iniBalBox.Name = "iniBalBox";
            this.iniBalBox.Size = new System.Drawing.Size(100, 21);
            this.iniBalBox.TabIndex = 3;
            // 
            // createAcctButton
            // 
            this.createAcctButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAcctButton.Location = new System.Drawing.Point(17, 128);
            this.createAcctButton.Name = "createAcctButton";
            this.createAcctButton.Size = new System.Drawing.Size(109, 34);
            this.createAcctButton.TabIndex = 4;
            this.createAcctButton.Text = "Create Account";
            this.createAcctButton.UseVisualStyleBackColor = true;
            this.createAcctButton.Click += new System.EventHandler(this.createAcctButton_Click);
            // 
            // withdrawBox
            // 
            this.withdrawBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawBox.Location = new System.Drawing.Point(21, 225);
            this.withdrawBox.Name = "withdrawBox";
            this.withdrawBox.Size = new System.Drawing.Size(100, 21);
            this.withdrawBox.TabIndex = 5;
            this.withdrawBox.Visible = false;
            // 
            // withdrawLabel
            // 
            this.withdrawLabel.AutoSize = true;
            this.withdrawLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawLabel.Location = new System.Drawing.Point(42, 196);
            this.withdrawLabel.Name = "withdrawLabel";
            this.withdrawLabel.Size = new System.Drawing.Size(58, 15);
            this.withdrawLabel.TabIndex = 0;
            this.withdrawLabel.Text = "Withdraw";
            this.withdrawLabel.Visible = false;
            // 
            // depositLabel
            // 
            this.depositLabel.AutoSize = true;
            this.depositLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositLabel.Location = new System.Drawing.Point(207, 196);
            this.depositLabel.Name = "depositLabel";
            this.depositLabel.Size = new System.Drawing.Size(49, 15);
            this.depositLabel.TabIndex = 0;
            this.depositLabel.Text = "Deposit";
            this.depositLabel.Visible = false;
            // 
            // depositBox
            // 
            this.depositBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositBox.Location = new System.Drawing.Point(181, 225);
            this.depositBox.Name = "depositBox";
            this.depositBox.Size = new System.Drawing.Size(100, 21);
            this.depositBox.TabIndex = 6;
            this.depositBox.Visible = false;
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLabel.Location = new System.Drawing.Point(366, 196);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(52, 15);
            this.balanceLabel.TabIndex = 0;
            this.balanceLabel.Text = "Balance";
            this.balanceLabel.Visible = false;
            // 
            // balanceBox
            // 
            this.balanceBox.Enabled = false;
            this.balanceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceBox.Location = new System.Drawing.Point(342, 225);
            this.balanceBox.Name = "balanceBox";
            this.balanceBox.Size = new System.Drawing.Size(100, 21);
            this.balanceBox.TabIndex = 7;
            this.balanceBox.Visible = false;
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(344, 128);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(109, 34);
            this.updateButton.TabIndex = 8;
            this.updateButton.Text = "Update Balance";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Visible = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(235, 128);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(109, 34);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Visible = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(126, 128);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(109, 34);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // BankRegisterApp
            // 
            this.AcceptButton = this.createAcctButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 291);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.balanceBox);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.depositBox);
            this.Controls.Add(this.depositLabel);
            this.Controls.Add(this.withdrawLabel);
            this.Controls.Add(this.withdrawBox);
            this.Controls.Add(this.createAcctButton);
            this.Controls.Add(this.iniBalBox);
            this.Controls.Add(this.initBalLabel);
            this.Controls.Add(this.acctNumBox);
            this.Controls.Add(this.acctNumberLabel);
            this.Controls.Add(this.acctNameLabel);
            this.Controls.Add(this.acctNameBox);
            this.Name = "BankRegisterApp";
            this.Text = "Bank Register";
            this.Load += new System.EventHandler(this.BankRegisterApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox acctNameBox;
        private System.Windows.Forms.Label acctNameLabel;
        private System.Windows.Forms.Label acctNumberLabel;
        private System.Windows.Forms.TextBox acctNumBox;
        private System.Windows.Forms.Label initBalLabel;
        private System.Windows.Forms.TextBox iniBalBox;
        private System.Windows.Forms.Button createAcctButton;
        private System.Windows.Forms.TextBox withdrawBox;
        private System.Windows.Forms.Label withdrawLabel;
        private System.Windows.Forms.Label depositLabel;
        private System.Windows.Forms.TextBox depositBox;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.TextBox balanceBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
    }
}

