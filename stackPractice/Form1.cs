using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stackPractice
{
    public partial class Form1 : Form
    {
        Stack<EmailReceived> myEmail = new Stack<EmailReceived>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //we are assuming "today" is saturday

            myEmail.Push(new EmailReceived("John", 
                "Let's go for a walk next week on Monday.", DayOfWeek.Sunday));
            myEmail.Push(new EmailReceived("Mary", 
                "I talked to John about going for a walk next week on Monday.", DayOfWeek.Monday));
            myEmail.Push(new EmailReceived(
                "Smith", "Anna and I will be going to a movie next Sunday.", DayOfWeek.Tuesday));
            myEmail.Push(new EmailReceived(
                "Anna", "Smith and I will be going to see a movie on Sunday", DayOfWeek.Wednesday));
            myEmail.Push(new EmailReceived(
                "John", "I can no longer make it to hangout guys....", DayOfWeek.Thursday));
            myEmail.Push(new EmailReceived(
                "Mary", "We need to meet tomorrow.", DayOfWeek.Friday));

            do
            {
                EmailReceived anyEmail = (EmailReceived)myEmail.Pop();

                MessageBox.Show(anyEmail.from + ": " + anyEmail.content + "\nSent: " + anyEmail.dayReceived.ToString());
            }
            while (myEmail.Count != 0);
        }
    }
}
