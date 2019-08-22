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
using Second;

namespace MyProject1
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void InsertNewButton_Click(object sender, RoutedEventArgs e)
        {
            string name = Convert.ToString(NameTextBox.Text);
            int cellPhone = Convert.ToInt32(CellPhoneTextBox.Text);
            string resultName;
            string resultCellphone;

            SecondFile validations = new SecondFile();
            resultName = validations.validarNome(name);
            resultCellphone = validations.validarCelular(cellPhone);
            nameTextBlock.Text = string.Format("Nome: {0}", resultName);
            CellTextBox.Text = string.Format("Celular: {0}", resultCellphone);
        }
    }
}
