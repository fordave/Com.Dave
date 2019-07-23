using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityDemo
{
    [UserHandlerAttribute(Order = 1)]
    [LogHandlerAttribute(Order = 2)]
    [ExceptionHandlerAttribute(Order = 3)]
    [AfterLogHandlerAttribute(Order = 4)]
    public interface IUserProcessor
    {
        void RegUser(User user);
        User GetUser(User user);
    }
    public class UserProcessor : IUserProcessor
    {
        public void RegUser(User user)
        {
            Console.WriteLine("用户已注册。");
            //throw new Exception("11");
        }
        public User GetUser(User user)
        {
            return user;
        }
    }

}
