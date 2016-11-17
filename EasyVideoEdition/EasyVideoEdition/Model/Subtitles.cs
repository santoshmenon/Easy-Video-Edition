using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectB;

namespace EasyVideoEdition.Model
{
    /// <summary>
    /// Every subtitles of a video in srt format
    /// </summary>
    class Subtitles : ObjectBase
    {
        #region Attributes
        private ObservableCollection<Subtitle> _subtitlesCollection;
        private String _srtPath;
        #endregion
        #region Get/Set
        /// <summary>
        /// Path of the srt file
        /// </summary>
        public String srtPath
        {
            get
            {
                return _srtPath;
            }
            set
            {
                _srtPath = value;
                OnPropertyChanged("srtPath");
            }
        }
        /// <summary>
        /// List of Subtitles of a video
        /// </summary>
        public ObservableCollection<Subtitle> subtitlesCollection
        {
            get
            {
                return _subtitlesCollection;
            }
            set
            {
                _subtitlesCollection = value;
                OnPropertyChanged("subtitlesCollection");
            }
        }
        #endregion

        //Test

        /// <summary>
        /// Creates the subtitles of the video
        /// </summary>
        /// <param name="srtPath">Path of the video</param>
        public Subtitles(String srtPath)
        {
            srtPath = CreateSrtFileName(srtPath);
            subtitlesCollection = new ObservableCollection<Subtitle>();
        }

        /// <summary>
        /// Create the file name with the path
        /// </summary>
        /// <param name="originalPath">Path of the video file</param>
        /// <returns>Path of the srt file</returns>
        public String CreateSrtFileName(String originalPath)
        {
            String filePath;
            int endIndex = originalPath.Length;
            /* Remove the extension of the pah searching the '.' at the end */
            while(originalPath[endIndex] != '.')
            {    
                endIndex--;
            }
            filePath = originalPath.Remove(endIndex + 1);                                                                        //Remove chars from the '.' to the end
            return filePath;
        }

        /// <summary>
        /// Add a subtitle to the video
        /// </summary>
        /// <param name="startTime">Time when the subtitle will start</param>
        /// <param name="endTime">Time when the subtitle will end</param>
        /// <param name="text">Text that the subtitle will contain</param>
        public void AddSubtitle(String startTime, String endTime, String text)
        {
            Subtitle sub = new Subtitle(startTime, endTime, text);
            subtitlesCollection.Add(sub);
        }

        /// <summary>
        /// Edit a subtitle of the video
        /// </summary>
        /// <param name="index">Index of the subtitle in the list</param>
        /// <param name="startTime">Time when the subtitle will start</param>
        /// <param name="endTime">Time when the subtitle will end</param>
        /// <param name="text">Text that the subtitle will contain</param>
        public void EditSubtitle(int index, String startTime, String endTime, String text)
        {
            if(subtitlesCollection.Count > index)
                
        }
    }
}
