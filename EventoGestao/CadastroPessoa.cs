using EventoGestao.Objects;
using EventoGestao.Data;
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
    public partial class CadastroPessoa : Form
    {
        private string file = "pessoas.json";
        private List<Pessoa> pessoas = new List<Pessoa>();
        private DataSerializer dt = new DataSerializer();
        public CadastroPessoa()
        {
            InitializeComponent();
        }

        private void btnCloseCadastroPessoa_Click(object sender, EventArgs e)
        {
            //Fecha o form
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Recupera a lista de pessoas do arquivo salvo.
            pessoas = dt.JsonDeserializePessoas(file);
            if (pessoas==null)
            {
                //caso o arquivo nao exista, a variavel ficará nula, logo não seria possivel adicionar algo nela, apenas segurança caso seja a primeira vez abrindo o programa.
                pessoas = new List<Pessoa>();
            }
            //Cria a pessoa
            Pessoa p = new Pessoa(tbCadastroPessoaNome.Text, tbCadastroPessoaSobrenome.Text);
            //Verifica se o nome está vazio
            if (string.IsNullOrEmpty(p.nome))
            {
                labelCadastroPessoaStatus.Text = "Nome está vazio!";
                labelCadastroPessoaStatus.ForeColor = Color.Red;
                return;
            }
            //verifica se o sobrenome está vazio
            else if (string.IsNullOrEmpty(p.sobrenome))
            {
                labelCadastroPessoaStatus.Text = "Sobrenome está vazio!";
                labelCadastroPessoaStatus.ForeColor = Color.Red;
                return;
            }
            //Procura para ver se ela já existe
            foreach (var item in pessoas)
            {
                if (item.nome == p.nome && item.sobrenome == p.sobrenome)
                {
                    //Caso o nome e sobrenome sejam iguais, retorna avisando que essa pessoa já existe.
                    //uma maneira de não precisar disto seria usar um id para cada um, mas isso é algo mais facil de ser gerado com um DB, já que muitos criam o id sozinho.
                    labelCadastroPessoaStatus.Text = "Esta pessoa já existe!";
                    labelCadastroPessoaStatus.ForeColor = Color.Red;
                    tbCadastroPessoaNome.Clear();
                    tbCadastroPessoaSobrenome.Clear();
                    return;
                }
            }
            //Adiciona a pessoa a lista já adquirida
            pessoas.Add(p);
            //Grava o arquivo
            dt.JsonSerialize(pessoas, file);
            //Informa que a pessoa foi adicionada com sucesso
            labelCadastroPessoaStatus.Text = "Pessoa adicionada com sucesso!";
            labelCadastroPessoaStatus.ForeColor = Color.Green;
            tbCadastroPessoaNome.Clear();
            tbCadastroPessoaSobrenome.Clear();
        }
    }
}
