﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eTouristapp.Models.Request
{
    public class HotelSearchRequest
    {
        public string Naziv { get; set; }

        public int? GradId { get; set; }
    }
}
