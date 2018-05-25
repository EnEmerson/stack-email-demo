using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
