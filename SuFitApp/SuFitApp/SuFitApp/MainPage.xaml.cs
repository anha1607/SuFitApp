using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SuFitApp.Droid.DBOperation;
using SuFitApp.Droid.DBClasses;

namespace SuFitApp
{
	public partial class MainPage : ContentPage
	{
        DBconn db = new DBconn();
        Person p = new Person();
        
		public MainPage()
		{
			InitializeComponent();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            foreach (var item in db.DBCall(p.AllPersons))
            {
                DisplayAlert(item.Firstname, item.Lastname, "OK");
            }
           
        }
    }
}
