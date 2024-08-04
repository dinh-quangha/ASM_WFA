namespace Tinhtiennuoc_WFA
{
    partial class Bill
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
            lbID = new Label();
            lbName = new Label();
            lbAddress = new Label();
            lbPhoneNumber = new Label();
            lbCustomType = new Label();
            groupBox1 = new GroupBox();
            label13 = new Label();
            label7 = new Label();
            lbNumPeople = new Label();
            label8 = new Label();
            lbTotalBill = new Label();
            label12 = new Label();
            lbVat = new Label();
            label11 = new Label();
            lbFee = new Label();
            label10 = new Label();
            lbBill = new Label();
            label9 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btExit = new Button();
            label6 = new Label();
            btReturn = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(225, 23);
            lbID.Name = "lbID";
            lbID.Size = new Size(24, 20);
            lbID.TabIndex = 0;
            lbID.Text = "ID";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(225, 58);
            lbName.Name = "lbName";
            lbName.Size = new Size(49, 20);
            lbName.TabIndex = 1;
            lbName.Text = "Name";
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.Location = new Point(224, 88);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(62, 20);
            lbAddress.TabIndex = 2;
            lbAddress.Text = "Address";
            // 
            // lbPhoneNumber
            // 
            lbPhoneNumber.AutoSize = true;
            lbPhoneNumber.Location = new Point(224, 154);
            lbPhoneNumber.Name = "lbPhoneNumber";
            lbPhoneNumber.Size = new Size(50, 20);
            lbPhoneNumber.TabIndex = 3;
            lbPhoneNumber.Text = "Phone";
            // 
            // lbCustomType
            // 
            lbCustomType.AutoSize = true;
            lbCustomType.Location = new Point(224, 121);
            lbCustomType.Name = "lbCustomType";
            lbCustomType.Size = new Size(40, 20);
            lbCustomType.TabIndex = 4;
            lbCustomType.Text = "Type";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(lbNumPeople);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(lbTotalBill);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(lbVat);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(lbFee);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(lbBill);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lbCustomType);
            groupBox1.Controls.Add(lbPhoneNumber);
            groupBox1.Controls.Add(lbAddress);
            groupBox1.Controls.Add(lbName);
            groupBox1.Controls.Add(lbID);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(512, 462);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label13
            // 
            label13.Location = new Point(4, 379);
            label13.Name = "label13";
            label13.Size = new Size(499, 25);
            label13.TabIndex = 36;
            label13.Text = "---------------------------------------------------------------------------------";
            // 
            // label7
            // 
            label7.Location = new Point(7, 234);
            label7.Name = "label7";
            label7.Size = new Size(499, 25);
            label7.TabIndex = 35;
            label7.Text = "---------------------------------------------------------------------------------";
            // 
            // lbNumPeople
            // 
            lbNumPeople.AutoSize = true;
            lbNumPeople.Location = new Point(224, 187);
            lbNumPeople.Name = "lbNumPeople";
            lbNumPeople.Size = new Size(86, 20);
            lbNumPeople.TabIndex = 34;
            lbNumPeople.Text = "NumPeople";
            // 
            // label8
            // 
            label8.Location = new Point(4, 187);
            label8.Name = "label8";
            label8.Size = new Size(177, 47);
            label8.TabIndex = 33;
            label8.Text = "Number of people (If the customer is a household)";
            // 
            // lbTotalBill
            // 
            lbTotalBill.AutoSize = true;
            lbTotalBill.Location = new Point(237, 413);
            lbTotalBill.Name = "lbTotalBill";
            lbTotalBill.Size = new Size(67, 20);
            lbTotalBill.TabIndex = 32;
            lbTotalBill.Text = "Total Bill";
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(4, 404);
            label12.Name = "label12";
            label12.Size = new Size(113, 39);
            label12.TabIndex = 31;
            label12.Text = "Total bill";
            // 
            // lbVat
            // 
            lbVat.AutoSize = true;
            lbVat.Location = new Point(240, 351);
            lbVat.Name = "lbVat";
            lbVat.Size = new Size(34, 20);
            lbVat.TabIndex = 31;
            lbVat.Text = "VAT";
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(7, 344);
            label11.Name = "label11";
            label11.Size = new Size(61, 31);
            label11.TabIndex = 30;
            label11.Text = "VAT";
            // 
            // lbFee
            // 
            lbFee.AutoSize = true;
            lbFee.Location = new Point(240, 307);
            lbFee.Name = "lbFee";
            lbFee.Size = new Size(32, 20);
            lbFee.TabIndex = 29;
            lbFee.Text = "Fee";
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(7, 300);
            label10.Name = "label10";
            label10.Size = new Size(174, 39);
            label10.TabIndex = 28;
            label10.Text = "Environment Fee";
            // 
            // lbBill
            // 
            lbBill.AutoSize = true;
            lbBill.Location = new Point(239, 268);
            lbBill.Name = "lbBill";
            lbBill.Size = new Size(71, 20);
            lbBill.TabIndex = 18;
            lbBill.Text = "Bill water";
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(6, 261);
            label9.Name = "label9";
            label9.Size = new Size(159, 39);
            label9.TabIndex = 17;
            label9.Text = "Total water bill";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 121);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 9;
            label5.Text = "Customer Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 154);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 8;
            label4.Text = "Phone Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 88);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 7;
            label3.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 58);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 6;
            label2.Text = "Full Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 23);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 5;
            label1.Text = "Customer ID";
            // 
            // btExit
            // 
            btExit.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btExit.Location = new Point(360, 543);
            btExit.Name = "btExit";
            btExit.Size = new Size(164, 45);
            btExit.TabIndex = 27;
            btExit.Text = "Exit";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(178, 19);
            label6.Name = "label6";
            label6.Size = new Size(164, 35);
            label6.TabIndex = 28;
            label6.Text = "Bill Water";
            // 
            // btReturn
            // 
            btReturn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btReturn.Location = new Point(12, 543);
            btReturn.Name = "btReturn";
            btReturn.Size = new Size(164, 45);
            btReturn.TabIndex = 29;
            btReturn.Text = "Return";
            btReturn.UseVisualStyleBackColor = true;
            btReturn.Click += btReturn_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(536, 593);
            Controls.Add(btReturn);
            Controls.Add(label6);
            Controls.Add(btExit);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Invoice details";
            Load += Form3_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbID;
        private Label lbName;
        private Label lbAddress;
        private Label lbPhoneNumber;
        private Label lbCustomType;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Button btExit;
        private Label lbBill;
        private Label label9;
        private Label lbFee;
        private Label label10;
        private Label lbVat;
        private Label label11;
        private Label lbTotalBill;
        private Label label12;
        private Label label8;
        private Label lbNumPeople;
        private Label label6;
        private Label label13;
        private Label label7;
        private Button btReturn;
    }
}