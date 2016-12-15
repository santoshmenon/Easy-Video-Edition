﻿using EasyVideoEdition.Model;
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
    class SubtitlesViewModel : ObjectBase, BaseViewModel
    {
        #region Attributes

        private String _startTime = "00:00:00,000";
        private String _endTime = "00:00:00,000";
        private String _subText = "New subtitle";
        private Subtitles _subtitles;

        #endregion

        #region Get/Set
        /// <summary>
        /// Name of the View Model
        /// </summary>
        public String name
        {
            get
            {
                return "Subtitles/Project";
            }
        }

        /// <summary>
        /// Subtitles of the video
        /// </summary>
        public Subtitles subtitles
        {
            get
            {
                return _subtitles;
            }
            set
            {
                _subtitles = value;
                RaisePropertyChanged("subtitles");
            }
        }

        /// <summary>
        /// Start time of the subtitle to add
        /// </summary>
        public String startTime
        {
            get
            {
                return _startTime;
            }
            set
            {
                _startTime = value;
                RaisePropertyChanged("startTime");
            }
        }

        /// <summary>
        /// End time of the subtitle to add
        /// </summary>
        public String endTime
        {
            get
            {
                return _endTime;
            }
            set
            {
                _endTime = value;
                RaisePropertyChanged("endTime");
            }
        }

        /// <summary>
        /// Text of the subtitle to add
        /// </summary>
        public String subText
        {
            get
            {
                return _subText;
            }
            set
            {
                _subText = value;
                RaisePropertyChanged("subText");
            }
        }
        #endregion

        #region CommandList

        /// <summary>
        /// Command to Add a subtitle
        /// </summary>
        public ICommand AddSubtitleCommand
        {
            get; private set;
        }

        /// <summary>
        /// Command to edit an already existing subtitle
        /// </summary>
        public ICommand EditSubtitleCommand
        {
            get; private set;
        }

        /// <summary>
        /// Command to delete en already existing subtitle
        /// </summary>
        public ICommand DeleteSubtitleCommand
        {
            get; private set;
        }
        #endregion

        /// <summary>
        ///  Creates the viewModel of subtitles. 
        /// </summary>
        /// <param name="filePath">Path of the video with we want to add subtile</param>
        public SubtitlesViewModel(String filePath)
        {
            subtitles = new Subtitles(filePath);
            subtitles.ReadSrtFile();

            AddSubtitleCommand = new RelayCommand(AddSubtitle);
        }

        #region CommandDefinition

        /// <summary>
        /// Add a subtitle
        /// </summary>
        private void AddSubtitle()
        {
            subtitles.AddSubtitle(startTime, endTime, subText);
        }

        /// <summary>
        /// Edit a subtitle
        /// </summary>
        private void EditSubtitle()
        {
            
        }

        /// <summary>
        /// Delete a subtitle
        /// </summary>
        private void DeleteSubtitle()
        {
            
        }

        #endregion
    }
}
