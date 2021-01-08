using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;
using DataContracts;

namespace Projet1
{
    public partial class Form1 : Form
    {
        Sac sac;
        List<Objet> notreListeObjet = new List<Objet>();

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sac = new SacRapportValPoid();
            notreListeObjet = sac.getObjets();
            dataGridView1.DataSource = notreListeObjet;
            buttonMeilleurCombinaison.Visible = true;
            dataGridView2.Rows.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            List<Objet> result=new List<Objet>();
            if (radioSacDynamique.Checked)
            {
                sac = new SacDynamique(notreListeObjet);
            }
            if (radioSacGlouton.Checked)
            {
                sac = new SacRapportValPoid();
            }
            if (radioSacComplet.Checked)
            {
                sac = new SacComplet();
            }
            sac.sac= new List<Objet>();
            sac.grosLot(notreListeObjet);
            result = sac.sac;
            int valeur = 0;
            foreach(Objet re in result)
            {
                string[] row =
                {
                    ""+re.nom, ""+re.poid, ""+re.valeur
                };
                valeur += re.valeur;
                label2.Text = "" + valeur;
                dataGridView2.Rows.Add(row);
            }
            dataGridView1.DataSource = notreListeObjet;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
