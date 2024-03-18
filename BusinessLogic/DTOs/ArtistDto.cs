using BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs
{
    public class ArtistDto
    {
        public int Id { get; set; }
        public string Nickname { get; set; }
        public DateTime BirthDate { get; set; }
        public int CountryId { get; set; }
        public double OverallRating { get; set; }
        public int ProducerId { get; set; }
        public string ImgUrl { get; set; }
    }
}
