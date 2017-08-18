using AppCar.Models;
using AppCar.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;



namespace AppCar.Views
{
    public partial class AgendamentoView : ContentPage
    {
        public AgendamentoViewModel ViewModel { get; set; }

        public AgendamentoView(Veiculo veiculo)
        {
            InitializeComponent();
            this.ViewModel = new AgendamentoViewModel(veiculo);
            this.BindingContext = this.ViewModel;
        }

        private void buttonAgendar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Agendamento",
                string.Format(
                    @"Veiculo: {0}
                    Nome: {1}
                    Fone: {2}
                    E-mail: {3}
                    Data de Agendamento: {4}
                    Hora de Agendamento: {5}",
                    ViewModel.Agendamento.Veiculo.Nome,
                    ViewModel.Agendamento.Nome,
                    ViewModel.Agendamento.Fone,
                    ViewModel.Agendamento.Email,
                    ViewModel.Agendamento.DataAgendamento.ToString("dd/MM/yyy"),
                    ViewModel.Agendamento.HoraAgendamento), "ok");
        }
    }
}
