using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectB;


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
        }

    }
}
