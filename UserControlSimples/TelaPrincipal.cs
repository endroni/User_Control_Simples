using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlSimples
{
    public partial class TelaPrincipal : Form
    {
        static TelaPrincipal _obj;

        public static TelaPrincipal Instance
        {
            get
            {
                if(_obj == null)
                {
                    _obj = new TelaPrincipal();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }

        public Button BotaoHome
        {
            get { return btnTelaInicial; }
            set { btnTelaInicial = value; }
        }

        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            _obj = this;

            UCHome uc = new UCHome();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
            
        }

        private void btnTelaInicial_Click(object sender, EventArgs e)
        {
            panelContainer.Controls["UCHome"].BringToFront();
        }

        private void btnContatos_Click(object sender, EventArgs e)
        {
            if (!TelaPrincipal.Instance.PnlContainer.Controls.ContainsKey("UCContatos"))
            {
                UCContatos un = new UCContatos();
                un.Dock = DockStyle.Fill;
                TelaPrincipal.Instance.PnlContainer.Controls.Add(un);
            }
            TelaPrincipal.Instance.PnlContainer.Controls["UCContatos"].BringToFront();
        }
    }
}
