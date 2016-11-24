using EasyVideoEdition.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EasyVideoEdition.ViewModel
{
    class FileOpeningViewModel : ObjectBase
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
        /// Getter and Setter for the OpenFileCommand. This Command launch the method OpenFile. 
        /// </summary>
        public ICommand OpenFileCommand
        {
            get; private set;
        }

        /// <summary>
        /// Getter and Setter for the SaveFileCommand. This Command launch the method SaveFile. 
        /// </summary>
        public ICommand SaveFileCommand
        {
            get; private set;
        }
        #endregion

        /// <summary>
        /// Creation of the MainViewModel. Nottably, create the commands.  
        /// </summary>
        public FileOpeningViewModel()
        {
            browser = new FileBrowser();
            OpenFileCommand = new RelayCommand(OpenFile);
            SaveFileCommand = new RelayCommand(SaveFile);
        }

        #region CommandDefinition
        /// <summary>
        /// Method that launch the OpenFile of the Filebrowser. 
        /// </summary>
        private void OpenFile()
        {
            browser.OpenFile();
        }

        /// <summary>
        /// Method that launch the OpenFile of the Filebrowser. 
        /// </summary>
        private void SaveFile()
        {
            browser.SaveFile();
        }


        #endregion
    }
}
