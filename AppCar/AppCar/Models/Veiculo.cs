using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCar.Models
{
    public class Veiculo
    {
        public const int FREIO_ABS = 1200;
        public const int AR_CONDICIONADO = 2000;
        public const int MP3_PLAYER = 700;

        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string PrecoFormatado
        {
            get { return string.Format("R$ {0}", Preco); }
        }

        public bool TemFreioABS { get; set; }
        public bool  TemArCondicionado{ get; set; }
        public bool TemMP3Player { get; set; }

        public string PrecoTotalFormatado
        {
            get
            {
                return string.Format("Valor Total: R$ {0}", 
                    Preco
                  + (TemFreioABS ? FREIO_ABS : 0)
                  + (TemArCondicionado ? AR_CONDICIONADO : 0)
                  + (TemMP3Player ? MP3_PLAYER : 0)
                  );
            }
        }
    }
}
