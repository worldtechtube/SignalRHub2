using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRHub2
{
    public interface ITypedHubClient
    {
        Task BroadcastMessage(Message message);
    }
}
