using System.Collections.Generic;
using SilentAuction.Core.Entities;

namespace SilentAuction.Core.Abstract
{
    public interface IDonorTypeRepository
    {
        /// <summary>
        /// Returns all of the DonorTypes in the database
        /// </summary>
        /// <returns>A list of DonorType objects</returns>
        List<DonorType> GetDonorTypes();

        /// <summary>
        /// Returns a single DonorType in the database
        /// </summary>
        /// <param name="id">The unique ID of the donor type</param>
        /// <returns>The DonorType object; or null if not found</returns>
        DonorType GetDonorType(int id);

        /// <summary>
        /// Returns a single DonorType in the database
        /// </summary>
        /// <param name="name">The unique name of the donor type</param>
        /// <returns>The DonorType object (first match); or null if not found</returns>
        DonorType GetDonorType(string name);
    }
}
