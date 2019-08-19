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
using CursosLibNS;

namespace CursoWpfProj
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ExibeCurso(object sender, RoutedEventArgs e)
        {
            int codigo = Convert.ToInt32(CodigoCursoTextBox.Text);
            string nomeCurso;
            CursosClass objCurso = new CursosClass();
            nomeCurso = objCurso.ExibirNomeCurso(codigo);
            ExibeNomeCursoTextBlock.Text = string.Format("{0} - {1}", codigo, nomeCurso);
        }
    }
}
