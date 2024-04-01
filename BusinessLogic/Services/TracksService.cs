using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using BusinessLogic.Models;
using BusinessLogic.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BusinessLogic.Services
{
    internal class TracksService
    {
        private readonly IMapper mapper;
        private readonly IRepository<Track> tracksR;
        private readonly IRepository<Album> albumsR;
        
        public TracksService(IMapper mapper, IRepository<Track> repository, IRepository<Album> albumsR)
        {
            this.mapper = mapper;
            this.tracksR = repository;
            this.albumsR = albumsR;
        }

        public void Create(CreateTrackModel product)
        {
            tracksR.Insert(mapper.Map<Track>(product));
            tracksR.Save();
        }

        public void Delete(int id)
        {
            if (id < 0 || id > tracksR.GetAll().Count())
            {
                throw new HttpException(HttpStatusCode.BadRequest);
            }
            else { tracksR.Delete(id); tracksR.Save(); }
        }

        public void Edit(TrackDto Model)
        {
            tracksR.Update(mapper.Map<Track>(Model));
            tracksR.Save();
        }

        public async Task<TrackDto?> Get(int id)
        {
            if (id < 0) throw new HttpException(HttpStatusCode.BadRequest);

            var item = await tracksR.GetItemBySpec(new TracksSpecs.ById(id));
            if (item == null) throw new HttpException(HttpStatusCode.NotFound);

            var dto = mapper.Map<TrackDto>(item);

            return dto;
        }
    }
}
