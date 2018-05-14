using IDCM.WebsocketConsle.Models;
using IDCM.WebsocketConsle.WebSocketSharp;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace IDCM.WebsocketConsle
{
    class Program
    {
        private readonly static string URL = "ws://XXXXXX:10330/websocket";
        static void Main(string[] args)
        {
            GetOrderInfoTest();
        }

        static void PingTest()
        {
            var @event = "ping";
            Console.WriteLine($"{nameof(PingTest)} Start");
            using (var ws = new WebSocket(URL))
            {
                ws.OnMessage += (sender, e) => {
                    Console.WriteLine($"Result：{e.Data}");
                };

                BaseEvent baseEvent = new BaseEvent
                {
                    Event = @event
                };
                var data = JsonConvert.SerializeObject(baseEvent);
                ws.Connect();
                ws.Send(data);
                Console.ReadLine();
            }
            Console.WriteLine($"{nameof(PingTest)} End");
        }

        static void AddChannelTest()
        {
            var @event = "addChannel";
            Console.WriteLine($"{nameof(AddChannelTest)} Start");
            using (var ws = new WebSocket(URL))
            {
                ws.OnMessage += (sender, e) => {
                    BaseOutput baseOutput = JsonConvert.DeserializeObject<BaseOutput>(e.Data);
                    if (baseOutput.Event == @event)
                    {
                        Console.WriteLine($"Result：{baseOutput.Result} Code:{baseOutput.ErrorCode}");
                    }
                };

                ChannelEvent baseEvent = new ChannelEvent
                {
                    Event = @event,
                    Channel = "XXXXXX"
                };
                var data = JsonConvert.SerializeObject(baseEvent);
                ws.Connect();
                ws.Send(data);
                Console.ReadLine();
            }
            Console.WriteLine($"{nameof(AddChannelTest)}  End");
        }

        static void LoginTest()
        {
            var @event = "login";
            Console.WriteLine($"{nameof(LoginTest)} Start");
            using (var ws = new WebSocket(URL))
            {
                ws.OnMessage += (sender, e) => {
                    BaseOutput baseOutput = JsonConvert.DeserializeObject<BaseOutput>(e.Data);
                    if (baseOutput.Event == @event)
                    {
                        Console.WriteLine($"Result：{baseOutput.Result} Code:{baseOutput.ErrorCode}");
                    }
                };

                LoginEvent baseEvent = new LoginEvent
                {
                    Event = @event,
                    parameters = new LoginInfo {
                        ApiKey = "XXXXXX",
                        Sign = "XXXXXX"
                    }
                };
                var data = JsonConvert.SerializeObject(baseEvent);
                ws.Connect();
                ws.Send(data);
                Console.ReadLine();
            }
            Console.WriteLine($"{nameof(LoginTest)}  End");
        }

        static void SendOrderTest()
        {
            var @event = "sendorder";
            Console.WriteLine($"{nameof(SendOrderTest)} Start");
            using (var ws = new WebSocket(URL))
            {
                ws.OnMessage += (sender, e) => {
                    DataOutput<string> baseOutput = JsonConvert.DeserializeObject<DataOutput<string>>(e.Data);
                    if (baseOutput.Event == @event)
                    {
                        var parameters = baseOutput.Data == null? "": JsonConvert.SerializeObject(baseOutput.Data);
                        Console.WriteLine($"Parameters:{parameters} Result：{baseOutput.Result} Code:{baseOutput.ErrorCode} ");
                    }
                };

                SendOrderEvent baseEvent = new SendOrderEvent
                {
                    Event = @event,
                    Parameters = new OrderInfo
                    {
                        ApiKey = "XXXXXX",
                        Sign = "XXXXXX",
                        Symbol = "XXXXXX",
                        Amount = 1,
                        IsMarket = true,
                        Price = (decimal)0.1,
                        Type = "XXXXXX"
                    }
                };
                var data = JsonConvert.SerializeObject(baseEvent);
                ws.Connect();
                ws.Send(data);
                Console.ReadLine();
            }
            Console.WriteLine($"{nameof(SendOrderTest)} End");
        }

        static void CancelOrderTest()
        {
            var @event = "cancelorder";
            Console.WriteLine($"{nameof(CancelOrderTest)} Start");
            using (var ws = new WebSocket(URL))
            {
                ws.OnMessage += (sender, e) => {
                    BaseOutput baseOutput = JsonConvert.DeserializeObject<BaseOutput>(e.Data);
                    if (baseOutput.Event == @event)
                    {
                        Console.WriteLine($"Result：{baseOutput.Result} Code:{baseOutput.ErrorCode} ");
                    }
                };

                CancelOrderEvent baseEvent = new CancelOrderEvent
                {
                    Event = @event,
                    Parameters = new CancelOrder {
                        Side = TradeSide.BUY,
                        Sign = "XXXXXX",
                        Symbol = "XXXXXX",
                        ApiKey = "XXXXXX",
                        OrderID = "XXXXXX"
                    }
                };
                var data = JsonConvert.SerializeObject(baseEvent);
                ws.Connect();
                ws.Send(data);
                Console.ReadLine();
            }
            Console.WriteLine($"{nameof(CancelOrderTest)}  End");
        }

        static void GetUserInfoTest()
        {
            var @event = "getuserinfo";
            Console.WriteLine($"{nameof(GetUserInfoTest)} Start");
            using (var ws = new WebSocket(URL))
            {
                ws.OnMessage += (sender, e) => {
                    DataOutput<IList<GetUserInfoOutput>> baseOutput = JsonConvert.DeserializeObject<DataOutput<IList<GetUserInfoOutput>>>(e.Data);
                    if (baseOutput.Event == @event)
                    {
                        var parameters = baseOutput.Data == null ? string.Empty : JsonConvert.SerializeObject(baseOutput.Data);
                        Console.WriteLine($"Parameters:{parameters} Result：{baseOutput.Result} Code:{baseOutput.ErrorCode} ");
                    }
                };

                GetUserinfoEvent baseEvent = new GetUserinfoEvent
                {
                    Event = @event,
                    Parameters = new Userinfo {
                        Sign = "XXXXXX",
                        ApiKey = "XXXXXX"
                    }
                };
                var data = JsonConvert.SerializeObject(baseEvent);
                ws.Connect();
                ws.Send(data);
                Console.ReadLine();
            }
            Console.WriteLine($"{nameof(GetUserInfoTest)}  End");
        }

        static void GetOrderInfoTest()
        {
            var @event = "getorderinfo";
            Console.WriteLine($"{nameof(GetOrderInfoTest)} Start");
            using (var ws = new WebSocket(URL))
            {
                ws.OnMessage += (sender, e) => {
                    DataOutput<IList<GetOrderInfoOutput>> baseOutput = JsonConvert.DeserializeObject<DataOutput<IList<GetOrderInfoOutput>>>(e.Data);
                    if (baseOutput.Event == @event)
                    {
                        var parameters = baseOutput.Data == null ? string.Empty : JsonConvert.SerializeObject(baseOutput.Data);
                        Console.WriteLine($"Parameters:{parameters} Result：{baseOutput.Result} Code:{baseOutput.ErrorCode} ");
                    }
                };

                GetOrderinfoEvent baseEvent = new GetOrderinfoEvent
                {
                    Event = @event,
                    Parameters = new Orderinfo
                    {
                        Symbol = "XXXXXX",
                        Sign = "XXXXXX",
                        ApiKey = "XXXXXX",
                        OrderId = "XXXXXX"
                    }
                };
                var data = JsonConvert.SerializeObject(baseEvent);
                ws.Connect();
                ws.Send(data);
                Console.ReadLine();
            }
            Console.WriteLine($"{nameof(GetOrderInfoTest)}  End");
        }
    }
}
