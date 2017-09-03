using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace blqw.Services
{
    /// <summary>
    /// 成员调用器
    /// </summary>
    public interface IMemberInvoker
    {
        /// <summary>
        /// 调用器引用的成员
        /// </summary>
        MemberInfo Member { get; }
        /// <summary>
        /// 调用参数列表
        /// </summary>
        IReadOnlyList<ParameterInfo> Parameters { get; }
        /// <summary>
        /// 返回值类型 如果没有返回值(void), 则为null
        /// </summary>
        TypeInfo ReturnType { get; }
        /// <summary>
        /// 调用成员时要求的实例类型, 如果成员是静态的, 则为null
        /// </summary>
        TypeInfo InstanceType { get; }
        /// <summary>
        /// 执行调用器
        /// </summary>
        /// <param name="instance">调用成员时要求的实例对象, 如果成员是静态的, 则为null</param>
        object Execute(object instance);
        /// <summary>
        /// 执行调用器
        /// </summary>
        /// <param name="instance">调用成员时要求的实例对象, 如果成员是静态的, 则为null</param>
        /// <param name="argument0">调用成员时要求的第一个参数</param>
        /// <returns></returns>
        object Execute(object instance, object argument0);
        /// <summary>
        /// 执行调用器
        /// </summary>
        /// <param name="instance">调用成员时要求的实例对象, 如果成员是静态的, 则为null</param>
        /// <param name="argument0">调用成员时要求的第一个参数</param>
        /// <param name="argument1">调用成员时要求的第二个参数</param>
        /// <returns></returns>
        object Execute(object instance, object argument0, object argument1);
        /// <summary>
        /// 执行调用器
        /// </summary>
        /// <param name="instance">调用成员时要求的实例对象, 如果成员是静态的, 则为null</param>
        /// <param name="arguments">调用成员时要求的参数</param>
        /// <returns></returns>
        object Execute(object instance, params object[] arguments);
    }
}
