using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace штвн.Server
{
    public partial class ИнформацияОКомпании
    {
        public int InfId { get; set; }
        public string Название { get; set; }
        public string ГлаваЫСтудии { get; set; }
        public int? КоличествоСотрудников { get; set; }
        public DateTime ДатаОснования { get; set; }
        public string Страна { get; set; }

        public virtual ИнформацияОИгре ИнформацияОИгре { get; set; }
    }
}
