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
    public partial class Organizar : Form
    {
        private string filePessoa = "pessoas.json";
        private string fileEvento = "evento.json";
        private string fileCafe = "cafe.json";
        private List<Pessoa> pessoas = new List<Pessoa>();
        private List<Evento> eventos = new List<Evento>();
        private List<Cafe> cafes = new List<Cafe>();
        private DataSerializer dt = new DataSerializer();
        public Organizar()
        {
            InitializeComponent();
            lvStatus.View = View.Details;
            lvStatus.Columns.Add("Status").Width = lvStatus.Width;
        }

        private void btnCloseOrganizar_Click(object sender, EventArgs e)
        {
            //Fecha o form
            this.Close();
        }

        private void btnOrganizar_Click(object sender, EventArgs e)
        {
            pessoas = dt.JsonDeserializePessoas(filePessoa);
            eventos = dt.JsonDeserializeEvento(fileEvento);
            cafes = dt.JsonDeserializeCafe(fileCafe);

            //quantidade de pessoas por sala de evento
            int pessoasPorSala = pessoas.Count / eventos.Count;
            int pessoasSobrandoNaDivisaoPorSala = pessoas.Count % eventos.Count;

            //verificar se salas tem capacidade para todas pessoas
            for (int i = 0; i < eventos.Count; i++)
            {
                if (eventos[i].lotacao < pessoasPorSala)
                {
                    CreateAndAddNewErrorListItem("Salas não tem capacidade para todos alunos.");
                    CreateAndAddNewErrorListItem("caso continue a diferença entre salas será maior do que uma pessoa!");
                    return;
                }
            }
            //dividir as pessoas
            //colocar elas nas salas de evento e aplicar a sala de evento nelas
            List<Pessoa> pe = new List<Pessoa>();
            List<string> nomeCompleto = new List<string>();
            for (int i = 0; i < pessoas.Count; i += pessoasPorSala)
            {
                if (pessoasSobrandoNaDivisaoPorSala > 0)
                {
                    pe.Add(pessoas[pessoas.Count - pessoasSobrandoNaDivisaoPorSala]);
                    pessoas[pessoas.Count - pessoasSobrandoNaDivisaoPorSala].evento1 = eventos[i > 0 ? i / pessoasPorSala : i].nome;
                    pessoasSobrandoNaDivisaoPorSala--;
                }
                for (int j = 0; j < pessoasPorSala; j++)
                {
                    if (i + pessoasPorSala > pessoas.Count)
                        break;
                    pe.Add(pessoas[i + j]);
                    pessoas[i + j].evento1 = eventos[i > 0 ? i / pessoasPorSala : i].nome;
                }
                if (i + pessoasPorSala > pessoas.Count)
                    break;
                foreach (var item in pe)
                {
                    nomeCompleto.Add(item.nome + " " + item.sobrenome);
                }
                eventos[i > 0 ? i / pessoasPorSala : i].pessoas1 = nomeCompleto.ToArray();
                nomeCompleto.Clear();
                pe.Clear();
            }
            CreateAndAddNewNominalListItem("Primeiro evento criado!");
            pbStatus.Value = 25;

            //dividir pessoas para cafe

            int pessoasPorEspaco = pessoas.Count / cafes.Count;
            int pessoasSobrandoNaDivisaoPorEspaco = pessoas.Count % cafes.Count;

            for (int i = 0; i < pessoas.Count; i += pessoasPorEspaco)
            {
                if (pessoasSobrandoNaDivisaoPorEspaco > 0)
                {
                    pe.Add(pessoas[pessoas.Count - pessoasSobrandoNaDivisaoPorEspaco]);
                    pessoas[pessoas.Count - pessoasSobrandoNaDivisaoPorEspaco].cafe1 = cafes[i > 0 ? i / pessoasPorEspaco : i].nome;
                    pessoasSobrandoNaDivisaoPorEspaco--;
                }
                for (int j = 0; j < pessoasPorEspaco; j++)
                {
                    if (i + pessoasPorEspaco > pessoas.Count)
                        break;
                    pe.Add(pessoas[i + j]);
                    pessoas[i + j].cafe1 = cafes[i > 0 ? i / pessoasPorEspaco : i].nome;
                }
                if (i + pessoasPorEspaco > pessoas.Count)
                    break;
                foreach (var item in pe)
                {
                    nomeCompleto.Add(item.nome + " " + item.sobrenome);
                }
                cafes[i > 0 ? i / pessoasPorEspaco : i].pessoas1 = nomeCompleto.ToArray();
                nomeCompleto.Clear();
                pe.Clear();
            }
            CreateAndAddNewNominalListItem("Primeiro café criado!");
            pbStatus.Value = 50;
        }

        private void CreateAndAddNewErrorListItem(string texto)
        {
            var listViewItem = new ListViewItem(texto);
            listViewItem.ForeColor = Color.Red;
            lvStatus.Items.Add(listViewItem);
        }

        private void CreateAndAddNewNominalListItem(string texto)
        {
            var listViewItem = new ListViewItem(texto);
            listViewItem.ForeColor = Color.Green;
            lvStatus.Items.Add(listViewItem);
        }
    }
}
