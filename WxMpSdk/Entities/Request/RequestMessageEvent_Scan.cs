namespace WxMpSdk.Entities
{
    public class RequestMessageEvent_Scan : RequestMessageEventBase
    {
        public override Event Event
        {
            get { return Event.Scan; }
        }
        /// <summary>
        /// 二维码的参数
        /// </summary>
        public string Ticket { get; set; }
    }
}
