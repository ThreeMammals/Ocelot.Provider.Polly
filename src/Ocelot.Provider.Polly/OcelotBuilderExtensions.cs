namespace Ocelot.Provider.Polly
{
    using DependencyInjection;

    public static class OcelotBuilderExtensions
    {
        public static IOcelotBuilder AddSomething(this IOcelotBuilder builder)
        {
            return builder;
        }
    }
}
