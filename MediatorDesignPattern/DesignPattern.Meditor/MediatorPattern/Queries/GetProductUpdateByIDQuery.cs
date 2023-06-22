using DesignPattern.Meditor.MediatorPattern.Results;
using MediatR;

namespace DesignPattern.Meditor.MediatorPattern.Queries
{
    public class GetProductUpdateByIDQuery : IRequest<GetProductUpdateQueryResult>
    {
        public GetProductUpdateByIDQuery(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
