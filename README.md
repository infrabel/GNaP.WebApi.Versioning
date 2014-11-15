GNaP.CSharp.Web.Versioning
==========================

## Usage

Add a reference to [GNaP.Web.Versioning.dll](https://github.com/infrabel/GNaP.CSharp.Web.Versioning/raw/master/deploy/1.0.0.0/GNaP.Web.Versioning/GNaP.Web.Versioning.dll) in your Web API project.

You can now use ```VersionedRoute``` instead of ```Route``` in your controllers to get API versioning for free on your routes.

## Example

### Version 1 Controller
```
namespace GNaP.Web.Versioning.Example.Controllers
{
    using System.Web.Http;
    using GNaP.Web.Versioning;

    [RoutePrefix("api/customers")]
    public class CustomerVersion1Controller : ApiController
    {
        [VersionedRoute("", 1)]
        public IHttpActionResult Get()
        {
            return Json(...);
        }

        [VersionedRoute("{id:int:min(1)}", 1)]
        public IHttpActionResult Get(int id)
        {
            return Json(...);
        }
    }
}
```

### Version 2 Controller
```
namespace GNaP.Web.Versioning.Example.Controllers
{
    using System.Web.Http;
    using GNaP.Web.Versioning;

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

## Copyright

Copyright © 2014 Infrabel and contributors.

## License

GNaP.CSharp.Web.Versioning is licensed under [BSD (3-Clause)](http://choosealicense.com/licenses/bsd-3-clause/ "Read more about the BSD (3-Clause) License"). Refer to [LICENSE](https://github.com/infrabel/GNaP.CSharp.Web.Versioning/blob/master/LICENSE) for more information.
