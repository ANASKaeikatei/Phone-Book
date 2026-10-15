using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHONE_BOOK
{
    public partial class Form_Search : Form
    {
        public Form_Search()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("الرجاء إدخال الاسم", "message", MessageBoxButtons.OKCancel);
                return;
            }
                Storage_Manger.Search(txtName.Text);
                txtName.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            UI uI = new UI();
            this.Close();
            uI.Show();
        }
    }
}
