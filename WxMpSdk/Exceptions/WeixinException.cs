using System;

namespace WxMpSdk
{
    /// <summary>
    /// 微信自定义异常基类
    /// </summary>
    public class WeiXinException : ApplicationException
    {
        public WeiXinException(string message)
            : base(message, null)
        {
        }

        public WeiXinException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
