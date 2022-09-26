using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace штвн.Server
{
    public partial class РегистрацияНаСайте1
    {
        public int RegId { get; set; }
        public string Имя { get; set; }
        public string Фамилия { get; set; }
        public string Ник { get; set; }
        public byte Возраст { get; set; }
        public long EMailИлиТелефон { get; set; }
        public string Пароль { get; set; }
        public string ПодтверждениеПароля { get; set; }
        public string ВашаСтудия { get; set; }
    }
}
