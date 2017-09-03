using System;
using System.Collections.Generic;
using System.Text;

namespace blqw.Services
{
    /// <summary>
    /// 类型转换服务
    /// </summary>
    public interface IConvertService
    {
        /// <summary>
        /// 返回一个指定类型的对象，该对象的值等效于指定的对象。
        /// </summary>
        /// <param name="value">待转换的值</param>
        /// <param name="conversionType">要返回的对象的类型</param>
        /// <returns></returns>
        object To(object value, Type conversionType);
        /// <summary>
        /// 返回一个指定类型的对象，该对象的值等效于指定的对象，如果转换失败返回 <see cref="defaultValue"/>
        /// </summary>
        /// <param name="value">待转换的值</param>
        /// <param name="conversionType">要返回的对象的类型</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns></returns>
        object To(object value, Type conversionType, object defaultValue);
        /// <summary>
        /// 返回一个指定类型的对象，该对象的值等效于指定的对象，如果转换失败返回 <see cref="defaultValue"/>
        /// </summary>
        /// <typeparam name="T">要返回的对象的类型</typeparam>
        /// <param name="value">待转换的值</param>
        /// <returns></returns>
        T To<T>(object value);
        /// <summary>
        /// 返回一个指定类型的对象，该对象的值等效于指定的对象，如果转换失败返回 <see cref="defaultValue"/>
        /// </summary>
        /// <typeparam name="T">要返回的对象的类型</typeparam>
        /// <param name="value">待转换的值</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns></returns>
        T To<T>(object value, T defaultValue);
        /// <summary>
        /// 尝试将一个指定的对象的值转换为等效的指定类型的对象，返回转换是否成功
        /// </summary>
        /// <param name="value">待转换的值</param>
        /// <param name="conversionType">要返回的对象的类型</param>
        /// <param name="convertedValue">转换后的值</param>
        /// <returns></returns>
        bool TryConvert(object value, Type conversionType, out object convertedValue);
        /// <summary>
        /// 尝试将一个指定的对象的值转换为等效的指定类型的对象，返回转换是否成功
        /// </summary>
        /// <typeparam name="T">要返回的对象的类型</typeparam>
        /// <param name="value">待转换的值</param>
        /// <param name="convertedValue">转换后的值</param>
        bool TryConvert<T>(object value, out T convertedValue);

        
    }
}
