using System;
using WxMpSdk.Entities;

namespace WxMpSdk
{
    /// <summary>
    /// JSON返回错误代码（比如token_access相关操作中使用）。
    /// </summary>
    public class ErrorJsonResultException : WeiXinException
    {
        public WxJsonResult JsonResult { get; set; }
        public ErrorJsonResultException(string message, Exception inner, WxJsonResult jsonResult)
            : base(message, inner)
        {
            JsonResult = jsonResult;
        }
    }
}
