using EasyVideoEdition.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace EasyVideoEdition.ViewModel
{
    class MainViewModel : ObjectBase
    {
        #region Attributes

        #endregion


        #region CommandList
        /// <summary>
        /// THIS IS A TEST !
        /// </summary>
        public ICommand TestCommand
        {
            get; private set;
        }
        #endregion

        /// <summary>
        /// Creation of the MainViewModel. Nottably, create the commands.  
        /// </summary>
        public MainViewModel()
        {
            TestCommand = new RelayCommand(ThisIsATest);
        }

        private void ThisIsATest()
        {
            MessageBox.Show("THIS IS A FUCKING TEST");
        }

        #region CommandDefinition

        #endregion
    }
}
