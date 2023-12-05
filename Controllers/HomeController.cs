﻿using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace AIIELTS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController:RESTFulController
    {
        [HttpGet]
        public ActionResult <string> Get()=>
            Ok("Hello Mario");
    }
}