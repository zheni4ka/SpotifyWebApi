using Microsoft.AspNetCore.Mvc;
using BusinessLogic.Interfaces;
using BusinessLogic.DTOs;
using BusinessLogic.Models;

namespace SpotifyWebApi.Controllers
{
    public class TracksController : ControllerBase
    {
        public readonly ITracksService tracksService;
        public TracksController(ITracksService tracksService) 
        {
            this.tracksService = tracksService;
        }

        public async Task<IActionResult> Get()
        {
            return Ok(await tracksService.GetAll());
        }

        public async Task<IActionResult> Get(int Id) 
        {
            return Ok(await tracksService.Get(Id));
        }

        public IActionResult Create(CreateTrackModel createTrackModel)
        {
            tracksService.Create(createTrackModel);
            return Ok();
        }

        public IActionResult Edit(TrackDto trackDto)
        {
            tracksService.Edit(trackDto);
            return Ok();
        }

        public IActionResult Delete(int id) 
        {
            tracksService.Delete(id);
            return Ok();
        }


    }
}
