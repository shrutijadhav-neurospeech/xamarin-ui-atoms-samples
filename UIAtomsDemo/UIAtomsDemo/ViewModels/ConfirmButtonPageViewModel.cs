﻿using NeuroSpeech.UIAtoms;
using NeuroSpeech.UIAtoms.DI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UIAtomsDemo.ViewModels
{
    public class ConfirmButtonPageViewModel : BaseViewModel
    {

        public ConfirmButtonPageViewModel()
        {
            this.DeleteCommand = new AtomCommand(async () => await OnDeleteCommandAsync());
        }

        public AtomCommand DeleteCommand { get; private set; }

        private async Task OnDeleteCommandAsync()
        {
            Get<INotificationService>().Notify("Deleted successfully");
        }
    }
}