﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeBuilder.Shared.Models
{
    public class ResumeSection
    {
        public string Name { get; set; } = string.Empty;
        public bool Active { get; set; } = false;
    }
}