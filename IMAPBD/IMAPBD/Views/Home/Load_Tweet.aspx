<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>
<script runat="server">

    public  void Button1_Click(object sender, EventArgs e)
    {
        IMAPBD.Controllers.TweetClass tweet = new IMAPBD.Controllers.TweetClass();
        tweet.GetTweet();

    }
</script>




<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title></title>

    
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <div class="tweets-container">
                <p>tweets...<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />

                    <input type="button" value="Get Tweets" onclick="location.href='<%: Url.Action("Load", "Load_TweetController") %>'" />
                </p>
               
            </div>
            <asp:BulletedList ID="TweetList" runat="server"></asp:BulletedList>
         

        </div>
    </form>
</body>
</html>
