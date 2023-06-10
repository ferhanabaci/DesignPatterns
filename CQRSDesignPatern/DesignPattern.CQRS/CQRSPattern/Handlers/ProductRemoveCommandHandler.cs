using DesignPattern.CQRS.CQRSPattern.Commands;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class ProductRemoveCommandHandler
    {
        private readonly Context _context;

        public ProductRemoveCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(RemoveProductCommand remove)
        {
            var values = _context.Products.Find(remove.Id);
            _context.Products.Remove(values);
            _context.SaveChanges();
        }
    }
}
