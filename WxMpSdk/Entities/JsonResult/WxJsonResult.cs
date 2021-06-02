﻿using Newtonsoft.Json;

namespace WxMpSdk.Entities
{
    /// <summary>
    /// 微信接口返回的结果
    /// 正确时的返回JSON数据包如下：
    /// {"errcode":0,"errmsg":"ok"}
    /// </summary>
    public class WxJsonResult
    {
        /// <summary>
        /// 错误类型
        /// </summary>
        [JsonProperty("errcode")]
        public ReturnCode ErrCode { get; set; }
        /// <summary>
        /// 错误提示信息
        /// </summary>
        [JsonProperty("errmsg")]
        public string ErrMsg { get; set; }
    }
}
