﻿using System;
using System.Collections.Generic;

namespace ReunionWeb.NeoDbs
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

        public virtual ICollection<AsistenReu> AsistenReus { get; set; }
    }
}