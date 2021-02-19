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
    public partial class ConsultaPessoa : Form
    {
        public ConsultaPessoa()
        {
            InitializeComponent();
        }

        private void btnCloseConsultaPessoa_Click(object sender, EventArgs e)
        {
            //Fecha o form
            this.Close();
        }
    }
}
