using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCar.Models
{
    public class ListagemVeiculos
    {
        public List<Veiculo> Veiculos { get; private set; }
        public ListagemVeiculos()
        {
            this.Veiculos = new List<Veiculo>
            {
                new Veiculo { Nome="Azera V6", Preco = 60000},
                new Veiculo { Nome="Fiesta", Preco = 50000},
                new Veiculo { Nome="Vectra", Preco = 40000},
            };

        }

        
    }
}
