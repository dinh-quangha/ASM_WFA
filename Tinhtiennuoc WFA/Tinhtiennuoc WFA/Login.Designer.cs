namespace Tinhtiennuoc_WFA
{
    partial class Loggin
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
            btLoggin = new Button();
            tbName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            tbConfirm = new TextBox();
            tbPass = new TextBox();
            btExit = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(19, 49);
            label1.Name = "label1";
            label1.Size = new Size(92, 31);
            label1.TabIndex = 0;
            label1.Text = "User Name";
            // 
            // btLoggin
            // 
            btLoggin.Location = new Point(19, 231);
            btLoggin.Name = "btLoggin";
            btLoggin.Size = new Size(108, 45);
            btLoggin.TabIndex = 1;
            btLoggin.Text = "Login";
            btLoggin.UseVisualStyleBackColor = true;
            btLoggin.Click += btLoggin_Click;
            // 
            // tbName
            // 
            tbName.Location = new Point(248, 46);
            tbName.Name = "tbName";
            tbName.Size = new Size(165, 27);
            tbName.TabIndex = 2;
            // 
            // label2
            // 
            label2.Location = new Point(19, 105);
            label2.Name = "label2";
            label2.Size = new Size(92, 31);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.Location = new Point(19, 161);
            label3.Name = "label3";
            label3.Size = new Size(130, 31);
            label3.TabIndex = 4;
            label3.Text = "Confirm Password";
            // 
            // tbConfirm
            // 
            tbConfirm.Location = new Point(248, 158);
            tbConfirm.Name = "tbConfirm";
            tbConfirm.PasswordChar = '*';
            tbConfirm.Size = new Size(165, 27);
            tbConfirm.TabIndex = 5;
            // 
            // tbPass
            // 
            tbPass.Location = new Point(248, 102);
            tbPass.Name = "tbPass";
            tbPass.PasswordChar = '*';
            tbPass.Size = new Size(165, 27);
            tbPass.TabIndex = 6;
            // 
            // btExit
            // 
            btExit.Location = new Point(305, 231);
            btExit.Name = "btExit";
            btExit.Size = new Size(108, 45);
            btExit.TabIndex = 7;
            btExit.Text = "Exit";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btExit);
            groupBox1.Controls.Add(tbPass);
            groupBox1.Controls.Add(tbConfirm);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbName);
            groupBox1.Controls.Add(btLoggin);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(95, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(440, 295);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // Loggin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(659, 426);
            Controls.Add(groupBox1);
            Name = "Loggin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loggin";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btLoggin;
        private TextBox tbName;
        private Label label2;
        private Label label3;
        private TextBox tbConfirm;
        private TextBox tbPass;
        private Button btExit;
        private GroupBox groupBox1;
    }
}
