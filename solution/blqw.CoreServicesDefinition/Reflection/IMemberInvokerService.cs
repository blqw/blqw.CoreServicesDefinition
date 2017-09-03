using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace blqw.Services
{
    /// <summary>
    /// 属性调用器服务
    /// </summary>
    public interface IMemberInvokerService
    {
        /// <summary>
        /// 生成字段的取值调用器
        /// </summary>
        /// <param name="field">字段描述</param>
        IMemberInvoker CreateGetter(FieldInfo field);
        /// <summary>
        /// 生成字段的设值调用器
        /// </summary>
        /// <param name="field">字段描述</param>
        /// <returns></returns>
        IMemberInvoker CreateSetter(FieldInfo field);
        /// <summary>
        /// 生成属性的取值调用器
        /// </summary>
        /// <param name="property">属性描述</param>
        /// <returns></returns>
        IMemberInvoker CreateGetter(PropertyInfo property);
        /// <summary>
        /// 生成属性的设值调用器
        /// </summary>
        /// <param name="property">属性描述</param>
        /// <returns></returns>
        IMemberInvoker CreateSetter(PropertyInfo property);
        /// <summary>
        /// 生成方法的调用器
        /// </summary>
        /// <param name="method">方法描述</param>
        /// <returns></returns>
        IMemberInvoker CreateCaller(MethodInfo method);
        /// <summary>
        /// 生成构造函数的调用器
        /// </summary>
        /// <param name="constructor">构造函数描述</param>
        /// <returns></returns>
        IMemberInvoker CreateCaller(ConstructorInfo constructor);
    }
}
