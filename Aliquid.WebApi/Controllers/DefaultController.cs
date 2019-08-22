namespace Aliquid.WebApi.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Application;
    using MediatR;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.DependencyInjection;

    [ApiController]
    [Route("api/[controller]/[action]")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public class DefaultController : Controller
    {
        private IMediator _mediator;

        private IMediator Mediator => _mediator ?? (_mediator = HttpContext.RequestServices.GetService<IMediator>());
        
        public async Task<ActionResult<IEnumerable<int>>> GetChange(decimal money, decimal itemPrice)
        {
            return Ok(await Mediator.Send(new GetChangeRequest
            {
                Money = money,
                ItemPrice = itemPrice
            }));
        }
    }
}