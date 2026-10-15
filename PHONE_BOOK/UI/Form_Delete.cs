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
    public partial class Form_Delete : Form
    {
        public Form_Delete()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("الرجاء إدخال الاسم", "message", MessageBoxButtons.OKCancel);
                return;
            }
              bool deleted = Storage_Manger.Remove(txtName.Text);


            if (deleted )
            {
                MessageBox.Show("تم حذف البيانات بنجاح", "message", MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                txtName.Clear();
                return;
            }
            else
            {
                MessageBox.Show("البيانات غير موجودة", "message", MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            UI uI = new UI();
            this.Close();
            uI.Show();
        }
    }
}
