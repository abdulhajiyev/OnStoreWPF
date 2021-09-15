using System.ComponentModel;
using System.Runtime.CompilerServices;
using OnStoreWPF.Annotations;


namespace OnStoreWPF.Models
{
    public class Item : INotifyPropertyChanged
    {
        private int _id;
        public int Id
        {
            get => _id;
            set { _id = value; OnPropertyChanged(); }
        }
        private string _name;
        public string Name
        {
            get => _name;
            set { _name = value; OnPropertyChanged(); }
        }
        private double _price;
        public double Price
        {
            get => _price;
            set { _price = value; OnPropertyChanged(); }
        }
        private int _quantity;
        public int Quantity
        {
            get => _quantity;
            set { _quantity = value; OnPropertyChanged(); }
        }
        private string _image;
        public string Image
        {
            get => _image;
            set { _image = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
