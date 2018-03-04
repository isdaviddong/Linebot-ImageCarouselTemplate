using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _default : System.Web.UI.Page
    {
        string ChannelAccessToken = "!!! replace with Channel Access Token !!!";
        string AdminUserId = "!!! replace with your admin Userid !!!";

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //建立Bot instance
            isRock.LineBot.Bot bot =
                new isRock.LineBot.Bot(ChannelAccessToken);  //傳入Channel access token

            //第一個Column 
            var ImageCarouselColumn1 = new isRock.LineBot.ImageCarouselColumn
            {
                //設定圖片
                imageUrl = new Uri("https://arock.blob.core.windows.net/blogdata201706/22-124357-ad3c87d6-b9cc-488a-8150-1c2fe642d237.png"),
                //設定回覆動作
                action = new isRock.LineBot.MessageAction() { label = "標題A", text = "回覆文字A" }
            };

            //第一個Column 
            var ImageCarouselColumn2 = new isRock.LineBot.ImageCarouselColumn
            {
                //設定圖片
                imageUrl = new Uri("https://arock.blob.core.windows.net/blogdata201803/29-101326-d653db4b-44ea-4fe9-af6b-26730734d450.png"),
                //設定回覆動作
                action = new isRock.LineBot.MessageAction() { label = "標題B", text = "回覆文字B" }
            };

            //建立CarouselTemplate
            var ImageCarouselTemplate = new isRock.LineBot.ImageCarouselTemplate();

            //這是範例，所以用一組樣板建立三個
            ImageCarouselTemplate.columns.Add(ImageCarouselColumn1);
            ImageCarouselTemplate.columns.Add(ImageCarouselColumn2);
            //發送 CarouselTemplate
            bot.PushMessage(AdminUserId, ImageCarouselTemplate);
        }
    }
}