using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SilentAuction.Core.Entities;

namespace SilentAuction.Core.Abstract
{
    public interface IItemRepository
    {
        /// <summary>
        /// Add a new Item to the database
        /// </summary>
        /// <param name="item">The item to add</param>
        /// <returns>true if succesfully added, false otherwise</returns>
        bool Add(Item item);

        /// <summary>
        /// Updates an Item in the database
        /// </summary>
        /// <param name="item">The Item object to update in the database</param>
        /// <returns>true if succesfully updated, false otherwise</returns>
        bool Update(Item item);

        /// <summary>
        /// Deletes an Item from the database
        /// </summary>
        /// <param name="item">The Item object to delete from the database</param>
        /// <returns>true if succesfully deleted, false otherwise</returns>
        bool Delete(Item item);

        /// <summary>
        /// Deletes an Item from the database
        /// </summary>
        /// <param name="id">The id of the Item to delete from the database</param>
        /// <returns>true if succesfully deleted, false otherwise</returns>
        bool Delete(int id);

        /// <summary>
        /// Returns all Items for a given Auction Id
        /// </summary>
        /// <param name="auctionId">The Auction Id to return the Items for</param>
        /// <returns>A list of Items for the given Auction Id</returns>
        List<Item> GetItems(int auctionId);

        /// <summary>
        /// Returns a single Item in the database
        /// </summary>
        /// <param name="id">The unique ID of the Item</param>
        /// <returns>The Item object; or null if not found</returns>
        Item GetItem(int id);
    }
}
