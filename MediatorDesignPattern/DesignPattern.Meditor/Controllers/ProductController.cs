using DesignPattern.Meditor.MediatorPattern.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Meditor.Controllers
{
    public class ProductController : Controller
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetAllProductQuery());
            return View(values);
        }
    }
}
