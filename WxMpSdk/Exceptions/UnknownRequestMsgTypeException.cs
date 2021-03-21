using System;

namespace WxMpSdk
{
    /// <summary>
    /// 未知请求类型。
    /// </summary>
    public class UnknownRequestMsgTypeException : WeiXinException
    {
        public UnknownRequestMsgTypeException(string message)
            : base(message, null)
        {
        }

        public UnknownRequestMsgTypeException(string message, Exception inner)
            : base(message, inner)
        { }
    }
}
