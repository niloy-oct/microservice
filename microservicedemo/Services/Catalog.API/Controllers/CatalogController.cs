using System.Net;
using Catalog.API.Interfaces.Manager;
using Catalog.API.Models;
using CoreApiResponse;
using Microsoft.AspNetCore.Mvc;
namespace Catalog.API.Controllers;


[Route("api/[controller]/[action]")]
[ApiController]
public class CatalogController : BaseController
{
   private IProductManager _productManager;
   public ILogger<CatalogController> _logger;

   public CatalogController(IProductManager productManager, ILogger<CatalogController> logger)
   {
      _productManager = productManager;
      _logger = logger;
   }


   [HttpGet]
   [ProducesResponseType(typeof(IEnumerable<Product>),(int)HttpStatusCode.OK)]
   public IActionResult GetProducts()
   {
      var products = _productManager.GetAll();
      return CustomResult("Data get successfully",products, HttpStatusCode.OK);
   }
}