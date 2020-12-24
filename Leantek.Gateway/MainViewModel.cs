using DevExpress.Mvvm;
using HandyControl.Controls;
using HandyControl.Tools.Extension;
using Leantek.Gateway.View;
using Leantek.Gateway.ViewModels;

namespace Leantek.Gateway
{
    public class MainViewModel : ViewModelBase
    {
        public DelegateCommand NewProjectCommand { get; private set; }

        public MainViewModel()
        {
            NewProjectCommand = new DelegateCommand(ShowProjectFrm);

        }

        private void ShowProjectFrm()
        {
            //var main = new Window();
            //main.Name = "AddMQTT";
            //AddMQTT frm = new AddMQTT();
            //main.Height = 350;
            //main.Width = 350;
            //main.Content = frm;
            //main.Owner = Application.Current.MainWindow;
            //main.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            //main.Show();
            Dialog.Show<AddMQTT>().Initialize<AddMQTTViewModel>(vm => { })
                .GetResultAsync<AddMQTTViewModel>().ContinueWith(str => { });
        }
    }
}
