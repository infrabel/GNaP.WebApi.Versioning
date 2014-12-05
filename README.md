GNaP.WebApi.Versioning
======================

## Usage

Install from NuGet in your Web API project: ```Install-Package GNaP.WebApi.Versioning```

You can now use ```VersionedRoute``` instead of ```Route``` in your controllers to get API versioning for free on your routes.

Remember to turn on [Attribute Based Routing](http://www.asp.net/web-api/overview/web-api-routing-and-actions/attribute-routing-in-web-api-2) with [MapHttpAttributeRoutes()](http://msdn.microsoft.com/en-us/library/dn479134%28v=vs.118%29.aspx) on your Web API configuration, in case it isn't already there (e.g.: Visual Studio 2012 Web API template does not contain it).

## Example

### Version 1 Controller
```csharp
namespace GNaP.WebApi.Versioning.Example.Controllers
{
    using System.Web.Http;
    using GNaP.WebApi.Versioning;

    [RoutePrefix("api/customers")]
    public class CustomerVersion1Controller : ApiController
    {
        [VersionedRoute("")]
        public IHttpActionResult Get()
        {
            return Json(...);
        }

        [VersionedRoute("{id:int:min(1)}")]
        public IHttpActionResult Get(int id)
        {
            return Json(...);
        }
    }
}
```

### Version 2 Controller
```csharp
namespace GNaP.WebApi.Versioning.Example.Controllers
{
    using System.Web.Http;
    using GNaP.WebApi.Versioning;

    [RoutePrefix("api/customers")]
    public class CustomerVersion2Controller : ApiController
    {
        [VersionedRoute("", 2)]
        public IHttpActionResult Get()
        {
            return Json(...);
        }

        [VersionedRoute("{id:int:min(1)}", 2)]
        public IHttpActionResult Get(int id)
        {
            return Json(...);
        }
    }
}
```

## Supported Versioning Strategies

### Query string
```
GET /api/customers/42?v=2
```

### Api-version header
```
GET /api/customers/42
api-version: 2
```

### Accept header
```
GET /api/customers/42
Accept: application/vnd.gnap.v2+json
```

## NuGet

[GNaP.WebApi.Versioning](http://www.nuget.org/packages/GNaP.WebApi.Versioning/)

## Copyright

Copyright © 2014 Infrabel and contributors.

## License

GNaP.WebApi.Versioning is licensed under [BSD (3-Clause)](http://choosealicense.com/licenses/bsd-3-clause/ "Read more about the BSD (3-Clause) License"). Refer to [LICENSE](https://github.com/infrabel/GNaP.WebApi.Versioning/blob/master/LICENSE) for more information.
