using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// An enum indicating the type of a linked service. Note that <c>adult_sites</c> refers to explicit video content, and includes a number of related services.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RiskCheckLinkedService>))]
public sealed record RiskCheckLinkedService : OpenStringEnum<RiskCheckLinkedService>
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

    public TResult Match<TResult>(Func<TResult> onAboutme,
        Func<TResult> onAdobe,
        Func<TResult> onAdultSites,
        Func<TResult> onAirbnb,
        Func<TResult> onAltbalaji,
        Func<TResult> onAmazon,
        Func<TResult> onApple,
        Func<TResult> onArchiveorg,
        Func<TResult> onAtlassian,
        Func<TResult> onBitmoji,
        Func<TResult> onBodybuilding,
        Func<TResult> onBooking,
        Func<TResult> onBukalapak,
        Func<TResult> onCodecademy,
        Func<TResult> onDeliveroo,
        Func<TResult> onDiigo,
        Func<TResult> onDiscord,
        Func<TResult> onDisneyplus,
        Func<TResult> onDuolingo,
        Func<TResult> onEbay,
        Func<TResult> onEnvato,
        Func<TResult> onEventbrite,
        Func<TResult> onEvernote,
        Func<TResult> onFacebook,
        Func<TResult> onFirefox,
        Func<TResult> onFlickr,
        Func<TResult> onFlipkart,
        Func<TResult> onFoursquare,
        Func<TResult> onFreelancer,
        Func<TResult> onGaana,
        Func<TResult> onGiphy,
        Func<TResult> onGithub,
        Func<TResult> onGoogle,
        Func<TResult> onGravatar,
        Func<TResult> onHubspot,
        Func<TResult> onImgur,
        Func<TResult> onInstagram,
        Func<TResult> onJdid,
        Func<TResult> onKakao,
        Func<TResult> onKommo,
        Func<TResult> onKomoot,
        Func<TResult> onLastfm,
        Func<TResult> onLazada,
        Func<TResult> onLine,
        Func<TResult> onLinkedin,
        Func<TResult> onMailru,
        Func<TResult> onMicrosoft,
        Func<TResult> onMyspace,
        Func<TResult> onNetflix,
        Func<TResult> onNike,
        Func<TResult> onOk,
        Func<TResult> onPatreon,
        Func<TResult> onPinterest,
        Func<TResult> onPlurk,
        Func<TResult> onQuora,
        Func<TResult> onQzone,
        Func<TResult> onRambler,
        Func<TResult> onRappi,
        Func<TResult> onReplit,
        Func<TResult> onSamsung,
        Func<TResult> onSeoclerks,
        Func<TResult> onShopclues,
        Func<TResult> onSkype,
        Func<TResult> onSnapchat,
        Func<TResult> onSnapdeal,
        Func<TResult> onSoundcloud,
        Func<TResult> onSpotify,
        Func<TResult> onStarz,
        Func<TResult> onStrava,
        Func<TResult> onTaringa,
        Func<TResult> onTelegram,
        Func<TResult> onTiki,
        Func<TResult> onTokopedia,
        Func<TResult> onTreehouse,
        Func<TResult> onTumblr,
        Func<TResult> onTwitter,
        Func<TResult> onVenmo,
        Func<TResult> onViber,
        Func<TResult> onVimeo,
        Func<TResult> onVivino,
        Func<TResult> onVkontakte,
        Func<TResult> onWattpad,
        Func<TResult> onWeibo,
        Func<TResult> onWhatsapp,
        Func<TResult> onWordpress,
        Func<TResult> onXing,
        Func<TResult> onYahoo,
        Func<TResult> onYandex,
        Func<TResult> onZalo,
        Func<TResult> onZoho,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Aboutme => onAboutme(),
            _ when this == Adobe => onAdobe(),
            _ when this == AdultSites => onAdultSites(),
            _ when this == Airbnb => onAirbnb(),
            _ when this == Altbalaji => onAltbalaji(),
            _ when this == Amazon => onAmazon(),
            _ when this == Apple => onApple(),
            _ when this == Archiveorg => onArchiveorg(),
            _ when this == Atlassian => onAtlassian(),
            _ when this == Bitmoji => onBitmoji(),
            _ when this == Bodybuilding => onBodybuilding(),
            _ when this == Booking => onBooking(),
            _ when this == Bukalapak => onBukalapak(),
            _ when this == Codecademy => onCodecademy(),
            _ when this == Deliveroo => onDeliveroo(),
            _ when this == Diigo => onDiigo(),
            _ when this == Discord => onDiscord(),
            _ when this == Disneyplus => onDisneyplus(),
            _ when this == Duolingo => onDuolingo(),
            _ when this == Ebay => onEbay(),
            _ when this == Envato => onEnvato(),
            _ when this == Eventbrite => onEventbrite(),
            _ when this == Evernote => onEvernote(),
            _ when this == Facebook => onFacebook(),
            _ when this == Firefox => onFirefox(),
            _ when this == Flickr => onFlickr(),
            _ when this == Flipkart => onFlipkart(),
            _ when this == Foursquare => onFoursquare(),
            _ when this == Freelancer => onFreelancer(),
            _ when this == Gaana => onGaana(),
            _ when this == Giphy => onGiphy(),
            _ when this == Github => onGithub(),
            _ when this == Google => onGoogle(),
            _ when this == Gravatar => onGravatar(),
            _ when this == Hubspot => onHubspot(),
            _ when this == Imgur => onImgur(),
            _ when this == Instagram => onInstagram(),
            _ when this == Jdid => onJdid(),
            _ when this == Kakao => onKakao(),
            _ when this == Kommo => onKommo(),
            _ when this == Komoot => onKomoot(),
            _ when this == Lastfm => onLastfm(),
            _ when this == Lazada => onLazada(),
            _ when this == Line => onLine(),
            _ when this == Linkedin => onLinkedin(),
            _ when this == Mailru => onMailru(),
            _ when this == Microsoft => onMicrosoft(),
            _ when this == Myspace => onMyspace(),
            _ when this == Netflix => onNetflix(),
            _ when this == Nike => onNike(),
            _ when this == Ok => onOk(),
            _ when this == Patreon => onPatreon(),
            _ when this == Pinterest => onPinterest(),
            _ when this == Plurk => onPlurk(),
            _ when this == Quora => onQuora(),
            _ when this == Qzone => onQzone(),
            _ when this == Rambler => onRambler(),
            _ when this == Rappi => onRappi(),
            _ when this == Replit => onReplit(),
            _ when this == Samsung => onSamsung(),
            _ when this == Seoclerks => onSeoclerks(),
            _ when this == Shopclues => onShopclues(),
            _ when this == Skype => onSkype(),
            _ when this == Snapchat => onSnapchat(),
            _ when this == Snapdeal => onSnapdeal(),
            _ when this == Soundcloud => onSoundcloud(),
            _ when this == Spotify => onSpotify(),
            _ when this == Starz => onStarz(),
            _ when this == Strava => onStrava(),
            _ when this == Taringa => onTaringa(),
            _ when this == Telegram => onTelegram(),
            _ when this == Tiki => onTiki(),
            _ when this == Tokopedia => onTokopedia(),
            _ when this == Treehouse => onTreehouse(),
            _ when this == Tumblr => onTumblr(),
            _ when this == Twitter => onTwitter(),
            _ when this == Venmo => onVenmo(),
            _ when this == Viber => onViber(),
            _ when this == Vimeo => onVimeo(),
            _ when this == Vivino => onVivino(),
            _ when this == Vkontakte => onVkontakte(),
            _ when this == Wattpad => onWattpad(),
            _ when this == Weibo => onWeibo(),
            _ when this == Whatsapp => onWhatsapp(),
            _ when this == Wordpress => onWordpress(),
            _ when this == Xing => onXing(),
            _ when this == Yahoo => onYahoo(),
            _ when this == Yandex => onYandex(),
            _ when this == Zalo => onZalo(),
            _ when this == Zoho => onZoho(),
            _ => otherwise(Value)
        };

    public void Match(Action onAboutme,
        Action onAdobe,
        Action onAdultSites,
        Action onAirbnb,
        Action onAltbalaji,
        Action onAmazon,
        Action onApple,
        Action onArchiveorg,
        Action onAtlassian,
        Action onBitmoji,
        Action onBodybuilding,
        Action onBooking,
        Action onBukalapak,
        Action onCodecademy,
        Action onDeliveroo,
        Action onDiigo,
        Action onDiscord,
        Action onDisneyplus,
        Action onDuolingo,
        Action onEbay,
        Action onEnvato,
        Action onEventbrite,
        Action onEvernote,
        Action onFacebook,
        Action onFirefox,
        Action onFlickr,
        Action onFlipkart,
        Action onFoursquare,
        Action onFreelancer,
        Action onGaana,
        Action onGiphy,
        Action onGithub,
        Action onGoogle,
        Action onGravatar,
        Action onHubspot,
        Action onImgur,
        Action onInstagram,
        Action onJdid,
        Action onKakao,
        Action onKommo,
        Action onKomoot,
        Action onLastfm,
        Action onLazada,
        Action onLine,
        Action onLinkedin,
        Action onMailru,
        Action onMicrosoft,
        Action onMyspace,
        Action onNetflix,
        Action onNike,
        Action onOk,
        Action onPatreon,
        Action onPinterest,
        Action onPlurk,
        Action onQuora,
        Action onQzone,
        Action onRambler,
        Action onRappi,
        Action onReplit,
        Action onSamsung,
        Action onSeoclerks,
        Action onShopclues,
        Action onSkype,
        Action onSnapchat,
        Action onSnapdeal,
        Action onSoundcloud,
        Action onSpotify,
        Action onStarz,
        Action onStrava,
        Action onTaringa,
        Action onTelegram,
        Action onTiki,
        Action onTokopedia,
        Action onTreehouse,
        Action onTumblr,
        Action onTwitter,
        Action onVenmo,
        Action onViber,
        Action onVimeo,
        Action onVivino,
        Action onVkontakte,
        Action onWattpad,
        Action onWeibo,
        Action onWhatsapp,
        Action onWordpress,
        Action onXing,
        Action onYahoo,
        Action onYandex,
        Action onZalo,
        Action onZoho,
        Action<string> otherwise)
    {
        if (this == Aboutme) onAboutme();
        else if (this == Adobe) onAdobe();
        else if (this == AdultSites) onAdultSites();
        else if (this == Airbnb) onAirbnb();
        else if (this == Altbalaji) onAltbalaji();
        else if (this == Amazon) onAmazon();
        else if (this == Apple) onApple();
        else if (this == Archiveorg) onArchiveorg();
        else if (this == Atlassian) onAtlassian();
        else if (this == Bitmoji) onBitmoji();
        else if (this == Bodybuilding) onBodybuilding();
        else if (this == Booking) onBooking();
        else if (this == Bukalapak) onBukalapak();
        else if (this == Codecademy) onCodecademy();
        else if (this == Deliveroo) onDeliveroo();
        else if (this == Diigo) onDiigo();
        else if (this == Discord) onDiscord();
        else if (this == Disneyplus) onDisneyplus();
        else if (this == Duolingo) onDuolingo();
        else if (this == Ebay) onEbay();
        else if (this == Envato) onEnvato();
        else if (this == Eventbrite) onEventbrite();
        else if (this == Evernote) onEvernote();
        else if (this == Facebook) onFacebook();
        else if (this == Firefox) onFirefox();
        else if (this == Flickr) onFlickr();
        else if (this == Flipkart) onFlipkart();
        else if (this == Foursquare) onFoursquare();
        else if (this == Freelancer) onFreelancer();
        else if (this == Gaana) onGaana();
        else if (this == Giphy) onGiphy();
        else if (this == Github) onGithub();
        else if (this == Google) onGoogle();
        else if (this == Gravatar) onGravatar();
        else if (this == Hubspot) onHubspot();
        else if (this == Imgur) onImgur();
        else if (this == Instagram) onInstagram();
        else if (this == Jdid) onJdid();
        else if (this == Kakao) onKakao();
        else if (this == Kommo) onKommo();
        else if (this == Komoot) onKomoot();
        else if (this == Lastfm) onLastfm();
        else if (this == Lazada) onLazada();
        else if (this == Line) onLine();
        else if (this == Linkedin) onLinkedin();
        else if (this == Mailru) onMailru();
        else if (this == Microsoft) onMicrosoft();
        else if (this == Myspace) onMyspace();
        else if (this == Netflix) onNetflix();
        else if (this == Nike) onNike();
        else if (this == Ok) onOk();
        else if (this == Patreon) onPatreon();
        else if (this == Pinterest) onPinterest();
        else if (this == Plurk) onPlurk();
        else if (this == Quora) onQuora();
        else if (this == Qzone) onQzone();
        else if (this == Rambler) onRambler();
        else if (this == Rappi) onRappi();
        else if (this == Replit) onReplit();
        else if (this == Samsung) onSamsung();
        else if (this == Seoclerks) onSeoclerks();
        else if (this == Shopclues) onShopclues();
        else if (this == Skype) onSkype();
        else if (this == Snapchat) onSnapchat();
        else if (this == Snapdeal) onSnapdeal();
        else if (this == Soundcloud) onSoundcloud();
        else if (this == Spotify) onSpotify();
        else if (this == Starz) onStarz();
        else if (this == Strava) onStrava();
        else if (this == Taringa) onTaringa();
        else if (this == Telegram) onTelegram();
        else if (this == Tiki) onTiki();
        else if (this == Tokopedia) onTokopedia();
        else if (this == Treehouse) onTreehouse();
        else if (this == Tumblr) onTumblr();
        else if (this == Twitter) onTwitter();
        else if (this == Venmo) onVenmo();
        else if (this == Viber) onViber();
        else if (this == Vimeo) onVimeo();
        else if (this == Vivino) onVivino();
        else if (this == Vkontakte) onVkontakte();
        else if (this == Wattpad) onWattpad();
        else if (this == Weibo) onWeibo();
        else if (this == Whatsapp) onWhatsapp();
        else if (this == Wordpress) onWordpress();
        else if (this == Xing) onXing();
        else if (this == Yahoo) onYahoo();
        else if (this == Yandex) onYandex();
        else if (this == Zalo) onZalo();
        else if (this == Zoho) onZoho();
        else otherwise(Value);
    }
}
