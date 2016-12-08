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
        

        //Declaration of the viewModel 
        private FileOpeningViewModel FileOpeningViewModel;
        private SaveFileViewModel SaveFileViewModel;
        private VideoPlayerViewModel VideoPlayerViewModel;

        //Access right for the different view


        #endregion

        #region Get/Set
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

        public ICommand GoToVideoPlayerCommand
        {
            get; private set;
        }
        #endregion

        /// <summary>
        /// Creation of the MainViewModel. Nottably, create the commands, and all of the other view Model
        /// </summary>
        public MainViewModel()
        {

            //Place the creation of the viewModel here
            FileOpeningViewModel = new FileOpeningViewModel();
            SaveFileViewModel = new SaveFileViewModel();
            VideoPlayerViewModel = new VideoPlayerViewModel();

            viewModel = FileOpeningViewModel;
            GoToOpenCommand = new RelayCommand(GoToOpen);
            GoToSaveCommand = new RelayCommand(GoToSave, canExec);
            GoToVideoPlayerCommand = new RelayCommand(GoToVideoPlayer);
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

        /// <summary>
        /// Open the SaveFil View
        /// </summary>
        private void GoToVideoPlayer()
        {
            viewModel = VideoPlayerViewModel;
        }

        public bool canExec(object parameter)
        {
            return !(FileOpeningViewModel.browser.canOpenFile);
        }

        #region CommandDefinition

        #endregion
    }
}
