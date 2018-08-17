using System.Net.Http;
using Ocelot.Logging;
using Ocelot.Requester.QoS;

namespace Ocelot.Provider.Polly
{
    public delegate DelegatingHandler LastDelegatingHandlerDelegate(QosProviderDelegate provider, DownstreamReRoute reRoute, IOcelotLoggerFactory factory);
}
