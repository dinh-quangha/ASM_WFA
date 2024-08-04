namespace Tinhtiennuoc_WFA
{
    partial class Information
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
            groupBox1 = new GroupBox();
            tbConsumption = new TextBox();
            label13 = new Label();
            btCalculate = new Button();
            tbNumberPeople = new TextBox();
            label8 = new Label();
            tbWtThisMonth = new TextBox();
            label7 = new Label();
            tbWtLastMonth = new TextBox();
            label6 = new Label();
            cbCustomerType = new ComboBox();
            label5 = new Label();
            tbName = new TextBox();
            label4 = new Label();
            tbPhone = new TextBox();
            label3 = new Label();
            tbCustomerID = new TextBox();
            label2 = new Label();
            tbAddress = new TextBox();
            label1 = new Label();
            btResets = new Button();
            btExit = new Button();
            btView = new Button();
            tbBill = new TextBox();
            label12 = new Label();
            tbVat = new TextBox();
            label11 = new Label();
            tbFee = new TextBox();
            tbTotalBill = new TextBox();
            label10 = new Label();
            label9 = new Label();
            groupBox2 = new GroupBox();
            btAdd = new Button();
            btEdit = new Button();
            btDelete = new Button();
            lv_hienthi = new ListView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbConsumption);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(btCalculate);
            groupBox1.Controls.Add(tbNumberPeople);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(tbWtThisMonth);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(tbWtLastMonth);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cbCustomerType);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tbPhone);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbCustomerID);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbAddress);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(18, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1112, 378);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Fact Sheet";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // tbConsumption
            // 
            tbConsumption.Location = new Point(778, 241);
            tbConsumption.Name = "tbConsumption";
            tbConsumption.Size = new Size(176, 27);
            tbConsumption.TabIndex = 34;
            // 
            // label13
            // 
            label13.Location = new Point(532, 244);
            label13.Name = "label13";
            label13.Size = new Size(222, 44);
            label13.TabIndex = 33;
            label13.Text = "Water consumption per person (If the customer is a household)";
            // 
            // btCalculate
            // 
            btCalculate.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btCalculate.Location = new Point(464, 301);
            btCalculate.Name = "btCalculate";
            btCalculate.Size = new Size(156, 58);
            btCalculate.TabIndex = 22;
            btCalculate.Text = "Calculate";
            btCalculate.UseVisualStyleBackColor = true;
            btCalculate.Click += btCalculate_Click;
            // 
            // tbNumberPeople
            // 
            tbNumberPeople.Location = new Point(326, 244);
            tbNumberPeople.Name = "tbNumberPeople";
            tbNumberPeople.Size = new Size(176, 27);
            tbNumberPeople.TabIndex = 15;
            // 
            // label8
            // 
            label8.Location = new Point(42, 244);
            label8.Name = "label8";
            label8.Size = new Size(252, 44);
            label8.TabIndex = 14;
            label8.Text = "Number of people in the household (If the customer is a household)";
            // 
            // tbWtThisMonth
            // 
            tbWtThisMonth.Location = new Point(778, 183);
            tbWtThisMonth.Name = "tbWtThisMonth";
            tbWtThisMonth.Size = new Size(176, 27);
            tbWtThisMonth.TabIndex = 13;
            // 
            // label7
            // 
            label7.Location = new Point(574, 186);
            label7.Name = "label7";
            label7.Size = new Size(180, 34);
            label7.TabIndex = 12;
            label7.Text = "Water Usage This Month";
            // 
            // tbWtLastMonth
            // 
            tbWtLastMonth.Location = new Point(326, 183);
            tbWtLastMonth.Name = "tbWtLastMonth";
            tbWtLastMonth.Size = new Size(176, 27);
            tbWtLastMonth.TabIndex = 11;
            // 
            // label6
            // 
            label6.Location = new Point(92, 186);
            label6.Name = "label6";
            label6.Size = new Size(180, 34);
            label6.TabIndex = 10;
            label6.Text = "Water Usage Last Month";
            // 
            // cbCustomerType
            // 
            cbCustomerType.FormattingEnabled = true;
            cbCustomerType.Items.AddRange(new object[] { "Business services", "Administrative agency, public services", "Production units", "Household" });
            cbCustomerType.Location = new Point(711, 88);
            cbCustomerType.Name = "cbCustomerType";
            cbCustomerType.Size = new Size(176, 28);
            cbCustomerType.TabIndex = 9;
            // 
            // label5
            // 
            label5.Location = new Point(558, 94);
            label5.Name = "label5";
            label5.Size = new Size(120, 34);
            label5.TabIndex = 8;
            label5.Text = "Customer Type";
            // 
            // tbName
            // 
            tbName.Location = new Point(194, 85);
            tbName.Name = "tbName";
            tbName.Size = new Size(176, 27);
            tbName.TabIndex = 7;
            // 
            // label4
            // 
            label4.Location = new Point(47, 40);
            label4.Name = "label4";
            label4.Size = new Size(114, 34);
            label4.TabIndex = 6;
            label4.Text = "Customer ID";
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(711, 36);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(176, 27);
            tbPhone.TabIndex = 5;
            // 
            // label3
            // 
            label3.Location = new Point(558, 40);
            label3.Name = "label3";
            label3.Size = new Size(147, 34);
            label3.TabIndex = 4;
            label3.Text = "Phone Number";
            // 
            // tbCustomerID
            // 
            tbCustomerID.Location = new Point(194, 36);
            tbCustomerID.Name = "tbCustomerID";
            tbCustomerID.Size = new Size(176, 27);
            tbCustomerID.TabIndex = 3;
            // 
            // label2
            // 
            label2.Location = new Point(42, 136);
            label2.Name = "label2";
            label2.Size = new Size(87, 34);
            label2.TabIndex = 2;
            label2.Text = "Address";
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(194, 133);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(176, 27);
            tbAddress.TabIndex = 1;
            // 
            // label1
            // 
            label1.Location = new Point(47, 88);
            label1.Name = "label1";
            label1.Size = new Size(87, 33);
            label1.TabIndex = 0;
            label1.Text = "Full Name";
            // 
            // btResets
            // 
            btResets.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btResets.Location = new Point(599, 198);
            btResets.Name = "btResets";
            btResets.Size = new Size(98, 45);
            btResets.TabIndex = 25;
            btResets.Text = "Resets";
            btResets.UseVisualStyleBackColor = true;
            btResets.Click += btResets_Click;
            // 
            // btExit
            // 
            btExit.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btExit.Location = new Point(1012, 198);
            btExit.Name = "btExit";
            btExit.Size = new Size(100, 45);
            btExit.TabIndex = 26;
            btExit.Text = "Exit";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // btView
            // 
            btView.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btView.Location = new Point(809, 198);
            btView.Name = "btView";
            btView.Size = new Size(109, 45);
            btView.TabIndex = 35;
            btView.Text = "Print Bill";
            btView.UseVisualStyleBackColor = true;
            btView.Click += btView_Click;
            // 
            // tbBill
            // 
            tbBill.Location = new Point(558, 99);
            tbBill.Multiline = true;
            tbBill.Name = "tbBill";
            tbBill.Size = new Size(176, 47);
            tbBill.TabIndex = 31;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(426, 107);
            label12.Name = "label12";
            label12.Size = new Size(113, 39);
            label12.TabIndex = 30;
            label12.Text = "Total bill";
            // 
            // tbVat
            // 
            tbVat.Location = new Point(899, 31);
            tbVat.Name = "tbVat";
            tbVat.Size = new Size(176, 27);
            tbVat.TabIndex = 21;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(823, 31);
            label11.Name = "label11";
            label11.Size = new Size(70, 31);
            label11.TabIndex = 20;
            label11.Text = "VAT";
            // 
            // tbFee
            // 
            tbFee.Location = new Point(599, 31);
            tbFee.Name = "tbFee";
            tbFee.Size = new Size(176, 27);
            tbFee.TabIndex = 19;
            // 
            // tbTotalBill
            // 
            tbTotalBill.Location = new Point(182, 31);
            tbTotalBill.Name = "tbTotalBill";
            tbTotalBill.Size = new Size(176, 27);
            tbTotalBill.TabIndex = 18;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(404, 31);
            label10.Name = "label10";
            label10.Size = new Size(174, 39);
            label10.TabIndex = 17;
            label10.Text = "Environment Fee";
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(6, 31);
            label9.Name = "label9";
            label9.Size = new Size(159, 39);
            label9.TabIndex = 16;
            label9.Text = "Total water bill";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btAdd);
            groupBox2.Controls.Add(btEdit);
            groupBox2.Controls.Add(btDelete);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(btView);
            groupBox2.Controls.Add(tbBill);
            groupBox2.Controls.Add(tbVat);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(tbFee);
            groupBox2.Controls.Add(btResets);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(btExit);
            groupBox2.Controls.Add(tbTotalBill);
            groupBox2.Location = new Point(18, 395);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1112, 243);
            groupBox2.TabIndex = 36;
            groupBox2.TabStop = false;
            groupBox2.Text = "----Bill----";
            // 
            // btAdd
            // 
            btAdd.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btAdd.Location = new Point(0, 198);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(98, 45);
            btAdd.TabIndex = 38;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // btEdit
            // 
            btEdit.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btEdit.Location = new Point(196, 198);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(98, 45);
            btEdit.TabIndex = 37;
            btEdit.Text = "Edit";
            btEdit.UseVisualStyleBackColor = true;
            btEdit.Click += btEdit_Click;
            // 
            // btDelete
            // 
            btDelete.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btDelete.Location = new Point(393, 198);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(98, 45);
            btDelete.TabIndex = 36;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // lv_hienthi
            // 
            lv_hienthi.Location = new Point(12, 644);
            lv_hienthi.Name = "lv_hienthi";
            lv_hienthi.Size = new Size(1144, 122);
            lv_hienthi.TabIndex = 37;
            lv_hienthi.UseCompatibleStateImageBehavior = false;
            lv_hienthi.SelectedIndexChanged += lv_hienthi_SelectedIndexChanged;
            // 
            // Information
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1234, 791);
            Controls.Add(lv_hienthi);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Information";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Informance";
            FormClosing += Form2_FormClosing;
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tbAddress;
        private Label label1;
        private TextBox tbCustomerID;
        private Label label2;
        private TextBox tbPhone;
        private Label label3;
        private Label label4;
        private TextBox tbName;
        private ComboBox cbCustomerType;
        private Label label5;
        private Label label7;
        private TextBox tbWtLastMonth;
        private Label label6;
        private TextBox tbWtThisMonth;
        private Label label8;
        private TextBox tbNumberPeople;
        private TextBox tbTotalBill;
        private Label label10;
        private Label label9;
        private Button btCalculate;
        private TextBox tbVat;
        private Label label11;
        private TextBox tbFee;
        private Button btExit;
        private Button btResets;
        private Label label12;
        private TextBox tbBill;
        private TextBox tbConsumption;
        private Label label13;
        private Button btView;
        private GroupBox groupBox2;
        private Button btAdd;
        private Button btEdit;
        private Button btDelete;
        private ListView lv_hienthi;
    }
}