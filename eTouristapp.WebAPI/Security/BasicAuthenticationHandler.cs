﻿using AngleSharp.Io;
using eTouristapp.Models.Request;
using eTouristapp.WebAPI.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace eTouristapp.WebAPI.Security
{
   
        public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
        {
        private readonly IKorisniciService _userService;
        
        public BasicAuthenticationHandler(
                IOptionsMonitor<AuthenticationSchemeOptions> options,
                ILoggerFactory logger,
                UrlEncoder encoder,
                ISystemClock clock,
                IKorisniciService userService)
                : base(options, logger, encoder, clock)
            {
                _userService = userService;
            }

            protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
            {
                if (!Request.Headers.ContainsKey("Authorization"))
                    return AuthenticateResult.Fail("Missing Authorization Header");

                Models.Korisnik user = null;
                try
                {
                    var authHeader = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
                    var credentialBytes = Convert.FromBase64String(authHeader.Parameter);
                    var credentials = Encoding.UTF8.GetString(credentialBytes).Split(new[] { ':' }, 2);
                    var username = credentials[0];
                    var password = credentials[1];
                //user = _userService.Authentifikacija(username, password);
                    user = _userService.Authentifikacija(username, password);
                }
                catch
                {
                    return AuthenticateResult.Fail("Invalid Authorization Header");
                }

                if (user == null)
                    return AuthenticateResult.Fail("Invalid Username or Password");

                var claims = new[] {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name,user.KorisnikoIme),
                new Claim(ClaimTypes.Role,user.Uloga.Naziv),
            };
                var identity = new ClaimsIdentity(claims, Scheme.Name);
                var principal = new ClaimsPrincipal(identity);
                var ticket = new AuthenticationTicket(principal, Scheme.Name);

                return AuthenticateResult.Success(ticket);
            }
        }
    
}

