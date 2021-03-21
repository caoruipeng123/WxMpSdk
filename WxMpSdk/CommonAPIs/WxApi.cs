using WxMpSdk.Entities;

namespace WxMpSdk
{
    public static partial class WxMpApi
    {
        /// <summary>
        /// 获取jsapi_ticket[曹瑞鹏]
        /// </summary>
        /// <param name="access_token">access_token</param>
        /// <returns></returns>
        public static JsApiTicketResult GetJsApiTicket(string access_token)
        {
            var urlFormat = "https://api.weixin.qq.com/cgi-bin/ticket/getticket?access_token={0}&type=jsapi";
            return ApiHelper.Get<JsApiTicketResult>(access_token, urlFormat);
        }
        /// <summary>
        /// 获取jsapi签名[曹瑞鹏]
        /// </summary>
        /// <param name="jsapi_ticket">jsapi临时票据</param>
        /// <param name="noncestr">随机字符串</param>
        /// <param name="url">当前网页的URL，不包含#及其后面部分</param>
        /// <param name="timestamp">时间戳</param>
        /// <returns></returns>
        public static string GetJsApiSign(string jsapi_ticket, string noncestr, string url, string timestamp,out string s)
        {
            string str = $"jsapi_ticket={jsapi_ticket}&noncestr={noncestr}&timestamp={timestamp}&url={url}";
            string sign = WxApiHelper.SHA1(str).ToLower();
            s = str;
            return sign;
        }
    }
}
