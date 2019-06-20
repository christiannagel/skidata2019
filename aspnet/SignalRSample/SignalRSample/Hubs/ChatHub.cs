using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRSample.Hubs
{
    public class ChatHub : Hub
    {
        public void MyMessage(string name, string message)
        {
            base.Clients.All.SendAsync("MyBroadcast", name, message);
        }
    }
}
