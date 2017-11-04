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
	public partial class NeutropeniaFebrilPage : ContentPage
	{
		public NeutropeniaFebrilPage ()
		{
            Title = MainPage.THE_TITLE;
			InitializeComponent ();
		}
	}
}