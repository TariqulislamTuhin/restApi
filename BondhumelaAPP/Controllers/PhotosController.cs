using AutoMapper;
using BondhumelaApp.Data;
using BondhumelaApp.Helper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace BondhumelaAPP.Controllers
{

    [Authorize]
    [Route("api/users/userId/photos")]
    public class PhotosController : ControllerBase
    {
        // private readonly IBondhumelaRepository _repo;
        // private readonly IMapper _mapper;
        // private readonly IOptions<CloudinarySettings> _clodinaryConfig;
        // public PhotosController(IBondhumelaRepository repo, IMapper mapper, IOptions<CloudinarySettings> clodinaryConfig)
        // {
        //     _clodinaryConfig = clodinaryConfig;
        //     _mapper = mapper;
        //     _repo = repo;

        // }
    }
}