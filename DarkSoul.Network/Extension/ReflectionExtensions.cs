using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace DarkSoul.Network.Extension
{
    public static class ReflectionExtensions
    {
        public static T CreateDelegate<T>(this ConstructorInfo ctor)
        {
            var list = (from param in ctor.GetParameters()
                        select Expression.Parameter(param.ParameterType));
            var expression = Expression.Lambda<T>(Expression.New(ctor, list), list);
            return expression.Compile();
        }
    }
}
