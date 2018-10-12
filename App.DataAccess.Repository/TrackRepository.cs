using App.DataAccess.Interfaces;
using App.Entities.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Repository
{
    public class TrackRepository :
        GenericRepository<Track>, ITrackRepository
    {
        public TrackRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<Track> GetTracksByName(string name)
        {
            return ((AppModelDB)context).Track
                    .Where(item => item.Name.Contains(name)).ToList();
        }
    }
}
