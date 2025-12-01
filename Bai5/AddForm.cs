using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5
{
    public partial class AddForm : Form
    {
        public string StudentID;
        public string StudentName;
        public string Major;
        public float GPA;

        public AddForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtStudentID.Text == "" || txtGPA.Text == "" || cbbMajor.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return;
            }

            StudentID = txtStudentID.Text;
            StudentName = txtName.Text;
            Major = cbbMajor.SelectedItem.ToString();
            GPA = float.Parse(txtGPA.Text);

            DialogResult = DialogResult.OK;
        }

        private void txtStudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtGPA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
