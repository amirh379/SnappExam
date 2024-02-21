using Infrastructure.Persistence.Ef;
using Moq;
using Moq.EntityFrameworkCore;
using SnappExam.Core.Domain.Models.Users;
using SnappExam.Infrastructure.Persistence.EF.Contracts;
using SnappExam.Infrastructure.Persistence.EF.Repositories;
using SnappExam.Test.Fixture;

namespace SnappExam.Test.UserTests
{
    public class UserUnitTest
    {
        IRepository<User> _repository;

        [Fact]
        public async Task ShouldBeNotNull()
        {
            // Arrange
            var employeeContextMock = new Mock<ApplicationDbContext>();
            employeeContextMock.Setup(x => x.Users).ReturnsDbSet(FakeData.GetFakeUserList());

            //Act
            _repository = new Repository<User>(employeeContextMock.Object);
            var employees = await _repository.GetAll(default);

            //Assert
            Assert.NotNull(employees);
            Assert.Equal(10, employees.Count());
        }

    }
}
