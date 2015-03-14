using System.Collections.Generic;
using SilentAuction.Core.Entities;

namespace SilentAuction.Core.Abstract
{
    public interface IAuctionRepository
    {
        /// <summary>
        /// Add a new Auction to the database
        /// </summary>
        /// <param name="auction">The auction to add</param>
        /// <returns>true if succesfully added, false otherwise</returns>
        bool Add(Auction auction);

        /// <summary>
        /// Updates an Auction in the database
        /// </summary>
        /// <param name="auction">The Auction object to update in the database</param>
        /// <returns>true if succesfully updated, false otherwise</returns>
        bool Update(Auction auction);

        /// <summary>
        /// Deletes an Auction from the database
        /// </summary>
        /// <param name="auction">The Auction object to delete from the database</param>
        /// <returns>true if succesfully deleted, false otherwise</returns>
        bool Delete(Auction auction);

        /// <summary>
        /// Deletes an Auction from the database
        /// </summary>
        /// <param name="id">The id of the Auction to delete from the database</param>
        /// <returns>true if succesfully deleted, false otherwise</returns>
        bool Delete(int id);

        /// <summary>
        /// Returns all of the Auction in the database
        /// </summary>
        /// <returns>A list of Auction objects</returns>
        List<Auction> GetAuctions();

        /// <summary>
        /// Returns a single Auction in the database
        /// </summary>
        /// <param name="id">The unique ID of the Auction</param>
        /// <returns>The Auction object; or null if not found</returns>
        Auction GetAuction(int id);

        /// <summary>
        /// Returns a single Auction in the database
        /// </summary>
        /// <param name="name">The unique name of the AuctionEvent</param>
        /// <returns>The Auction object (first match); or null if not found</returns>
        Auction GetAuction(string name);

        /// <summary>
        /// Indicates if the name already exists in the database
        /// </summary>
        /// <param name="name">The name to check</param>
        /// <returns>true if name already exists, false otherwise</returns>
        bool AuctionNameExists(string name);
    }
}
