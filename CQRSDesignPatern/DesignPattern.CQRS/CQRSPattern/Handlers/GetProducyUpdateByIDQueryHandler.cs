using DesignPattern.CQRS.CQRSPattern.Queries;
using DesignPattern.CQRS.CQRSPattern.Results;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class GetProducyUpdateByIDQueryHandler
    {
        private readonly Context _context;

        public GetProducyUpdateByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public GetProductUpdateQueryResult Handle(GetProductUpdateByIdQuery query)
        {
            var values = _context.Products.Find(query.Id);
            return new GetProductUpdateQueryResult
            {
                Description = values.Description,
                Name = values.Name,
                Price = values.Price,
                Stock = values.Stock,
                ProductId = values.ProductId,
            };
        }
    }
}
