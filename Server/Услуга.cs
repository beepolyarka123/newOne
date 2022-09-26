using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace штвн.Server
{
    public partial class Услуга
    {
        public Услуга()
        {
            Аренда = new HashSet<Аренда>();
            ДополнительныеУслуги = new HashSet<ДополнительныеУслуги>();
        }

        public int UslugaId { get; set; }
        public int? Стоимость { get; set; }
        public int? ArendaId { get; set; }
        public int? Id { get; set; }

        public virtual Покупатель IdNavigation { get; set; }
        public virtual ICollection<Аренда> Аренда { get; set; }
        public virtual ICollection<ДополнительныеУслуги> ДополнительныеУслуги { get; set; }
    }
}
