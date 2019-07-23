using NUnit.Framework;
using System;
using System.Diagnostics;
using Unity;
using Unity.Interception.ContainerIntegration;
using Unity.Interception.Interceptors.InstanceInterceptors.InterfaceInterception;
using UnityDemo;

namespace UnitTestProject
{
    [TestFixture]
    public class UnitTest
    {
        [Test]
        public void TestMethod()
        {
            Show();
            Assert.Fail();
        }

        public void Show()
        {
            var user = new User() { Name = "Eleven", Password = "12345678957576" };
            {
                var processor = new UserProcessor();
                processor.RegUser(user);
                Console.WriteLine("*********************");
            }
            {
                IUnityContainer container = new UnityContainer();//声明一个容器 
                container.RegisterType<IUserProcessor, UserProcessor>();//声明UnityContainer并注册IUserProcessor 
                var processor = container.Resolve<IUserProcessor>();
                processor.RegUser(user);//没有AOP的，可在此打个断点F11进入 //配置AOP，固定套路 
                container.AddNewExtension<Interception>()
                    .Configure<Interception>()
                    .SetInterceptorFor<IUserProcessor>(new InterfaceInterceptor());
                var userprocessor = container.Resolve<IUserProcessor>();//重新实例化 
                Trace.WriteLine("dave");
                Console.WriteLine("********************");
                userprocessor.RegUser(user);//有AOP的，可在此打个断点F11进入 
                userprocessor.GetUser(user);//有AOP的，可在此打个断点F11进入 
            }
        }
    }
}
