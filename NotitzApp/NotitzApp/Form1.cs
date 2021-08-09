using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotitzApp
{
    public partial class Form1 : Form
    {
        DataTable table;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //table = new DataTable();
            grdTasks.ColumnCount = 2;
            grdTasks.Columns[0].Name = "Title";
            grdTasks.Columns[1].Name = "Messages";

            //dataGridView1.DataSource = table;

            grdTasks.Columns["Messages"].Visible = false;
            grdTasks.Columns["Title"].Width = grdTasks.Width;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtTitel.Clear();
            txtNachricht.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Color ccolor = Color.Empty;
            if (cboxHohePrioritaet.Checked == true)
            {
                ccolor = Color.LightCoral;
            }
            else if (cboxMittlereprioritaet.Checked == true)
            {
                ccolor = Color.LightBlue;
            }
            else if (cboxUnwichtig.Checked == true)
            {
                ccolor = Color.LightGreen;
            }

            int rowId = grdTasks.Rows.Add();
            DataGridViewRow row = grdTasks.Rows[rowId];
            row.Cells["Title"].Value = txtTitel.Text;
            row.Cells["Messages"].Value = txtNachricht.Text;
            row.DefaultCellStyle.BackColor = ccolor;
            



            txtTitel.Clear();
            txtNachricht.Clear();


        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            int index = grdTasks.CurrentCell.RowIndex;
            if (index > -1)
            {
                txtTitel.Text = table.Rows[index].ItemArray[0].ToString();
                txtNachricht.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = grdTasks.CurrentCell.RowIndex;
            table.Rows[index].Delete();
        }

        private void cboxHohePrioritaet_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxHohePrioritaet.Checked == true)
            {
                cboxMittlereprioritaet.Checked = false;
                cboxUnwichtig.Checked = false;
            }
        }

        private void cboxMittlereprioritaet_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxMittlereprioritaet.Checked == true)
            {
                cboxHohePrioritaet.Checked = false;
                cboxUnwichtig.Checked = false;
            }
        }

        private void cboxUnwichtig_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxUnwichtig.Checked == true)
            {
                cboxMittlereprioritaet.Checked = false;
                cboxHohePrioritaet.Checked = false;
            }
        }
    }
}
