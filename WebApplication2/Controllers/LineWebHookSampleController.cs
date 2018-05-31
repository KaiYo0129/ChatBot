using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication2.Controllers
{
    public class LineBotWebHookController : isRock.LineBot.LineWebHookControllerBase
    {
        const string channelAccessToken = "sQK8v90ohwrqsQ2aB4Uk7VlkXt2eh+gNS5CN0OXXpUWqhCaVUEajfTR/JwZxXNIdtl7Fyj99CKuf27B9Lz5zEth5RtQVD9iVVgZd6VIOxZu0oHm65vat6+fSK4o6zy44Xd4ekzr5O0Hze1Sq2frQpgdB04t89/1O/w1cDnyilFU=";
        const string AdminUserId= "Ud053c5b30e1bb4c805a2578915204cc7";

        [Route("api/LineWebHookSample")]
        [HttpPost]
        public IHttpActionResult POST()
        {
            try
            {
                //設定ChannelAccessToken(或抓取Web.Config)
                this.ChannelAccessToken = channelAccessToken;
                //取得Line Event(範例，只取第一個)
                var LineEvent = this.ReceivedMessage.events.FirstOrDefault();
                //配合Line verify 
                if (LineEvent.replyToken == "00000000000000000000000000000000") return Ok();
                //回覆訊息
                if (LineEvent.type == "message")
                {
                    if (LineEvent.message.type == "text") //收到文字
                        this.ReplyMessage(LineEvent.replyToken, "你說了:" + LineEvent.message.text);
                    if (LineEvent.message.type == "sticker") //收到貼圖
                        this.ReplyMessage(LineEvent.replyToken, 1, 2);
                }
                //response OK
                return Ok();
            }
            catch (Exception ex)
            {
                //如果發生錯誤，傳訊息給Admin
                this.PushMessage(AdminUserId, "發生錯誤:\n" + ex.Message);
                //response OK
                return Ok();
            }
        }
    }
}
