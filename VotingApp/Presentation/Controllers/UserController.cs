﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Security;
using VotingApp.Domain.Models;
using VotingApp.Services;
using VotingApp.Services.Models;

namespace VotingApp.Presentation.Controllers
{
    public class UserController : ApiController
    {

        private UserService _service;

        public UserController(UserService service)
        {
            _service = service;
        }

        // GET: api/Global
        public IEnumerable<ApplicationUserDTO> Get()
        {
            return (_service.List());
        }

        public ApplicationUserDTO Get(string id)
        {
            return (_service.Find(id));
        }

        // POST: api/Global
        // will aslo not be necessary if identity login creates
        [Authorize(Roles = "Admin")]
        public HttpResponseMessage Post(ApplicationUserDTO admin)
        {
            if (ModelState.IsValid)
            {
                _service.AddOrUpdate(admin);

                return Request.CreateResponse(HttpStatusCode.Created, admin);
            }
            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
        }

    }
}
