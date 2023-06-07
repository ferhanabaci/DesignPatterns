using DesignPattern.CQRS.CQRSPattern.Results;
using DesignPattern.CQRS.DAL;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class GetProductQueryHandler
    {
        private readonly Context _context;
        public GetProductQueryHandler() { _context = new Context(); }

        public List<GetProductQueryResult> Handle()
        {
            var values = _context.Products.Select(x => new GetProductQueryResult
            {

                ID = x.ProductId,
                Price = x.Price,
                ProductName = x.Name,
                Stock = x.Stock,

            }).ToList();
            return values;
        }
    }
}
