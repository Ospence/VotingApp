﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VotingApp.Domain.Models;
using VotingApp.Services.Models;

namespace VotingApp.App_Start
{
    public class AutoMapperConfig
    {
        public static void RegisterMaps()
        {
            Mapper.CreateMap<ApplicationUser, ApplicationUserDTO>();
            Mapper.CreateMap<ApplicationUserDTO, ApplicationUser>();

            Mapper.CreateMap<Comment, CommentDTO>();
            Mapper.CreateMap<CommentDTO, Comment>();

            Mapper.CreateMap<Motion, MotionDTO>();
            Mapper.CreateMap<MotionDTO, Motion>();

            Mapper.CreateMap<Vote, VoteDTO>();
            Mapper.CreateMap<VoteDTO, Vote>();

            Mapper.CreateMap<ApplicationUser, ApplicationUserDTO>();
            Mapper.CreateMap<ApplicationUserDTO, ApplicationUser>();
        }
    }
}