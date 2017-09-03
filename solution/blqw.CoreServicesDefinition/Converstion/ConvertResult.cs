using System;
using System.Collections.Generic;
using System.Text;

namespace blqw.Services
{
    /// <summary>
    /// 转换结果
    /// </summary>
    public struct ConvertResult
    {
        /// <summary>
        /// 获取表示转换成功的结果
        /// </summary>
        /// <param name="value">转换后的值</param>
        /// <returns></returns>
        public static ConvertResult Success(object value)
            => new ConvertResult(true, null, value);


        /// <summary>
        /// 获取表示转换失败的结果
        /// </summary>
        /// <param name="exception">转换中的异常</param>
        /// <returns></returns>
        public static ConvertResult Fail(Exception exception)
            => new ConvertResult(false, exception, exception);
        /// <summary>
        /// 私有构造函数
        /// </summary>
        /// <param name="success">转换是否成功</param>
        /// <param name="exception">转换中的出现的错误</param>
        /// <param name="value">转换后的值</param>
        private ConvertResult(bool success, Exception exception, object value)
        {
            IsSuccess = success;
            Exception = exception;
            Value = value;
        }

        /// <summary>
        /// 转换是否成功
        /// </summary>
        public bool IsSuccess { get; }
        /// <summary>
        /// 转换中的出现的错误
        /// </summary>
        public Exception Exception { get; }
        /// <summary>
        /// 转换后的值
        /// </summary>
        public object Value { get; }
    }
}
