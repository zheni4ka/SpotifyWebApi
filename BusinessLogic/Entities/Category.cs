using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Entities
{
    public enum Categories
    {
        Rock = 1,
        Pop,
        HipHop,
        Jazz,
        Classical,
        Electronic,
        Country,
        Folk,
        RnB,
        Metal,
        Blues,
        Other
    }

    public class Category 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Playlist> Playlists { get; set; } = new HashSet<Playlist>();
    }
}
