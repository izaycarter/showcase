﻿using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kopis_Showcase.Models
{
    public class UploadFile
    { 
        public IFormFile Upload { get; set; }

        public string ErrorMessage = "please select an excel file ending with .xlxs";

        public bool Wrongtype
        {
            get;
        }

    }
}
