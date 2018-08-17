using System.Net.Http;
using Ocelot.Logging;
using Ocelot.Requester.QoS;

namespace Ocelot.Provider.Polly
{
    public delegate IQoSProvider QosProviderDelegate(DownstreamReRoute reRoute, IOcelotLoggerFactory factory);
}
