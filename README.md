# stack-email-demo

---

### Description: This is a demonstration of how an email management system might keep track of received emails using a Stack. Custom enumerator used to track day of the week.

---

## Setting up the emails.

```C#

namespace stackPractice
{
    enum DayOfWeek
    {
        Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
    }
    class EmailReceived
    {
        internal string from;
        internal string content;
        internal DayOfWeek dayReceived;

        public EmailReceived()
        {
            //empty default constructor
        }
        public EmailReceived(string pName, string pContent, DayOfWeek pDayReceived)
        {
            from = pName;
            content = pContent;
            dayReceived = pDayReceived;
        }
    }
}
```

---

## Viewing the emails.

```C#
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

            if(myEmail.Count == 0)
            {
                this.Close();
            }
        }
    }
}
```

In this case, the "emails" are simply text boxes that pop-up on the screen contianing the email's information:

![email-box](https://github.com/EnEmerson/stack-email-demo/blob/master/resources/email-box.png)




