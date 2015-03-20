
using SilentAuction.Properties;

namespace SilentAuction.Utilities
{
    public class DatabaseScripts
    {
        // Database strings
        public static string DatabaseConnectionString = Settings.Default.SilentAuctionConnectionString;   // ConfigurationManager.ConnectionStrings["SilentAuctionDb"].ConnectionString;  //"Data Source=SilentAuction.sqlite;Version=3;";
        public static string DatabaseName = Settings.Default.SilentAuctionDatabaseName;  //ConfigurationManager.AppSettings["SilentAuctionDbName"];  // "SilentAuction.sqlite";

        // Table Names
        public static string AuctionsTableName = "Auctions";
        public static string AuctionDonorRequestStatusTableName = "AuctionDonorRequestStatus";
        public static string BidIncrementTypesTableName = "BidIncrementTypes";
        public static string DonationDeliveryTypesTableName = "DonationDeliveryTypes";
        public static string DonorsTableName = "Donors";
        public static string DonorTypesTableName = "DonorTypes";
        public static string ItemsTableName = "Items";
        public static string ItemTypesTableName = "ItemTypes";
        public static string RequestFormatTypesTableName = "RequestFormatTypes";
        public static string RequestStatusTypesTableName = "RequestStatusTypes";


        // Table Create Scripts
        public static string AuctionDonorRequestStatusTableCreateSql = string.Format(@"CREATE TABLE [{0}](
                                                                   [Id] [integer] PRIMARY KEY AUTOINCREMENT NOT NULL,
                                                                   [AuctionId] [integer] NOT NULL,
                                                                   [DonorId] [integer] NOT NULL,
                                                                   [RequestStatusId] [integer] NOT NULL)", AuctionDonorRequestStatusTableName);

        public static string AuctionsTableCreateSql = string.Format(@"CREATE TABLE [{0}](
                                                                   [Id] [integer] PRIMARY KEY AUTOINCREMENT NOT NULL,
                                                                   [Name] [nvarchar](200) NOT NULL,
                                                                   [Description] [nvarchar](5000) NULL,
                                                                   [CreateDate] [text] NOT NULL,
                	                                               [ModifiedDate] [text] NOT NULL)", AuctionsTableName);
        
        public static string BidIncrementTypesCreateSql = string.Format(@"CREATE TABLE [{0}](
                                                                   [Id] [integer] PRIMARY KEY AUTOINCREMENT NOT NULL,
                	                                               [Name] [nvarchar](200) NOT NULL,
                                                                   [Description] [nvarchar](5000) NOT NULL)", BidIncrementTypesTableName);

        public static string DonationDeliveryTypesCreateSql = string.Format(@"CREATE TABLE [{0}](
                                                                   [Id] [integer] PRIMARY KEY AUTOINCREMENT NOT NULL,
                                                                   [Name] [nvarchar](200) NOT NULL,
                                                                   [Description] [nvarchar](5000) NOT NULL)", DonationDeliveryTypesTableName);
        
        public static string DonorsTableCreateSql = string.Format(@"CREATE TABLE [{0}](
                	                                        [Id] [integer] PRIMARY KEY AUTOINCREMENT NOT NULL,
                                                            [DonorTypeId] [integer] NOT NULL,
                	                                        [Name] [nvarchar](200) NOT NULL,
                                                            [RequestFormatTypeId] [integer] NULL,
                	                                        [ContactName] [nvarchar](200) NULL,
                	                                        [Email] [nvarchar](100) NULL,
                	                                        [Url] [nvarchar](5000) NULL,
                	                                        [Street1] [nvarchar](100) NULL,
                	                                        [Street2] [nvarchar](100) NULL,
                	                                        [City] [nvarchar](100) NULL,
                	                                        [State] [nvarchar](2) NULL,
                	                                        [ZipCode] [nvarchar](10) NULL,
                	                                        [Phone1] [nvarchar](12) NULL,
                	                                        [Extension1] [nvarchar](10) NULL,
                	                                        [Phone2] [nvarchar](12) NULL,
                	                                        [Extension2] [nvarchar](10) NULL,
                	                                        [CreateDate] [text] NOT NULL,
                	                                        [ModifiedDate] [text] NOT NULL)", DonorsTableName);
        
        public static string DonorTypesTableCreateSql = string.Format(@"CREATE TABLE [{0}](
                                                                      [Id] [integer] PRIMARY KEY AUTOINCREMENT NOT NULL,
                                                                      [Name] [nvarchar](200) NOT NULL)", DonorTypesTableName);
        
