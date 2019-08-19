using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CursosLibNS;

namespace CursoFormsAppProjNS
{
    public partial class Form1 : Form
    {
        public Form1() // construtor
        {
            InitializeComponent();
            exibiCursoButton.Click += QualquerNomeDeFuncao;
        }

        private void exibiCursoButton_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(codigoCursoTextBox.Text);
            string nomeCurso;
            CursosClass objCurso = new CursosClass();
            nomeCurso = objCurso.ExibirNomeCurso(codigo);
            nomeCursoLabel.Text = string.Format("{0} - {1}", codigo, nomeCurso);
        }

        private void QualquerNomeDeFuncao(object sender, EventArgs e)
        {
            MessageBox.Show("Testando o MultCast delegate", "Event Click");
        }

        private void ExibiCursoButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
