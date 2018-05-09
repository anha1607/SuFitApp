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
    public class Meal
    {
        public int Id { get; set; }
        public int Diet_Id { get; set; }
        public int Workout_Id { get; set; }
        public int TypeOfMeal_Id { get; set; }
        public int TotalPortions { get; set; }
    }
}