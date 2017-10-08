using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThirdExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            if ( calendar.SelectionEnd.DayOfWeek.ToString() == "Monday")
            {
                textBoxForDay.Text = "Понедельник";
            }
            else if (calendar.SelectionEnd.DayOfWeek.ToString() == "Tuesday")
            {
                textBoxForDay.Text = "Вторник";
            }
            else if (calendar.SelectionEnd.DayOfWeek.ToString() == "Wednesday")
            {
                textBoxForDay.Text = "Среда";
            }
            else if (calendar.SelectionEnd.DayOfWeek.ToString() == "Thursday")
            {
                textBoxForDay.Text = "Четверг";
            }
            else if (calendar.SelectionEnd.DayOfWeek.ToString() == "Friday")
            {
                textBoxForDay.Text = "Пятница";
            }
            else if (calendar.SelectionEnd.DayOfWeek.ToString() == "Saturday")
            {
                textBoxForDay.Text = "Суббота";
            }
            else if (calendar.SelectionEnd.DayOfWeek.ToString() == "Sunday")
            {
                textBoxForDay.Text = "Воскресенье";
            }
        }

       
    }
}
