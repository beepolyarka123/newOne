using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace штвн.Server
{
    public partial class Аренда
    {
        public Аренда()
        {
            РасположениеКлуба = new HashSet<РасположениеКлуба>();
        }

        public int ArendaId { get; set; }
        public bool? НомерКомпьютера { get; set; }
        public DateTime? ВремяИДатаАренды { get; set; }
        public byte? ВремяАренды { get; set; }
        public int? UslugaId { get; set; }

        public virtual Услуга Usluga { get; set; }
        public virtual ICollection<РасположениеКлуба> РасположениеКлуба { get; set; }
    }
}
