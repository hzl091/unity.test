using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc4;
using System.Configuration;
using Microsoft.Practices.Unity.Configuration;

namespace unity.test.app
{
  public static class Bootstrapper
  {
    public static IUnityContainer Initialise()
    {
        var section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
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