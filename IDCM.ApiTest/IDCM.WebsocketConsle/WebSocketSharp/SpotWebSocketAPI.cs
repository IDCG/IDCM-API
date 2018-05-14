using IDCM.WebsocketConsle.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace IDCM.WebsocketConsle.WebSocketSharp
{
    public class SpotWebSocketAPI: WebSocketBehavior
    {
        protected override void OnMessage(MessageEventArgs e)
        {
            var baseEvent = JsonConvert.DeserializeObject<BaseEvent>(e.Data);
            Console.WriteLine(baseEvent);
        }

        protected override void OnClose(CloseEventArgs e)
        {
            base.OnClose(e);
            Console.WriteLine($"关闭:{e.Reason}");
        }

        protected override void OnError(ErrorEventArgs e)
        {
            base.OnError(e);
            Console.WriteLine($"异常:{e.Message}");
        }

        protected override void OnOpen()
        {
            base.OnOpen();
            Console.WriteLine($"打开");
            BaseEvent baseEvent = new BaseEvent {
                Event = "ping"
            };
            var data = JsonConvert.SerializeObject(baseEvent);
            Send(data);
        }
        
    }
}
