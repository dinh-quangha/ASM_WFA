using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tinhtiennuoc_WFA
{
    public partial class Information : Form
    {

        public Information()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //không cho nhập dữ liệu
            tbTotalBill.Enabled = false;
            tbVat.Enabled = false;
            tbFee.Enabled = false;
            tbBill.Enabled = false;
            tbConsumption.Enabled = false;
            tbNumberPeople.Enabled = false;
            

            // tách hàng và cột(listview)
            lv_hienthi.GridLines = true;
            // chọn toàn bộ hàng khi người dùng click vào hàng đó(listview)
            lv_hienthi.FullRowSelect = true;
            //hiển thị những thông tin vào listview
            lv_hienthi.View = View.Details;
            lv_hienthi.Columns.Add(" ID", 120);
            lv_hienthi.Columns.Add(" Name", 175);
            lv_hienthi.Columns.Add(" Address", 250);
            lv_hienthi.Columns.Add(" Phone", 110);
            lv_hienthi.Columns.Add(" Type", 190);
            lv_hienthi.Columns.Add(" Last Month", 90);
            lv_hienthi.Columns.Add(" This Month", 90);
            lv_hienthi.Columns.Add(" Total Bill", 115);

        }


        // xóa hết thông tin người dùng vừa nhập
        private void btResets_Click(object sender, EventArgs e)
        {
            DialogResult check_btResets = MessageBox.Show("Do you want to Resest?", "Confim",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //check nếu người dùng chọn yes thì xóa hết thông tin của người dùng
            if (check_btResets == DialogResult.Yes)
            {
                tbCustomerID.Clear();
                tbName.Clear();
                tbAddress.Clear();
                tbPhone.Clear();
                tbWtLastMonth.Clear();
                tbWtThisMonth.Clear();
                tbNumberPeople.Clear();
                tbTotalBill.Clear();
                tbFee.Clear();
                tbBill.Clear();
                tbVat.Clear();
                tbConsumption.Clear();
                cbCustomerType.SelectedIndex = -1;
            }

        }


        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult check_Exit = MessageBox.Show("Do you want to exit?", "Confim",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check_Exit == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //Tính sau khi người dùng nhập dữ liệu
        private void btCalculate_Click(object sender, EventArgs e)
        {
            // nếu loại khách hàng trống
            if (cbCustomerType.SelectedItem == null)
            {
                MessageBox.Show("Please select a customer type.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int lastMonthUsage, thisMonthUsage, numPeople = 1;
            // yêu cầu nhập thông tin lượng nước sử dụng nếu khacks hàng để trống
            if (!int.TryParse(tbWtLastMonth.Text, out lastMonthUsage) || !int.TryParse(tbWtThisMonth.Text, out thisMonthUsage))
            {
                MessageBox.Show("Please enter valid water usage numbers.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // yeu cau nhap lai neu last >= this
            if (lastMonthUsage >= thisMonthUsage)
            {
                MessageBox.Show("Last month's water usage should be less than this month's. Please try again.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //tính toán lượng nước tháng này nếu người dùng nhập đúng
            int waterConsumption = thisMonthUsage - lastMonthUsage;

            string choice = cbCustomerType.SelectedItem.ToString();

            double waterPrice = GetWaterPrice(choice, waterConsumption);

            tbConsumption.Text = waterConsumption.ToString();
            //tính toán giá nước và trả kết quả về dạng ToString 
            tbTotalBill.Text = waterPrice.ToString("0.000" + "VND");
            //tinh toán phí môi trường và trả về kết qả dạng ToString 
            double environmentFee = waterPrice * 0.1;
            tbFee.Text = environmentFee.ToString("0.000" + "VND");
            //tính toán giá VAT và trả về kết quả dạng ToString
            double VAT = waterPrice  * 0.1;
            tbVat.Text = VAT.ToString("0.000" + "VND");
            //tính toán tổng bill và trả về kết quả dạng ToString
            double totalBill = waterPrice + VAT + environmentFee;
            tbBill.Text = totalBill.ToString("0.000" + "VND");

            //lựa chọn là hộ gia đình
            if (choice != "Household")// nếu không phải là hộ gia đình thì lượng nước mỗi người sử dụng trống
            {
                tbConsumption.Text = null;
                

            }


            if (choice == "Household")
            {
                tbNumberPeople.Enabled = true;

                if (!int.TryParse(tbNumberPeople.Text, out numPeople) || numPeople <= 0)
                {
                    MessageBox.Show("Please enter a valid number of people in household.");
                    return;
                }
                double avgPerPerson = waterConsumption / numPeople;
                tbConsumption.Text = (avgPerPerson + "m3");

            }
            else 
            {
                tbNumberPeople.Enabled = false;
            }

           


           


        }
        private double GetWaterPrice(string choice, int waterConsumption)// tính toán tiền nước
        {
            double waterPrice = 0;
            //tinh toan dua tren lua chon khack hang
            switch (choice) 
            {
                case "Business services":
                    waterPrice = waterConsumption * 22.068;
                    break;
                case "Administrative agency, public services":
                    waterPrice = waterConsumption * 9.955;
                    break;
                case "Production units":
                    waterPrice = waterConsumption * 11.615;
                    break;
                case "Household":
                    if (waterConsumption <= 10)
                    {
                        waterPrice = 5.973 * waterConsumption;
                    }
                    else if (waterConsumption <= 20)
                    {
                        waterPrice = (10 * 5.973) + (waterConsumption - 10) * 7.052;
                    }
                    else if (waterConsumption <= 30)
                    {
                        waterPrice = (10 * 5.973) + (10 * 7.052) + (waterConsumption - 20) * 8.699;
                    }
                    else
                    {
                        waterPrice = (10 * 5.973) + (10 * 7.052) + (10 * 8.699) + (waterConsumption - 30) * 15.929;
                    }
                    break;

            }
            return waterPrice;
        }

        //chuyển sang form3
        private void btView_Click(object sender, EventArgs e)
        {
            //yêu cầu nhập thông tin nếu thông tin trống 
            if (string.IsNullOrWhiteSpace(tbAddress.Text) ||
                string.IsNullOrWhiteSpace(tbCustomerID.Text) ||
                string.IsNullOrWhiteSpace(tbName.Text) ||
                string.IsNullOrWhiteSpace(tbPhone.Text))

            {
                MessageBox.Show("Please enter complete information", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            //đầy đủ thông tin thì sẽ cho người dùng chuyển được sang form3 
            else
            {
                //truyền dữ liệu vào form 3 
                Bill form3 = new Bill(tbCustomerID.Text, tbName.Text, tbAddress.Text, tbPhone.Text, cbCustomerType.Text, tbTotalBill.Text, tbFee.Text, tbVat.Text, tbBill.Text, tbNumberPeople.Text);
                this.Hide();
                form3.ShowDialog();
                this.Show();
                this.Close();

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
           

            
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Close();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string ID = tbCustomerID.Text;
            //MessageBox.Show(ID);
            string Name = tbName.Text;
            //MessageBox.Show(Name);
            string Address = tbAddress.Text;
            //Show address
            string Phone = tbPhone.Text;
            //MessageBox.Show(Phone);
            string lastMonth = tbWtLastMonth.Text;
            string thisMonth = tbWtThisMonth.Text;
            string totalbill = tbBill.Text;

            string Type = null;
            if (cbCustomerType.SelectedIndex == 0)
            {
                Type = "Business services";
            }
            else if (cbCustomerType.SelectedIndex == 1)
            {
                Type = "Administrative agency, public services";
            }
            else if (cbCustomerType.SelectedIndex == 2)
            {
                Type = "Production units";
            }
            else if (cbCustomerType.SelectedIndex == 3)
            {
                Type = "Household";
            }
            

            //MessageBox.Show(ID + " " + Name + " " + Address + " " + Phone + " " + Type + " " + number + " " + totalbill);

            //tạo đối tượng item để nhận các giá trị trong form
            ListViewItem item = new ListViewItem();
            item.Text = ID;
            item.SubItems.Add(Name);
            item.SubItems.Add(Address);
            item.SubItems.Add(Phone);
            item.SubItems.Add(Type);
            item.SubItems.Add(lastMonth);
            item.SubItems.Add(thisMonth);
            item.SubItems.Add(totalbill);

            lv_hienthi.Items.Add(item);

            

        }

        private void lv_hienthi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_hienthi.SelectedItems.Count > 0)
            {
                // MessageBox.Show(lv_hienthi.SelectedItems.Count.ToString());
                // khởi tạo biến tempItem để chứa dữ liệu trong hàm đã chọn
                ListViewItem tempItem = lv_hienthi.SelectedItems[0];

                // lấy ra từng giá trị trong tempItem
                string ID = tempItem.SubItems[0].Text;
                string Name = tempItem.SubItems[1].Text;
                string address = tempItem.SubItems[2].Text;
                string Phone = tempItem.SubItems[3].Text;
                string Type = tempItem.SubItems[4].Text;
                string lastMonth = tempItem.SubItems[5].Text;
                string thisMonth = tempItem.SubItems[6].Text;
                string TotalBill = tempItem.SubItems[7].Text;

                // đẩy dữ liệu lên form 
                tbCustomerID.Text = ID;
                tbName.Text = Name;
                tbAddress.Text = address;
                tbPhone.Text = Phone;
                tbWtLastMonth.Text = lastMonth;
                tbWtThisMonth.Text = thisMonth;
                tbBill.Text = TotalBill;
                if (Type == "Business services")
                {
                    cbCustomerType.SelectedIndex = 0;
                }
                else if (Type == "Administrative agency, public services")
                {
                    cbCustomerType.SelectedIndex = 1;
                }
                else if (Type == "Production units")
                {
                    cbCustomerType.SelectedIndex = 2;

                }
                else if (Type == "Household")
                {
                    cbCustomerType.SelectedIndex = 3;

                }
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (lv_hienthi.SelectedItems.Count > 0)
            {

                ListViewItem item = lv_hienthi.SelectedItems[0];
                item.SubItems.Clear();


                string ID = tbCustomerID.Text;
                //MessageBox.Show(ID);
                string Name = tbName.Text;
                //MessageBox.Show(Name);
                string add = tbAddress.Text;
                string Phone = tbPhone.Text;
                //MessageBox.Show(Phone);
                string lastMonth = tbWtLastMonth.Text;
                string thisMonth = tbWtThisMonth.Text;
                string totalBill = tbBill.Text;


                string Type = null;
                if (cbCustomerType.SelectedIndex == 0)
                {
                    Type = "Business services";
                }
                else if (cbCustomerType.SelectedIndex == 1)
                {
                    Type = "Administrative agency, public services";
                }
                else if (cbCustomerType.SelectedIndex == 2)
                {
                    Type = "Production units";
                }
                else if (cbCustomerType.SelectedIndex == 3)
                {
                    Type = "Household";
                }


                //tạo đối tượng item để nhận các giá trị trong form

                item.Text = ID;
                item.SubItems.Add(Name);
                item.SubItems.Add(add);
                item.SubItems.Add(Phone);
                item.SubItems.Add(Type);
                item.SubItems.Add(lastMonth);
                item.SubItems.Add(thisMonth);
                item.SubItems.Add(totalBill);

                lv_hienthi.Items.Add(item);

                // xóa dữ liệu trên form
                tbCustomerID.Clear();
                tbName.Clear();
                tbAddress.Clear();
                tbPhone.Clear();
                tbWtLastMonth.Clear();
                tbWtThisMonth.Clear();
                tbTotalBill.Clear();
                cbCustomerType.SelectedIndex = -1;
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            lv_hienthi.Items.Remove(lv_hienthi.SelectedItems[0]);
        }
    }
}
