/****************************************************************************************
 * 文件名：Engine
 * 作者：黄泽林
 * 创始时间：2017/5/27 16:22:15
 * 创建说明：
****************************************************************************************/

using System;
using System.Linq;
using Microsoft.Practices.Unity;

namespace unity.test.framework.DIContainer
{
    public class Engine
    {
        private static readonly Engine _engine = new Engine();
        private static IUnityContainer _container;
        public static void Init(IUnityContainer container)
        {
            _container = container;
        }

        public static Engine Current 
        {
            get 
            {
                return _engine;
            }
        }

        /// <summary>
        /// 获取依赖对象
        /// </summary>
        /// <typeparam name="T">T</typeparam>
        /// <returns></returns>
        public T Resolve<T>() where T : class
        {
            return _container.Resolve<T>();
        }

        /// <summary>
        ///  获取依赖对象
        /// </summary>
        /// <param name="type">Type</param>
        /// <returns></returns>
        public object Resolve(Type type)
        {
            return _container.Resolve(type);
        }

        /// <summary>
        /// 获取所有依赖对象
        /// </summary>
        /// <typeparam name="T">T</typeparam>
        /// <returns></returns>
        public T[] ResolveAll<T>()
        {
            return _container.ResolveAll<T>().ToArray();
        }
    }
}
