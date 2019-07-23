using ModuleA;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Prism.RegionsDemo
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        // 读取配置文件
        //protected override IModuleCatalog CreateModuleCatalog()
        //{
        //    
        //    return new ConfigurationModuleCatalog();
        //}

        ///// <summary>
        ///// code referrence 需要直接引用程序集 ModuleA
        ///// </summary>
        ///// <param name="moduleCatalog"></param>
        ////protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        ////{
        ////    moduleCatalog.AddModule<ModuleA.ModuleAModule>();
        ////}



        ///// <summary>
        ///// 加载制定目录里 Module
        ///// </summary>
        ///// <returns></returns>
        //protected override IModuleCatalog CreateModuleCatalog()
        //{
        //    return new DirectoryModuleCatalog() { ModulePath = @".\Modules" };
        //}

        /// <summary>
        /// load manual 人为加载制定的Module 需要 引用程序集
        /// </summary>
        /// <param name="moduleCatalog"></param>
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            var moduleAType = typeof(ModuleAModule);
            moduleCatalog.AddModule(new ModuleInfo()
            {
                ModuleName = moduleAType.Name,
                ModuleType = moduleAType.AssemblyQualifiedName,
                InitializationMode = InitializationMode.WhenAvailable
            });
        }


    }
}
