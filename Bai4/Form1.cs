using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Form1 : Form
    {
        private int defaultFamilyIndex = 0;
        private string filePath;

        public Form1()
        {
            InitializeComponent();

            SetFontFamilyItems();
            SetFontSizeItems();
        }

        #region ToolStrip: ComboBox: Font Family, Font Size
        private void SetFontFamilyItems()
        {
            int index = -1;

            InstalledFontCollection installedFontCollection = new InstalledFontCollection();
            FontFamily[] fontFamilies = installedFontCollection.Families;
            foreach (FontFamily font in fontFamilies)
            {
                tsCbbFont.Items.Add(font.Name);
                index++;
                if (font.Name == "Microsoft Sans Serif") defaultFamilyIndex = index;
            }
            tsCbbFont.SelectedIndex = defaultFamilyIndex;
        }

        private void tsCbbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rtbMain.SelectionFont != null)
                rtbMain.SelectionFont = new Font(tsCbbFont.SelectedItem.ToString(), rtbMain.SelectionFont.Size, rtbMain.SelectionFont.Style);
        }

        private void SetFontSizeItems()
        {
            for (int i = 8; i <= 11; i += 1)
            {
                tsCbbSize.Items.Add(i.ToString());
            }
            for (int i = 12; i <= 28; i += 2)
            {
                tsCbbSize.Items.Add(i.ToString());
            }
            tsCbbSize.Items.Add("36");
            tsCbbSize.Items.Add("48");
            tsCbbSize.Items.Add("72");

            tsCbbSize.SelectedIndex = 2; 
        }

        private void tsCbbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rtbMain.SelectionFont != null)
                rtbMain.SelectionFont = new Font(rtbMain.SelectionFont.FontFamily, float.Parse(tsCbbSize.SelectedItem.ToString()), rtbMain.SelectionFont.Style);
        }
        #endregion

        #region ToolStrip: Button: New, Open
        private void tsBtnNew_Click(object sender, EventArgs e)
        {
            rtbMain.Clear();
            tsCbbFont.SelectedIndex = defaultFamilyIndex;
            tsCbbSize.SelectedIndex = 2;
        }

        private void tsBtnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text (*.txt, *rtf)|*.txt;*rtf|All files (*.*)|*.*";

            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string content = System.IO.File.ReadAllText(ofd.FileName);
                rtbMain.Text = content;

                filePath = ofd.FileName;
            }
        }
        #endregion

        #region ToolStrip: Button: Bold, Italic, Underline
        private void tsBtnBold_Click(object sender, EventArgs e)
        {
            if (rtbMain.SelectionFont != null)
                rtbMain.SelectionFont = new Font(rtbMain.SelectionFont, rtbMain.SelectionFont.Style ^ FontStyle.Bold);
        }

        private void tsBtnItalic_Click(object sender, EventArgs e)
        {
            if (rtbMain.SelectionFont != null)
                rtbMain.SelectionFont = new Font(rtbMain.SelectionFont, rtbMain.SelectionFont.Style ^ FontStyle.Italic);
        }

        private void tsBtnUnderline_Click(object sender, EventArgs e)
        {
            if (rtbMain.SelectionFont != null)
                rtbMain.SelectionFont = new Font(rtbMain.SelectionFont, rtbMain.SelectionFont.Style ^ FontStyle.Underline);
        }
        #endregion

        #region MenuStrip System, Format
        #region MenuStrip System: New, Open, Save, Exit
        private void mnuiSystemNew_Click(object sender, EventArgs e)
        {
            tsBtnNew_Click(sender, e);
        }

        private void mnuiSystemOpen_Click(object sender, EventArgs e)
        {
            tsBtnOpen_Click(sender, e);
        }

        private void mnuiSystemSave_Click(object sender, EventArgs e)
        {
            if (filePath != null)
            {
                System.IO.File.WriteAllText(filePath, rtbMain.Text);
                MessageBox.Show("Lưu " + filePath + " thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text (.rtf)|*rtf|All files (*.*)|*.*";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(sfd.FileName, rtbMain.Text);
                filePath = sfd.FileName;
            }
        }

        private void mnuiSystemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        private void mnuiFormat_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                rtbMain.Font = fontDialog1.Font;
                rtbMain.ForeColor = fontDialog1.Color;
            }
        }
        #endregion
    }
}
