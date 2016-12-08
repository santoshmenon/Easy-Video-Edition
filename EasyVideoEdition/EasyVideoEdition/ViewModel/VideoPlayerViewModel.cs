using EasyVideoEdition.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using EasyVideoEdition.View;
using System.Windows;

namespace EasyVideoEdition.ViewModel
{
    class VideoPlayerViewModel : ObjectBase, BaseViewModel
    {
        #region Attributes
        public String name
        {
            get
            {
                return "Video Player";
            }
        }

        private Slider slide;
        private MediaElement MediaElementVideoPlayer;
        private ViewVideoPlayer view;

        private VideoPlayer _videoPlayer = new VideoPlayer();

        public VideoPlayer videoPlayer
        {
            get
            {
                return _videoPlayer;
            }
            set
            {
                _videoPlayer = value;
                RaisePropertyChanged("videoPlayer");
            }
        }
        #endregion


        #region CommandList
        public ICommand PlayVideoCommand
        {
            get; private set;
        }

        public ICommand PauseVideoCommand
        {
            get; private set;
        }

        public ICommand StopVideoCommand
        {
            get; private set;
        }
        #endregion

        /// <summary>
        /// Creation of the MainViewModel. Nottably, create the commands.  
        /// </summary>
        public VideoPlayerViewModel()
        {
            PlayVideoCommand = new RelayCommand(PlayVideo);
            PauseVideoCommand = new RelayCommand(PauseVideo);
            StopVideoCommand = new RelayCommand(StopVideo);
            videoPlayer.EditSource("");
        }


        public void InitializeVM(ViewVideoPlayer view)
        {
            this.view = view;
        }

        #region CommandDefinition

        private void PlayVideo()
        {
            this.view.mediaElement.Play();
        }

        private void PauseVideo()
        {
            this.view.mediaElement.Pause();
        }

        private void StopVideo()
        {
            this.view.mediaElement.Stop();
        }

        #endregion
    }
}
