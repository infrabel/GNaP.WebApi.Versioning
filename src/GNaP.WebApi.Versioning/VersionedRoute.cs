namespace GNaP.WebApi.Versioning
{
    using System.Collections.Generic;
    using System.Web.Http.Routing;

    public class VersionedRoute : RouteFactoryAttribute
    {
        public int Version { get; private set; }

        public override IDictionary<string, object> Constraints
        {
            get
            {
                return new HttpRouteValueDictionary
                {
                    { "version", new VersionConstraint(Version) }
                };
            }
        }

        public VersionedRoute()
            : this(string.Empty)
        {
        }

        public VersionedRoute(string template)
            : this(template, 1)
        {
        }

        public VersionedRoute(string template, int version)
            : base(template)
        {
            Version = version;
        }
    }
}
