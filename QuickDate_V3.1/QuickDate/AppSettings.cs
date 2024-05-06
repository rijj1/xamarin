//###############################################################
// Author >> Elin Doughouz 
// Copyright (c) PixelPhoto 15/07/2018 All Right Reserved
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// Follow me on facebook >> https://www.facebook.com/Elindoughous
//=========================================================
//For the accuracy of the icon and logo, please use this website " http://nsimage.brosteins.com " and add images according to size in folders " mipmap " 

using Android.Graphics;
using QuickDate.Helpers.Model;

namespace QuickDate
{
    internal static class AppSettings
    {
        /// <summary>
        /// Deep Links To App Content
        /// you should add your website without http in the analytic.xml file >> ../values/analytic.xml .. line 5
        /// <string name="ApplicationUrlWeb">quickdatescript.com</string>
        /// </summary> 
        public static readonly string TripleDesAppServiceProvider = "a750X3uhWo50JBJbl0TR92NIZlVUaqnPDsF2TFmeLB4hCN5lxDMfFzjz9lfzQwlkSisDgDKnY50omCfp6gZdfVT5Ds94lY8VKeoV323boMOQ8jLEErEnOaizRgaU+yn5oxVBQRKaeGzV1AiVW46E/9CmL0bwYcx84j+pwbjsK1v6qzp73ziywb9seOWJ9ntH51EbQgGBU7CivHGMT9NoW/jjv5IaIoJzMw5/MjT0hQsF2/RGRPAqXsFshacL2wNSgkzcupLLTKgt9WHzUYRQv6ZG2tPKudI4XFTA2AZ+JQ8lfamGOdDH/1SsNmjkhmIYXa6oHvN00rDwVPumy3BmMOGWfsCYiz/NrNNA7Mppdt7HkKPC7eveWGpZ6+rRJFVmkQbrJYcAsiHC1b0EZQmoaQ3WMCVA7qUP3irNSw+PPEhvvTUOAF7UuggZfHmvc8vxGZQji9nmmivw3wj8bFOsaAM3JUDEfRxBqVoHkscfHCWzu0O3OMh82xIQuFykkOcI6hvYNMsFlfTISHfZJwMnXyDZJ/KHN7qeMF9bpaZoPN1gF+WGjr9pwEBJiIpn4vnzwok+hopCIKTxE/UHCtz/CKhJtYXiCBLbLTu9wxbSjY3/TYc1uU90Kxk98jcYS7cjTSLTXlZKOKVq5M9NAveMSw2Uy0IOrKajtv65xh7/6cfJioWDwyM7CZbbkiK9maXMSqUjSSksmRSp/klqAnLIN+yAVXOimCFXyFmw60hYlPW+LRd2EyQuULScOV/IekdQcOTZWkb0TUUMifb+usHdnoM1lDFDwTNGYfUhQjL/Oo7iEchUsQvl0e7CJzYOhwCFzs5rIu6h36nW9JGSJ8gKymLfDu/BUFDUuc0U/bUJ3Yaj7rcLCu5czzTrkLbOKYldQWkfd4fOdrWPjTzDL/IrMoVqqU5087I1+N9h/mj4bwDkw/4U3u8wO3Yc24B50mC7O4LS9ekZfkKC544hMTbDhoXWJSo4nLMabvHIyX+zEh+tx6dHyN06Zu07llo9qY6EfqCGAK6yymS5iZRBjIhvyCJBvpyTiIq7b28pFJsW7VeCzMaRWeT8mPaJ67fPy0WBKk5yBAO77EscSfz+taD9RMaDkM7C6WYLT8U/ohFNjojXEqAZkyk3XcaxqjsyuqvLcpeWo3wv423zxZgZIY7Ctn06FISh1OwYK1pTAmBQdApQs82/N0vKHZTNchFnQ2Oh3hSor7+81qUVnl0EEmy0apueGfM2YKidVKF3v8f5sV1lnr0WMOT+1DKsxpJL8JAMab1ErHqtulL66qzKQJc8D9MI7pLTT/IUXpVTgkj8m6iJC+gVDPYjYcNsQKA0jkb4n0/5lg/Pfhuj2BNhkZUQIVEapuFOzScxEoDCUhgVug248nxONx8CloKwrd/wARBvjwgkpOwwxT2e+XUZgCA9+YWbzVs3qz1Fc++CU1OvaCSz7Zf+WljGFMN3DIbdfW55U+LWrq23RzlamFnBTLFC1aLOA0W5gdP8f2c9owR93p5MdeVR22FG+aQbIf/ZY6KzXWP4RlEDQyECqJnV/raBKSRbd1aNBZxrxLDHRWJs7U3+khdJOGUBY0YTNxTgSUmc8mLILcWgcJ/is0OidIK2sOTi8RVJ05pYaZ3Mk/Dwav+iijcgoaVV7MMnsilkkRUDlSb+Dd9HPpvmrl5uw1z98ES18KTZY9ETjrlWbYykcRZp2h4JvYJCqnrOwu2TIemDgds2yAh98NKTLs5lDl3fgjug8/yLEXhYDPqfpQddEmukmPrPGitX6XoQ76EykH2wBmSo3NTaYgL2pyM68m86QqMdSmrZmoYYPG4QESc/op+Y+B4wnr3NxFgyeKdbXxbqftj6eRLgri9/IyAdWEy8o9Vjqz2k1NNEWbHSyKhlWyeC2w1FFznp8WjOYee1YhL9VVnfA1RTrTYmoSI8s2+NfTRn0IeyEF4xgKR3O0pjpCEr7Qe3fz9UVAkMCSMfPy9aP3InsjLBdHRA3zl9CPCjEZb3IQ327F9G7rhRxI0LQSU+wZpELX00B/fXtJISfYuuWZtOs3cuJALw5nQ7qhy70nO5VI+49t62/BWFYWtYKbFqGad/oZbB+ODB7aagqChmO1foWzRGZ4/0C+YVrON3SBeWpJgI7ZDJ9KLWeW9jMhQybqXFbDrym2DC68FOcw3iDrX3eRmISxCbBju/or30sB6zmIVqICQKRFHIvnHG5T7foS4rQFLWJa0vfduv40hgnr4vJjaIjKkz5eeqZk9TglXYQ4lxdjxRvL8YYTRUPwhwXhH2W6oK8ctLfdtQjaCASGjpceifq06jjfus9rxmPWDhYbZSAwG57W0GwzynVlP8Sn6k26fsMsCWqgd5CDNVrvupaPPux9kfb1Umjyu/RmNj7j1mPjjnWFpxnsqcKV3W5syrC6KNlJMPK/AWqxunXOe9yL7MS0dUeducbMNbq6sWsQIV/BT58Iw70LZfLriuFCpLR4Mr1bhXg57uS/g7gFczQlMc5NCsr1XOpGk1QKIKiRdwq8+HGc14AQrIKvf4TwePmUGujttaXjpa9hv5mIyL4G99f4xz7YX/LksiymLOAyp7A4EeZlWnVzwU8oNPH+Cb6r822rviCbSNKeSnFqTQYGWxbE26ROLfE1rd6wSBwwvmLkF0PWMJW074RGHV3xHbY5b/bW9/m55rflUBs52AB6EsiX0+YjfBFoL/GrGkQXHjmGYpQEAbGB9wstQv6vqLu6avfkIico+uLHUFRvi+Q168rmYiAjcmJjrxqj0r5Z9bZLYGFCvxIeJYLq7LNu02ZoewCkAkO4f7tVtbHf8MKLL+HEDqMa7KjpLDBnljmzVv0lkV5Ao0bKbLpnB+grFL2mP1mYSuKyZmc+TgsyTR3AXSp91ajTD+6ZSpt5AIjxE4bgrI9ObNPdgmMsRhVffcTIoCIOcOVFiYfV+8q4oBNbTFaEqNgtbwHPKR/El1dZKCDXlSQNlzqZ9RH5XAtw3ozM134RdZjrpnf3w+TLCEZCIPVLPbhStF2p3bbhavv/tKR9rpzw13romTOlL5DsGr4ylEqY4ah3sduhyeitF5BSgCrdgp/F9Q4gbKuyMEjueug/7qo0CmRxTg7DcoL4xx2LyMXuYwU5M7CJj2zxHlfhB1g7VvAUyWNgGXEaOZQ1q4mz9WGzSy9pgFTairqhrl5O22QbfK//JGBbhfMFZxAws9TLKBoZ4bkeNqI445ZMA71hTMLvJoBLtw1NQS+B5OZb7KybLZkF+r9YnIWlOOqEMTZo1bxYCX4AJRuP4mBI9UyTMTE13+zZrc3di7Qxb9Erx3ETuSCToMHSgQsaLhYZqjD/0vQX7BV8SKl6to2GADab9RRrsc0GLfFa8u22ARLax2j22t1EkrFaJP1yv888e7GaoHrtwilb7SNyoVlSh0zU1Wyg9F9ndup63eaoWQIFF13PrALIKvGoxIYSoSNw9IFBfQI2yqUHJvWU6n+hlm0lu8pm/LR5bHrVB69P1Nxep4J1FAN73Ym8ULGAe4DFGfrbHQa3c/U3DB+efmY7ckNszqPWeAmQld/GnRNl0lKy8YcVPFEPXCygzo5/5XisaFTO6pKSBCGjWESeDNNDdsKxI2ptjVsfHQROyv/msHsFSjbUZ7SfBYZNbA0ziNhxps91Oeua6VAX07zFJQsH7LUb0m/Fmokbo71ap7uRiGUYfpmFzUZ2yF2hGhNxC2rFnHaGoxq4jV4xd9AHEG0wbw6WsgHth7kPVOCSrr/Yj04cfrPw==";

