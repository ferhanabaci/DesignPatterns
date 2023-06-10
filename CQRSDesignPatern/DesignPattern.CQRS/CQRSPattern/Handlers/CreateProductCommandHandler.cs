using DesignPattern.CQRS.CQRSPattern.Commands;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class CreateProductCommandHandler
    {
        private readonly Context _context;

        public CreateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(CreateProductCommand commad)
        {
            _context.Products.Add(new Product
            {
                Name = commad.Name,
                Description = commad.Description,
                Price = commad.Price,
                Status = true,
                Stock = commad.Stock,
            });
            _context.SaveChanges();
        }
    }
}
