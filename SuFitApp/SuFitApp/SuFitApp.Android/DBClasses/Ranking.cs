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
    public class Ranking
    {
        public int Id { get; set; }
        public int Training_Id { get; set; }
        public int Person_Id { get; set; }
        public int Diet_Id { get; set; }
        public int Goal_Id { get; set; }
    }
}