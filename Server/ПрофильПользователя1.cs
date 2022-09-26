using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace штвн.Server
{
    public partial class ПрофильПользователя1
    {
        public int RegId { get; set; }
        public byte[] ФотоПрофиля { get; set; }

        public virtual РегистрацияНаСайте1 Reg { get; set; }
    }
}
