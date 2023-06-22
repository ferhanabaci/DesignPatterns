using DesignPattern.Meditor.DAL;
using DesignPattern.Meditor.MediatorPattern.Queries;
using DesignPattern.Meditor.MediatorPattern.Results;
using MediatR;

namespace DesignPattern.Meditor.MediatorPattern.Handlers
{
    public class GetUpdateByIDQueryHandler : IRequestHandler<GetProductUpdateByIDQuery, GetProductUpdateQueryResult>
    {
        private readonly Context _context;

        public GetUpdateByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetProductUpdateQueryResult> Handle(GetProductUpdateByIDQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Products.FindAsync(request.Id);
            return new GetProductUpdateQueryResult
            {
                ProductID = values.ProductID,
                ProductName = values.ProductName,
                ProductCategory = values.ProductCategory,
                ProductPrice = values.ProductPrice,
                ProductStock = values.ProductStock,
                ProductStockType = values.ProductStockType,
            };
        }
    }
}
