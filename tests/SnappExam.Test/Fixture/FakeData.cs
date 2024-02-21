using GenFu;
using SnappExam.Core.Domain.Models.Users;

namespace SnappExam.Test.Fixture
{
    public class FakeData
    {
        public static List<User> GetFakeUserList()
        {
            var id = 1;
            A.Configure<User>().Fill(c => c.Id, () => id++);
            return A.ListOf<User>(10);            
        }
    }
}
