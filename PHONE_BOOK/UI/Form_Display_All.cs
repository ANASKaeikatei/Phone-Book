using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHONE_BOOK
{
    public partial class Form_Display_All : Form
    {
        public Form_Display_All()
        {
            InitializeComponent();
        }

       static int x = 0;

        private void btn_Show_Click(object sender, EventArgs e)
        {
           
            if (x == 0)
            {
                x = 1;
                string result = Storage_Manger.DisplayAll();

                string[] li = result.Split('\n');

                foreach (string item in li)
                {
                    Interface_Show.Items.Add(item);
                }
                
            }
            else
            {
                MessageBox.Show("تم عرض جميع الاسماء", "message",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            UI uI = new UI();
            this.Close();
            uI.Show();
        }
    }
}
