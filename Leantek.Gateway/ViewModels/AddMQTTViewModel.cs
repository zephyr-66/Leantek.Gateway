
using DevExpress.Mvvm;
using HandyControl.Tools.Extension;
using Leantek.Gateway.Model;
using System;

namespace Leantek.Gateway.ViewModels
{
    public class AddMQTTViewModel : ViewModelBase, IDialogResultable<AddMQTTViewModel>
    {
        public Action CloseAction { get; set; }
        public DelegateCommand CloseCommand { get; private set; }
        public DelegateCommand SaveCommand { get; private set; }

        private ServiceModel _serviceModel;

        public ServiceModel serviceModel 
        {
            get => _serviceModel;
            set => SetValue(ref _serviceModel, value);
        }

        public AddMQTTViewModel Result { get; set; }
        public AddMQTTViewModel()
        {
            CloseCommand = new DelegateCommand(CloseFrm);
            SaveCommand = new DelegateCommand(SaveFrm);
        }

        void SaveFrm()
        {
            CloseAction?.Invoke();
        }
        void CloseFrm()
        {
            CloseAction?.Invoke();
        }
    }
}