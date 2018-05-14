using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace IDCM.ApiTest.Models.OutputModels
{
    /// <summary>
    /// 资产状态 （1申请,2待审批,3处理中,4完成，5审批失败，6处理失败）
    /// </summary>

    public enum AssetsStatus
    {
        /// <summary>
        /// 已受理、申请
        /// </summary>
        [Description("已受理")]
        Apply = 1,
        /// <summary>
        /// 待审核
        /// </summary>
        [Description("待审核")]
        PendingApproval = 2,
        /// <summary>
        /// 处理失败,钱包扣除失败
        /// </summary>
        [Description("钱包处理失败")]
        ProcessFail = 4,
        /// <summary>
        /// 审核未通过
        /// </summary>
        [Description("审核未通过")]
        ApprovalReject = 5,
        /// <summary>
        /// 完成，通过
        /// </summary>
        [Description("已完成")]
        Finish = 12,
        /// <summary>
        /// 处理中
        /// </summary>
        [Description("处理中")]
        Processing = 3,
        /// <summary>
        /// 撤销
        /// </summary>
        [Description("撤销")]
        Cancel = 7,
        /// <summary>
        /// 待充值
        /// </summary>
        [Description("待充值")]
        WaitRecharge = 8,
        /// <summary>
        /// 确认中
        /// </summary>
        [Description("确认中")]
        WaitConfirm = 9,
        /// <summary>
        /// 已到账
        /// </summary>
        [Description("已到账")]
        ArrivedAccount = 10,
        /// <summary>
        /// 已汇出
        /// </summary>
        [Description("已汇出")]
        TransactionOut = 11,
        /// <summary>
        /// 异常
        /// </summary>
        [Description("异常订单")]
        Exception = 99
    }
    public class GetWithdrawInfoOutput
    {
        /// <summary>
        /// 提币地址
        /// </summary>
        [JsonProperty("address")]
        public string Address { set; get; }
        /// <summary>
        /// 提现金额
        /// </summary>
        [JsonProperty("amount")]
        public decimal Amount { set; get; }
        /// <summary>
        /// 提币时间
        /// </summary>
        [JsonProperty("createtime")]
        public long CreateTime { set; get; }
        /// <summary>
        /// 提币状态 1、已受理、申请  2、待审核  3、处理中  4、处理失败,钱包扣除失败  5、审核未通过 7、撤销  8、待充值  9、确认中 10、已到账 11、已汇出  12、已完成
        /// </summary>
        [JsonProperty("status")]
        public AssetsStatus Status { set; get; }
        /// <summary>
        /// 提币申请Id
        /// </summary>
        [JsonProperty("withdrawid")]
        public string WithdrawID { set; get; }
    }
}
