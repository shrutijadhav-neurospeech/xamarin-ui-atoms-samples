﻿using NeuroSpeech.UIAtoms;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UIAtomsDemo;
using UIAtomsDemo.RestServices;
using UIAtomsDemo.RestServices.Models;

namespace ComboBox.ViewModels
{
    public class SimpleComboBoxPageViewModel: BaseViewModel
    {

        public AtomList<Country> CountryList { get; } =
            new AtomList<Country>();

        public override async Task InitAsync()
        {
            var countryList = await Get<ConfigService>().GetCountriesAsync();
            CountryList.Clear();
            CountryList.AddRange(countryList);
        }

    }
}
