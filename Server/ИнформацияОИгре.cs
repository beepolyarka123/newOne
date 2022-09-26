using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace штвн.Server
{
    public partial class ИнформацияОИгре
    {
        public int InfId { get; set; }
        public string Название { get; set; }
        public string КраткоеОписаниеИгры { get; set; }
        public string Жанр { get; set; }
        public string Теги { get; set; }

        public virtual ИнформацияОКомпании Inf { get; set; }
    }
}
