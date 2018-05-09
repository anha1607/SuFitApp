using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace SuFitApp.Droid.DBClasses
{
    public class Diet
    {
        public int Id { get; set; }
        public string Food { get; set; }
        public int Portion { get; set; }
        public int Kcal { get; set; }
        public int Protein { get; set; }
        public int Fat { get; set; }
        public int Carbs{ get; set; }

    }
}