using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            DataTable dt = new DataTable();
            string srtSelect = "SELECT MaterialGroupID, GroupName FROM MaterialGroups Order By GroupName";
            dt = new DataProvider().executeQuery(srtSelect);

            cbxGroup.DataSource = dt;
            cbxGroup.DisplayMember = "GroupName";
            cbxGroup.ValueMember = "MaterialGroupID"; // for selectedValue
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCode.Text))
            {
                MessageBox.Show("Please enter Material Type Code");
                return;
            }

            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please enter Material Type Name");
                return;
            }

            string strInsert = "INSERT INTO MaterialTypes([MaterialTypeCode], [MaterialTypeName], [MaterialGroupID], [IsDetail])" +
                " VALUES ('" + txtCode.Text + "', '" + txtName.Text + "' , '" + cbxGroup.SelectedValue + "', '" + cb.Checked + "')";

            if (new DataProvider().executeNonQuery(strInsert))
            {
                DialogResult res = MessageBox.Show("A new Material type added \n Material Type Code: " + txtCode.Text + "\n Material Type Name: " + txtName.Text
                        + "\n Material Type GroupId: " + cbxGroup.SelectedValue.ToString()
                         + (cb.Checked ? "\n Is Detail: " : "\n Is not Detail: "), "Information Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
            else
            {
                MessageBox.Show("Insert fail");
            }

        }
    }
}
