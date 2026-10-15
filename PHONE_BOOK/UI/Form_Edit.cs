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
    public partial class Form_Edit : Form
    {
        public Form_Edit()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtOldName.Text == "" || txtNewNumber.Text == "" || txtNewName.Text == "")
            {
                MessageBox.Show("يوجد حقل فارغ", "message", MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                return;
            }
            bool edited = Storage_Manger.Edit(txtOldName.Text, txtNewName.Text, txtNewNumber.Text);

            if (edited)
            {
                MessageBox.Show("تم تعديل البيانات بنجاح", "message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                txtOldName.Clear();
                txtNewName.Clear();
                txtNewNumber.Clear();
                return;
            }
            else
            {
                MessageBox.Show(" البيانات غير موجودة", "message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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
