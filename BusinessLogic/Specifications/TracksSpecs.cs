using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Specification;

using BusinessLogic.Entities;

namespace BusinessLogic.Specifications
{
    internal class TracksSpecs
    {
        internal class ById : Specification<Track>
        {
            public ById(int id) 
            {
                Query.Where(x => x.Id == id)
                    .Include(x => x.Album);
            }
        }

        internal class All : Specification<Track>
        {
            public All()
            {
                Query.Include(x => x.Album);
            }
        }
        internal class ByIds : Specification<Track>
        {
            public ByIds(IEnumerable<int> ids)
            {
                Query
                    .Where(x => ids.Contains(x.Id))
                    .Include(x => x.Album);
            }
        }
    }
}
