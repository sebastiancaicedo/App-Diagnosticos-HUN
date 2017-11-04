using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hospital_UN.Inmunologicos
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DiagnosticosInmunologicosPage : ContentPage
	{
		public DiagnosticosInmunologicosPage ()
		{
            Title = MainPage.THE_TITLE;
			InitializeComponent ();
		}

        public void OnNeutropeniaClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NeutropeniaFebrilPage());
        }

    }
}