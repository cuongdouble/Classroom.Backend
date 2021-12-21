using Classroom.Backend.Contracts;
using Classroom.Backend.DTO;
using Classroom.Backend.Entity.Models;
using Classroom.Backend.Exceptions;
using Classroom.Backend.Services.EmailService;
using CompanyEmployees.JwtFeatures;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classroom.Backend.Services
{
    public class UserService : IUserService
	{
        private readonly IRepositoryManager _repositoryManager;
		private readonly UserManager<User> _userManager;
		private readonly JwtHandler _jwtHandler;
		private readonly IEmailSender _emailSender;

		public UserService(IRepositoryManager repositoryManager, UserManager<User> userManager,
			JwtHandler jwtHandler, IEmailSender emailSender)
        {
            _repositoryManager = repositoryManager;
			_userManager = userManager;
			_jwtHandler = jwtHandler;
			_emailSender = emailSender;
		}

        public async Task<AuthResponseDto> Login(UserForAuthenticationDto userForAuthentication)
        {
			var user = await _userManager.FindByNameAsync(userForAuthentication.Email);
			if (user == null)
				throw new BadRequestException("Invalid Request");

			if (!await _userManager.CheckPasswordAsync(user, userForAuthentication.Password))
			{
				if (await _userManager.IsLockedOutAsync(user))
				{
					var content = $"Your account is locked out. To reset the password click this link: {userForAuthentication.ClientURI}";
					var message = new Message(new string[] { userForAuthentication.Email }, "Locked out account information", content, null);
					await _emailSender.SendEmailAsync(message);

					throw new UnAuthenticatedException("The account is locked out");
				}

				throw new UnAuthenticatedException("Invalid Authentication");
			}		

			var token = await _jwtHandler.GenerateToken(user);
			return new AuthResponseDto { IsAuthSuccessful = true, Token = token };
		}

    }
}
