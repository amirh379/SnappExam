using DGLand.Logistic.Tests.Persistence;
using SnappExam.Core.Domain.Models.Users;
using SnappExam.Infrastructure.Persistence.EF.Contracts;
using SnappExam.Infrastructure.Persistence.EF.Repositories;

namespace SnappExam.Test.UserTests
{
    public class UserUnitTest : BasePersistenceTest
    {
        
        [Fact]
        public async Task ShouldBeNotNull()
        {
            // Arrange
            IRepository<User>  _repository = new Repository<User>(_DbContext);
            
            //Act            
            var employees = await _repository.GetAll(default);

            //Assert
            Assert.NotNull(employees);
            Assert.Equal(10, employees.Count());
        }

    }
}
