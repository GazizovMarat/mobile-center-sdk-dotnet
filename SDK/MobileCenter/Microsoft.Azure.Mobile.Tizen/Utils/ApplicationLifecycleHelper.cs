﻿using System;
/*using Windows.ApplicationModel.Core;
using Windows.UI.Xaml;*/

namespace Microsoft.Azure.Mobile.Utils
{
    public class ApplicationLifecycleHelper : IApplicationLifecycleHelper
    {
        public ApplicationLifecycleHelper()
        {
            Enabled = true;
            /*Application.Current.UnhandledException += (sender, eventArgs) =>
            {
                UnhandledExceptionOccurred?.Invoke(sender, new UnhandledExceptionOccurredEventArgs(eventArgs.Exception));
            };*/
        }

        private void InvokeResuming(object sender, object e)
        {
            ApplicationResuming?.Invoke(sender, EventArgs.Empty);
        }

        private void InvokeSuspending(object sender, object e)
        {
            ApplicationSuspending?.Invoke(sender, EventArgs.Empty);
        }

        private bool _enabled;
        public bool Enabled {
            get
            {
                return _enabled;
            }
            set
            {
                if (value == _enabled)
                {
                    return;
                }
                /*if (value)
                {
                    CoreApplication.Resuming += InvokeResuming;
                    CoreApplication.Suspending += InvokeSuspending;
                }
                else
                {
                    CoreApplication.Resuming -= InvokeResuming;
                    CoreApplication.Suspending -= InvokeSuspending;
                }*/
                _enabled = value;
            }
        }

        public event EventHandler ApplicationSuspending;
        public event EventHandler ApplicationResuming;
        public event EventHandler<UnhandledExceptionOccurredEventArgs> UnhandledExceptionOccurred;
    }
}
