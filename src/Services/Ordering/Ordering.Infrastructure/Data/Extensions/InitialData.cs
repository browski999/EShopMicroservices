namespace Ordering.Infrastructure.Data.Extensions;

internal static class InitialData
{
    public static IEnumerable<Customer> Customers =>
        new List<Customer>
        {
            Customer.Create(CustomerId.Of(new Guid("afde1df6-025f-46b5-91ae-9dacbc3e1cb5")), "Robert", "rob@bt.com"),
            Customer.Create(CustomerId.Of(new Guid("b9236c95-c2e6-4a2a-80af-804f57b9f383")), "Peter", "pete@bt.com")
        };

    public static IEnumerable<Product> Products =>
        new List<Product>
        {
            Product.Create(ProductId.Of(new Guid("06c3fd40-7614-41d0-981a-7292b3f8f5a5")), "Radio", 10.99M),
            Product.Create(ProductId.Of(new Guid("7ece089f-e053-400a-9e4c-01e7a4345624")), "Television", 15.99M),
            Product.Create(ProductId.Of(new Guid("fe5bf78e-6d30-402e-a91a-2ac937182202")), "Garden Shed", 200.99M),
            Product.Create(ProductId.Of(new Guid("6a707244-5bf7-4425-97cc-6168921533a8")), "Sports Car", 15000.99M)
        };

    public static IEnumerable<Order> OrdersWithItems
    {
        get
        {
            var address1 = Address.Of("Robert", "Wright", "robert.wright@bt.com", "1 High Street", "UK", "Surrey", "CR27E");
            var address2 = Address.Of("Robert", "Wright", "robert.wright@bt.com", "1 High Street", "UK", "Surrey", "CR28T");

            var payment1 = Payment.Of("Robert", "12345678", "11/27", "424", 1);
            var payment2 = Payment.Of("Peter", "12343878", "08/29", "245", 2);

            var order1 = Order.Create(
                OrderId.Of(Guid.NewGuid()),
                CustomerId.Of(new Guid("afde1df6-025f-46b5-91ae-9dacbc3e1cb5")),
                OrderName.Of("Orde1"),
                shippingAddress: address1,
                billingAddress: address1,
                payment1);

            order1.Add(ProductId.Of(new Guid("06c3fd40-7614-41d0-981a-7292b3f8f5a5")), 2, 21.98M);
            order1.Add(ProductId.Of(new Guid("7ece089f-e053-400a-9e4c-01e7a4345624")), 3, 47.97M);

            var order2 = Order.Create(
                OrderId.Of(Guid.NewGuid()),
                CustomerId.Of(new Guid("b9236c95-c2e6-4a2a-80af-804f57b9f383")),
                OrderName.Of("Orde2"),
                shippingAddress: address2,
                billingAddress: address2,
                payment2);

            order2.Add(ProductId.Of(new Guid("fe5bf78e-6d30-402e-a91a-2ac937182202")), 2, 401.98M);
            order2.Add(ProductId.Of(new Guid("6a707244-5bf7-4425-97cc-6168921533a8")), 3, 45000.97M);

            return new List<Order> { order1, order2 };
        }
    }   
}