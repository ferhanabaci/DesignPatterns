using DesignPattern.Meditor.MediatorPattern.Results;
using MediatR;

namespace DesignPattern.Meditor.MediatorPattern.Queries
{
    public class GetAllProductQuery : IRequest<List<GetAllProductQueryResult>> 
    {
    }
}
