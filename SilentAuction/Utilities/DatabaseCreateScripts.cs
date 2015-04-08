using System.Collections.Generic;
using SilentAuction.Properties;

namespace SilentAuction.Utilities
{
    public class DatabaseCreateScripts
    {
        #region Properties
        // Database strings
        public static string DatabaseConnectionString
        {
            get
            {
                return Settings.Default.SilentAuctionConnectionString; // ConfigurationManager.ConnectionStrings["SilentAuctionDb"].ConnectionString;  //"Data Source=SilentAuction.sqlite;Version=3;";
            }
        }

        public static string DatabaseName
        {
            get
            {
                return Settings.Default.SilentAuctionDatabaseName; //ConfigurationManager.AppSettings["SilentAuctionDbName"];  // "SilentAuction.sqlite";
            }
        }

        public List<string> TableCreateScripts { get; set; }
        public List<string> TablePreLoadScripts { get; set; } 

        #endregion
        
        #region Private Fields
        // Table Names
        private const string AuctionsTableName = "Auctions";
        private const string BidIncrementTypesTableName = "BidIncrementTypes";
        private const string DocumentsTableName = "Documents";
        private const string DonationDeliveryTypesTableName = "DonationDeliveryTypes";
        private const string DonorsTableName = "Donors";
        private const string DonorTypesTableName = "DonorTypes";
        private const string EmailAccountsTableName = "EmailAccounts";
        private const string ItemsTableName = "Items";
        private const string ItemTypesTableName = "ItemTypes";
        private const string RequestFormatTypesTableName = "RequestFormatTypes";
        private const string RequestStatusTypesTableName = "RequestStatusTypes";

        #endregion

        #region Constructor
        public DatabaseCreateScripts()
        {
            FillTableCreateScripts();
            FillTablePreLoadScripts();
        }
        #endregion

