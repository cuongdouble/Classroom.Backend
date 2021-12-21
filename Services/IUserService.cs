using Classroom.Backend.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classroom.Backend.Services
{
    public interface IUserService
    {
        public Task<AuthResponseDto> Login(UserForAuthenticationDto userForAuthentication);
    }
}
