using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using OnStoreWPF.Annotations;
using OnStoreWPF.Models;

namespace OnStoreWPF
{
    /// <summary>
    /// Interaction logic for ItemUC.xaml
    /// </summary>
    public partial class ItemUC : UserControl, INotifyPropertyChanged
    {

        public bool isOpen { get; set; }

        private Item _item;

        public Item Item
        {
            get => _item;
            set
            {
                _item = value;
                OnPropertyChanged();
            }
        }


        public ItemUC()
        {
            InitializeComponent();
            DataContext = this;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void ItemUControl_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            isOpen = true;
        }
    }
}
