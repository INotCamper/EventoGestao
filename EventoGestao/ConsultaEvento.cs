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
    public partial class ConsultaEvento : Form
    {
        private string file = "evento.json";
        private Evento evento = new Evento();
        private DataSerializer dt = new DataSerializer();
        public ConsultaEvento()
        {
            InitializeComponent();
            lvEtapa1.View = View.Details;
            lvEtapa1.Columns.Add("Pessoas").Width = lvEtapa1.Width;
            lvEtapa2.View = View.Details;
            lvEtapa2.Columns.Add("Pessoas").Width = lvEtapa2.Width;
        }

        private void btnCloseConsultaEvento_Click(object sender, EventArgs e)
        {
            //Fecha o form
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //Verifica se o nome é nulo
            if (string.IsNullOrEmpty(tbConsultaEventoNome.Text))
            {
                labelConsultaEventoStatus.Text = "Nome inválido!";
                labelConsultaEventoStatus.ForeColor = Color.Red;
                return;
            }
            //procura o evento com base no nome
            evento = dt.SearchEvento(tbConsultaEventoNome.Text, file);
            //verifica se esse evento existe nos arquivos
            if (evento == null)
            {
                //se não existir indica que não existe e para aqui
                labelConsultaEventoStatus.Text = "Sala não encontrada!";
                labelConsultaEventoStatus.ForeColor = Color.Red;
                return;
            }
            //caso exista preenche a interface com os dados do objeto
            labelSalaNome.Text = evento.nome;
            labelSalaLotacao.Text = evento.lotacao.ToString();
            //limpa a lista de itens
            lvEtapa1.Items.Clear();
            //preenche a lista de itens com cada pessoa
            if (evento.pessoas1 != null)
            {
                foreach (var item in evento.pessoas1)
                {
                    CreateAddListItem(item, lvEtapa1);
                }
            }
            else
            {
                //se a lista de pessoas for nula o evento não foi organizado
                CreateAddListItem("Evento não organizado", lvEtapa1);
            }
            //limpa a lista de itens
            lvEtapa2.Items.Clear();
            //preenche a lista de itens com cada pessoa
            if (evento.pessoas2 != null)
            {
                foreach (var item in evento.pessoas2)
                {
                    CreateAddListItem(item, lvEtapa2);
                }
            }
            else
            {
                //se a lista de pessoas for nula o evento não foi organizado
                CreateAddListItem("Evento não organizado", lvEtapa2);
            }
            //informa que o item foi encontrado
            labelConsultaEventoStatus.Text = "Sala encontrada com sucesso!";
            labelConsultaEventoStatus.ForeColor = Color.Green;
        }
        //Uma função para evitar de se escrever o mesmo codigo multiplas vezes
        private void CreateAddListItem(string nome, ListView lv)
        {
            var listViewItem = new ListViewItem(nome);
            lv.Items.Add(listViewItem);
        }
    }
}