        public static string ItemsTableCreateSql = string.Format(@"CREATE TABLE [{0}](
                                                                  [Id] [integer] PRIMARY KEY AUTOINCREMENT NOT NULL,
                                                                  [DonorId] [integer] NOT NULL,
                                                                  [AuctionId] [integer] NOT NULL,
                                                                  [Name] [nvarchar](200) NOT NULL,
                                                                  [Description] [nvarchar](5000) NULL,
                                                                  [Qty] [integer] NOT NULL,
                                                                  [ItemTypeId] [integer] NULL,
                                                                  [DonationDeliveryTypeId] [integer] NULL,
                                                                  [RetailValue] [real] NULL,
                                                                  [BidIncrementTypeId] [integer] NOT NULL,
                                                                  [BidMinValue] [real] NULL,
                                                                  [BidMaxValue] [real] NULL,
                                                                  [BidIncrementValue] [real] NULL,
                                                                  [BidBuyItNowValue] [real] NULL,
                                                                  [BidNumberOfBids] [real] NULL,
                                                                  [Notes]  [nvarchar](5000) NULL,
                	                                              [CreateDate] [text] NOT NULL,
                	                                              [ModifiedDate] [text] NOT NULL)", ItemsTableName);
        
        public static string ItemTypesTableCreateSql = string.Format(@"CREATE TABLE [{0}](
                                                                      [Id] [integer] PRIMARY KEY AUTOINCREMENT NOT NULL,
                                                                      [Name] [nvarchar](200) NOT NULL)", ItemTypesTableName);
        
        public static string RequestFormatTypesCreateSql = string.Format(@"CREATE TABLE [{0}](
                                                                   [Id] [integer] PRIMARY KEY AUTOINCREMENT NOT NULL,
                                                                   [Name] [nvarchar](200) NOT NULL)", RequestFormatTypesTableName);
        
        public static string RequestStatusTypesCreateSql = string.Format(@"CREATE TABLE [{0}](
                                                                   [Id] [integer] PRIMARY KEY AUTOINCREMENT NOT NULL,
                                                                   [Name] [nvarchar](200) NOT NULL,
                                                                   [Description] [nvarchar](5000) NOT NULL)", RequestStatusTypesTableName);


        // Preload Data Scripts
        public static string BidIncrementTypesPreload =
            string.Format(@"INSERT INTO {0} (Name, Description) VALUES ('Increment Value', 'Increments based on the Increment Value');
                            INSERT INTO {0} (Name, Description) VALUES ('Increment Number', 'Increments based on the Number of Bids');"
            , BidIncrementTypesTableName);

        public static string DonationDeliveryTypesPreload =
            string.Format(@"INSERT INTO {0} (Name, Description) VALUES ('Delivery', 'Item will be delivered by Donor');
                            INSERT INTO {0} (Name, Description) VALUES ('Pick-Up', 'Item is to be picked up');
                            INSERT INTO {0} (Name, Description) VALUES ('Gift Certificate', 'Item produced by Donor is enclosed');
                            INSERT INTO {0} (Name, Description) VALUES ('Needs Certificate', 'Item is to be produced by Auction Committee');"
            , DonationDeliveryTypesTableName);

        public static string DonorTypesPreload =
            string.Format(@"INSERT INTO {0} (Name) VALUES ('Business');
                            INSERT INTO {0} (Name) VALUES ('Individual');
                            INSERT INTO {0} (Name) VALUES ('Teacher');"
            , DonorTypesTableName);

        public static string ItemTypesPreload =
            string.Format(@"INSERT INTO {0} (Name) VALUES ('Certificate');
                            INSERT INTO {0} (Name) VALUES ('Physical Item');"
            , ItemTypesTableName);

        public static string RequestFormatTypesPreload =
            string.Format(@"INSERT INTO {0} (Name) VALUES ('Email');
                            INSERT INTO {0} (Name) VALUES ('Letter');
                            INSERT INTO {0} (Name) VALUES ('Phone');
                            INSERT INTO {0} (Name) VALUES ('Website');"
            , RequestFormatTypesTableName);

        public static string RequestStatusTypesPreload =
            string.Format(@"INSERT INTO {0} (Name, Description) VALUES ('No Response', 'A response has not yet been received');
                            INSERT INTO {0} (Name, Description) VALUES ('Declined', 'Donor has declined to participate');
                            INSERT INTO {0} (Name, Description) VALUES ('Approval Pending', 'Request has been received.  If approved, an item will be donated.');
                            INSERT INTO {0} (Name, Description) VALUES ('Approved', 'Request has been approved.  Item has not yet been received.');
                            INSERT INTO {0} (Name, Description) VALUES ('Received', 'Item has been received.');"
            , RequestStatusTypesTableName);
    }
}
