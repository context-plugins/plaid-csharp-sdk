using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// An enum indicating the type of a linked service. Note that <c>adult_sites</c> refers to explicit video content, and includes a number of related services.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RiskCheckLinkedService>))]
public sealed record RiskCheckLinkedService : StringEnum<RiskCheckLinkedService>
{
    private RiskCheckLinkedService(string value) : base(value)
    {
    }

    public static readonly RiskCheckLinkedService Aboutme = new("aboutme");

    public static readonly RiskCheckLinkedService Adobe = new("adobe");

    public static readonly RiskCheckLinkedService AdultSites = new("adult_sites");

    public static readonly RiskCheckLinkedService Airbnb = new("airbnb");

    public static readonly RiskCheckLinkedService Altbalaji = new("altbalaji");

    public static readonly RiskCheckLinkedService Amazon = new("amazon");

    public static readonly RiskCheckLinkedService Apple = new("apple");

    public static readonly RiskCheckLinkedService Archiveorg = new("archiveorg");

    public static readonly RiskCheckLinkedService Atlassian = new("atlassian");

    public static readonly RiskCheckLinkedService Bitmoji = new("bitmoji");

    public static readonly RiskCheckLinkedService Bodybuilding = new("bodybuilding");

    public static readonly RiskCheckLinkedService Booking = new("booking");

    public static readonly RiskCheckLinkedService Bukalapak = new("bukalapak");

    public static readonly RiskCheckLinkedService Codecademy = new("codecademy");

    public static readonly RiskCheckLinkedService Deliveroo = new("deliveroo");

    public static readonly RiskCheckLinkedService Diigo = new("diigo");

    public static readonly RiskCheckLinkedService Discord = new("discord");

    public static readonly RiskCheckLinkedService Disneyplus = new("disneyplus");

    public static readonly RiskCheckLinkedService Duolingo = new("duolingo");

    public static readonly RiskCheckLinkedService Ebay = new("ebay");

    public static readonly RiskCheckLinkedService Envato = new("envato");

    public static readonly RiskCheckLinkedService Eventbrite = new("eventbrite");

    public static readonly RiskCheckLinkedService Evernote = new("evernote");

    public static readonly RiskCheckLinkedService Facebook = new("facebook");

    public static readonly RiskCheckLinkedService Firefox = new("firefox");

    public static readonly RiskCheckLinkedService Flickr = new("flickr");

    public static readonly RiskCheckLinkedService Flipkart = new("flipkart");

    public static readonly RiskCheckLinkedService Foursquare = new("foursquare");

    public static readonly RiskCheckLinkedService Freelancer = new("freelancer");

    public static readonly RiskCheckLinkedService Gaana = new("gaana");

    public static readonly RiskCheckLinkedService Giphy = new("giphy");

    public static readonly RiskCheckLinkedService Github = new("github");

    public static readonly RiskCheckLinkedService Google = new("google");

    public static readonly RiskCheckLinkedService Gravatar = new("gravatar");

    public static readonly RiskCheckLinkedService Hubspot = new("hubspot");

    public static readonly RiskCheckLinkedService Imgur = new("imgur");

    public static readonly RiskCheckLinkedService Instagram = new("instagram");

    public static readonly RiskCheckLinkedService Jdid = new("jdid");

    public static readonly RiskCheckLinkedService Kakao = new("kakao");

    public static readonly RiskCheckLinkedService Kommo = new("kommo");

    public static readonly RiskCheckLinkedService Komoot = new("komoot");

    public static readonly RiskCheckLinkedService Lastfm = new("lastfm");

    public static readonly RiskCheckLinkedService Lazada = new("lazada");

    public static readonly RiskCheckLinkedService Line = new("line");

    public static readonly RiskCheckLinkedService Linkedin = new("linkedin");

    public static readonly RiskCheckLinkedService Mailru = new("mailru");

    public static readonly RiskCheckLinkedService Microsoft = new("microsoft");

    public static readonly RiskCheckLinkedService Myspace = new("myspace");

    public static readonly RiskCheckLinkedService Netflix = new("netflix");

    public static readonly RiskCheckLinkedService Nike = new("nike");

    public static readonly RiskCheckLinkedService Ok = new("ok");

    public static readonly RiskCheckLinkedService Patreon = new("patreon");

    public static readonly RiskCheckLinkedService Pinterest = new("pinterest");

    public static readonly RiskCheckLinkedService Plurk = new("plurk");

    public static readonly RiskCheckLinkedService Quora = new("quora");

    public static readonly RiskCheckLinkedService Qzone = new("qzone");

    public static readonly RiskCheckLinkedService Rambler = new("rambler");

    public static readonly RiskCheckLinkedService Rappi = new("rappi");

    public static readonly RiskCheckLinkedService Replit = new("replit");

    public static readonly RiskCheckLinkedService Samsung = new("samsung");

    public static readonly RiskCheckLinkedService Seoclerks = new("seoclerks");

    public static readonly RiskCheckLinkedService Shopclues = new("shopclues");

    public static readonly RiskCheckLinkedService Skype = new("skype");

    public static readonly RiskCheckLinkedService Snapchat = new("snapchat");

    public static readonly RiskCheckLinkedService Snapdeal = new("snapdeal");

    public static readonly RiskCheckLinkedService Soundcloud = new("soundcloud");

    public static readonly RiskCheckLinkedService Spotify = new("spotify");

    public static readonly RiskCheckLinkedService Starz = new("starz");

    public static readonly RiskCheckLinkedService Strava = new("strava");

    public static readonly RiskCheckLinkedService Taringa = new("taringa");

    public static readonly RiskCheckLinkedService Telegram = new("telegram");

    public static readonly RiskCheckLinkedService Tiki = new("tiki");

    public static readonly RiskCheckLinkedService Tokopedia = new("tokopedia");

    public static readonly RiskCheckLinkedService Treehouse = new("treehouse");

    public static readonly RiskCheckLinkedService Tumblr = new("tumblr");

    public static readonly RiskCheckLinkedService Twitter = new("twitter");

    public static readonly RiskCheckLinkedService Venmo = new("venmo");

    public static readonly RiskCheckLinkedService Viber = new("viber");

    public static readonly RiskCheckLinkedService Vimeo = new("vimeo");

    public static readonly RiskCheckLinkedService Vivino = new("vivino");

    public static readonly RiskCheckLinkedService Vkontakte = new("vkontakte");

    public static readonly RiskCheckLinkedService Wattpad = new("wattpad");

    public static readonly RiskCheckLinkedService Weibo = new("weibo");

    public static readonly RiskCheckLinkedService Whatsapp = new("whatsapp");

    public static readonly RiskCheckLinkedService Wordpress = new("wordpress");

    public static readonly RiskCheckLinkedService Xing = new("xing");

    public static readonly RiskCheckLinkedService Yahoo = new("yahoo");

    public static readonly RiskCheckLinkedService Yandex = new("yandex");

    public static readonly RiskCheckLinkedService Zalo = new("zalo");

    public static readonly RiskCheckLinkedService Zoho = new("zoho");

    public static RiskCheckLinkedService FromValue(string value) => FromValueCore(value);
}
