using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_7_4_Dating_Game
{
    class Messages
    {
        public Dating_Profile sender;
        public string messageTitle;
        public string messageData;
        public bool isRead;

        public Messages(Dating_Profile sender, string messageTitle, string messageData)
        {
            this.sender = sender;
            this.messageTitle = messageTitle;
            this.messageData = messageData;
            isRead = false;
        }

    }
}