        //Main Settings >>>>>
        //********************************************************* 
        public static string Version = "3.0";
        public static readonly string ApplicationName = "QuickDate";
        public static readonly string DatabaseName = "QuickDate"; 

        //Main Colors >>
        //*********************************************************
        public static readonly string MainColor = "#FF007F"; 
        public static Color TitleTextColor = Color.Black;
        public static Color TitleTextColorDark = Color.White;

        //Language Settings >> http://www.lingoes.net/en/translator/langcode.htm
        //*********************************************************
        public static bool FlowDirectionRightToLeft = true;
        public static string Lang = ""; //Default language ar

        //Notification Settings >>
        //*********************************************************
        public static bool ShowNotification = true;
        public static string OneSignalAppId = "c6d8ecf6-e3b8-4c49-b208-07a23364a6ed";
         
        //Error Report Mode
        //*********************************************************
        public static readonly bool SetApisReportMode = false;
         
        //Add Animation Image User
        //*********************************************************
        public static readonly bool EnableAddAnimationImageUser = false;
         
        //Set Theme Full Screen App
        //*********************************************************
        public static readonly bool EnableFullScreenApp = false;

        //Social Logins >>
        //If you want login with facebook or google you should change id key in the analytic.xml file or AndroidManifest.xml
        //Facebook >> ../values/analytic.xml  
        //Google >> ../Properties/AndroidManifest.xml .. line 42
        //*********************************************************
        public static readonly bool EnableSmartLockForPasswords = false; 

