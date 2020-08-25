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

namespace EFTest
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		EF baza = new EF();

		private string _pretraga;
		public string Pretraga 
		{
			get => _pretraga;

			set
			{
				_pretraga = value;
				baza = new EF();
				dg.ItemsSource = baza.Osobas.Where(o => o.Ime.Contains(_pretraga)).ToList();
			}
		}
		public MainWindow()
		{
			InitializeComponent();
			DataContext = this;
			dg.ItemsSource = baza.Osobas.ToList();
		}

		private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			baza.SaveChanges();
		}
	}
}
