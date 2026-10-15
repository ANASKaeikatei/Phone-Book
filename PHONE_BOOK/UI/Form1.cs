using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PHONE_BOOK.Storage_Manger;

namespace PHONE_BOOK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnArray_Click(object sender, EventArgs e)
        {
            Storage_Manger.Currentstorage = StorageType.Array;
            UI uI = new UI();
            uI.Show();
            this.Hide();
        }

        private void btnDatabase_Click(object sender, EventArgs e)
        {
            Storage_Manger.Currentstorage = StorageType.Database;
            UI uI = new UI();
            uI.Show();
            this.Hide();
        }

        private void btnTextFile_Click(object sender, EventArgs e)
        {
            Storage_Manger.Currentstorage = StorageType.File;
            UI uI = new UI();
            uI.Show();
            this.Hide();
        }


        private void btnList_Click(object sender, EventArgs e)
        {
            Storage_Manger.Currentstorage = StorageType.List;
            UI uI = new UI();
            uI.Show();
            this.Hide();
        }
    }
}
