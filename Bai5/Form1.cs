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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region ToolStrip: Add, Search
        private void tsBtnNew_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.ShowDialog();

            if (addForm.DialogResult == DialogResult.OK)
            {
                string id = addForm.StudentID;
                string name = addForm.StudentName;
                string major = addForm.Major;
                float gpa = addForm.GPA;
                AddStudent(id, name, major, gpa);
            }
        }

        public void AddStudent(string id, string name, string major, float gpa)
        {
            dgvMain.Rows.Add(dgvMain.RowCount, id, name, major, gpa);
        }

        private void tsTxtSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvMain.Rows)
            {
                if (row.Cells["clmName"].Value != null)
                {
                    string name = row.Cells["clmName"].Value.ToString().ToLower();
                    
                    if (name.Contains(tsTxtSearch.Text.ToLower()))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }
        #endregion

        #region MenuStripItem: Add, Exit
        private void mnuiOptionNew_Click(object sender, EventArgs e)
        {
            tsBtnNew_Click(sender, e);
        }

        private void mnuiOptionExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

    }
}
