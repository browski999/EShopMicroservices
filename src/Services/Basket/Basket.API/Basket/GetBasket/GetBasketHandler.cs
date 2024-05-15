
namespace Basket.API.Basket.GetBasket
{
    public record GetBasketQuery(string username) : IQuery<GetBasketResult>;
    public record GetBasketResult(ShoppingCart ShoppingCart);

    public class GetBasketQueryHandler : IQueryHandler<GetBasketQuery, GetBasketResult>
    {
        public async Task<GetBasketResult> Handle(GetBasketQuery query, CancellationToken cancellationToken)
        {
            //TODO: get basket from the database
            //var basket = await _repository.GetBasket(request.Username);

            return new GetBasketResult(new ShoppingCart("swn"));
        }
    }
}