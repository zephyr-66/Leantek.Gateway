
using DevExpress.Mvvm;
using HandyControl.Tools.Extension;
using System;

namespace Leantek.Gateway.ViewModels
{
    public class AddMQTTViewModel : ViewModelBase, IDialogResultable<AddMQTTViewModel>
    {
        public Action CloseAction { get; set; }
        public DelegateCommand CloseCommand { get; private set; }
        public AddMQTTViewModel Result { get; set; }
        public AddMQTTViewModel()
        {
            CloseCommand = new DelegateCommand(CloseFrm);
        }

        void CloseFrm()
        {
            CloseAction?.Invoke();
        }
    }
}