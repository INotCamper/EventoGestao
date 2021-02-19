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
    public partial class Gestao : Form
    {
        public Gestao()
        {
            InitializeComponent();
            ApplyDesign();
        }
        private void ApplyDesign()
        {
            //Esconde os submenus no início do programa
            panelCadastroSubMenu.Visible = false;
            panelConsultaSubMenu.Visible = false;
        }
        private void HideSubMenu()
        {
            if (panelCadastroSubMenu.Visible)
                panelCadastroSubMenu.Visible = false;
            if (panelConsultaSubMenu.Visible)
                panelConsultaSubMenu.Visible = false;
        }
        private void ShowSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        #region Cadastro
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelCadastroSubMenu);
        }

        private void btnCadastroPessoa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CadastroPessoa());
            HideSubMenu();
            // Abrir Cadastro de pessoa
        }

        private void btnCadastroEvento_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CadastroEvento());
            HideSubMenu();
            // Abrir Cadastro de evento
        }

        private void btnCadastroCafe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CadastroCafe());
            HideSubMenu();
            // Abrir Cadastro de cafe
        }
        #endregion

        #region Organizar
        private void btnOrganizar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Organizar());
            HideSubMenu();
            // Abrir Organizador
        }
        #endregion

        #region Consulta
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelConsultaSubMenu);
        }

        private void btnConsultaPessoa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ConsultaPessoa());
            HideSubMenu();
            // Abrir Pesquisa de pessoa
        }

        private void btnConsultaEvento_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ConsultaEvento());
            HideSubMenu();
            // Abrir Pesquisa de evento
        }

        private void btnConsultaCafe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ConsultaCafe());
            HideSubMenu();
            // Abrir Pesquisa de cafe
        }
        #endregion

        //Referencia do atual form aberto
        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            //Caso já exista um form aberto, fecha ele para abrir o form solicitado
            if (activeForm != null)
                activeForm.Close();
            //Torna o form solicitado o atual form aberto
            activeForm = childForm;
            //Customiza aparência do form para ficar dentro do panel sem parecer algo estranho
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            //Aplica o form aberto ao panel
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            //Coloca o form em cima do panel
            childForm.BringToFront();
            //Finalmente mostra o form
            childForm.Show();
        }
    }
}
