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
    public partial class Form_Add : Form
    {
        public Form_Add()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool check = Input_Validition(txtName.Text, txtNumber.Text);
            if(check)
            {
                 bool saved = Storage_Manger.Add(txtName.Text, txtNumber.Text);
                 if (saved)
                 {   
                     MessageBox.Show("تم حفظ البيانات بنجاح", "message", MessageBoxButtons.OKCancel);
                     txtName.Clear();
                     txtNumber.Clear();
                     return;
                 }
                 else
                 {
                     MessageBox.Show("لا يمكن حفظ البيانات", "message", MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                     return;
                 }

            }
           
        }
       public static bool Input_Validition(string name, string phone)
       {
            for (int x = 0; x < Model.names.Length; x++)
            {
                if (name == "" || phone == "")
                {
                    MessageBox.Show("الرجاء إدخال البيانات", "message", MessageBoxButtons.OKCancel);
                    return false;
                }

                   for (int y = 0; y < Model.names.Length; y++)
                   {
                       if (Model.names[y] == name || Model.phoneNumbers[y] == phone)
                       {
                           MessageBox.Show("البيانات موجودة مسبقاً", "message", MessageBoxButtons.OKCancel);
                           return false;
                       }
                   }
            }
            return true;
       }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            UI uI = new UI();
            this.Close();
            uI.Show();
        }
    }
}
