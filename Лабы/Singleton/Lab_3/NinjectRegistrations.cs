using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject.Modules;
using Lab_3.Model;

namespace Lab_3
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<ISingleton>().To<Singleton>().InSingletonScope();

            // InTransientScope() - по умолчанию - новый на каждый вызов
            // InSingletonScope() - паттерн Singleton - один на все вызовы
            // InThreadScope() - новый экземпляр на каждый поток
            // InRequestScope() - новый экземпляр на каждый запрос
        }
    }
}