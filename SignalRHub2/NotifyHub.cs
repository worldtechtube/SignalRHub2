using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRHub2
{
    public class NotifyHub : Hub<ITypedHubClient>
    {
    }
}
