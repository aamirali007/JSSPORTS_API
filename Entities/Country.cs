﻿using System;
using System.Collections.Generic;

namespace SportsOrderApp.Entities
{
    public partial class Country
    {
        public Country()
        {
            States = new HashSet<State>();
        }

        public long CountryId { get; set; }
        public string? CountryName { get; set; }

        public virtual ICollection<State> States { get; set; }
    }
}
