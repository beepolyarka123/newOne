using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace штвн.Server
{
    public partial class РасположениеКлуба
    {
        public int ClubId { get; set; }
        public string Адрес { get; set; }
        public int? ArendaId { get; set; }

        public virtual Аренда Arenda { get; set; }
    }
}
