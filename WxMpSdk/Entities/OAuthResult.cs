namespace WxMpSdk.Entities
{
    public class OAuthResult:WxJsonResult
    {
        /// <summary>
        /// openid
        /// </summary>
        public string openid { get; set; }
        /// <summary>
        /// 会话秘钥
        /// </summary>
        public string session_key { get; set; }
        /// <summary>
        /// 开放平台
        /// </summary>
        public string unionid { get; set; }
    }
}
