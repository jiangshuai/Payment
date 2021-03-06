using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCardTemplateBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingCardTemplateBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页大小，默认20条，最大支持20条
        /// </summary>
        [JsonProperty("page_size")]
        public long PageSize { get; set; }
    }
}
