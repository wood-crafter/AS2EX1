using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ex3.Models;

namespace Ex3
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
            using (MyDB3Context context = new MyDB3Context())
            {
                var data = context.Dictionaries.Select(item => item).ToList();
                var wordType = context.WordTypes.Select(item => item).ToList();

                dgv.DataSource = data;
                cbx.DataSource = wordType;
                cbx.DisplayMember = "TypeName";
                cbx.ValueMember = "ID";
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Please enter ID");
                return;
            }
            if (String.IsNullOrEmpty(txtMeaning.Text))
            {
                MessageBox.Show("Please enter meaning");
                return;
            }

            Dictionary d = new Dictionary
            {
                Meaning = txtMeaning.Text,
                EditDate = DateTime.Today,
            };

            //using (MyDB12Context context = new MyDB12Context())
            //{
            //    context.AssetTypes.Add(at);
            //    if (context.SaveChanges() > 0)
            //    {
            //        DialogResult res = MessageBox.Show("A new Asset type added \n Asset Type Code: " + txtTypeCode.Text + "\n Asset Type Name: " + txtTypeName.Text
            //            + "\n Asset Type GroupId: " + cbxTypeGroup.SelectedValue.ToString()
            //             + (cb.Checked ? "\n Is Detail: " : "\n Is not Detail: "), "Information Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        if (res == DialogResult.OK)
            //        {
            //        }
            //        loadData();
            //    }
            //}
        }
    }
}
