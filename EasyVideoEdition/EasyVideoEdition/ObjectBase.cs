using System.ComponentModel;


namespace ObjectB
{
    /// <summary>
    /// Base class of all object. Allow it to be notified to the view
    /// </summary>
    class ObjectBase : INotifyPropertyChanged
    {
        /// <summary>
        /// Raise a change of the property
        /// </summary>
        /// <param name="propertyName">Name of the property</param>
        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}