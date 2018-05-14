using IDCM.ApiTest.HttpTools;
using IDCM.ApiTest.Models;
using IDCM.ApiTest.Models.InputModels;
using IDCM.ApiTest.Models.OutputModels;
using System;
using Newtonsoft.Json;
using IDCM.ApiTest.Signs;
using System.Threading.Tasks;
using System.Collections.Generic;
using IDCM.ApiTest.Extensions;
using Xunit;

namespace IDCM.ApiTest
{
    class Program
    {
        private readonly static string ApiKey = "666666666666666666";
        private readonly static string SecretKey = "666666666666666666";
        private readonly static string OrderID = "jACXiSfBxk2OEirWGz1zQA";
        static void Main(string[] args)
        {
            Console.WriteLine("测试开始");
            do
            {
                GetDepthTest().Wait();
                Console.Read();
                Console.WriteLine("继续...");
            } while (true);
        }

        #region 币币行情测试用例
        /// <summary>
        /// 获取行情测试用例
        /// </summary>
        [Fact]
        static async Task GetTickerTest()
        {
            try
            {
                HttpHelp httpHelp = new HttpHelp();
                GetTickerInput inputDto = new GetTickerInput
                {
                    Symbol = "XXXXXX"
                };
                string url = "http://localhost:8303/api/v1/getticker";
                string input = JsonConvert.SerializeObject(inputDto);
                var response = await httpHelp.PostAsync<OperateMessage<PositionOutput>>(url,
                    ApiKey,
                    input,
                    ApiSign.CreateSign(SecretKey, input)
                    );

                Console.WriteLine($"code:{response.code}");
                Console.WriteLine($"result:{response.result}");
                Console.WriteLine($"data:{response.ToJson()}");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{nameof(GetTickerTest)}出错：{ex.Message}");
            }
        }
        /// <summary>
        /// 获取市场深度测试用例
        /// </summary>
        /// <returns></returns>
        [Fact]
        static async Task GetDepthTest()
        {
            try
            {
                HttpHelp httpHelp = new HttpHelp();
                GetDepthInput inputDto = new GetDepthInput
                {
                    Symbol = "XXXXXX"
                };
                string url = "http://localhost:8303/api/v1/getdepth";
                string input = JsonConvert.SerializeObject(inputDto);
                var response = await httpHelp.PostAsync<OperateMessage<GetDepthOutput>>(url,
                    ApiKey,
                    input,
                    ApiSign.CreateSign(SecretKey, input)
                    );

                Console.WriteLine($"code:{response.code}");
                Console.WriteLine($"result:{response.result}");
                Console.WriteLine($"data:{response.ToJson()}");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{nameof(GetDepthTest)}出错：{ex.Message}");
            }
        }
        /// <summary>
        /// 获取交易信息(500条)测试用例
        /// </summary>
        /// <returns></returns>
        [Fact]
        static async Task GetTradesTest()
        {
            try
            {
                HttpHelp httpHelp = new HttpHelp();
                GetTradesInput inputDto = new GetTradesInput
                {
                    Symbol = "XXXXXX",
                    Since = 10000
                };
                string url = "http://localhost:8303/api/v1/gettrades";
                string input = JsonConvert.SerializeObject(inputDto);
                var response = await httpHelp.PostAsync<OperateMessage<IEnumerable<GetTradesOutput>>>(url,
                    ApiKey,
                    input,
                    ApiSign.CreateSign(SecretKey, input)
                    );

                Console.WriteLine($"code:{response.code}");
                Console.WriteLine($"result:{response.result}");
                Console.WriteLine($"data:{response.data.ToJson()}");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{nameof(GetTradesTest)}出错：{ex.Message}");
            }
        }
        /// <summary>
        /// 获取K线数据测试用例
        /// </summary>
        /// <returns></returns>
        [Fact]
        static async Task GetKLineTest()
        {
            try
            {
                HttpHelp httpHelp = new HttpHelp();
                GetKLineInput inputDto = new GetKLineInput
                {
                    Symbol = "XXXXXX",
                    Since = 10000,
                    Size = 100,
                    Type = "XXXXXX"
                };
                string url = "http://localhost:8303/api/v1/getkline";
                string input = JsonConvert.SerializeObject(inputDto);
                var response = await httpHelp.PostAsync<OperateMessage<IEnumerable<GetKLineOutput>>>(url,
                    ApiKey,
                    input,
                    ApiSign.CreateSign(SecretKey, input)
                    );

                Console.WriteLine($"code:{response.code}");
                Console.WriteLine($"result:{response.result}");
                Console.WriteLine($"data:{response.data.ToJson()}");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{nameof(GetTradesTest)}出错：{ex.Message}");
            }
        }
        #endregion

