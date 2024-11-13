using MauiAppEvento.Models;

namespace MauiAppEvento.Views;

public partial class CadastroEvento : ContentPage
{
	App PropriedadesApp;
	public CadastroEvento()
	{
        InitializeComponent();

		PropriedadesApp = (App)Application.Current;

		dtpck_inicio.MinimumDate = DateTime.Now;

		dtpck_termino.MinimumDate = dtpck_inicio.Date.AddDays(1);

    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Evento f = new Evento
			{
				NumeroParticipantes = Convert.ToDouble(stp_participantes.Value),
				DataInicio = dtpck_inicio.Date,
				DataTermino = dtpck_termino.Date,
				Local = txt_local.Text,
				Nome = txt_nome.Text,
				Custo = Convert.ToDouble(txt_custo.Text),


			};


            
            await Navigation.PushAsync(new EventoCadastrado()
			{
				BindingContext = f
			});

		}catch (Exception ex)
		{
			await DisplayAlert("Ops", ex.Message, "OK");
		}
    }

    private void dtpck_inicio_DateSelected(object sender, DateChangedEventArgs e)
    {
		DatePicker elemento = sender as DatePicker;

		DateTime data_selecionada_inicio = elemento.Date;

		dtpck_termino.MinimumDate = data_selecionada_inicio.AddDays(1);
		
    }
}