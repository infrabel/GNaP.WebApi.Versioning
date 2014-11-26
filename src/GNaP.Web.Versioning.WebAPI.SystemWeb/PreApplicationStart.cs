using System.Web;
using GNaP.Web.Versioning.WebAPI;

[assembly:PreApplicationStartMethod (typeof(PreApplicationStart), "Start")]
namespace GNaP.Web.Versioning.WebAPI
{
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    public class PreApplicationStart
    {
        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(RouteVersioningHttpModule));
        }
    }
}
