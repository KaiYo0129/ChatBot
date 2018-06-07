using isRock.LineBot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class _default : System.Web.UI.Page
    {
        const string channelAccessToken = "sQK8v90ohwrqsQ2aB4Uk7VlkXt2eh+gNS5CN0OXXpUWqhCaVUEajfTR/JwZxXNIdtl7Fyj99CKuf27B9Lz5zEth5RtQVD9iVVgZd6VIOxZu0oHm65vat6+fSK4o6zy44Xd4ekzr5O0Hze1Sq2frQpgdB04t89/1O/w1cDnyilFU=";
        const string AdminUserId= "Ud053c5b30e1bb4c805a2578915204cc7";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            bot.PushMessage(AdminUserId, $"測試 {DateTime.Now.ToString()} ! ");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            bot.PushMessage(AdminUserId, 1,2);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            var actions = new List<isRock.LineBot.TemplateActionBase>();
            actions.Add(new isRock.LineBot.MessageAction() { label = "Yes", text = "是" });
            actions.Add(new isRock.LineBot.UriAction() { label = "url", uri = new Uri("http://www.google.com") });
            actions.Add(new isRock.LineBot.PostbackAction() { label = "postack", data = "abc=aaa&def=111" });
            var TempalteMessage = new isRock.LineBot.ButtonsTemplate()
            {
                title = "選項",
                text = "請選擇其一",
                altText = "請在手機上檢視",
                thumbnailImageUrl = new Uri("https://i.ytimg.com/vi/r3wLrjai_9Q/hqdefault.jpg"),
                actions = actions
            };
            bot.PushMessage(AdminUserId, TempalteMessage);
        }
    }
}