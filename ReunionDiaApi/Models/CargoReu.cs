﻿using System;
using System.Collections.Generic;

namespace ReunionDiaApi.Models
{
    public partial class CargoReu
    {
        public CargoReu()
        {
            AsistenReus = new HashSet<AsistenReu>();
        }

        public int IdCargoR { get; set; }
        public string Crnombre { get; set; } = null!;
        public bool Cresta { get; set; }
        public string Crempresa { get; set; } = null!;
        public string? Cearea { get; set; }

        public virtual ICollection<AsistenReu> AsistenReus { get; set; }
    }
}
