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
    public class Gymactivitys
    {
        public int Id { get; set; }
        public int Weight { get; set; }
        public int Repetition { get; set; }
        public int Points { get; set; }
        public int TrainingMachine_Id { get; set; }
        public int ActivityCategories_Id { get; set; }

    }
}