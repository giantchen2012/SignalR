﻿
namespace Microsoft.AspNet.SignalR.Stress
{
    public class RunData
    {
        public string Transport { get; set; }
        public string Payload { get; set; }
        public int Senders { get; set; }
        public int Connections { get; set; }
    }
}
