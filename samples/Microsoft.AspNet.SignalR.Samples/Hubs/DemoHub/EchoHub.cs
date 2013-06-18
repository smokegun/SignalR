using System.Threading.Tasks;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR.Hubs;

namespace Microsoft.AspNet.SignalR.Samples.Hubs.DemoHub
{
    public class EchoHub : Hub
    {
        public Task Echo(int value)
        {
            return Clients.Caller.echo(value);
        }
    }
}