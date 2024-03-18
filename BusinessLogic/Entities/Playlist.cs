using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Entities
{
    public class Playlist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public int UserId { get; set; }
        public string ImgUrl { get; set; }
        public User User { get; set; }
        public ICollection<Track> Tracks { get; set; } = new HashSet<Track>();
    }
}
