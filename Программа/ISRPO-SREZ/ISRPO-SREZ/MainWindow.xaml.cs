using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
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


namespace ISRPO_SREZ
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            string dateStart = dp1.ToString();
            var dateStartSplitProbel  = dateStart.Split(' ');
            var dateStartSplitTochka = dateStartSplitProbel[0].Split('.');
            var datestartend = "" + dateStartSplitTochka[1] + "." + dateStartSplitTochka[0] + "." + dateStartSplitTochka[2] + "";
            dateStart = datestartend;
            string dateEnd = dp2.ToString();
            var dateEndSplitProbel = dateEnd.Split(' ');
            var dateEndSplitTochka = dateEndSplitProbel[0].Split('.');
            var dateendend = "" + dateEndSplitTochka[1] + "." + dateEndSplitTochka[0] + "." + dateEndSplitTochka[2] + "";
            dateEnd = dateendend;
            var json = client.DownloadString($"https://localhost:7100/api/Sale?dateStart="+ dateStart + "&dateEnd=" + dateEnd + "");
            List<Models.Sale> sales = JsonConvert.DeserializeObject<List<Models.Sale>>(json);           
            List<Models.Sale> sa1s = new List<Models.Sale>();
            foreach (Models.Sale sale in sales)
            {           
                sa1s.AddRange(sales);               
            }
            kara.ItemsSource = sa1s;
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {         
        }
    }
}
