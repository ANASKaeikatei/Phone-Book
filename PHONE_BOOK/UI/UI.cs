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
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form_Add form_Add = new Form_Add();
            form_Add.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Form_Delete form_Delete = new Form_Delete();
            form_Delete.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form_Edit form_Edit = new Form_Edit();
            form_Edit.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Form_Search form_Search = new Form_Search();
            form_Search.Show();
            this.Hide();
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            Form_Display_All form_Display_All = new Form_Display_All();
            form_Display_All.Show();
            this.Hide();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();
        }
    }
}
