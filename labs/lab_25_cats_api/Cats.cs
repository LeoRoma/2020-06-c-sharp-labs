﻿using System;
using System.Collections.Generic;

namespace lab_25_cats_api
{
    public partial class Cats
    {
        public int CatId { get; set; }
        public string CatName { get; set; }
        public int? Age { get; set; }
        public string Description { get; set; }
    }
}
