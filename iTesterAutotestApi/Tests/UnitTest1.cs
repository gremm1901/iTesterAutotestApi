using iTesterPlatformAutotest.Client;
using iTesterPlatformAutotest.Entities.Requests;

namespace iTesterAutotestApi.Tests
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            var user = new AuthRequest
            {
                Login = "string121233",
                Password = "111111"
            };
            var user1 = new LoginRequest
            {
                Login = "string121233"
            };
            var client = new ITesterClient("https://itester.online");
            client.AuthClient(user);
            var asd = client.PasswordReset(user1);
            Console.WriteLine(asd.Content);
            var qwe = client.GetScores();
            Console.WriteLine(qwe.Content);
        }
    }
}