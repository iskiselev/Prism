using System;

namespace Prism
{
    using System.Reflection;

    internal static class PortablityHelpers
    {
        internal static Type GetTypeInfo(this Type type)
        {
            return type;
        }

        internal static MethodInfo GetMethodInfo(this Delegate @delegate)
        {
            return @delegate.Method;
        }

        internal static Delegate CreateDelegate(this MethodInfo methodInfo, Type delegateType, object target)
        {
            if (target == null)
            {
                return Delegate.CreateDelegate(delegateType, methodInfo);
            }

            return Delegate.CreateDelegate(delegateType, target, methodInfo);
        }
    }
}
