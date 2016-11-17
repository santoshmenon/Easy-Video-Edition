using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectB
{
    /// <summary>
    /// Class to implement to use PropertyChanged
    /// </summary>
    public abstract class ObjectBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Notify a change of a property
        /// </summary>
        /// <param name="PropertyName">Name of the property</param>
        protected internal void OnPropertyChanged(String PropertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }
    }
}
