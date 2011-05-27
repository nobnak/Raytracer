using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using StudyDiffuseShading.ViewModel;

namespace StudyDiffuseShading
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
        public const string KEY_MODEL = "MainWindowVMDataSource";


        private MainWindowVM model;


		public MainWindow()
		{
			this.InitializeComponent();

            this.model = (MainWindowVM) FindResource(KEY_MODEL);
		}

		private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
		{
            model.render((int) imageRendered.Width, (int) imageRendered.Height);
		}
	}
}