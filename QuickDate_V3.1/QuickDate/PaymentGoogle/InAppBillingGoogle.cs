using Android.BillingClient.Api;
using System.Collections.Generic;

namespace QuickDate.PaymentGoogle
{
    public static class InAppBillingGoogle 
    {
        public static readonly string ProductId = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAvgOCbgWuNYEXpx5SFItf3SWjJF28YPCWmgOIZ6KC+4QhZniEC2S/425RLkpcRjGBfJ1MfgFoWmDQDYrJ46n8qgIl/yA3O3gGnriQHx+sH6btgIV5oBt6Hgf80r910FIqjfEbx2bwIMxwm8iXAuaAUjbMUoOUUyxGk5vqK9M2lU/UgK+DmpHNpWcBEoweYhcBx5Kmu9VEo9dFT5xmKIDLCCK4NIy/hPC0ds0uHyv4hf0/4021lb94XhIFzVKDZny4t8sbewLQdbMn9b8VVxZj0PJcfdSI6fssGCqO9ePIa69Cr9gExC/JPhbzuMu42P7zdCjZRhiaZA81akHYhxvZGQIDAQAB";

        public const string BagOfCredits = "bag.of.credits";
        public const string BoxofCredits = "box.of.credits";
        public const string ChestofCredits = "chest.of.credits";
        public const string MembershipWeekly = "membershipweekly";
        public const string MembershipMonthly = "membershipmonthly";
        public const string MembershipYearly = "membershipyearly";
        public const string MembershipLifetime = "membership.lifetime";

        public static readonly List<QueryProductDetailsParams.Product> ListProductSku = new List<QueryProductDetailsParams.Product> // ID Product
        {
            //All products should be of the same product type.
            QueryProductDetailsParams.Product.NewBuilder().SetProductId(BagOfCredits).SetProductType(BillingClient.ProductType.Subs).Build(),
            QueryProductDetailsParams.Product.NewBuilder().SetProductId(BoxofCredits).SetProductType(BillingClient.ProductType.Subs).Build(),
            QueryProductDetailsParams.Product.NewBuilder().SetProductId(ChestofCredits).SetProductType(BillingClient.ProductType.Subs).Build(),
            QueryProductDetailsParams.Product.NewBuilder().SetProductId(MembershipWeekly).SetProductType(BillingClient.ProductType.Subs).Build(),
            QueryProductDetailsParams.Product.NewBuilder().SetProductId(MembershipMonthly).SetProductType(BillingClient.ProductType.Subs).Build(),
            QueryProductDetailsParams.Product.NewBuilder().SetProductId(MembershipYearly).SetProductType(BillingClient.ProductType.Subs).Build(),
            QueryProductDetailsParams.Product.NewBuilder().SetProductId(MembershipLifetime).SetProductType(BillingClient.ProductType.Subs).Build(),
        };
    }
} 