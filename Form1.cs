using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentAssignment;

namespace StudentAssignment
{
    public partial class Form1 : Form
    {
        List<Student> studentsList = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
           
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentsList.Add(new Student() { FirstName = textBox1.Text, LastName = textBox2.Text, Address = textBox3.Text, Age = textBox4.Text, Major = textBox4.Text });
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = studentsList;

        }
    }
}
