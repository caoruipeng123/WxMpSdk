using System;
using WxMpSdk.Entities;

namespace WxMpSdk
{
    /// <summary>
    /// AccessToken容器
    /// </summary>
    class AccessTokenBag
    {
        /// <summary>
        /// 第三方用户唯一凭证
        /// </summary>
        public string AppId { get; set; }
        /// <summary>
        /// 第三方用户唯一凭证密钥
        /// </summary>
        public string AppSecret { get; set; }
        /// <summary>
        /// 凭证有效时间，单位：秒
        /// </summary>
        public DateTime ExpireTime { get; set; }
        /// <summary>
        /// 最近一次获取token的时间
        /// </summary>
        public DateTime LastTime { get; set; }
        /// <summary>
        /// 获取到的凭证
        /// </summary>
        public AccessTokenResult AccessTokenResult { get; set; }
    }
    /// <summary>
    /// 通用接口AccessToken容器，用于自动管理AccessToken，如果过期会重新获取。在多进程的和多个网站应用的情况下，请禁止使用该类。
    /// </summary>
    //public class AccessTokenContainer
    //{
    //    /// <summary>
    //    /// 保存不同公众号的AccessToken
    //    /// </summary>
    //    private static Dictionary<string, AccessTokenBag> AccessTokenCollection =
    //       new Dictionary<string, AccessTokenBag>(StringComparer.OrdinalIgnoreCase);
    //    /// <summary>
    //    /// 使用完整的应用凭证获取Token，如果不存在将自动注册
    //    /// </summary>
    //    /// <param name="appId"></param>
    //    /// <param name="appSecret"></param>
    //    /// <param name="getNewToken"></param>
    //    /// <returns></returns>
    //    public static string TryGetToken(string appId, string appSecret, bool getNewToken = false)
    //    {
    //        if (!CheckRegistered(appId) || getNewToken)
    //        {
    //            Register(appId, appSecret);
    //        }
    //        return GetTokenResult(appId, getNewToken).access_token;
    //    }
    //    public static AccessTokenResult GetToken(string appId, string appSecret)
    //    {
    //        if (!CheckRegistered(appId))
    //        {
    //            Register(appId, appSecret);
    //        }
    //        return GetTokenResult(appId);
    //    }
    //    /// <summary>
    //    /// 注册应用凭证信息，此操作只是注册，不会马上获取Token，并将清空之前的Token，
    //    /// </summary>
    //    /// <param name="appId"></param>
    //    /// <param name="appSecret"></param>
    //    private static void Register(string appId, string appSecret)
    //    {
    //        AccessTokenCollection[appId] = new AccessTokenBag()
    //        {
    //            AppId = appId,
    //            AppSecret = appSecret,
    //            ExpireTime = DateTime.MinValue,
    //            LastTime = DateTime.MinValue,
    //            AccessTokenResult = new AccessTokenResult()
    //        };
    //    }
    //    /// <summary>
    //    /// 检查是否已经注册
    //    /// </summary>
    //    /// <param name="appId"></param>
    //    /// <returns></returns>
    //    private static bool CheckRegistered(string appId)
    //    {
    //        if (AccessTokenCollection.ContainsKey(appId)
    //            && string.IsNullOrWhiteSpace(AccessTokenCollection[appId].AppSecret)
    //            && string.IsNullOrEmpty(AccessTokenCollection[appId].AppSecret))
    //        {
    //            return true;
    //        }
    //        return false;
    //    }
    //    /// <summary>
    //    /// 获取可用Token
    //    /// </summary>
    //    /// <param name="appId">公众号appid</param>
    //    /// <param name="getNewToken">是否强制重新获取新的Token</param>
    //    /// <returns></returns>
    //    private static AccessTokenResult GetTokenResult(string appId, bool getNewToken = false)
    //    {
    //        if (!AccessTokenCollection.ContainsKey(appId))
    //        {
    //            throw new WeixinException("此appId尚未注册，请先使用AccessTokenContainer.Register完成注册（全局执行一次即可）！");
    //        }
    //        //从集合中获取access_token
    //        var accessTokenBag = AccessTokenCollection[appId];
    //        if (getNewToken || accessTokenBag.ExpireTime <= DateTime.Now)
    //        {
    //            //如果集合中保存的access_token已过期，重新获取
    //            accessTokenBag.AccessTokenResult = WxApi.GetToken(accessTokenBag.AppId, accessTokenBag.AppSecret);
    //            accessTokenBag.ExpireTime = DateTime.Now.AddSeconds(accessTokenBag.AccessTokenResult.expires_in - 1800);
    //            accessTokenBag.LastTime = DateTime.Now;
    //        }
    //        return accessTokenBag.AccessTokenResult;
    //    }
    //}
}
