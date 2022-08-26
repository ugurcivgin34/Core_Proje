using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.ViewComponents.Feature
{

    //Component mantığının amacı direk erişimi engellemektir.Yani direk adrese yazılıp gidilmez .Bu yüzden kullanılır. Aşağıdaki şekilde tanımlanır
    //Daha sonra Shared klasörüne Components klaösrnün altına aşağıdaki class isminin aynı olması şartıyla klasör oluşturulur.Onun içine de 
    //Default controllerinde çalıştığımız için onun ismi verilir .
    public class FeatureList:ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
            var values = featureManager.TGetList();
            return View(values);
        }
    }
}
