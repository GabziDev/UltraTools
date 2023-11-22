using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltraTools
{
    public partial class InstallerForm : Form
    {
        private PopUp popUpInstance;

        public InstallerForm()
        {
            InitializeComponent();

            Informations informations = new Informations();
            Text = informations.TitleForm("Installeur");
            Icon = Properties.Resources.logo;
        }

        private void InstallerForm_Load(object sender, EventArgs e)
        {
            Informations informations = new Informations();
            labelFooter.Text = $"{informations.getAuthor()} - {informations.getCopyright()} - {informations.getVersion()}";

            popUpInstance = new PopUp();
            popUpInstance.Dev();
        }
    }
}