        public static readonly bool ShowFacebookLogin = true;
        public static readonly bool ShowGoogleLogin = true; 
        public static readonly bool ShowWoWonderLogin = true;  
        public static readonly bool ShowSocialLoginAtRegisterScreen = true;
         
        public static readonly string ClientId = "716215768781-1riglii0rihhc9gmp53qad69tt8o2e03.apps.googleusercontent.com";

        public static readonly string AppNameWoWonder = "WoWonder";
        public static readonly string WoWonderDomainUri = "https://demo.wowonder.com";
        public static readonly string WoWonderAppKey = "131c471c8b4edf662dd0ebf7adf3c3d7365838b9";

        //AdMob >> Please add the code ads in the Here and analytic.xml 
        //*********************************************************
        public static readonly ShowAds ShowAds = ShowAds.AllUsers;

        //Three times after entering the ad is displayed
        public static readonly int ShowAdInterstitialCount = 5;
        public static readonly int ShowAdRewardedVideoCount = 5;
        public static int ShowAdNativeCount = 40;
        public static readonly int ShowAdAppOpenCount = 3;

        public static readonly bool ShowAdMobBanner = true;
        public static readonly bool ShowAdMobInterstitial = true;
        public static readonly bool ShowAdMobRewardVideo = true;
        public static readonly bool ShowAdMobNative = true;
        public static readonly bool ShowAdMobAppOpen = true;  
        public static readonly bool ShowAdMobRewardedInterstitial = true; 

        public static readonly string AdInterstitialKey = "ca-app-pub-5135691635931982/6657648824";
        public static readonly string AdRewardVideoKey = "ca-app-pub-5135691635931982/7559666953";
        public static readonly string AdAdMobNativeKey = "ca-app-pub-5135691635931982/2342769069";
        public static readonly string AdAdMobAppOpenKey = "ca-app-pub-5135691635931982/7036343147";  
        public static readonly string AdRewardedInterstitialKey = "ca-app-pub-5135691635931982/9662506481";  
         
        //FaceBook Ads >> Please add the code ad in the Here and analytic.xml 
        //*********************************************************
        public static readonly bool ShowFbBannerAds = false; 
        public static readonly bool ShowFbInterstitialAds = false; 
        public static readonly bool ShowFbRewardVideoAds = false;  
        public static readonly bool ShowFbNativeAds = false; 

