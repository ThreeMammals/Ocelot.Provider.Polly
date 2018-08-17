namespace Ocelot.Provider.Polly
{
    using DependencyInjection;
    using Microsoft.Extensions.DependencyInjection;

    public static class OcelotBuilderExtensions
    {
        public static IOcelotBuilder AddSomething(this IOcelotBuilder builder)
        {
            QosProviderDelegate qosDelegate = (reRoute, factory) => {
                return new PollyQoSProvider(reRoue, factory);
            };

            LastDelegatingHandlerDelegate lastDelegatingHandler = (qosDelegate, reRoute, logger) => {
                return new PollyCircuitBreakingDelegatingHandler(qosDelegate(reRoute), logger);
            };

            builder.Services.AddSingleton<QosProviderDelegate>(lastDelegatingHandler);
            builder.Services.AddSingleton<LastDelegatingHandlerDelegate>(lastDelegatingHandler);
            return builder;
        }
    }
}
