using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASP.NETCoreRepositoryPattern.Models;
using ASP.NETCoreRepositoryPattern.Data.EFCoreLayer;

namespace ASP.NETCoreRepositoryPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : MyBaseController<Product, EfCoreProductRepository>
    {
        public ProductsController(EfCoreProductRepository context) : base(context)
        {
          
        }

    }
}
