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
    public class Goal
    {
        public int Id { get; set; }
        public string GoalType { get; set; }
        public int Points { get; set; }

    }
}