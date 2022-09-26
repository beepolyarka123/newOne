using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace штвн.Server
{
    public partial class Оплата
    {
        public int? ExtraId { get; set; }
        public int? ClubId { get; set; }
        public long? НомерКарты { get; set; }
        public long? НомерТелефона { get; set; }

        public virtual РасположениеКлуба Club { get; set; }
        public virtual ДополнительныеУслуги Extra { get; set; }
    }
}
