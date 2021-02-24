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
            //Verifica se o nome é nulo
            if (string.IsNullOrEmpty(tbConsultaCafeNome.Text))
            {
                labelConsultaCafeStatus.Text = "Nome inválido!";
                labelConsultaCafeStatus.ForeColor = Color.Red;
                return;
            }
            //procura o café com base no nome
            cafe = dt.SearchCafe(tbConsultaCafeNome.Text, file);
            //verifica se esse cafe existe nos arquivos
            if (cafe == null)
            {
                //se não existir indica que não existe e para aqui
                labelConsultaCafeStatus.Text = "Espaço não encontrado!";
                labelConsultaCafeStatus.ForeColor = Color.Red;
                return;
            }
            //caso exista preenche a interface com os dados do objeto
            labelCafeNome.Text = cafe.nome;
            labelLotacao.Text = cafe.lotacao.ToString();
            //limpa a lista de itens
            lvEtapa1.Items.Clear();
            //preenche a lista de itens com cada pessoa
            if (cafe.pessoas1 != null)
            {
                foreach (var item in cafe.pessoas1)
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
            if (cafe.pessoas2 != null)
            {
                foreach (var item in cafe.pessoas2)
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
            labelConsultaCafeStatus.Text = "Espaço encontrado com sucesso!";
            labelConsultaCafeStatus.ForeColor = Color.Green;
        }
        //Uma função para evitar de se escrever o mesmo codigo multiplas vezes
        private void CreateAddListItem(string nome, ListView lv)
        {
            var listViewItem = new ListViewItem(nome);
            lv.Items.Add(listViewItem);
        }
    }    
}
