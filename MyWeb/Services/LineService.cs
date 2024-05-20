using System.Drawing;
using Line.Messaging;
using Line.Messaging.Webhooks;

public class LineService : ILineService
{
    public LineService()
    {
    }

    public async Task<List<ISendMessage>> ProcessTextEventMessageAsync(string channelId, string userId, string message)
    {
        var result = null as List<ISendMessage>;

        /* 513進度
         if (message.Contains("黎深"))
         {
             return  new List<ISendMessage>
             {
             new ImageMessage("https://assets.papegames.com/nikkiweb/papegame/deepspacetw/material/20240110/699e9eab486328f6dd8718911dd86043.png","https://assets.papegames.com/nikkiweb/papegame/deepspacetw/material/20240110/699e9eab486328f6dd8718911dd86043.png",
                 null),
             };
         }*/

        Random rnd = new();
        int index = rnd.Next(0, 3);//012
        string[] imageUrl = new string[]
        {
            "https://assets.papegames.com/nikkiweb/papegame/deepspacetw/material/20240110/699e9eab486328f6dd8718911dd86043.png",
            "https://assets.papegames.com/nikkiweb/papegame/deepspacetw/material/20240109/3bcac847bd8995730801796639ffd341.png",
            "https://assets.papegames.com/nikkiweb/papegame/deepspacetw/material/20240109/2499eed5c83a35a472eee74bec9b5e41.png",
        };
                
            
            
        
        result = new List<ISendMessage>
        {
            new ImageMessage(imageUrl[index],"https://assets.papegames.com/nikkiweb/papegame/deepspacetw/material/20240110/699e9eab486328f6dd8718911dd86043.png",
                null),
            
            new TextMessage($"Receive a text event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessStickerEventMessageAsync(string channelId, string userId,string packageId, string stickerId)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a sticker event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessImageEventMessageAsync(string channelId, string userId,string originalContentUrl,
        string previewImageUrl)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a image event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessImageEventMessageAsync(string channelId, string userId, Image image)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a image event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessVideoEventMessageAsync(string channelId, string userId,string originalContentUrl, string previewImageUrl)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a video event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessAudioEventMessageAsync(string channelId, string userId,string originalContentUrl, int duration)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a audio event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessLocationEventMessageAsync(string channelId, string userId,string title, string address, float latitude, float longitude)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a location event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }
}