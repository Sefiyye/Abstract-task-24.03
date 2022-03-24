using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Task
{
     class SmsSender: MessageSender
    {
        public override string SendMessage()
        {
            return $"Masage sent via SMS";
        }
    }
}
