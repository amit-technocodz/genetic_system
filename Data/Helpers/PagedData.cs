﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Helpers
{
    public class PagedData<T> where T : class
    {
        public IEnumerable<T> Data { get; set; }
        public int NumberOfPages { get; set; }
        public int CurrentPage { get; set; }
    }
}
