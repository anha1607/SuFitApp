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
    public class Trainingmachine
    {
        public int Id { get; set; }
        public string MachineType { get; set; }
        public int QrCode { get; set; }
    }
}