        #region 币币交易测试用例
        /// <summary>
        /// 获取用户信息测试用例
        /// </summary>
        /// <returns></returns>
        [Fact]
        static async Task GetUserInfoTest()
        {
            try
            {
                HttpHelp httpHelp = new HttpHelp();
                string url = "http://localhost:8303/api/v1/getuserinfo";
                string input = "1";
                var response = await httpHelp.PostAsync<OperateMessage<List<GetUserInfoOutput>>>(url,
                    ApiKey,
                    input,
                    ApiSign.CreateSign(SecretKey, input)
                    );

                Console.WriteLine($"code:{response.code}");
                Console.WriteLine($"result:{response.result}");
                Console.WriteLine($"data:{response.data.ToJson()}");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{nameof(GetTickerTest)}出错：{ex.Message}");
            }
        }
        /// <summary>
        /// 下单交易测试用例
        /// </summary>
        /// <returns></returns>
        [Fact]
        static async Task TradeTest()
        {
            try
            {
                HttpHelp httpHelp = new HttpHelp();
                string url = "http://localhost:8303/api/v1/trade";
                SendOrderInput inputDto = new SendOrderInput
                {
                    Symbol = "XXXXXX",
                    Size = 1,
                    Side = TradeSide.BUY,
                    Price = (decimal)0.01,
                    Type = OrderType.Limit
                };
                string input = JsonConvert.SerializeObject(inputDto);
                var response = await httpHelp.PostAsync<OperateMessage<TradeOutput>>(url,
                    ApiKey,
                    input,
                    ApiSign.CreateSign(SecretKey, input)
                    );

                Console.WriteLine($"code:{response.code}");
                Console.WriteLine($"result:{response.result}");
                Console.WriteLine($"data:{response.data.ToJson()}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{nameof(GetTickerTest)}出错：{ex.Message}");
            }
        }
        /// <summary>
        /// 获取用户的订单信息测试用例
        /// </summary>
        /// <returns></returns>
        [Fact]
        static async Task GetOrderInfoTest()
        {
            try
            {
                HttpHelp httpHelp = new HttpHelp();
                string url = "http://localhost:8303/api/v1/getorderinfo";
                GetOrderInfoInput inputDto = new GetOrderInfoInput
                {
                    Symbol = "XXXXXX",
                    OrderID = OrderID
                };
                string input = JsonConvert.SerializeObject(inputDto);
                var response = await httpHelp.PostAsync<OperateMessage<List<GetOrderInfoOutput>>>(url,
                    ApiKey,
                    input,
                    ApiSign.CreateSign(SecretKey, input)
                    );

                Console.WriteLine($"code:{response.code}");
                Console.WriteLine($"result:{response.result}");
                Console.WriteLine($"data:{response.data.ToJson()}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{nameof(GetTickerTest)}出错：{ex.Message}");
            }
        }
        /// <summary>
        ///  获取历史订单信息，只返回最近两天的信息测试用例
        /// </summary>
        /// <returns></returns>
        [Fact]
        static async Task GetHistoryOrderTest()
        {
            try
            {
                HttpHelp httpHelp = new HttpHelp();
                string url = "http://localhost:8303/api/v1/gethistoryorder";
                GetHistoryOrderInput inputDto = new GetHistoryOrderInput
                {
                    Symbol = "XXXXXX",
                    PageIndex = 1,
                    PageSize = 10,
                    Status = OrderStatus.DealSuccess
                };
                string input = JsonConvert.SerializeObject(inputDto);
                var response = await httpHelp.PostAsync<OperateMessage<List<GetOrderInfoOutput>>>(url,
                    ApiKey,
                    input,
                    ApiSign.CreateSign(SecretKey, input)
                    );

                Console.WriteLine($"code:{response.code}");
                Console.WriteLine($"result:{response.result}");
                Console.WriteLine($"data:{response.data.ToJson()}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{nameof(GetTickerTest)}出错：{ex.Message}");
            }
        }
        /// <summary>
        /// 提币测试
        /// </summary>
        /// <returns></returns>
        [Fact]
        static async Task WithdrawTest()
        {
            try
            {
                HttpHelp httpHelp = new HttpHelp();
                string url = "http://localhost:8303/api/v1/withdraw";
                WithdrawInput inputDto = new WithdrawInput
                {
                    Symbol = "XXXXXX",
                    Address = "XXXXXX",
                    Amount = 1
                };
                string input = JsonConvert.SerializeObject(inputDto);
                var response = await httpHelp.PostAsync<OperateMessage<string>>(url,
                    ApiKey,
                    input,
                    ApiSign.CreateSign(SecretKey, input)
                    );

                Console.WriteLine($"code:{response.code}");
                Console.WriteLine($"result:{response.result}");
                Console.WriteLine($"data:{response.data.ToString()}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{nameof(GetTickerTest)}出错：{ex.Message}");
            }
        }
        /// <summary>
        /// 取消提币测试用例
        /// </summary>
        /// <returns></returns>
        [Fact]
        static async Task Cancel_WithdrawTest()
        {
            try
            {
                HttpHelp httpHelp = new HttpHelp();
                string url = "http://localhost:8303/api/v1/cancel_withdraw";
                CancelWithdrawInput inputDto = new CancelWithdrawInput
                {
                    Symbol = "XXXXXX",
                    WithdrawID = "XXXXXX"
                };
                string input = JsonConvert.SerializeObject(inputDto);
                var response = await httpHelp.PostAsync<OperateMessage<bool>>(url,
                    ApiKey,
                    input,
                    ApiSign.CreateSign(SecretKey, input)
                    );

                Console.WriteLine($"code:{response.code}");
                Console.WriteLine($"result:{response.result}");
                Console.WriteLine($"data:{response.data.ToString()}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{nameof(GetTickerTest)}出错：{ex.Message}");
            }
        }
        /// <summary>
        /// 查询提币用例
        /// </summary>
        /// <returns></returns>
        [Fact]
        static async Task GetWithdrawInfoTest()
        {
            try
            {
                HttpHelp httpHelp = new HttpHelp();
                string url = "http://localhost:8303/api/v1/getwithdrawinfo";
                WithdrawinfoInput inputDto = new WithdrawinfoInput
                {
                    Symbol = "XXXXXX",
                    WithdrawID = "XXXXXX"
                };
                string input = JsonConvert.SerializeObject(inputDto);
                var response = await httpHelp.PostAsync<OperateMessage<GetWithdrawInfoOutput>>(url,
                    ApiKey,
                    input,
                    ApiSign.CreateSign(SecretKey, input)
                    );

                Console.WriteLine($"code:{response.code}");
                Console.WriteLine($"result:{response.result}");
                Console.WriteLine($"data:{response.data.ToJson()}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{nameof(GetWithdrawInfoTest)}出错：{ex.Message}");
            }
        }


        #endregion
    }
}
