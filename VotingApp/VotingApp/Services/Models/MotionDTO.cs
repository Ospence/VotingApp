﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VotingApp.Domain.Models
{
    public class Motion
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public int CreatedById { get; set; }
        public int SecondedById { get; set; }

        public bool Seconded { get; set; }
        public bool Active { get; set; }
        public bool Passed { get; set; }
        public bool WasEdited { get; set; }

        public DateTime Created { get; set; }

        public IList<Vote> Votes { get; set; }
        public IList<Comment> Comments { get; set; }
        public IList<string> Edits { get; set; }
    }
}