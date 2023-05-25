using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
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
using System.Xml.Serialization;

namespace Учёт_бюджета
{
    public partial class MainWindow : Window
    {
        public string a;
        public Conteiners appData;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            appData = new Conteiners();

            appData.entry.Add(new Accounting("Александрова Ева Егоровна", "Вычет из Гос. бюджета", 500000, true, new DateTime(2023, 03, 18)));
            appData.entry.Add(new Accounting("Самсонов Артемий Андреевич", "Налоговый вычет", 16800, true, new DateTime(2023, 01, 01)));
            appData.entry.Add(new Accounting("Фомина Ксения Ярославовна", "Доход от продажи одежды", 31450, false, new DateTime(2023, 05, 10)));
            appData.entry.Add(new Accounting("Лебедев Илья Маркович", "Доход от крупной сети ресторанов", 65000, false, new DateTime(2023, 03, 18)));
            appData.entry.Add(new Accounting("Романов Владислав Борисович", "Налоговый вычет", 23000, true, new DateTime(2023, 03, 18)));
            appData.entry.Add(new Accounting("Петров Руслан Матвеевич", "Вычет из-за нераспроданного товара", 200000, true, new DateTime(2023, 05, 10)));
            appData.entry.Add(new Accounting("Комаров Тимофей Игнатиевич", "Налоговый вычет", 30000, true, new DateTime(2023, 01, 30)));
            appData.entry.Add(new Accounting("Зиновьева Ясмина Артёмовна", "Вычет из бухгалтерии", 34500, true, new DateTime(2023, 03, 18)));
            appData.entry.Add(new Accounting("Воронцова София Михайловна", "Налоговый вычет", 16800, true, new DateTime(2023, 03, 18)));
            appData.entry.Add(new Accounting("Никитина Мария Львовна", "Вычет из-за нераспроданного товара", 32000, true, new DateTime(2023, 01, 01)));

            appData.entryTypes.Add("Налоговый вычет");
            appData.entryTypes.Add("Доход от вклада");
            appData.entryTypes.Add("Вычет из Гос. бюджета");
            appData.entryTypes.Add("Вычет из бухгалтерии");
            appData.entryTypes.Add("Доход от крупной сети ресторанов");
            appData.entryTypes.Add("Вычет из-за нераспроданного товара");
            appData.entryTypes.Add("Доход от продажи одежды");

            for (int i = 0; i < appData.entry.Count; i++)
            {
                if (!appData.dates.Contains(appData.entry[i].date))
                    appData.dates.Add(appData.entry[i].date);
            }

            MyDG.Items.Clear();
            MyDG.ItemsSource = appData.entry;
            DatePicker.ItemsSource = appData.dates;
            DGColumn.ItemsSource = appData.entryTypes;
        }

        private void Razer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DatePicker.SelectedIndex = -1;
            MyDG.ItemsSource = appData.entry;
        }

        private void RecordDatePicker_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DatePicker.SelectedIndex != -1)
                MyDG.ItemsSource = appData.entry.Where(a => a.date == (DateTime)DatePicker.SelectedValue).ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MyInputBox.Text = a;
            //Razer.ItemsSource = appData.entry.Add(a);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
    public class Accounting
    {
        public string name { get; set; }
        public string entrytype { get; set; }
        public double money { get; set; }
        public bool deduction { get; set; }
        public DateTime date { get; set; }

        public Accounting() { }
        public Accounting(string name, string entrytype, double money, bool deduction, DateTime date)
        {
            this.name = name;
            this.entrytype = entrytype;
            this.money = money;
            this.deduction = deduction;
            this.date = date;
        }
    }

    public class Conteiners
    {
        public List<Accounting> entry;
        public List<string> entryTypes;
        public List<DateTime> dates;

        public Conteiners()
        {
            entry = new List<Accounting>();
            dates = new List<DateTime>();
            entryTypes = new List<string>();
        }
    }
    
}
