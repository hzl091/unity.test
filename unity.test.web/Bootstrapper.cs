using System.Configuration;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using unity.test.iservice;
using Unity.Mvc4;
using System.Web;

namespace unity.test.web
{
  public static class Bootstrapper
  {
    public static IUnityContainer Initialise()
    {
      string configFile = HttpContext.Current.Server.MapPath("~/Unity.config"); //自定义unity配置文件
      var fileMap = new ExeConfigurationFileMap { ExeConfigFilename = configFile };
      Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);

      var section = (UnityConfigurationSection)configuration.GetSection("unity"); //通过配置获取unity配置信息
      IUnityContainer container = BuildUnityContainer();
      section.Configure(container, "unityTest");

      DependencyResolver.SetResolver(new UnityDependencyResolver(container));
      return container;
    }

    private static IUnityContainer BuildUnityContainer()
    {
      var container = new UnityContainer();

      // register all your components with the container here
      // it is NOT necessary to register your controllers

      // e.g. container.RegisterType<ITestService, TestService>();    
      RegisterTypes(container);

      return container;
    }

    public static void RegisterTypes(IUnityContainer container)
    {
    
    }
  }
}