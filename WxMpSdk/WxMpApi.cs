using WxMpSdk.Entities;

namespace WxMpSdk
{
    public partial class WxMpApi
    {
        /// <summary>
        /// 获取小程序的授权信息
        /// </summary>
        /// <param name="appId">小程序appid</param>
        /// <param name="secret">小程序秘钥</param>
        /// <param name="jsCode">登录code</param>
        /// <param name="grantType">授权类型</param>
        /// <returns></returns>
        public static OAuthResult GetOAuthResult(string appId, string secret, string jsCode, string grantType = "authorization_code")
        {
            var url =
                string.Format("https://api.weixin.qq.com/sns/jscode2session?appid={0}&secret={1}&js_code={2}&grant_type=authorization_code",
                                appId, secret, jsCode, grantType);
            string result = RequestUtility.HttpGet(url, null);
            return ApiHelper.GetResult<OAuthResult>(result);
        }
    }
}
