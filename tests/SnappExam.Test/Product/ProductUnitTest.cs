using Infrastructure.Persistence.Ef;
using SnappExam.Core.Application.CommandHandlers;
using SnappExam.Core.Application.Commands;
using SnappExam.Infrastructure.Persistence.EF.Contracts;
using SnappExam.Infrastructure.Persistence.EF.Repositories;

namespace SnappExam.Test.Product
{
    public class ProductUnitTest
    {
        readonly IProductRepository _productRepository;
        public ProductUnitTest()
        {
            _productRepository = new ProductRepository(new ApplicationDbContext());
        }

        [Fact]
        public async Task ShouldBeAddNewProduct()
        {
            //Arrange
            var command = new AddProductCommand("test", 1500, 2);
            var commandHandler = new AddProductCommandHandler(_productRepository);
            //Act
            var result = await commandHandler.Handle(command, default);

            //Assert            
            Assert.NotEqual(0, result);
        }

        [Fact]
        public async Task ShouldBeTrueIfProductTitleExists()
        {
            var result = await _productRepository.IsProductTitleExists("test", default);
            Assert.True(result);
        }



    }
}