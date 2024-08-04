using System.ComponentModel;
using System.Net;

namespace Tinhtiennuoc_WFA
{
    public partial class Loggin : Form
    {
        public Loggin()
        {
            InitializeComponent();
            
        }

        private void btLoggin_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string pass = tbPass.Text;
            string confirm = tbConfirm.Text;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please Enter User Name", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbName.Focus();
            }
            else if (string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Please Enter Password", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbPass.Focus();
            }
            else if (string.IsNullOrEmpty(confirm))
            {
                MessageBox.Show("Please Enter Confirm Password", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbConfirm.Focus();

            }
           

            if (confirm == pass )// pass và confirm = nhau mở form 2
            {
                if (string.IsNullOrWhiteSpace(tbName.Text) ||
                string.IsNullOrWhiteSpace(tbPass.Text) ||
                string.IsNullOrWhiteSpace(tbConfirm.Text))


                {
                    MessageBox.Show("Please enter complete information", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {


                    MessageBox.Show("Register success", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Information form2 = new Information();
                    this.Hide();
                    form2.ShowDialog();
                    this.Show();
                    this.Close();
                }
            }
            else 
            {
                MessageBox.Show("Register un-success", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbPass.Text = "";
                tbConfirm.Text = "";
                tbPass.Focus();
                tbConfirm.Focus();
            }

        }

        private void btExit_Click(object sender, EventArgs e)// tạo nút thoát
        {
            DialogResult check_Exit = MessageBox.Show("Do you want Exit", "Confim", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check_Exit == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
