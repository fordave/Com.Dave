using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Interception.PolicyInjection.Pipeline;
using Unity.Interception.PolicyInjection.Policies;

namespace UnityDemo
{
    public class UserHandlerAttribute : HandlerAttribute
    {
        public override ICallHandler CreateHandler(IUnityContainer container)
        {
            ICallHandler handler = new UserHandler()
            {
                Order = this.Order
            };
            return handler;
        }
    }
    public class LogHandlerAttribute : HandlerAttribute
    {
        public override ICallHandler CreateHandler(IUnityContainer container)
        {
            return new LogHandler()
            {
                Order = this.Order
            };
        }
    }
    public class ExceptionHandlerAttribute : HandlerAttribute
    {
        public override ICallHandler CreateHandler(IUnityContainer container)
        {
            return new ExceptionHandler()
            {
                Order = this.Order
            };
        }
    }
    public class AfterLogHandlerAttribute : HandlerAttribute
    {
        public override ICallHandler CreateHandler(IUnityContainer container)
        {
            return new AfterLogHandler()
            {
                Order = this.Order
            };
        }
    }

}
