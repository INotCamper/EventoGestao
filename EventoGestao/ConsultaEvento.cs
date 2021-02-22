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
            if (string.IsNullOrEmpty(tbConsultaEventoNome.Text))
            {
                labelConsultaEventoStatus.Text = "Nome inválido!";
                labelConsultaEventoStatus.ForeColor = Color.Red;
                return;
            }
            evento = dt.SearchEvento(tbConsultaEventoNome.Text, file);
            if (evento == null)
            {
                labelConsultaEventoStatus.Text = "Sala não encontrada!";
                labelConsultaEventoStatus.ForeColor = Color.Red;
                return;
            }
            labelSalaNome.Text = evento.nome;
            labelSalaLotacao.Text = evento.lotacao.ToString();
            lvEtapa1.Items.Clear();
            if (evento.pessoas1 != null)
            {
                foreach (var item in evento.pessoas1)
                {
                    CreateAddListItem(item, lvEtapa1);
                }
            }
            else
            {
                CreateAddListItem("Evento não organizado", lvEtapa1);
            }
            lvEtapa2.Items.Clear();
            if (evento.pessoas2 != null)
            {
                foreach (var item in evento.pessoas2)
                {
                    CreateAddListItem(item, lvEtapa2);
                }
            }
            else
            {
                CreateAddListItem("Evento não organizado", lvEtapa2);
            }
            labelConsultaEventoStatus.Text = "Sala encontrada com sucesso!";
            labelConsultaEventoStatus.ForeColor = Color.Green;
        }
        private void CreateAddListItem(string nome, ListView lv)
        {
            var listViewItem = new ListViewItem(nome);
            lv.Items.Add(listViewItem);
        }
    }
}
