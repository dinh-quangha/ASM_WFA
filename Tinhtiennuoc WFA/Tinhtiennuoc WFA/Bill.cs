using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tinhtiennuoc_WFA
{
    public partial class Bill : Form
    {
        // Khai báo các biến riêng tư (private) cho lớp Form3
        private string ID;
        private string Name;
        private string Address;
        private string PhoneNumber;
        private string CustomerType;
        private string BillWater;
        private string Fee;
        private string VAT;
        private string TotalBill;
        private string NumPeople;
        public Bill()
        {
            InitializeComponent();
        }

        // Phương thức khởi tạo có tham số
        public Bill(string customerID, string name, string address, string phone, string type, string billWater, string fee, string vat, string Totalbill, string numPeople)
        {
            InitializeComponent();
            // Gán các giá trị tham số cho các biến con
            this.ID = customerID;
            this.Name = name;
            this.Address = address;
            this.PhoneNumber = phone;
            this.CustomerType = type;
            this.BillWater = billWater;
            this.Fee = fee;
            this.VAT = vat;
            this.TotalBill = Totalbill;
            this.NumPeople = numPeople;

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //lable hien thi nhung du lieu tu form2
            lbID.Text = ID;
            lbName.Text = Name;
            lbAddress.Text = Address;
            lbPhoneNumber.Text = PhoneNumber;
            lbCustomType.Text = CustomerType;
            lbBill.Text = BillWater;
            lbFee.Text = Fee;
            lbVat.Text = VAT;
            lbTotalBill.Text = TotalBill;
            lbNumPeople.Text = NumPeople;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            //Check nguoi dung click vao exit
            DialogResult check_Exit = MessageBox.Show("Do you want to exit?", "Confim",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //neu nguoi dung chon yes thi dong form
            if (check_Exit == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            //check nguoi dung click vao return
            DialogResult check_btReturn = MessageBox.Show("Do you want to Return?", "Confim",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //neu nguoi dung chon yes thi tro lai form 2
            if (check_btReturn == DialogResult.Yes)
            {
                Information form2 = new Information();
                this.Hide();
                form2.ShowDialog();
                this.Show();
                this.Close();
            }
        }
    }
}
