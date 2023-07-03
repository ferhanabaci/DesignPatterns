using DesignPattern.Meditor.MediatorPattern.Commands;
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

        public async Task<IActionResult> GetProduct(int id)
        {
            var values = await _mediator.Send(new GetProductByIDQuery(id));
            return View(values);
        }
        public async Task<IActionResult> RemoveProduct(int id)
        {
            await _mediator.Send(new RemoveProductCommand(id));
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateProduct(int id)
        {
           var values = await _mediator.Send(new GetProductUpdateByIDQuery(id));
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateProduct(UpdateProductCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost] 
        public async Task<IActionResult> AddProduct(CreateProductCommand createProductCommand)
        {
            await _mediator.Send(createProductCommand);
            return RedirectToAction("Index");
        }
    }
}
