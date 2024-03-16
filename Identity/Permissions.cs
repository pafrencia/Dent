namespace Dent.Identity
{
    public static class Permissions
    {
        public static class PaymentOrders
        {
            public static PermissionTuple Create => new(1, "Permissions.PaymentOrders.Create");
            public static PermissionTuple View => new(2, "Permissions.PaymentOrders.View");
            public static PermissionTuple Edit => new(3, "Permissions.PaymentOrders.Edit");
            public static PermissionTuple Delete => new(4, "Permissions.PaymentOrders.Delete");
            public static PermissionTuple Pay => new(111, "Permissions.PaymentOrders.Pay");
            public static PermissionTuple Void => new(112, "Permissions.PaymentOrders.Void");
            public static PermissionTuple AddExtraAmount => new(177, "Permissions.PaymentOrders.AddExtraAmount");
        }
        public static class Trackings
        {
            public static PermissionTuple AddBookings => new(163, "Permissions.Trackings.AddBookings");
            public static PermissionTuple Cancel => new(160, "Permissions.Trackings.Cancel");
            public static PermissionTuple Confirm => new(162, "Permissions.Trackings.Confirm");
            public static PermissionTuple Create => new(158, "Permissions.Trackings.Create");
            public static PermissionTuple Delete => new(159, "Permissions.Trackings.Delete");
            public static PermissionTuple Edit => new(161, "Permissions.Trackings.Edit");
            public static PermissionTuple RemoveBookings => new(164, "Permissions.Trackings.RemoveBookings");
            public static PermissionTuple View => new(157, "Permissions.Trackings.View");
        }
        public static class BillingOrders
        {
            public static PermissionTuple Create => new(5, "Permissions.BillingOrders.Create");
            public static PermissionTuple View => new(6, "Permissions.BillingOrders.View");
            public static PermissionTuple Edit => new(7, "Permissions.BillingOrders.Edit");
            public static PermissionTuple Delete => new(8, "Permissions.BillingOrders.Delete");
        }
        public static class Users
        {
            public static PermissionTuple Create => new(9, "Permissions.Users.Create");
            public static PermissionTuple View => new(10, "Permissions.Users.View");
            public static PermissionTuple Edit => new(11, "Permissions.Users.Edit");
            public static PermissionTuple Delete => new(12, "Permissions.Users.Delete");
            public static PermissionTuple CreateAgent => new(65, "Permissions.Users.CreateAgent");
            public static PermissionTuple ViewAgent => new(66, "Permissions.Users.ViewAgent");
            public static PermissionTuple EditAgent => new(68, "Permissions.Users.EditAgent");
            public static PermissionTuple DeleteAgent => new(69, "Permissions.Users.DeleteAgent");
        }

        public static class Roles
        {
            public static PermissionTuple Create => new(13, "Permissions.Roles.Create");
            public static PermissionTuple View => new(14, "Permissions.Roles.View");
            public static PermissionTuple Edit => new(15, "Permissions.Roles.Edit");
            public static PermissionTuple Delete => new(16, "Permissions.Roles.Delete");
        }
        public static class Sellers
        {
            public static PermissionTuple View => new(166, "Permissions.Sellers.View");
            public static PermissionTuple ViewStats => new(167, "Permissions.Sellers.ViewStats");
        }

        public static class Issues
        {
            public static PermissionTuple Create => new(17, "Permissions.Issues.Create");
            public static PermissionTuple View => new(18, "Permissions.Issues.View");
            public static PermissionTuple Edit => new(19, "Permissions.Issues.Edit");
            public static PermissionTuple Delete => new(20, "Permissions.Issues.Delete");
            public static PermissionTuple ViewOwn => new(70, "Permissions.Issues.ViewOwn");
            public static PermissionTuple EditOwn => new(71, "Permissions.Issues.EditOwn");
        }

        public static class Providers
        {
            public static PermissionTuple Create => new(21, "Permissions.Providers.Create");
            public static PermissionTuple View => new(22, "Permissions.Providers.View");
            public static PermissionTuple Edit => new(23, "Permissions.Providers.Edit");
            public static PermissionTuple Delete => new(24, "Permissions.Providers.Delete");
            public static PermissionTuple ViewStatics => new(95, "Permissions.Providers.ViewStatics");
        }
        public static class ProvidersEbooking
        {
            public static PermissionTuple Create => new(198, "Permissions.ProvidersEbooking.Create");
            public static PermissionTuple View => new(199, "Permissions.ProvidersEbooking.View");
            public static PermissionTuple Edit => new(200, "Permissions.ProvidersEbooking.Edit");
            public static PermissionTuple Delete => new(201, "Permissions.ProvidersEbooking.Delete");
        }

        public static class Clients
        {
            public static PermissionTuple Create => new(25, "Permissions.Clients.Create");
            public static PermissionTuple View => new(26, "Permissions.Clients.View");
            public static PermissionTuple Edit => new(27, "Permissions.Clients.Edit");
            public static PermissionTuple Delete => new(28, "Permissions.Clients.Delete");
            public static PermissionTuple ViewStatics => new(93, "Permissions.Clients.ViewStatics");
        }

        public static class Reports
        {
            public static PermissionTuple Account => new(195, "Permissions.Reports.Account");
            public static PermissionTuple AdvancedView => new(191, "Permissions.Reports.AdvancedView");
            public static PermissionTuple Clients => new(192, "Permissions.Reports.Clients");
            public static PermissionTuple Providers => new(193, "Permissions.Reports.Providers");
            public static PermissionTuple Sellers => new(194, "Permissions.Reports.Sellers");
            public static PermissionTuple View => new(190, "Permissions.Reports.View");
        }

        public static class Division
        {
            public static PermissionTuple Admin => new(179, "Permissions.Division.Admin");
            public static PermissionTuple CEO => new(171, "Permissions.Division.CEO");
            public static PermissionTuple ClientsAdmin => new(212, "Permissions.Division.ClientsAdmin");
            public static PermissionTuple ClientsSellers => new(211, "Permissions.Division.ClientsSellers");
            public static PermissionTuple CTO => new(172, "Permissions.Division.CTO");
            public static PermissionTuple Developers => new(169, "Permissions.Division.Developers");
            public static PermissionTuple Payments => new(170, "Permissions.Division.Payments");
            public static PermissionTuple Quality => new(173, "Permissions.Division.Quality");
            public static PermissionTuple Sellers => new(168, "Permissions.Division.Sellers");
            public static PermissionTuple Support => new(174, "Permissions.Division.Support");
        }

        public static class Cards
        {
            public static PermissionTuple Create => new(29, "Permissions.Cards.Create");
            public static PermissionTuple View => new(30, "Permissions.Cards.View");
            public static PermissionTuple Edit => new(31, "Permissions.Cards.Edit");
            public static PermissionTuple Delete => new(32, "Permissions.Cards.Delete");
            public static PermissionTuple ViewOwn => new(72, "Permissions.Cards.ViewOwn");
            public static PermissionTuple EditOwn => new(73, "Permissions.Cards.EditOwn");
        }

        public static class Banks
        {
            public static PermissionTuple Create => new(33, "Permissions.Banks.Create");
            public static PermissionTuple View => new(34, "Permissions.Banks.View");
            public static PermissionTuple Edit => new(35, "Permissions.Banks.Edit");
            public static PermissionTuple Delete => new(36, "Permissions.Banks.Delete");
        }
        public static class Posts
        {
            public static PermissionTuple Create => new(181, "Permissions.Posts.Create");
            public static PermissionTuple View => new(180, "Permissions.Posts.View");
            public static PermissionTuple Edit => new(183, "Permissions.Posts.Edit");
            public static PermissionTuple Delete => new(182, "Permissions.Posts.Delete");
        }
        public static class BookingIncidences
        {
            public static PermissionTuple Create => new(131, "Permissions.BookingIncidences.Create");
            public static PermissionTuple Edit => new(130, "Permissions.BookingIncidences.Edit");
            public static PermissionTuple View => new(129, "Permissions.BookingIncidences.View");
        }

        public static class BankAccounts
        {
            public static PermissionTuple Create => new(37, "Permissions.BankAccounts.Create");
            public static PermissionTuple View => new(38, "Permissions.BankAccounts.View");
            public static PermissionTuple Edit => new(39, "Permissions.BankAccounts.Edit");
            public static PermissionTuple Delete => new(40, "Permissions.BankAccounts.Delete");
        }
        public static class PurchaseGroups
        {
            public static PermissionTuple View => new(165, "Permissions.PurchaseGroups.View");
        }
        public static class WhatsApp
        {
            public static PermissionTuple National => new(56, "Permissions.WhatsApp.National");
            public static PermissionTuple International => new(59, "Permissions.WhatsApp.International");
        }



        public static class Bookings
        {
            public static PermissionTuple Create => new(74, "Permissions.Bookings.Create");
            public static PermissionTuple View => new(75, "Permissions.Bookings.View");
            public static PermissionTuple Edit => new(76, "Permissions.Bookings.Edit");
            public static PermissionTuple Delete => new(77, "Permissions.Bookings.Delete");
            public static PermissionTuple Cancel => new(127, "Permissions.Bookings.Cancel");
            public static PermissionTuple ViewClient => new(79, "Permissions.Bookings.ViewClient");
            public static PermissionTuple EditClient => new(80, "Permissions.Bookings.EditClient");
            public static PermissionTuple CancelClient => new(81, "Permissions.Bookings.CancelClient");
            public static PermissionTuple ViewOwn => new(82, "Permissions.Bookings.ViewOwn");
            public static PermissionTuple EditOwn => new(84, "Permissions.Bookings.EditOwn");
            public static PermissionTuple CancelOwn => new(85, "Permissions.Bookings.CancelOwn");
            public static PermissionTuple AdvancedEdit => new(140, "Permissions.Bookings.AdvancedEdit");
            public static PermissionTuple AdvancedView => new(150, "Permissions.Bookings.AdvancedView");
            public static PermissionTuple AutoCancel => new(135, "Permissions.Bookings.AutoCancel");
            public static PermissionTuple CanSellBookings => new(178, "Permissions.Bookings.CanSellBookings");
            public static PermissionTuple ChangeCheckedStatus => new(148, "Permissions.Bookings.ChangeCheckedStatus");
            public static PermissionTuple ChangeCommission => new(132, "Permissions.Bookings.ChangeCommission");
            public static PermissionTuple ChangeNonUpdateable => new(147, "Permissions.Bookings.ChangeNonUpdateable");
            public static PermissionTuple Check => new(134, "Permissions.Bookings.Check");
            public static PermissionTuple CompareProperties => new(128, "Permissions.Bookings.CompareProperties");
            public static PermissionTuple CreateVouchers => new(189, "Permissions.Bookings.CreateVouchers");
            public static PermissionTuple DownloadProviderVoucher => new(139, "Permissions.Bookings.DownloadProviderVoucher");
            public static PermissionTuple EditCancellationCosts => new(156, "Permissions.Bookings.EditCancellationCosts");
            public static PermissionTuple EditCost => new(143, "Permissions.Bookings.EditCost");
            public static PermissionTuple EditDNIPax => new(149, "Permissions.Bookings.EditDNIPax");
            public static PermissionTuple EditPassengers => new(185, "Permissions.Bookings.EditPassengers");
            public static PermissionTuple EditPayment => new(188, "Permissions.Bookings.EditPayment");
            public static PermissionTuple EditPurchaseGroupId => new(151, "Permissions.Bookings.EditPurchaseGroupId");
            public static PermissionTuple EditSeller => new(154, "Permissions.Bookings.EditSeller");
            public static PermissionTuple EditUserAgency => new(146, "Permissions.Bookings.EditUserAgency");
            public static PermissionTuple PaymentRequest => new(187, "Permissions.Bookings.PaymentRequest");
            public static PermissionTuple SellNonRef => new(196, "Permissions.Bookings.SellNonRef");
            public static PermissionTuple SendEmail => new(133, "Permissions.Bookings.SendEmail");
            public static PermissionTuple StatusEdit => new(186, "Permissions.Bookings.StatusEdit");
            public static PermissionTuple Update => new(136, "Permissions.Bookings.Update");
            public static PermissionTuple ViewAvail => new(138, "Permissions.Bookings.ViewAvail");
            public static PermissionTuple ViewCancellationCosts => new(155, "Permissions.Bookings.ViewCancellationCosts");
            public static PermissionTuple ViewCancellationInfo => new(125, "Permissions.Bookings.ViewCancellationInfo");
            public static PermissionTuple ViewCost => new(142, "Permissions.Bookings.ViewCost");
            public static PermissionTuple ViewGrossProfit => new(145, "Permissions.Bookings.ViewGrossProfit");
            public static PermissionTuple ViewHistory => new(137, "Permissions.Bookings.ViewHistory");
            public static PermissionTuple ViewIncidences => new(184, "Permissions.Bookings.ViewIncidences");
            public static PermissionTuple ViewIndirectSale => new(152, "Permissions.Bookings.ViewIndirectSale");
            public static PermissionTuple ViewOptimizedCost => new(144, "Permissions.Bookings.ViewOptimizedCost");
            public static PermissionTuple ViewPaymentInfo => new(126, "Permissions.Bookings.ViewPaymentInfo");
        }

        public class Budgets
        {
            public static PermissionTuple Create => new(117, "Permissions.Budgets.Create");
            public static PermissionTuple View => new(116, "Permissions.Budgets.View");
            public static PermissionTuple Edit => new(118, "Permissions.Budgets.Edit");
            public static PermissionTuple Delete => new(119, "Permissions.Budgets.Delete");
            public static PermissionTuple ViewOwn => new(121, "Permissions.Budgets.ViewOwn");
            public static PermissionTuple EditOwn => new(120, "Permissions.Budgets.EditOwn");
            public static PermissionTuple DeleteOwn => new(122, "Permissions.Budgets.DeleteOwn");
        }

        public class RolesPermissions
        {
            public static PermissionTuple Create => new(86, "Permissions.RolesPermissions.Create");
            public static PermissionTuple View => new(87, "Permissions.RolesPermissions.View");
            public static PermissionTuple Edit => new(88, "Permissions.RolesPermissions.Edit");
            public static PermissionTuple Delete => new(89, "Permissions.RolesPermissions.Delete");
        }

        public class SantaCatalina
        {
            public static PermissionTuple View => new(92, "Permissions.SantaCatalina.View");
        }


        public class Help
        {
            public static PermissionTuple Create => new(96, "Permissions.Help.Create");
            public static PermissionTuple Edit => new(98, "Permissions.Help.Edit");
            public static PermissionTuple Delete => new(99, "Permissions.Help.Delete");
            public static PermissionTuple ViewAdmin => new(197, "Permissions.Help.ViewAdmin");
        }

        public class Invoice
        {
            public static PermissionTuple Create => new(202, "Permissions.Invoice.Create");
            public static PermissionTuple Edit => new(204, "Permissions.Invoice.Edit");
            public static PermissionTuple Delete => new(205, "Permissions.Invoice.Delete");
            public static PermissionTuple View => new(203, "Permissions.Invoice.View");
        }
        public class MyBookings
        {
            public static PermissionTuple Cancel => new(208, "Permissions.MyBookings.Cancel");
            public static PermissionTuple Edit => new(207, "Permissions.MyBookings.Edit");
            public static PermissionTuple View => new(206, "Permissions.MyBookings.View");
        }
        public class Authentication
        {
            public static PermissionTuple Token => new(223, "Permissions.Authentication.Token");
        }
        public class News
        {
            public static PermissionTuple Create => new(100, "Permissions.News.Create");
            public static PermissionTuple Edit => new(101, "Permissions.News.Edit");
            public static PermissionTuple Delete => new(102, "Permissions.News.Delete");
        }

        public class Checks
        {
            public static PermissionTuple Create => new(107, "Permissions.Checks.Create");
            public static PermissionTuple Edit => new(108, "Permissions.Checks.Edit");
            public static PermissionTuple Delete => new(109, "Permissions.Checks.Delete");
            public static PermissionTuple View => new(110, "Permissions.Checks.View");
        }

        public class Vouchers
        {
            public static PermissionTuple BasicEdit => new(113, "Permissions.Vouchers.BasicEdit");
            public static PermissionTuple FullEdit => new(209, "Permissions.Vouchers.FullEdit");
            public static PermissionTuple Sync => new(141, "Permissions.Vouchers.Sync");


        }
    }
    public class PermissionTuple
    {
        public PermissionTuple(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
