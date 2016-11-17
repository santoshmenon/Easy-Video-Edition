using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// namespace: EasyVideoEdition.Model
//
// summary:	.
namespace EasyVideoEdition.Model
{
   
    /// <summary>   A file browser. </summary>
    ///
    /// <remarks>   Théo, 10/11/2016. </remarks>
    
    class FileBrowser : ObjectBase
    {
        #region Attributes
        private string _filePath;
        private byte[] _fileData;

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
        #endregion

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
            }

            fileData = File.ReadAllBytes(filePath);
        }

        public void SaveFile()
        {
            SaveFileDialog svf = new SaveFileDialog();
           
            if (svf.ShowDialog() != false)
            {
                FileStream fs = new FileStream(svf.FileName, FileMode.Create);
                fs.Write(fileData, 0, fileData.Length);
            }
          
        }

    }
}
