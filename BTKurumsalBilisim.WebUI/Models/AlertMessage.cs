using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTKurumsalBilisim.WebUI.Models
{
    public class AlertMessage
    {
        public string Title { get; set; }

        public string Message { get; set; }

        //alert mesajlarının renginin belirlenmesi için tanımlandı
        public string AlertType { get; set; }
    }
}
