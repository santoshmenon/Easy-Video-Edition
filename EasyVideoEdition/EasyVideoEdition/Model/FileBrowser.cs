﻿using Microsoft.Win32;
using System.IO;

namespace EasyVideoEdition.Model
{
    /// <summary>
    /// Allow to open a video 
    /// </summary>
    class FileBrowser : ObjectBase
    {
        #region Attributes
        private string _filePath;
        private string _fileTempPath;
        private string _fileName;
        private byte[] _fileData;
        private long _fileSize;
        private bool _canOpenFile;
        private FileStream _stream;
        #endregion

        #region Get/Set
        /// <summary>
        /// Contains the stream of the file.
        /// </summary>
        public FileStream stream
        {
            get
            {
                return _stream;
            }
            set
            {
                _stream = value;
                RaisePropertyChanged("stream");
            }
        }

        /// <summary>
        /// Contains the filePath of the file.
        /// </summary>
        public string filePath
        {
            get
            {
                return _filePath;
            }
            set
            {
                _filePath = value;
                RaisePropertyChanged("filePath");
            }
        }

        /// <summary>
        /// Contains the temporary filePath of the file. It's where the soft clone the original file. 
        /// </summary>
        public string fileTempPath
        {
            get
            {
                return _fileTempPath;
            }
            set
            {
                _fileTempPath = value;
                RaisePropertyChanged("fileTempPath");
            }
        }

        /// <summary>
        /// Indicate that a file can be opened. Or not. 
        /// </summary>
        public bool canOpenFile
        {
            get
            {
                return _canOpenFile;
            }
            set
            {
                _canOpenFile = value;
                RaisePropertyChanged("canOpenFile");
            }
        }

        /// <summary>
        /// Contains the file name.
        /// </summary>
        public string fileName
        {
            get
            {
                return _fileName;
            }
            set
            {
                _fileName = value;
                RaisePropertyChanged("fileName");
            }
        }

        /// <summary>
        /// Contains the file data.
        /// </summary>
        public byte[] fileData
        {
            get
            {
                return _fileData;
            }
            set
            {
                _fileData = value;
                RaisePropertyChanged("fileData");
            }
        }

        /// <summary>
        /// Contains the size of the file
        /// </summary>
        public long fileSize
        {
            get
            {
                return _fileSize;
            }
            set
            {
                _fileSize = value;
                RaisePropertyChanged("fileSize");
            }
        }

        #endregion

        public FileBrowser()
        {
            canOpenFile = true;
        }

        /// <summary>
        /// This method allow the user to open a file brower. The file path is stocked in the attribute filePath.
        /// </summary>
        public void OpenFile()
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Multiselect = false;

            if (opf.ShowDialog() != false)
            {
                filePath = opf.FileName;

                stream = File.OpenRead(filePath);
                fileSize = stream.Length;
                canOpenFile = false;
            }
        }
    }
}
