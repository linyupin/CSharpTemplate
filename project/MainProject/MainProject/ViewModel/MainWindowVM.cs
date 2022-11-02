using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using WpfControlLibrary.Information;
using WpfControlLibrary.Resource;

namespace MainProject.ViewModel {
    public class MainWindowVM : ViewModelBase {
        public MainWindowVM() {
            initInfoWinVM();
        }

        // **** Init Function ****
        #region

        #endregion

        // **** Private Parameter ****
        #region
        #endregion

        // **** Public Parameter ****
        #region
        #endregion

        // **** Binding Parameter ****
        #region
        #endregion

        // **** Binding Command ****
        #region
        #endregion

        // **** Private Function ****
        #region
        #endregion

        // **** Public Function ****
        #region
        #endregion

        // **** Information Window ****
        #region
        InformationWindowVM _InfoWinVM;
        public InformationWindowVM InfoWinVM {
            get { return _InfoWinVM; }
            set { _InfoWinVM = value; OnPropertyChanged(() => InfoWinVM); }
        }

        void initInfoWinVM() {
            InfoWinVM = new InformationWindowVM();
            InfoWinVM.CurrentInforItem.Content = "Init";
            InfoWinVM.CurrentInforItem.FontColor = Brushes.Black;
        }
        #endregion
    }
}
