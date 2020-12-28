using DevExpress.Mvvm;
using HandyControl.Tools.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leantek.Gateway.ViewModels
{
    public class AddNodeViewModel : ViewModelBase, IDialogResultable<AddNodeViewModel>
    {
        public Action CloseAction { get; set; }
        public AddNodeViewModel Result { get; set; }

    }
}
