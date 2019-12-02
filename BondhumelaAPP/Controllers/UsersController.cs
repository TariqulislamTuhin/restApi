using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BondhumelaApp.Data;
using BondhumelaApp.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BondhumelaApp.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly IBondhumelaRepository _repo;
        private readonly IMapper _mapper;
        public UsersController(IBondhumelaRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _repo.GetUsers();
            var usersToReturn = _mapper.Map<IEnumerable<UserForListDto>>(users);
            return Ok(usersToReturn);

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _repo.GetUser(id);
            var UserToReturn = _mapper.Map<UserForDetailsDto>(user);
            return Ok(UserToReturn);
        }
    }
}