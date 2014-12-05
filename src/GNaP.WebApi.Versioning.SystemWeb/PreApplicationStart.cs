using System.Web;
using GNaP.WebApi.Versioning;

[assembly:PreApplicationStartMethod (typeof(PreApplicationStart), "Start")]
namespace GNaP.WebApi.Versioning
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
