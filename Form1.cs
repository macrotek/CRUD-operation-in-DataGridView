using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewApplication
{
    public partial class Form1 : Form
    {
        DataTable table = new DataTable("table");
        int index;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("ID Number", Type.GetType("System.Int32"));
            table.Columns.Add("First Name", Type.GetType("System.String"));
            table.Columns.Add("Last Name", Type.GetType("System.String"));
            table.Columns.Add("Department", Type.GetType("System.String"));
            dataGridView1.DataSource = table;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            table.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow dgridrow = dataGridView1.Rows[index];
            textBox1.Text = dgridrow.Cells[0].Value.ToString();
            textBox2.Text = dgridrow.Cells[1].Value.ToString();
            textBox3.Text = dgridrow.Cells[2].Value.ToString();
            textBox4.Text = dgridrow.Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdata = dataGridView1.Rows[index];
            newdata.Cells[0].Value = textBox1.Text;
            newdata.Cells[1].Value = textBox2.Text;
            newdata.Cells[2].Value = textBox3.Text;
            newdata.Cells[3].Value = textBox4.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
        }
    }
}
