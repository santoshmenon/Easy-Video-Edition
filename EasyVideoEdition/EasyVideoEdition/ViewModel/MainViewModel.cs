using EasyVideoEdition.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EasyVideoEdition.ViewModel
{
    class MainViewModel : ObjectBase
    {
        #region Attributes
        private FileBrowser _browser;
        public FileBrowser browser
        {
            get
            {
                return _browser;
            }
            set
            {
                _browser = value;
                RaisePropertyChanged("browser");
            }
        }
        #endregion


        #region CommandList
        /// <summary>
        /// 
        /// </summary>
        public ICommand OpenFileCommand
        {
            get; private set;
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        public MainViewModel()
        {
            browser = new FileBrowser();
            OpenFileCommand = new RelayCommand(OpenFile);
        }

        #region CommandDefinition
        /// <summary>
        /// Method that launch the OpenFile of the Filebrowser. 
        /// </summary>
        private void OpenFile()
        {
            browser.OpenFile();
        }
        
        
        #endregion
    }
}
