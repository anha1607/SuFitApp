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
    public class Workout
    {
        public int Id { get; set; }
        public int OtherActivitys_Id { get; set; }
        public int Person_Id { get; set; }
        public int Goal_Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime TotalTime { get; set; }
    }
}