        //YOUR_PLACEMENT_ID
        public static readonly string AdsFbBannerKey = "250485588986218_554026418632132"; 
        public static readonly string AdsFbInterstitialKey = "250485588986218_554026125298828";  
        public static readonly string AdsFbRewardVideoKey = "250485588986218_554072818627492";  
        public static readonly string AdsFbNativeKey = "250485588986218_554706301897477";

        //Colony Ads >> Please add the code ad in the Here 
        //*********************************************************  
        public static readonly bool ShowColonyBannerAds = true; 
        public static readonly bool ShowColonyInterstitialAds = false; 
        public static readonly bool ShowColonyRewardAds = false; 

        public static readonly string AdsColonyAppId = "app72922799d6714ded84"; 
        public static readonly string AdsColonyBannerId = "vz294826d94e094cdf98"; 
        public static readonly string AdsColonyInterstitialId = "vz3240d5ada18e4f78b3"; 
        public static readonly string AdsColonyRewardedId = "vza09dafc6975146f3a7";
  
        //Ads AppLovin >> Please add the code ad in the Here 
        //*********************************************************  
        public static readonly bool ShowAppLovinBannerAds = true;
        public static readonly bool ShowAppLovinInterstitialAds = true;
        public static readonly bool ShowAppLovinRewardAds = true;

        public static readonly string AdsAppLovinBannerId = "a474c0e01669a691";
        public static readonly string AdsAppLovinInterstitialId = "e4e6aa765134f661";
        public static readonly string AdsAppLovinRewardedId = "2acfe4b28e64de66";
        //********************************************************* 

        //Last_Messages Page >>
        ///********************************************************* 
        public static readonly bool RunSoundControl = true;
        public static readonly int RefreshAppAPiSeconds = 6000; // 6 Seconds

        public static readonly int MessageRequestSpeed = 3000; // 3 Seconds
        
        //Set Theme Tab
        //********************************************************* 
        public static TabTheme SetTabDarkTheme = TabTheme.Light; 
        public static readonly BackgroundTheme SetBackgroundTheme = BackgroundTheme.Image; 

        //Bypass Web Errors  
        //*********************************************************
        public static readonly bool TurnTrustFailureOnWebException = true;
        public static readonly bool TurnSecurityProtocolType3072On = true;
         
        //Trending 
        //*********************************************************
        public static readonly bool ShowTrending = true; 
         
        public static readonly bool ShowFilterBasic = true;
        public static readonly bool ShowFilterLooks = true;
        public static readonly bool ShowFilterBackground = true;
        public static readonly bool ShowFilterLifestyle = true;
        public static readonly bool ShowFilterMore = true;
         
        /// <summary>
        /// On main full filter view screen, reset filter option will available only on the first page by default
        /// If you want to show the reset filter option for all the pages then set "ShowResetFilterForAllPages" as true
        /// </summary>
        public static readonly bool ShowResetFilterForAllPages = true;
         
        //*********************************************************
        public static readonly bool RegisterEnabled = true; 
        public static readonly bool BlogsEnabled = true; 
        public static readonly bool PeopleILikedEnabled = true; 
        public static readonly bool PeopleIDislikedEnabled = true; 
        public static readonly bool FavoriteEnabled = true; 
       
        //Premium system
        public static bool PremiumSystemEnabled = true;

        //Phone Validation system
        public static readonly bool ValidationEnabled = true;
          
        public static readonly int AvatarSize = 60;  
        public static readonly int ImageSize = 200;

        public static readonly bool ShowTextWithSpace = true;

        /// <summary>
        /// JustWhenRegister : You can't change type gender after registering an account
        /// </summary>
        public static readonly UpdateGenderSystem UpdateGenderSystem = UpdateGenderSystem.JustWhenRegister; 

        /// <summary>
        /// if notv Enable Friend System ..
        /// you should comment this lines https://prnt.sc/1d2n56g on file notifcation_bar_tabs.xml
        /// you can find this file from  Resources/xml/notifcation_bar_tabs.xml
        /// </summary>
        public static readonly bool EnableFriendSystem = true; 
         
        public static bool ShowWalkTroutPage = true;

        public static readonly bool EnableAppFree = false;

        //Payment System (ShowPaymentCardPage >> Paypal & Stripe ) (ShowLocalBankPage >> Local Bank ) 
        //*********************************************************

        public static readonly PaymentsSystem PaymentsSystem = PaymentsSystem.All;
         
