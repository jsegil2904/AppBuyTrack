using App.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Interfaces
{
    public interface ITrackRepository : IGenericRepository<Track>
    {
        IEnumerable<Track> GetTracksByName(string name);
    }
}
