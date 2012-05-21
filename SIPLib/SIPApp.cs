﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIPLib
{
    public abstract class SIPApp
    {
        public abstract string[] Authenticate(UserAgent ua, Header header, SIPStack sIPStack);

        public abstract void DialogCreated(Dialog dialog, UserAgent ua, SIPStack sIPStack);

        public abstract void Cancelled(UserAgent ua, Message request, SIPStack sIPStack);

        public abstract void ReceivedResponse(UserAgent ua, Message response, SIPStack sIPStack);

        public abstract void ReceivedRequest(UserAgent ua, Message request, SIPStack sIPStack);

        public abstract void Sending(UserAgent ua, Message message, SIPStack sIPStack);

        public abstract UserAgent createServer(Message request, SIPURI uri, SIPStack sIPStack);

        public abstract Timer createTimer(UserAgent obj, SIPStack sIPStack);

        public abstract void send(string final_data, string destination_host, int destination_port, SIPStack sIPStack);

        public abstract TransportInfo transport { get; set; }

        public abstract SIPStack stack { get; set; }

        public virtual event EventHandler<RawEventArgs> Received_Data_Event;
    }
}
