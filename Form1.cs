using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Them_lop_hoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClass.Text) || string.IsNullOrEmpty(txtCount.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
            else
            {
                ListViewItem item = new ListViewItem();
                item.Text = txtClass.Text;
                lstvInfor.Items.Add(item);

                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, (txtCount.Text));
                item.SubItems.Add(subitem);

                txtClass.Clear();
                txtCount.Clear();
                txtClass.Focus();
            }
        }

        private void txtCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Chỉ nhập dữ liệu số");
                e.Handled = true;
            }
        }
    }
}
