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
    public partial class ConsultaCafe : Form
    {
        private string file = "cafe.json";
        private Cafe cafe = new Cafe();
        private DataSerializer dt = new DataSerializer();
        public ConsultaCafe()
        {
            InitializeComponent();
            lvEtapa1.View = View.Details;
            lvEtapa1.Columns.Add("Pessoas").Width = lvEtapa1.Width;
            lvEtapa2.View = View.Details;
            lvEtapa2.Columns.Add("Pessoas").Width = lvEtapa2.Width;
        }

        private void btnCloseConsultaCafe_Click(object sender, EventArgs e)
        {
            //Fecha o form
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbConsultaCafeNome.Text))
            {
                labelConsultaCafeStatus.Text = "Nome inválido!";
                labelConsultaCafeStatus.ForeColor = Color.Red;
                return;
            }
            cafe = dt.SearchCafe(tbConsultaCafeNome.Text, file);
            if (cafe == null)
            {
                labelConsultaCafeStatus.Text = "Espaço não encontrado!";
                labelConsultaCafeStatus.ForeColor = Color.Red;
                return;
            }
            labelCafeNome.Text = cafe.nome;
            lvEtapa1.Items.Clear();
            if (cafe.pessoas1 != null)
            {
                foreach (var item in cafe.pessoas1)
                {
                    CreateAddListItem(item, lvEtapa1);
                }
            }
            else
            {
                CreateAddListItem("Evento não organizado", lvEtapa1);
            }
            lvEtapa2.Items.Clear();
            if (cafe.pessoas2 != null)
            {
                foreach (var item in cafe.pessoas2)
                {
                    CreateAddListItem(item, lvEtapa2);
                }
            }
            else
            {
                CreateAddListItem("Evento não organizado", lvEtapa2);
            }
            labelConsultaCafeStatus.Text = "Espaço encontrado com sucesso!";
            labelConsultaCafeStatus.ForeColor = Color.Green;
        }
        private void CreateAddListItem(string nome, ListView lv)
        {
            var listViewItem = new ListViewItem(nome);
            lv.Items.Add(listViewItem);
        }
    }    
}