        /// <summary>
        /// Paypal and google pay using Braintree Gateway https://www.braintreepayments.com/
        /// 
        /// Add info keys in Payment Methods : https://prnt.sc/1z5bffc - https://prnt.sc/1z5b0yj
        /// To find your merchant ID :  https://prnt.sc/1z59dy8
        ///
        /// Tokenization Keys : https://prnt.sc/1z59smv
        /// </summary>
        public static readonly bool ShowPaypal = true;
        public static readonly string MerchantAccountId = "test"; 

        public static readonly string SandboxTokenizationKey = "sandbox_kt2f6mdh_hf4ccmn4dfy45******";
        public static readonly string ProductionTokenizationKey = "production_t2wns2y2_dfy45******"; 

        public static readonly bool ShowCreditCard = true;
        public static readonly bool ShowBankTransfer = true;
         
        /// <summary>
        /// if you want this feature enabled go to Properties -> AndroidManefist.xml and remove comments from below code
        /// <uses-permission android:name="com.android.vending.BILLING" />
        /// </summary>
        public static readonly bool ShowInAppBilling = true;


        public static readonly bool ShowCashFree = true; 
        /// <summary>
        /// Currencies : http://prntscr.com/u600ok
        /// </summary>
        public static readonly string CashFreeCurrency = "INR"; 

        /// <summary>
        /// If you want RazorPay you should change id key in the analytic.xml file
        /// razorpay_api_Key >> .. line 28 
        /// </summary>
        public static readonly bool ShowRazorPay = true; 
        /// <summary>
        /// Currencies : https://razorpay.com/accept-international-payments
        /// </summary>
        public static readonly string RazorPayCurrency = "INR"; 

        public static readonly bool ShowAuthorizeNet = true; 
        public static readonly bool ShowSecurionPay = true; 
        public static readonly bool ShowIyziPay = true; 
        public static readonly bool ShowPayStack = true; 
        public static readonly bool ShowAamarPay = true;

        /// <summary>
        /// FlutterWave get Api Keys From https://app.flutterwave.com/dashboard/settings/apis/live
        /// </summary>
        public static readonly bool ShowFlutterWave = true;//#New 
        public static readonly string FlutterWaveCurrency = "NGN";//#New 
        public static readonly string FlutterWavePublicKey = "FLWPUBK_TEST-9c877b3110438191127e631c8*****";//#New 
        public static readonly string FlutterWaveEncryptionKey = "FLWSECK_TEST298f1****";//#New 

        //*********************************************************

        //Settings Page >>  
        //********************************************************* 
        public static readonly bool ShowSettingsAccount = true;  
        public static readonly bool ShowSettingsSocialLinks = true; 
        public static readonly bool ShowSettingsPassword = true; 
        public static readonly bool ShowSettingsBlockedUsers = true; 
        public static readonly bool ShowSettingsDeleteAccount = true; 
        public static readonly bool ShowSettingsTwoFactor = true; 
        public static readonly bool ShowSettingsManageSessions = true;  
        public static readonly bool ShowSettingsWithdrawals = true;  
        public static readonly bool ShowSettingsMyAffiliates = true;  
        public static readonly bool ShowSettingsTransactions = true;  
         
        /// <summary>
        /// if you want this feature enabled go to Properties -> AndroidManefist.xml and remove comments from below code
        /// <uses-permission android:name="android.permission.READ_CONTACTS" />
        /// <uses-permission android:name="android.permission.READ_PHONE_NUMBERS" />
        /// </summary>
        public static readonly bool InvitationSystem = true;
        /// <summary>
        /// If want to have limit on messages then set this variable as 'true'
        /// If you set the limit on messages then non pro user will able to send only 5 messages
        /// </summary>
        public static readonly bool ShouldHaveLimitOnMessages = false; 
        public static int MaxMessageLimitForNonProUser = 5;
        //********************************************************* 

        public static readonly bool ShowSettingsRateApp = true; 
        public static readonly int ShowRateAppCount = 5; 

        public static readonly bool ShowSettingsUpdateManagerApp = false; 
         
        public static readonly bool OpenVideoFromApp = true; 
        public static readonly bool OpenImageFromApp = true;

        /// <summary>
        /// true => Only over 18 years old
        /// false => all 
        /// </summary>
        public static readonly bool IsUserYearsOld = true;
         
        //********************************************************* 
        public static readonly bool ShowLive = true;  
        public static readonly string AppIdAgoraLive = "619ee4ec26334d2dae20e52d1abbb32e";
        //*********************************************************
    }
} 