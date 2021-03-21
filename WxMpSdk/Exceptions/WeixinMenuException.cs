using System;

namespace WxMpSdk
{
    /// <summary>
    /// 微信自定义菜单接口类型错误
    /// </summary>
    public class WeixinMenuException : WeiXinException
    {
        public WeixinMenuException(string message)
            : base(message, null)
        {
        }

        public WeixinMenuException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
