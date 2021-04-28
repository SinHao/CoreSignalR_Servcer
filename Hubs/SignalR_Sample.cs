using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreSignalR_Servcer.Hubs
{
    public class SignalR_Sample : Microsoft.AspNetCore.SignalR.Hub
    {
        public async Task ServerMethod1(string userName, string message)
        {
            await this.Clients.All.SendCoreAsync("ClientMethod1", new object[] { userName, message });
        }
    }
}
