using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Shapes;
using OnStoreWPF.Annotations;
using OnStoreWPF.Models;

namespace OnStoreWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public ObservableCollection<Item> Items { get; set; }
        private ObservableCollection<ItemUC> _itemUCs;

        public ObservableCollection<ItemUC> ItemUCs
        {
            get => _itemUCs;
            set { _itemUCs = value; OnPropertyChanged(); }
        }

        public MainWindow()
        {
            InitializeComponent();
            PreviewKeyDown += HandleEsc;
            Items = new ObservableCollection<Item>();
            ItemUCs = new ObservableCollection<ItemUC>();
            DataContext = this;

            Item i1 = new Item
            {
                Id = 0,
                Name = "Cheetos",
                Price = 0.75,
                Quantity = 10,
                Image = "Assets/cheetos.png"
            };

            Item i2 = new Item
            {
                Id = 1,
                Name = "Coca-Cola Classic",
                Price = 1.5,
                Quantity = 35,
                Image = "Assets/cola classic.png"
            };

            Item i3 = new Item
            {
                Id = 2,
                Name = "Coca-Cola",
                Price = 1,
                Quantity = 46,
                Image = "Assets/cola.png"
            };

            Item i4 = new Item
            {
                Id = 3,
                Name = "Doritos",
                Price = 2.40,
                Quantity = 14,
                Image = "Assets/doritos.png"
            };
            Item i5 = new Item
            {
                Id = 4,
                Name = "Fanta",
                Price = 1,
                Quantity = 7,
                Image = "Assets/fanta.png"
            };
            Item i6 = new Item
            {
                Id = 5,
                Name = "Lay's",
                Price = 2.50,
                Quantity = 17,
                Image = "Assets/lays1.png"
            };
            Item i7 = new Item
            {
                Id = 6,
                Name = "Lay's",
                Price = 2.50,
                Quantity = 13,
                Image = "Assets/lays2.png"
            };
            Item i8 = new Item
            {
                Id = 7,
                Name = "M&M's",
                Price = 2.34,
                Quantity = 32,
                Image = "Assets/m&m's.png"
            };
            Item i9 = new Item
            {
                Id = 8,
                Name = "Oreo",
                Price = 1.52,
                Quantity = 14,
                Image = "Assets/oreo.png"
            };
            Items.Add(i1);
            Items.Add(i2);
            Items.Add(i3);
            Items.Add(i4);
            Items.Add(i5);
            Items.Add(i6);
            Items.Add(i7);
            Items.Add(i8);
            Items.Add(i9);
            foreach (var i in Items)
            {
                ItemUCs.Add(new ItemUC { Item = i });
            }
            
            foreach (var itemUC in ItemUCs)
            {
                itemUC.ItemUControl.Width = 200;
                itemUC.ItemUControl.Height = 230;

                itemUC.ItemUControl.Margin = new Thickness(4);
            }
        }

        private void HandleEsc(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Escape) return;
            Close();
        }

        private void Close_Click(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void ControlBox_Click(object sender, MouseButtonEventArgs e)
        {
            var elp = sender as Ellipse;

            switch (elp.Name)
            {
                case "close":
                    Close();
                    break;
                case "max":
                    WindowState = WindowState == WindowState.Normal ? WindowState.Maximized : WindowState.Normal;
                    break;
                default:
                    WindowState = WindowState.Minimized;
                    break;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void TextBoxBase_OnTextChanged(object sender, TextChangedEventArgs e)
        {
           /* if (string.IsNullOrWhiteSpace(TextBoxSearch.Text))
            {
                Items = Items ;
            }
            else
            {
                Prod = FilterByKeyword(TextBoxSearch.Text);
            }
            RefreshListBox(Prod);*/
        }
    }
}
