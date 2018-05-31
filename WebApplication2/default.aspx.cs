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
        const string channelAccessToken = "!!!!! 改成自己的ChannelAccessToken !!!!!";
        const string AdminUserId= "!!!改成你的AdminUserId!!!";

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