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
            lvEtapa1.Clear();
            if (cafe.pessoas1 != null)
            {
                foreach (var item in cafe.pessoas1)
                {
                    var listViewItem = new ListViewItem(item);
                    lvEtapa1.Items.Add(listViewItem);
                }
            }
            else
            {
                var listViewItem = new ListViewItem("Evento não organizado");
                lvEtapa1.Items.Add(listViewItem);
            }
            lvEtapa2.Clear();
            if (cafe.pessoas2 != null)
            {
                foreach (var item in cafe.pessoas2)
                {
                    var listViewItem = new ListViewItem(item);
                    lvEtapa2.Items.Add(listViewItem);
                }
            }
            else
            {
                var listViewItem = new ListViewItem("Evento não organizado");
                lvEtapa2.Items.Add(listViewItem);
            }
            labelConsultaCafeStatus.Text = "Espaço encontrado com sucesso!";
            labelConsultaCafeStatus.ForeColor = Color.Green;
        }
    }
}
