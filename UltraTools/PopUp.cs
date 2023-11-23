using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraTools
{
    internal class PopUp
    {
        public bool ScanPort()
        {
            string spTitre = "Attention !";
            string spMessage = "Nous tenons à vous rappeler que l'utilisation du scanneur de ports sans l'autorisation explicite du propriétaire du réseau local est illégale." +
                "\nRespectez les lois en vigueur sur l'accès non autorisé aux systèmes informatiques et assurez-vous d'obtenir une autorisation avant toute analyse de ports sur un réseau qui ne vous appartient pas." +
                "\nNous apprécions votre compréhension et votre coopération pour garantir une utilisation éthique de notre logiciel.";

            return MessageBox.Show(spMessage, spTitre, MessageBoxButtons.OKCancel) == DialogResult.OK;
        }

        public void Dev()
        {
            string dTitre = "Non disponible !";

            MessageBox.Show(null, dTitre, MessageBoxButtons.OK);
        }

        public void Erreur(string erreur)
        {
            string eTitre = "Une erreur est survenue";
            string eMessage = $"Erreur : {erreur}";

            MessageBox.Show(eMessage, eTitre, MessageBoxButtons.OK);
        }
    }
}
