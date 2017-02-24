using System;
using System.Threading;

namespace DarkSoul.Core.Instance
{
    public abstract class Singleton<T> where T : class
    {
        private static readonly Lazy<T> LazyInstance =
           new Lazy<T>(CreateInstanceOfT, LazyThreadSafetyMode.ExecutionAndPublication);

        #region Properties
        public static T Instance
        {
            get { return LazyInstance.Value; }
        }
        #endregion

        #region Methods
        private static T CreateInstanceOfT()
        {
            try
            {
                return Activator.CreateInstance(typeof(T), true) as T;
            }
            catch (Exception e)
            {
                throw new Exception(
                    "The Singleton couldnt be constructed, check if " + typeof(T).FullName + " has a default constructor", e);
            }            
        }

        protected Singleton()
        {
        }

        #endregion
    }
}
