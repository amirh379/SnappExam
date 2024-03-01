using DGLand.Logistic.Tests.Persistence;
using Infrastructure.Persistence.Ef;
using SnappExam.Core.Application.CommandHandlers;
using SnappExam.Core.Application.Commands;
using SnappExam.Infrastructure.Persistence.EF.Contracts;
using SnappExam.Infrastructure.Persistence.EF.Repositories;

namespace SnappExam.Test.Product
{
    public class ProductUnitTest : BasePersistenceTest
    {
        readonly IProductRepository _productRepository;
        public ProductUnitTest()
        {
            _productRepository = new ProductRepository(_DbContext);
        }

        [Fact]
        public async Task ShouldBeAddNewProduct()
        {
            //Arrange
            var command = new AddProductCommand("test2", 1500, 2);
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