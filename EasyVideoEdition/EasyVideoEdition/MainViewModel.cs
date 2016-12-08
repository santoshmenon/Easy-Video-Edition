using EasyVideoEdition.Model;
using EasyVideoEdition.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using EasyVideoEdition.ViewModel;

namespace EasyVideoEdition
{
    /// <summary>
    /// Main View Model, this one control all of the other view model, and allow to switch between them by the use of a button.
    /// </summary>
    class MainViewModel : ObjectBase
    {
        #region Attributes
        private BaseViewModel _viewModel;
        public BaseViewModel viewModel
        {
            get
            {
                return _viewModel;
            }
            set
            {
                _viewModel = value;
                RaisePropertyChanged("viewModel");
            }
        }

        //Declaration of the viewModel 
        private FileOpeningViewModel FileOpeningViewModel;
        private SaveFileViewModel SaveFileViewModel;

        //Access right for the different view
        private bool _editVideoEnabled;

        public bool editVideoEnabled
        {
            get
            {
                return _editVideoEnabled;
            }
            set
            {
                _editVideoEnabled = value;
                RaisePropertyChanged("editVideoEnabled");
            }
        }
        #endregion

        #region CommandList
        public ICommand GoToOpenCommand
        {
            get; private set;
        }

        public ICommand GoToSaveCommand
        {
            get; private set;
        }
        #endregion

        /// <summary>
        /// Creation of the MainViewModel. Nottably, create the commands, and all of the other view Model
        /// </summary>
        public MainViewModel()
        {
            editVideoEnabled = false;

            //Place the creation of the viewModel here
            FileOpeningViewModel = new FileOpeningViewModel();
            SaveFileViewModel = new SaveFileViewModel();

            viewModel = FileOpeningViewModel;
            GoToOpenCommand = new RelayCommand(GoToOpen);
            GoToSaveCommand = new RelayCommand(GoToSave);
        }

        /// <summary>
        /// Open the OpenFile View
        /// </summary>
        private void GoToOpen()
        {
            viewModel = FileOpeningViewModel;
        }

        /// <summary>
        /// Open the SaveFil View
        /// </summary>
        private void GoToSave()
        {
            viewModel = SaveFileViewModel;
        }

        #region CommandDefinition

        #endregion
    }
}
