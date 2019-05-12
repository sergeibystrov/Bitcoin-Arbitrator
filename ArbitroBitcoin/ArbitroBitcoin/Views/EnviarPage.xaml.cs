﻿using ArbitroBitcoin.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ArbitroBitcoin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EnviarPage : ContentPage
    {
        public EnviarPage()
        {
            InitializeComponent();

            enderecoDestinoEntry.Placeholder = AppResources.EnderecoDestino;
            valorEntry.Placeholder = AppResources.Valor;
            enderecoArbitroEntry.Placeholder = AppResources.EnderecoArbitro;
            enviarButton.Text = AppResources.Enviar;

            MessagingCenter.Subscribe<ViewModels.EnviarViewModel>(this, "erro_envio", (sender) =>
            {
                DisplayAlert("Alerta", "Não foi possivel emitir a transação.", "OK");
            });
        }
    }
}