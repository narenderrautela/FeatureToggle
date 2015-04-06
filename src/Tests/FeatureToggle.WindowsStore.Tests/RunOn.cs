﻿using System;
using System.Threading.Tasks;
using Windows.UI.Core;

namespace FeatureToggle.WindowsStore.Tests
{   
    public static class RunOn
    {
        public static async Task Dispatcher(Action a, int timeOut = 5000)
        {
            await Windows.ApplicationModel.Core.CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, a.Invoke);
        }        
    }

}
