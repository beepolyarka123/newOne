using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace штвн.Server
{
    public partial class ДополнительныеУслуги
    {
        public int ExtraId { get; set; }
        public byte? СколькоМониторовНужно { get; set; }
        public int? UslugaId { get; set; }
        public string ВыделятьОтдельнуюКомнату { get; set; }

        public virtual Услуга Usluga { get; set; }
    }
}
