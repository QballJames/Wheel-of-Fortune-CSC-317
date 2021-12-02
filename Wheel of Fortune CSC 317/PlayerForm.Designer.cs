namespace Wheel_of_Fortune_CSC_317
{
    partial class PlayerForm
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
            this.PlayerAmountQuestion = new System.Windows.Forms.Label();
            this.One = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.Player1NameTxt = new System.Windows.Forms.TextBox();
            this.Player2NameTxt = new System.Windows.Forms.TextBox();
            this.Player3NameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ReadyButton = new System.Windows.Forms.Button();
            this.QuitButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayerAmountQuestion
            // 
            this.PlayerAmountQuestion.AutoSize = true;
            this.PlayerAmountQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerAmountQuestion.ForeColor = System.Drawing.Color.White;
            this.PlayerAmountQuestion.Location = new System.Drawing.Point(239, 35);
            this.PlayerAmountQuestion.Name = "PlayerAmountQuestion";
            this.PlayerAmountQuestion.Size = new System.Drawing.Size(255, 31);
            this.PlayerAmountQuestion.TabIndex = 0;
            this.PlayerAmountQuestion.Text = "How many Players?";
            // 
            // One
            // 
            this.One.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.One.Location = new System.Drawing.Point(94, 102);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(95, 35);
            this.One.TabIndex = 1;
            this.One.Text = "1 Player";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.One_Click);
            // 
            // Two
            // 
            this.Two.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Two.Location = new System.Drawing.Point(349, 102);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(93, 35);
            this.Two.TabIndex = 2;
            this.Two.Text = "2 Players";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.Two_Click);
            // 
            // three
            // 
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.Location = new System.Drawing.Point(597, 102);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(89, 35);
            this.three.TabIndex = 3;
            this.three.Text = "3 Players";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // Player1NameTxt
            // 
            this.Player1NameTxt.Enabled = false;
            this.Player1NameTxt.Location = new System.Drawing.Point(74, 215);
            this.Player1NameTxt.Name = "Player1NameTxt";
            this.Player1NameTxt.Size = new System.Drawing.Size(140, 20);
            this.Player1NameTxt.TabIndex = 4;
            this.Player1NameTxt.TextChanged += new System.EventHandler(this.Player1NameTxt_TextChanged);
            // 
            // Player2NameTxt
            // 
            this.Player2NameTxt.Enabled = false;
            this.Player2NameTxt.Location = new System.Drawing.Point(330, 215);
            this.Player2NameTxt.Name = "Player2NameTxt";
            this.Player2NameTxt.Size = new System.Drawing.Size(140, 20);
            this.Player2NameTxt.TabIndex = 5;
            this.Player2NameTxt.TextChanged += new System.EventHandler(this.Player2NameTxt_TextChanged);
            // 
            // Player3NameTxt
            // 
            this.Player3NameTxt.Enabled = false;
            this.Player3NameTxt.Location = new System.Drawing.Point(575, 215);
            this.Player3NameTxt.Name = "Player3NameTxt";
            this.Player3NameTxt.Size = new System.Drawing.Size(140, 20);
            this.Player3NameTxt.TabIndex = 6;
            this.Player3NameTxt.TextChanged += new System.EventHandler(this.Player3NameTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(90, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Player 1 name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(345, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Player 2 name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(583, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Player 3 name:";
            // 
            // ReadyButton
            // 
            this.ReadyButton.Enabled = false;
            this.ReadyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadyButton.Location = new System.Drawing.Point(330, 314);
            this.ReadyButton.Name = "ReadyButton";
            this.ReadyButton.Size = new System.Drawing.Size(140, 65);
            this.ReadyButton.TabIndex = 10;
            this.ReadyButton.Text = "Ready!";
            this.ReadyButton.UseVisualStyleBackColor = true;
            this.ReadyButton.Click += new System.EventHandler(this.ReadyButton_Click);
            // 
            // QuitButton1
            // 
            this.QuitButton1.BackColor = System.Drawing.Color.Firebrick;
            this.QuitButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitButton1.ForeColor = System.Drawing.Color.White;
            this.QuitButton1.Location = new System.Drawing.Point(713, 12);
            this.QuitButton1.Name = "QuitButton1";
            this.QuitButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.QuitButton1.Size = new System.Drawing.Size(75, 26);
            this.QuitButton1.TabIndex = 11;
            this.QuitButton1.Text = "Quit";
            this.QuitButton1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.QuitButton1.UseVisualStyleBackColor = false;
            this.QuitButton1.Click += new System.EventHandler(this.QuitButton1_Click);
            // 
            // PlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.QuitButton1);
            this.Controls.Add(this.ReadyButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Player3NameTxt);
            this.Controls.Add(this.Player2NameTxt);
            this.Controls.Add(this.Player1NameTxt);
            this.Controls.Add(this.three);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.One);
            this.Controls.Add(this.PlayerAmountQuestion);
            this.Name = "PlayerForm";
            this.Text = "PlayerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PlayerAmountQuestion;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.TextBox Player1NameTxt;
        private System.Windows.Forms.TextBox Player2NameTxt;
        private System.Windows.Forms.TextBox Player3NameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ReadyButton;
        private System.Windows.Forms.Button QuitButton1;
    }
}