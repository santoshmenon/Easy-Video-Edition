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
        private FileOpeningViewModel _fileOpeningViewModel;
        private SaveFileViewModel _saveFileViewModel;
        private VideoPlayerViewModel _videoPlayerViewModel;
        private SubtitlesViewModel _subtitlesViewModel;

        //Access right for the different view
        public bool editVideoEnabled
        {
            get
            {
                return !(_fileOpeningViewModel.browser.canOpenFile);
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

        public ICommand GoToSubCommand
        {
            get; private set;
        }

        public ICommand GoToPlayCommand
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
            _fileOpeningViewModel = new FileOpeningViewModel();
            _saveFileViewModel = new SaveFileViewModel();

            viewModel = _fileOpeningViewModel;
            GoToOpenCommand = new RelayCommand(GoToOpen);
            GoToPlayCommand = new RelayCommand(GoToPlay, GoToPlayCanExecute);
            GoToSubCommand = new RelayCommand(GoToSub, GoToPlayCanExecute);
            GoToSaveCommand = new RelayCommand(GoToSave);
        }

        /// <summary>
        /// Open the OpenFile View
        /// </summary>
        private void GoToOpen()
        {
            viewModel = _fileOpeningViewModel;
        }

        /// <summary>
        /// Open the VideoPlayerView 
        /// </summary>
        private void GoToPlay()
        {
            viewModel = _videoPlayerViewModel;
        }

        /// <summary>
        /// Open the Subtile View
        /// </summary>
        private void GoToSub()
        {
            viewModel = _subtitlesViewModel;
        }

        /// <summary>
        /// Indicate if the user can go to the Player and the Subtitle view.
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        private bool GoToPlayCanExecute(object parameter)
        {
            if (!(_fileOpeningViewModel.browser.canOpenFile))
            {
                _videoPlayerViewModel = new VideoPlayerViewModel(_fileOpeningViewModel.browser.filePath);
                _subtitlesViewModel = new SubtitlesViewModel(_fileOpeningViewModel.browser.filePath);
            }
                
            return !(_fileOpeningViewModel.browser.canOpenFile);
        }

        /// <summary>
        /// Open the SaveFil View
        /// </summary>
        private void GoToSave()
        {
            viewModel = _saveFileViewModel;
        }

        #region CommandDefinition

        #endregion


    }
}
