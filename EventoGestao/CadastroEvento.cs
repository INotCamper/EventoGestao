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
    public partial class CadastroEvento : Form
    {
        private string file = "evento.json";
        private List<Evento> eventos = new List<Evento>();
        private DataSerializer dt = new DataSerializer();
        public CadastroEvento()
        {
            InitializeComponent();
        }

        private void btnCloseCadastroEvento_Click(object sender, EventArgs e)
        {
            //Fecha o form
            this.Close();
        }

        private void btnCadastrarEvento_Click(object sender, EventArgs e)
        {
            //Recupera os eventos salvos
            eventos = dt.JsonDeserializeEvento(file);
            if (eventos== null)
            {
                //Caso o retorno seja nulo, cria um novo sem nenhum dado para poder ser preenchido.
                eventos = new List<Evento>();
            }
            //Cria o evento com o que estiver colocado
            Evento ev = new Evento(tbEventoNome.Text, (int)numLotacao.Value);
            //verifica se o nome está vazio
            if (string.IsNullOrEmpty(ev.nome))
            {
                labelCadastroEventoStatus.Text = "Nome da sala está vazio!";
                labelCadastroEventoStatus.ForeColor = Color.Red;
                return;
            }
            //verifica se a lotação foi inserida
            else if (numLotacao.Value <= 0)
            {
                labelCadastroEventoStatus.Text = "Lotação inválida";
                labelCadastroEventoStatus.ForeColor = Color.Red;
                return;
            }
            //procura se já existe um evento com esse nome
            foreach (var item in eventos)
            {
                if (item.nome == ev.nome)
                {
                    labelCadastroEventoStatus.Text = "Esta sala de evento já existe!";
                    labelCadastroEventoStatus.ForeColor = Color.Red;
                    tbEventoNome.Clear();
                    numLotacao.Value = 1;
                }
            }
            //adiciona o evento ao grupo de eventos
            eventos.Add(ev);
            //serializa os eventos
            dt.JsonSerialize(eventos, file);
            //Informa que o evento foi adicionado com sucesso
            labelCadastroEventoStatus.Text = "Sala de evento adicionado com sucesso!";
            labelCadastroEventoStatus.ForeColor = Color.Green;
            tbEventoNome.Clear();
            numLotacao.Value = 0;
        }
    }
}
