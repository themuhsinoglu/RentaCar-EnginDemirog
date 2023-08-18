using Application.Features.Brands.Commands.Create;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : BaseController
    {
       
        
        [HttpPost]
        public async Task<IActionResult> Add([FromBody]CreateBrandCommand value)
        {
           CreatedBrandResponse res= await Mediator.Send(value);
            return Ok(res);
        }

       
    }
}

