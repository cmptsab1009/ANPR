using DesignApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DesignApp.Views
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        List<ListData> data = new List<ListData>(); 
        public HomePage()
        {
            InitializeComponent();
            FillListData();
            
        }

        private void FillListData()
        {
            data.Add(new ListData { Date = "01/01/01", Lane = "1", PlateNumber = "0001", Country = "India", VehNo = "ind04", Status = "Ready", Color = "Red", BgColor = "greeen", Categorytype = "1", Type = "1" });
            data.Add(new ListData { Date = "02/01/01", Lane = "2", PlateNumber = "0002", Country = "India", VehNo = "ind05", Status = "Ready", Color = "Red", BgColor = "greeen", Categorytype = "2", Type = "2" });
            data.Add(new ListData { Date = "03/01/01", Lane = "3", PlateNumber = "0003", Country = "India", VehNo = "ind01", Status = "Ready", Color = "Red", BgColor = "greeen", Categorytype = "3", Type = "3" });
            data.Add(new ListData { Date = "04/01/01", Lane = "4", PlateNumber = "0004", Country = "India", VehNo = "ind03", Status = "Ready", Color = "Red", BgColor = "greeen", Categorytype = "4", Type = "4" });
            data.Add(new ListData { Date = "05/01/01", Lane = "5", PlateNumber = "0005", Country = "India", VehNo = "ind02", Status = "Ready", Color = "Red", BgColor = "greeen", Categorytype = "5", Type = "5" });
            listDetails.ItemsSource = data;
        }
    }
}
