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
    public partial class CadastroCafe : Form
    {
        private string file = "cafe.json";
        private List<Cafe> cafes = new List<Cafe>();
        private DataSerializer dt = new DataSerializer();
        public CadastroCafe()
        {
            InitializeComponent();
        }

        private void btnCloseCadastroCafe_Click(object sender, EventArgs e)
        {
            //Fecha o form
            this.Close();
        }

        private void btnCadastrarEvento_Click(object sender, EventArgs e)
        {
            //Recupera os cafes que estiverem salvos
            cafes = dt.JsonDeserializeCafe(file);
            if (cafes == null)
            {
                //se o arquivo nao existir, cria uma lista para conseguir adicionar o que foi solicitado
                cafes = new List<Cafe>();
            }
            //cria o cafe com o que foi preenchido
            Cafe ca = new Cafe(tbCafeNome.Text);
            //verifica se o nome está vazio
            if (string.IsNullOrEmpty(ca.nome))
            {
                labelCadastroCafeStatus.Text = "Nome de espaço de café inválido!";
                labelCadastroCafeStatus.ForeColor = Color.Red;
                tbCafeNome.Clear();
                return;
            }
            //verifica se esse café já existe
            foreach (var item in cafes)
            {
                if (item.nome == ca.nome)
                {
                    labelCadastroCafeStatus.Text = "Este espaço de café ja existe!";
                    labelCadastroCafeStatus.ForeColor = Color.Red;
                    tbCafeNome.Clear();
                }
            }
            //adiciona o cafe criado a lista de cafes
            cafes.Add(ca);
            //serializa a lista
            dt.JsonSerialize(cafes, file);
            //indica que o cafe foi adicionado com sucesso
            labelCadastroCafeStatus.Text = "Espaço de café adicionado com sucesso!";
            labelCadastroCafeStatus.ForeColor = Color.Green;
            tbCafeNome.Clear();
        }
    }
}
