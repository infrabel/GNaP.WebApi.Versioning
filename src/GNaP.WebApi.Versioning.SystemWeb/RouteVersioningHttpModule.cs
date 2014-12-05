namespace GNaP.WebApi.Versioning
{
    using System.Web;
    using System.Web.Http;

    internal class RouteVersioningHttpModule : IHttpModule
    {
        private static readonly object ApplicationStartLock = new object();

        private static volatile bool _applicationStarted;

        public void Init(HttpApplication context)
        {
            if (!_applicationStarted)
            {
                lock (ApplicationStartLock)
                {
                    if (!_applicationStarted)
                    {
                        SetupAttributeBasedRouting();
                        _applicationStarted = true;
                    }
                }
            }
        }

        private static void SetupAttributeBasedRouting()
        {
            if (GlobalConfiguration.Configuration.Routes.Count == 0)
                GlobalConfiguration.Configure(config => config.MapHttpAttributeRoutes());
        }

        public void Dispose()
        {
        }
    }
}
