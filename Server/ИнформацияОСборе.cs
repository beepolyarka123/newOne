using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace штвн.Server
{
    public partial class ИнформацияОСборе
    {
        public int MoneyId { get; set; }
        public byte? НужнаяСумма { get; set; }
        public string БонусыПриПревышенииНужнойСуммы { get; set; }

        public virtual ИнформацияОИгре Money { get; set; }
    }
}
