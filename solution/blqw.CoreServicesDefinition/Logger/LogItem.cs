using System;
using System.Collections.Generic;
using System.Text;

namespace blqw.Services
{
    /// <summary>
    /// 日志项
    /// </summary>
    public struct LogItem
    {
        public LogItem(string id, string contextId, string sequence, DateTime dateTime, int level, string from, string source, string category, string summary, string details, string callstack)
        {
            ID = id;
            ContextID = contextId;
            Sequence = sequence;
            DateTime = dateTime;
            Level = level;
            From = from;
            Source = source;
            Category = category;
            Summary = summary;
            Details = details;
            Callstack = callstack;
        }

        /// <summary>
        /// 日志id
        /// </summary>
        string ID { get; }
        /// <summary>
        /// 上下文id
        /// </summary>
        string ContextID { get; }
        /// <summary>
        /// 日志序号
        /// </summary>
        string Sequence { get; }
        /// <summary>
        /// 时间
        /// </summary>
        DateTime DateTime { get; }
        /// <summary>
        /// 日志等级
        /// </summary>
        int Level { get; }
        /// <summary>
        /// 来自
        /// </summary>
        string From { get; }
        /// <summary>
        /// 日志源
        /// </summary>
        string Source { get; }
        /// <summary>
        /// 类别
        /// </summary>
        string Category { get; }
        /// <summary>
        /// 摘要
        /// </summary>
        string Summary { get; }
        /// <summary>
        /// 详细
        /// </summary>
        string Details { get; }
        /// <summary>
        /// 日志堆栈
        /// </summary>
        string Callstack { get; }

        /// <summary>
        /// 通过 <seealso cref="ID"/> 属性判断2个<seealso cref="LogItem"/> 对象是否相等
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj) => obj is LogItem it && it.ID == ID;

        /// <summary>
        /// 返回该对象的哈希代码。
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode() => ID.GetHashCode();

        /// <summary>
        /// == 运算符重载
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator ==(LogItem left, LogItem right) => left.Equals(right);

        /// <summary>
        /// != 运算符重载
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator !=(LogItem left, LogItem right) => !left.Equals(right);
    }
}
