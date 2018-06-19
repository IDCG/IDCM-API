using System;
using System.Collections.Generic;
using System.Text;

namespace IDCM.WebsocketConsle
{
    public class WebSocketAPICodeDefine
    {
        /// <summary>
        /// 必填参数为空
        /// </summary>
        public const string ParameterRequired = "10000";
        /// <summary>
        /// 验证失败
        /// </summary>
        public const string AuthenticationFailed = "10001";
        /// <summary>
        /// 该连接已经请求了其他用户的实时交易数据
        /// </summary>
        public const string OtherUserInvalid = "10003";
        /// <summary>
        /// 参数无效
        /// </summary>
        public const string ParameterInvalid = "41000";
        /// <summary>
        /// 非法参数
        /// </summary>
        public const string IllegalParameter = "10008";
        /// <summary>
        /// 系统错误
        /// </summary>
        public const string SystemError = "10002";
        /// <summary>
        /// SecretKey不存在
        /// </summary>
        public const string SecretKeyNotFound = "10005";
        /// <summary>
        /// Api_key不存在
        /// </summary>
        public const string ApiKeyNotFound = "10006";
        /// <summary>
        /// 没有登录
        /// </summary>
        public const string LoginRequired = "1014";
        /// <summary>
        /// 请求成功
        /// </summary>
        public const string Success = "200";
        /// <summary>
        /// 签名不匹配
        /// </summary>
        public const string SignaturesNotMatch = "10007";
        /// <summary>
        /// API鉴权失败
        /// </summary>
        public const string APIAuthenticationFailed = "10017";
        /// <summary>
        /// 用户不存在
        /// </summary>
        public const string UserNotExist = "51004";

        /// <summary>
        /// 申报价无效
        /// </summary>
        public const string QuotePriceInvalid = "51043";
        /// <summary>
        /// 申报数量无效
        /// </summary>
        public const string QuoteQuantityInvalid = "51044";
        /// <summary>
        /// 账号被冻结
        /// </summary>
        public const string UserIsFrozen = "51003";
        /// <summary>
        /// 交易品种必填
        /// </summary>
        public const string TradeVarietyRequired = "41017";
        /// <summary>
        /// 交易品种不存在
        /// </summary>
        public const string TradeVarietyNotExist = "51011";
        /// <summary>
        /// 最小金额无效
        /// </summary>
        public const string MinQuotePriceInvalid = "51046";
        /// <summary>
        /// 金额变动量无效
        /// </summary>
        public const string QuotePriceMinChangePriceInvalid = "51047";
        /// <summary>
        /// 最小交易量无效
        /// </summary>
        public const string MinTradeQuantityInvalid = "51045";
        /// <summary>
        /// 最小申报变动量无效
        /// </summary>
        public const string QuoteQuantityMinChangeQuantityInvalid = "51048";
        /// <summary>
        /// 货币资产信息不存在
        /// </summary>
        public const string CurrencyAssetsNotExist = "51040";
        /// <summary>
        /// 虚拟币资产信息不足
        /// </summary>
        public const string CoinAssetsNotExist = "51021";
        /// <summary>
        /// 现金资产不足
        /// </summary>
        public const string CurrencyAssetsNotEnought = "51041";
        /// <summary>
        /// 可用数量不足
        /// </summary>

        public const string AvailableNotEnough = "51023";
        /// <summary>
        /// 数据不存在
        /// </summary>
        public const string DataNotExist = "51026";
        /// <summary>
        /// 提币申请状态只有在，申请状态才能撤销
        /// </summary>
        public const string OnlyApplyStatusCanCancel = "51027";
        /// <summary>
        /// 虚拟币不存在
        /// </summary>
        public const string CoinNotExist = "51018";
        /// <summary>
        /// 申请数量太少
        /// </summary>
        public const string ApplyQuantityLess = "51022";
    }
}
