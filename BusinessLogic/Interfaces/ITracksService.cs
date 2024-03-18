using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.DTOs;
using BusinessLogic.Models;

namespace BusinessLogic.Interfaces
{
    public interface ITracksService
    {
        Task<IEnumerable<TrackDto>> GetAll();
        Task<IEnumerable<TrackDto>> Get(IEnumerable<int> ids);
        Task<TrackDto?> Get(int id);
        IEnumerable<CategoryDto> GetAllCategories();
        void Create(CreateTrackModel product);
        void Edit(TrackDto product);
        void Delete(int id);
    }
}
