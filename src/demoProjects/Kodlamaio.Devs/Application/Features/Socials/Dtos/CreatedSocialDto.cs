﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Socials.Dtos
{
    public class CreatedSocialDto
    {
        public int Id { get; set; }
        public int AppUserId { get; set; }
        public string GithubLink { get; set; }
    }
}
