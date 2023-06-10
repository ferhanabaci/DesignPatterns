using DesignPattern.CQRS.CQRSPattern.Commands;
using DesignPattern.CQRS.CQRSPattern.Handlers;
using DesignPattern.CQRS.CQRSPattern.Queries;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.CQRS.Controllers
{
    public class DefaultController : Controller
    {
        private readonly GetProductQueryHandler _getProductQueryHandler;
        private readonly CreateProductCommandHandler _createProductCommandHandler;
        private readonly GetProductByIDQueryHandler _getProductByIDQueryHandler;
        private readonly ProductRemoveCommandHandler _productRemoveCommandHandler;
        private readonly GetProducyUpdateByIDQueryHandler _getProductProducyUpdateByIDQueryHandler;
        private readonly UpdateProductCommandHandler _updateProductCommandHandler;

        public DefaultController(GetProductQueryHandler getProductQueryHandler, CreateProductCommandHandler createProductCommandHandler, GetProductByIDQueryHandler getProductByIDQueryHandler, ProductRemoveCommandHandler productRemoveCommandHandler, GetProducyUpdateByIDQueryHandler getProductProducyUpdateByIDQueryHandler, UpdateProductCommandHandler updateProductCommandHandler)
        {
            _getProductQueryHandler = getProductQueryHandler;
            _createProductCommandHandler = createProductCommandHandler;
            _getProductByIDQueryHandler = getProductByIDQueryHandler;
            _productRemoveCommandHandler = productRemoveCommandHandler;
            _getProductProducyUpdateByIDQueryHandler = getProductProducyUpdateByIDQueryHandler;
            _updateProductCommandHandler = updateProductCommandHandler;
        }

        public IActionResult Index()
        {
            var values = _getProductQueryHandler.Handle();
            return View( values);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(CreateProductCommand command)
        {
            _createProductCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }

        public IActionResult GetProduct(int id)
        {
            var values = _getProductByIDQueryHandler.Handle(new GetProductByIDQuery(id));
            return View(values);
        }
        public IActionResult DeleteProduct(int id)
        {
            _productRemoveCommandHandler.Handle(new RemoveProductCommand(id));
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var values = _getProductProducyUpdateByIDQueryHandler.Handle(new GetProductUpdateByIdQuery(id));
            return View(values);

        }
        [HttpPost]
        public IActionResult UpdateProduct(UpdateProductCommand command)
        {
            _updateProductCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
    }
}
