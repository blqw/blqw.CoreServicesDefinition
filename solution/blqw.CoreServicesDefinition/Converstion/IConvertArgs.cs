using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace blqw.Services
{
    /// <summary>
    /// 转换参数
    /// </summary>
    public interface IConvertArgs
    {
        IConvertService OnSelectService(string name, object value, IConvertService originalService);

        ConvertResult OnConvertError(string name, object value, Exception exception);
    }
}
