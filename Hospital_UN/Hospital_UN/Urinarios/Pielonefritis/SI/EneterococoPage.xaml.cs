using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hospital_UN.Urinarios.Pielonefritis.SI
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EnterococoPage : ContentPage
	{
		public EnterococoPage ()
		{
            Title = MainPage.THE_TITLE;
			InitializeComponent ();
		}
	}
}