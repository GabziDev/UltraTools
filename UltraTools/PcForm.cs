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
    public partial class PcForm : Form
    {
        private PopUp popUpInstance;

        public PcForm()
        {
            InitializeComponent();
        }

        private void PcForm_Load(object sender, EventArgs e)
        {
            Informations informations = new Informations();
            labelFooter.Text = $"{informations.getAuthor()} - {informations.getCopyright()} - {informations.getVersion()}";

            popUpInstance = new PopUp();
            popUpInstance.Dev();
        }
    }
}
