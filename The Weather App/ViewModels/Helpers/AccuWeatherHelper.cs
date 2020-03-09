using System;
using System.Collections.Generic;
using System.Text;

namespace The_Weather_App.ViewModels.Helpers
{
    public partial class AccuWeatherHelper
    {
        public const string BASE_URL = "http://dataservice.accuweather.com/";
        public const string AUTOCOMPLETE_ENDPOINT = "locations/v1/cities/autocomplete?apikey={0}&q={1}";
    }
}
