using Examen.Model;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace Examen
{
    public partial class MainWindow : Window
    {
        private readonly VlasenkoDemoExContext _context;
        private ObservableCollection<Client> _clients;

        public MainWindow()
        {
            InitializeComponent();
            _context = new VlasenkoDemoExContext();
            LClients();
        }

        //загрузка данных из бд в таблицу
        private void LClients()
        {
            DateTime today = DateTime.Today;
            _clients = new ObservableCollection<Client>(
                _context.Clients
                    .Select(c => new Client
                    {
                        Id = c.Id,
                        Familiya = c.Familiya,
                        Imya = c.Imya,
                        Otchestvo = c.Otchestvo,
                    })
                    .ToList());

            ClientsDataGrid.ItemsSource = _clients;
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            EddingDate editingWindow = new EddingDate()
            {
                Owner = this
            };

            this.Hide();
            editingWindow.ShowDialog();
            this.Show();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddData addWindow = new AddData()
            {
                Owner = this
            };

            this.Hide();
            addWindow.ShowDialog();
            this.Show();
        }
    }
}