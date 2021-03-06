﻿using NeuroSpeech.UIAtoms;
using System;
using System.Collections.Generic;
using System.Text;
using UIAtomsDemo;
using System.Threading.Tasks;
using Xamarin.Forms;
using NeuroSpeech.UIAtoms.DI;

namespace Form.ViewModels
{
    public class SimpleFormPageViewModel : BaseViewModel
    {

        public SimpleFormPageViewModel()
        {
            this.SubmitCommand = new AtomCommand(async ()=> await OnSubmitCommandAsync());
        }

        private async Task OnSubmitCommandAsync()
        {
            await Task.Delay(100);
            await Get<INotificationService>().NotifyAsync("Submit clicked");
        }

        public AtomCommand SubmitCommand { get; private set; }
    }
}
