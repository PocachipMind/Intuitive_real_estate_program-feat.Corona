using CoronaTrace.View;
using CoronaTrace.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CoronaTrace.Model
{
    [System.Runtime.InteropServices.ComVisible(true)]
    public class DataFromWebModel
    {
        //Web에서 API를 통해 받은 정보를통해 VM 생성. Web은 무조건 지정된 클래스로만 정보를 전달가능해서 따로구현.
        public void OpenInforWindow(int some)
        {
            InformationWindow sub = new InformationWindow();
            InformationWindowVM vm = new InformationWindowVM(some);
            sub.DataContext = vm;
            sub.Show();

        }
    }
}