        #region Private Methods
        private void FillTableCreateScripts()
        {
            TableCreateScripts = new List<string>();
            TableCreateScripts.Add(string.Format(@"CREATE TABLE [{0}](
                                                [Id] [integer] PRIMARY KEY AUTOINCREMENT NOT NULL,
                                                [Name] [nvarchar](200) NOT NULL,
                                                [Description] [nvarchar](5000) NULL,
                                                [CreateDate] [text] NOT NULL,
                	                            [ModifiedDate] [text] NOT NULL)", AuctionsTableName));

            TableCreateScripts.Add(string.Format(@"CREATE TABLE [{0}](
                                                [Id] [integer] PRIMARY KEY AUTOINCREMENT NOT NULL,
                	                            [Name] [nvarchar](200) NOT NULL,
                                                [Description] [nvarchar](5000) NOT NULL)", BidIncrementTypesTableName));

            TableCreateScripts.Add(string.Format(@"CREATE TABLE [{0}](
                                                [Id] [integer] PRIMARY KEY AUTOINCREMENT NOT NULL,
                                                [AuctionId] [integer] NOT NULL,
                                                [Name] [nvarchar](200) NOT NULL,
                                                [Document] [text] NOT NULL)", DocumentsTableName));

            TableCreateScripts.Add(string.Format(@"CREATE TABLE [{0}](
                                                [Id] [integer] PRIMARY KEY AUTOINCREMENT NOT NULL,
                                                [Name] [nvarchar](200) NOT NULL,
                                                [Description] [nvarchar](5000) NOT NULL)",DonationDeliveryTypesTableName));

            TableCreateScripts.Add(string.Format(@"CREATE TABLE [{0}](
                                                [Id] [integer] PRIMARY KEY AUTOINCREMENT NOT NULL,
                                                [Name] [nvarchar](200) NOT NULL,
                                                [Description] [nvarchar](5000) NOT NULL)", DonorTypesTableName));

            TableCreateScripts.Add(string.Format(@"CREATE TABLE [{0}](
                                                [Id] [integer] PRIMARY KEY AUTOINCREMENT NOT NULL,
                                                [Account] [nvarchar](200) NOT NULL,
                                                [Password] [nvarchar](200) NOT NULL)", EmailAccountsTableName));

            TableCreateScripts.Add(string.Format(@"CREATE TABLE [{0}](
                	                            [Id] [integer] PRIMARY KEY AUTOINCREMENT NOT NULL,
                                                [AuctionId] [integer] NOT NULL,
                                                [DonorTypeId] [integer] NOT NULL,
                	                            [Name] [nvarchar](200) NOT NULL,
                                                [RequestFormatTypeId] [integer] NULL,
                                                [RequestStatusTypeId] [integer] NULL,
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
                	                            [ModifiedDate] [text] NOT NULL)", DonorsTableName));

            TableCreateScripts.Add(string.Format(@"CREATE TABLE [{0}](
                                                [Id] [integer] PRIMARY KEY AUTOINCREMENT NOT NULL,
                                                [Name] [nvarchar](200) NOT NULL,
                                                [Description] [nvarchar](5000) NOT NULL)", ItemTypesTableName));

            TableCreateScripts.Add(string.Format(@"CREATE TABLE [{0}](
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
                                                [Image] [blob] NULL,
                	                            [CreateDate] [text] NOT NULL,
                	                            [ModifiedDate] [text] NOT NULL)", ItemsTableName));

            TableCreateScripts.Add(string.Format(@"CREATE TABLE [{0}](
                                                [Id] [integer] PRIMARY KEY AUTOINCREMENT NOT NULL,
                                                [Name] [nvarchar](200) NOT NULL,
                                                [Description] [nvarchar](5000) NOT NULL)", RequestFormatTypesTableName));

            TableCreateScripts.Add(string.Format(@"CREATE TABLE [{0}](
                                                [Id] [integer] PRIMARY KEY AUTOINCREMENT NOT NULL,
                                                [Name] [nvarchar](200) NOT NULL,
                                                [Description] [nvarchar](5000) NOT NULL)", RequestStatusTypesTableName));
        }

        private void FillTablePreLoadScripts()
        {
            TablePreLoadScripts = new List<string>();
            TablePreLoadScripts.Add(string.Format(
                @"INSERT INTO {0} (Name, Description) VALUES ('Increment Value', 'Increments based on the Increment Value');
                    INSERT INTO {0} (Name, Description) VALUES ('Increment Number', 'Increments based on the Number of Bids');"
                , BidIncrementTypesTableName));

            TablePreLoadScripts.Add(string.Format(
                @"INSERT INTO {0} (Name, Description) VALUES ('Delivery', 'Item will be delivered by Donor');
                            INSERT INTO {0} (Name, Description) VALUES ('Pick-Up', 'Item is to be picked up');
                            INSERT INTO {0} (Name, Description) VALUES ('Gift Certificate', 'Item produced by Donor is enclosed');
                            INSERT INTO {0} (Name, Description) VALUES ('Needs Certificate', 'Item is to be produced by Auction Committee');"
                , DonationDeliveryTypesTableName));

            TablePreLoadScripts.Add(
                string.Format(@"INSERT INTO {0} (Name, Description) VALUES ('Business', 'Donor is a business');
                            INSERT INTO {0} (Name, Description) VALUES ('Individual', 'Donor is an individual');
                            INSERT INTO {0} (Name, Description) VALUES ('Teacher', 'Donor is a teacher');"
                    , DonorTypesTableName));

            TablePreLoadScripts.Add(string.Format(
                @"INSERT INTO {0} (Name, Description) VALUES ('Certificate', 'Item is a certificate, gift card, etc.');
                            INSERT INTO {0} (Name, Description) VALUES ('Physical Item', 'Item is a physical item');"
                , ItemTypesTableName));

            TablePreLoadScripts.Add(
                string.Format(@"INSERT INTO {0} (Name, Description) VALUES ('Email', 'Contact Donor via email');
                            INSERT INTO {0} (Name, Description) VALUES ('Letter', 'Contact Donor via letter');
                            INSERT INTO {0} (Name, Description) VALUES ('Phone', 'Contact Donor via phone');
                            INSERT INTO {0} (Name, Description) VALUES ('Website', 'Contact Donor via website');"
                    , RequestFormatTypesTableName));

            TablePreLoadScripts.Add(string.Format(
                @"INSERT INTO {0} (Name, Description) VALUES ('No Response', 'A response has not yet been received');
                            INSERT INTO {0} (Name, Description) VALUES ('Declined', 'Donor has declined to participate');
                            INSERT INTO {0} (Name, Description) VALUES ('Approval Pending', 'Request has been received.  If approved, an item will be donated.');
                            INSERT INTO {0} (Name, Description) VALUES ('Approved', 'Request has been approved.  Item has not yet been received.');
                            INSERT INTO {0} (Name, Description) VALUES ('Received', 'Item has been received.');"
                , RequestStatusTypesTableName));
        }
        #endregion
    }
}
