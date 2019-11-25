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
        

        
        private void Clearbutton_Click(object sender, EventArgs e)
        {
            nameBox.Text = "";
            ageBox.Text = "";
            seatBox.Text = "";
        }

        private void Addbuttton_Click(object sender, EventArgs e)
        {
            Person p1 = new Person(nameBox.Text, Convert.ToInt32(ageBox.Text));
            int SeatNo = coach.AddPerson(p1);
            seatBox.Text = SeatNo + "";
        }

        private void Removebutton_Click(object sender, EventArgs e)
        {
            coach.RemovePersonByName(Name.Text);
        }

        private void Getbutton_Click_1(object sender, EventArgs e)
        {
            seatBox.Text = coach.GetSeatByName(nameBox.Text) + "";
        }
    }
}
