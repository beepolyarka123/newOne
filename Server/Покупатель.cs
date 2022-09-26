using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace штвн.Server
{
    public partial class Покупатель
    {
        public Покупатель()
        {
            Услуга = new HashSet<Услуга>();
        }

        public int Id { get; set; }
        public string Имя { get; set; }
        public string Фамилия { get; set; }
        public byte? Возраст { get; set; }
        public string ДеньРожденияСегодня { get; set; }

        public virtual ICollection<Услуга> Услуга { get; set; }
    }
}
