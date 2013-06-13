using System.Net;
using System.Net.Browser;
using System.Threading;
using System.Windows.Controls;
using Microsoft.AspNet.SignalR.Client.Samples;

namespace Microsoft.AspNet.SignalR.Client.Silverlight.Samples
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();

            bool httpResult = WebRequest.RegisterPrefix("http://", WebRequestCreator.ClientHttp);
            bool httpsResult = WebRequest.RegisterPrefix("https://", WebRequestCreator.ClientHttp);

            var writer = new TextBlockWriter(SynchronizationContext.Current, this.Messages);
            var client = new CommonClient(writer);
            var task = client.RunAsync();
        }
    }
}
