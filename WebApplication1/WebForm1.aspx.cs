using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DateTime dateTime = new DateTime();
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot("sQK8v90ohwrqsQ2aB4Uk7VlkXt2eh+gNS5CN0OXXpUWqhCaVUEajfTR/JwZxXNIdtl7Fyj99CKuf27B9Lz5zEth5RtQVD9iVVgZd6VIOxZu0oHm65vat6+fSK4o6zy44Xd4ekzr5O0Hze1Sq2frQpgdB04t89/1O/w1cDnyilFU=");
            bot.PushMessage("Ud053c5b30e1bb4c805a2578915204cc7", "123");
            bot.PushMessage("Ud053c5b30e1bb4c805a2578915204cc7", 1,8);
            bot.PushMessage("Ud053c5b30e1bb4c805a2578915204cc7",new Uri("https://ih0.redbubble.net/image.445130578.1102/flat,800x800,075,f.u1.jpg"));
        }
    }
}