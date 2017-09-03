using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace blqw.Services
{
    /// <summary>
    /// 日志服务接口
    /// </summary>
    public interface ILoggerService
    {
        /// <summary>
        /// 调试日志
        /// </summary>
        /// <param name="summary">日志摘要</param>
        /// <param name="details">日志详情</param>
        void Debug(string summary, string details = null, [CallerMemberName] string member = null, [CallerLineNumber] int line = 0, [CallerFilePath] string file = null);
        /// <summary>
        /// 一般日志
        /// </summary>
        /// <param name="summary">日志摘要</param>
        /// <param name="details">日志详情</param>
        void Log(string summary, string details = null, [CallerMemberName] string member = null, [CallerLineNumber] int line = 0, [CallerFilePath] string file = null);
        /// <summary>
        /// 提示日志
        /// </summary>
        /// <param name="summary">日志摘要</param>
        /// <param name="details">日志详情</param>
        void Info(string summary, string details = null, [CallerMemberName] string member = null, [CallerLineNumber] int line = 0, [CallerFilePath] string file = null);
        /// <summary>
        /// 警告日志
        /// </summary>
        /// <param name="summary">日志摘要</param>
        /// <param name="details">日志详情</param>
        void Warn(string summary, string details = null, [CallerMemberName] string member = null, [CallerLineNumber] int line = 0, [CallerFilePath] string file = null);
        /// <summary>
        /// 错误日志
        /// </summary>
        /// <param name="exception">错误异常</param>
        /// <param name="summary">日志摘要</param>
        /// <param name="details">日志详情</param>
        void Error(Exception exception, string summary = null, string details = null, [CallerMemberName] string member = null, [CallerLineNumber] int line = 0, [CallerFilePath] string file = null);
        /// <summary>
        /// 错误日志
        /// </summary>
        /// <param name="summary">日志摘要</param>
        /// <param name="details">日志详情</param>
        void Error(string summary, string details = null, [CallerMemberName] string member = null, [CallerLineNumber] int line = 0, [CallerFilePath] string file = null);
        /// <summary>
        /// 严重错误日志
        /// </summary>
        /// <param name="exception">错误异常</param>
        /// <param name="summary">日志摘要</param>
        /// <param name="details">日志详情</param>
        void Crash(Exception exception, string summary = null, string details = null, [CallerMemberName] string member = null, [CallerLineNumber] int line = 0, [CallerFilePath] string file = null);
        /// <summary>
        /// 严重错误日志
        /// </summary>
        /// <param name="summary">日志摘要</param>
        /// <param name="details">日志详情</param>
        void Crash(string summary, string details = null, [CallerMemberName] string member = null, [CallerLineNumber] int line = 0, [CallerFilePath] string file = null);
    }
}
