using System.Collections.Generic;
using System.Linq;
using SilentAuction.Core.Entities;

namespace SilentAuction.Core.Abstract
{
    public interface IDonorRepository
    {
        IQueryable<Donor> Donors { get; }

        /// <summary>
        /// Adds a new Donor to the database
        /// </summary>
        /// <param name="donor">The Donor object to add to the database</param>
        /// <returns>true if succesfully added, false otherwise</returns>
        bool Add(Donor donor);

        /// <summary>
        /// Updates a Donor in the database
        /// </summary>
        /// <param name="donor">The Donor object to update in the database</param>
        /// <returns>true if succesfully updated, false otherwise</returns>
        bool Update(Donor donor);

        /// <summary>
        /// Deletes a Donor from the database
        /// </summary>
        /// <param name="donor">The Donor object to delete from the database</param>
        /// <returns>true if succesfully deleted, false otherwise</returns>
        bool Delete(Donor donor);

        /// <summary>
        /// Deletes a Donor from the database
        /// </summary>
        /// <param name="id">The id of the Donor to delete from the database</param>
        /// <returns>true if succesfully deleted, false otherwise</returns>
        bool Delete(int id);

        /// <summary>
        /// Returns all of the Donors in the database
        /// </summary>
        /// <returns>A list of Donor objects</returns>
        List<Donor> GetDonors();

        /// <summary>
        /// Returns a single Donor in the database
        /// </summary>
        /// <param name="id">The unique ID of the donor</param>
        /// <returns>The Donor object; or null if not found</returns>
        Donor GetDonor(int id);

        /// <summary>
        /// Returns a single Donor in the database
        /// </summary>
        /// <param name="name">The unique name of the donor</param>
        /// <returns>The Donor object (first match); or null if not found</returns>
        Donor GetDonor(string name);
    }
}
