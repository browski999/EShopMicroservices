
namespace Catalog.API.Data
{
    public class CatalogInitialData : IInitialData
    {
        public async Task Populate(IDocumentStore store, CancellationToken cancellation)
        {
            using var session = store.LightweightSession();

            if (await session.Query<Product>().AnyAsync())
                return;

            //MARTEN UPSERT will cater for existing records
            session.Store<Product>(GetPreconfiguredProducts());
            await session.SaveChangesAsync();
        }

        private IEnumerable<Product> GetPreconfiguredProducts() => new List<Product>()
        {
            new Product()
            {
                Id = new Guid("5334c996-8457-4cf0-815c-ed2b77c4ff61"),
                Name = "IPhone X",
                Description = "This phone is the company's biggest change to it's ",
                ImageFile = "product-1.png",
                Price = 950.00M,
                Category = new List<string>{ "Smart Phone"}
            },
            new Product()
            {
                Id = new Guid("5334c996-8457-4cf0-815c-ed2b77c4ff62"),
                Name = "Samsung 10",
                Description = "This phone is the company's biggest change to it's ",
                ImageFile = "product-2.png",
                Price = 850.00M,
                Category = new List<string>{ "Smart Phone"}
            },
            new Product()
            {
                Id = new Guid("5334c996-8457-4cf0-815c-ed2b77c4ff63"),
                Name = "OnePlus 9t",
                Description = "This phone is the company's biggest change to it's ",
                ImageFile = "product-3.png",
                Price = 800.00M,
                Category = new List<string>{ "Smart Phone"}
            },
            new Product()
            {
                Id = new Guid("5334c996-8457-4cf0-815c-ed2b77c4ff64"),
                Name = "Nokia 1A",
                Description = "This phone is the company's biggest change to it's ",
                ImageFile = "product-4.png",
                Price = 150.00M,
                Category = new List<string>{ "Smart Phone"}
            },
            new Product()
            {
                Id = new Guid("5334c996-8457-4cf0-815c-ed2b77c4ff65"),
                Name = "Po",
                Description = "This phone is the company's biggest change to it's ",
                ImageFile = "product-5.png",
                Price = 950.00M,
                Category = new List<string>{ "Smart Phone"}
            },
            new Product()
            {
                Id = new Guid("5334c996-8457-4cf0-815c-ed2b77c4ff66"),
                Name = "IPhone SE",
                Description = "This phone is the company's biggest change to it's ",
                ImageFile = "product-6.png",
                Price = 950.00M,
                Category = new List<string>{ "Smart Phone"}
            }
        };
    }
}