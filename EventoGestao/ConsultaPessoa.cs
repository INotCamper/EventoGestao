using EventoGestao.Data;
using EventoGestao.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventoGestao
{
    public partial class ConsultaPessoa : Form
    {
        private string file = "pessoas.json";
        private Pessoa pessoa = new Pessoa();
        private DataSerializer dt = new DataSerializer();
        public ConsultaPessoa()
        {
            InitializeComponent();
        }

        private void btnCloseConsultaPessoa_Click(object sender, EventArgs e)
        {
            //Fecha o form
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbConsultaPessoaNome.Text))
            {
                labelConsultaPessoaStatus.Text = "Nome inválido!";
                labelConsultaPessoaStatus.ForeColor = Color.Red;
                return;
            }
            else if (string.IsNullOrEmpty(tbConsultaPessoaSobrenome.Text))
            {
                labelConsultaPessoaStatus.Text = "Sobrenome inválido!";
                labelConsultaPessoaStatus.ForeColor = Color.Red;
                return;
            }
            pessoa = dt.SearchPessoa(tbConsultaPessoaNome.Text, tbConsultaPessoaSobrenome.Text, file);
            if (pessoa == null)
            {
                labelConsultaPessoaStatus.Text = "Pessoa não encontrada!";
                labelConsultaPessoaStatus.ForeColor = Color.Red;
                return;
            }
            labelNome.Text = pessoa.nome;
            labelSobrenome.Text = pessoa.sobrenome;
            labelSala1.Text = pessoa.evento1 == null ? "Treinamento não foi organizado" : pessoa.evento1;
            labelCafe1.Text = pessoa.cafe1 == null ? "Treinamento não foi organizado" : pessoa.cafe1;
            labelSala2.Text = pessoa.evento2 == null ? "Treinamento não foi organizado" : pessoa.evento2;
            labelCafe2.Text = pessoa.cafe2 == null ? "Treinamento não foi organizado" : pessoa.cafe2;
            labelConsultaPessoaStatus.Text = "Pessoa encontrada com sucesso!";
            labelConsultaPessoaStatus.ForeColor = Color.Green;
        }
    }
}
