using System.Configuration;

namespace SilentAuction.Utilities.General
{
    public class Constants
    {
        // Database strings
        public static string DatabaseConnectionString = "Data Source=SilentAuction.sqlite;Version=3;"; // ConfigurationManager.ConnectionStrings["SilentAuctionDb"].ConnectionString;
        public static string DatabaseName = "SilentAuction.sqlite"; // ConfigurationManager.AppSettings["SilentAuctionDbName"];

        // Table Names
        public static string DonorsTableName = "Donors";
        public static string DonorTypesTableName = "DonorTypes";
        public static string AuctionsTableName = "Auctions";
        public static string ItemsTableName = "Items";
        public static string BidIncrementTypesTableName = "BidIncrementTypes";

        // Table Create Scripts
        public static string DonorsTableCreateSql = string.Format(@"CREATE TABLE [{0}](
                	                                        [Id] [integer] PRIMARY KEY AUTOINCREMENT NOT NULL,
                                                            [DonorTypeId] [integer] NOT NULL,
                	                                        [Name] [nvarchar](200) NOT NULL,
                	                                        [ContactName] [nvarchar](200) NULL,
                	                                        [Street1] [nvarchar](100) NULL,
                	                                        [Street2] [nvarchar](100) NULL,
                	                                        [City] [nvarchar](100) NULL,
                	                                        [State] [nvarchar](2) NULL,
                	                                        [ZipCode] [nvarchar](10) NULL,
                	                                        [Phone1] [nvarchar](12) NULL,
                	                                        [Extension1] [nvarchar](10) NULL,
                	                                        [Phone2] [nvarchar](12) NULL,
                	                                        [Extension2] [nvarchar](10) NULL,
                	                                        [Email] [nvarchar](100) NULL,
                	                                        [CreateDate] [text] NOT NULL,
                	                                        [ModifiedDate] [text] NOT NULL)", DonorsTableName);
        public static string DonorTypesTableCreateSql = string.Format(@"CREATE TABLE [{0}](
                                                                      [Id] [integer] PRIMARY KEY AUTOINCREMENT NOT NULL,
                                                                      [Name] [nvarchar](200) NOT NULL)", DonorTypesTableName);
        public static string AuctionsTableCreateSql = string.Format(@"CREATE TABLE [{0}](
                                                                   [Id] [integer] PRIMARY KEY AUTOINCREMENT NOT NULL,
                                                                   [Name] [nvarchar](200) NOT NULL,
                                                                   [Description] [nvarchar](5000) NULL,
                                                                   [CreateDate] [text] NOT NULL,
                	                                               [ModifiedDate] [text] NOT NULL)", AuctionsTableName);
        public static string ItemsTableCreateSql = string.Format(@"CREATE TABLE [{0}](
                                                                  [Id] [integer] PRIMARY KEY AUTOINCREMENT NOT NULL,
                                                                  [DonorId] [integer] NOT NULL,
                                                                  [AuctionId] [integer] NOT NULL,
                                                                  [Name] [nvarchar](200) NOT NULL,
                                                                  [Description] [nvarchar](5000) NULL,
                                                                  [Qty] [integer] NOT NULL,
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
        public static string BidIncrementTypesCreateSql = string.Format(@"CREATE TABLE [{0}](
                                                                  [Id] [integer] PRIMARY KEY AUTOINCREMENT NOT NULL,
                	                                              [Name] [nvarchar](200) NOT NULL,
                                                                  [Description] [nvarchar](5000) NOT NULL)", BidIncrementTypesTableName);

        // Preload Data Scripts
        public static string DonorTypesPreload = @"INSERT INTO DonorTypes (Name) VALUES ('Business');
                                                   INSERT INTO DonorTypes (Name) VALUES ('Individual');
                                                   INSERT INTO DonorTypes (Name) VALUES ('Teacher');";
        public static string BidIncrementTypesPreload = @"INSERT INTO BidIncrementTypes (Name, Description) VALUES ('Increment Value', 'Increments based on the Increment Value');
                                                          INSERT INTO BidIncrementTypes (Name, Description) VALUES ('Increment Number', 'Increments based on the Number of Bids');";
    }
}
