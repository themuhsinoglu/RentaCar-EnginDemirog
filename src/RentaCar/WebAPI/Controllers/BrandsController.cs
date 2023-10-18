using Application.Features.Brands.Commands.Create;
using Application.Features.Brands.Commands.Delete;
using Application.Features.Brands.Commands.Update;
using Application.Features.Brands.Queries.GetById;
using Application.Features.Brands.Queries.GetList;
using Core.Application.Requests;
using Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : BaseController
    {


        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateBrandCommand createBrandCommand)
        {
            CreatedBrandResponse response = await Mediator!.Send(createBrandCommand);
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListBrandQuery getListBrandQuery = new GetListBrandQuery { PageRequest = pageRequest };

            GetListResponse<GetListBrandListItemDto> respponse = await Mediator!.Send(getListBrandQuery);

            return Ok(respponse);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            GetByIdBrandQuery getByIdBrandQuery = new GetByIdBrandQuery { Id = id };

            GetByIdBrandResponse respponse = await Mediator!.Send(getByIdBrandQuery);

            return Ok(respponse);
        }

        [HttpPut]
        public async Task<IActionResult> Add([FromBody] UpdateBrandCommand updateBrandCommand)
        {
           UpdatedBrandResponse response= await Mediator !.Send(updateBrandCommand);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Add([FromRoute] Guid id)
        {
           

            DeletedBrandResponse response = await Mediator!.Send(new DeleteBrandCommand { Id = id});

            return Ok(response);
        }


    }
}

