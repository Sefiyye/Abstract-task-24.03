using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Task
{
     class EmailSender:MessageSender
    {
        public override string SendMessage()
        {
            return $"Masage sent via Email";
        }
    }
}
