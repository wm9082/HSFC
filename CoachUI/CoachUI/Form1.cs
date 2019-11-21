using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoachUI
{
    public partial class Form1 : Form
    {
        Coach coach = new Coach();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Person p1 = new Person(name.Text, Convert.ToInt32(age.Text));
       
            int seatnum = coach.AddPerson(p1);
            seat.Text = seatnum + "";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            name.Text = "";
            age.Text = "";
            seat.Text = "";
        }

        private void getButton_Click(object sender, EventArgs e)
        {
            seat.Text = coach.GetSeatByName(name.Text) + "";
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            coach.RemovePersonByName(name.Text);
        }
    }
}
