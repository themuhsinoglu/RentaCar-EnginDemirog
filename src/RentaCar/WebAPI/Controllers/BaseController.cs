using System;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class BaseController : ControllerBase
    {
        //attemtp commit 
        private IMediator? _mediator;
        protected IMediator? Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

    }
}

