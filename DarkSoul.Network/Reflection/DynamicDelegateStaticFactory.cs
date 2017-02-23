using System;
using System.Reflection;
using System.Reflection.Emit;

namespace DarkSoul.Network.Reflection
{
    public delegate object DynamicMethodDelegate(object target, params object[] args);
    public delegate object DynamicReadValueDelegate(object target);
    public delegate void DynamicWriteValueDelegate(object target, object value);

    public class DynamicDelegateStaticFactory
    {

        public static DynamicMethodDelegate CreateMethodCaller(MethodInfo method)
        {
            ParameterInfo[] parms = method.GetParameters();
            int numparams = parms.Length;

            Type[] _argTypes = { typeof(object), typeof(object[]) };

            // Create dynamic method and obtain its IL generator to
            // inject code.
            DynamicMethod dynam =
              new DynamicMethod(
                 ""
                 , typeof(object)
               , _argTypes
                , typeof(DynamicDelegateStaticFactory)
                 , true);
            ILGenerator il = dynam.GetILGenerator();

            // Define a label for succesfull argument count checking.
            Label argsOK = il.DefineLabel();

            // Check input argument count.
            il.Emit(OpCodes.Ldarg_1);
            il.Emit(OpCodes.Ldlen);
            il.Emit(OpCodes.Ldc_I4, numparams);
            il.Emit(OpCodes.Beq, argsOK);

            // Argument count was wrong, throw TargetParameterCountException.
            il.Emit(OpCodes.Newobj, typeof(TargetParameterCountException).GetConstructor(Type.EmptyTypes));
            il.Emit(OpCodes.Throw);

            // Mark IL with argsOK label.
            il.MarkLabel(argsOK);

            // If method isn't static push target instance on top
            // of stack.
            if (!method.IsStatic)
            {
                // Argument 0 of dynamic method is target instance.
                il.Emit(OpCodes.Ldarg_0);
            }

            // Lay out args array onto stack.
            int i = 0;
            while (i < numparams)
            {
                // Push args array reference onto the stack, followed
                // by the current argument index (i). The Ldelem_Ref opcode
                // will resolve them to args[i].

                // Argument 1 of dynamic method is argument array.
                il.Emit(OpCodes.Ldarg_1);
                il.Emit(OpCodes.Ldc_I4, i);
                il.Emit(OpCodes.Ldelem_Ref);

                // If parameter [i] is a value type perform an unboxing.
                Type parmType = parms[i].ParameterType;
                if (parmType.GetTypeInfo().IsValueType)
                {
                    il.Emit(OpCodes.Unbox_Any, parmType);
                }

                i++;
            }

            // Perform actual call.
            // If method is not final a callvirt is required
            // otherwise a normal call will be emitted.
            if (method.IsVirtual)
            {
                il.Emit(OpCodes.Callvirt, method);
            }
            else
            {
                il.Emit(OpCodes.Call, method);
            }

            if (method.ReturnType != typeof(void))
            {
                // If result is of value type it needs to be boxed
                if (method.ReturnType.GetTypeInfo().IsValueType)
                {
                    il.Emit(OpCodes.Box, method.ReturnType);
                }
            }
            else
            {
                il.Emit(OpCodes.Ldnull);
            }

            // Emit return opcode.
            il.Emit(OpCodes.Ret);

            return (DynamicMethodDelegate)dynam.CreateDelegate(typeof(DynamicMethodDelegate));
        }

        public const BindingFlags ALL_BINDINGFLAGS = BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static;


        public static DynamicReadValueDelegate CreatePropertyGetter(PropertyInfo propertyInfo)
        {
            MethodInfo getMethod = propertyInfo.DeclaringType.GetMethod("get_" + propertyInfo.Name, ALL_BINDINGFLAGS);
            var lCaller = CreateMethodCaller(getMethod);
            return (lambdaObject) => lCaller(lambdaObject);
        }
        public static DynamicWriteValueDelegate CreatePropertySetter(PropertyInfo propertyInfo)
        {
            MethodInfo getMethod = propertyInfo.DeclaringType.GetMethod("set_" + propertyInfo.Name, ALL_BINDINGFLAGS);
            var lCaller = CreateMethodCaller(getMethod);
            return (lambdaObject, lambdaValue) => lCaller(lambdaObject, lambdaValue);
        }

        public static DynamicReadValueDelegate CreateFieldGetter(FieldInfo fieldInfo)
        {
            DynamicMethod dynam = new DynamicMethod(
               ""
                 , typeof(object)
               , new Type[] { typeof(object) }
                , typeof(DynamicDelegateStaticFactory)
                 , true
             );

            ILGenerator il = dynam.GetILGenerator();

            // If method isn't static push target instance on top
            // of stack.
            if (!fieldInfo.IsStatic)
            {
                // Argument 0 of dynamic method is target instance.
                il.Emit(OpCodes.Ldarg_0);
                il.Emit(OpCodes.Ldfld, fieldInfo); // load from field
            }
            else
            {
                il.Emit(OpCodes.Ldsfld, fieldInfo); // static load from field
            }

            if (fieldInfo.FieldType.GetTypeInfo().IsValueType)
            {
                il.Emit(OpCodes.Box, fieldInfo.FieldType);
            }
            // Emit return opcode.
            il.Emit(OpCodes.Ret);
            return (DynamicReadValueDelegate)dynam.CreateDelegate(typeof(DynamicReadValueDelegate));
        }

        public static DynamicWriteValueDelegate CreateFieldSetter(FieldInfo fieldInfo)
        {
            DynamicMethod dynam = new DynamicMethod(
                ""
                  , typeof(void)
                  , new Type[] { typeof(object), typeof(object) }
                 , typeof(DynamicDelegateStaticFactory)
                  , true
              );

            ILGenerator il = dynam.GetILGenerator();

            // If method isn't static push target instance on top
            // of stack.
            if (!fieldInfo.IsStatic)
            {
                // Argument 0 of dynamic method is target instance.
                il.Emit(OpCodes.Ldarg_0);
            }
            il.Emit(OpCodes.Ldarg_1);     // load value

            if (fieldInfo.FieldType.GetTypeInfo().IsValueType)
            {
                il.Emit(OpCodes.Unbox_Any, fieldInfo.FieldType);
            }

            if (!fieldInfo.IsStatic)
            {
                il.Emit(OpCodes.Stfld, fieldInfo); // store into field
            }
            else
            {
                il.Emit(OpCodes.Stsfld, fieldInfo); // static store into field
            }

            // Emit return opcode.
            il.Emit(OpCodes.Ret);
            return (DynamicWriteValueDelegate)dynam.CreateDelegate(typeof(DynamicWriteValueDelegate));
        }
    }
}
