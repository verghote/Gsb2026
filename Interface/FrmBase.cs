using Metier;

namespace Interface
{
    public partial class FrmBase : Form
    {
        // Session en cours : contient les données de l'utilisateur connecté et les données nécessaires à l'application
        // null! : indique que la variable sera initialisée avant son utilisation, même si le constructeur par défaut ne l'initialise pas (injection de dépendance dans les formulaires secondaires)
        protected Session session = null!;

        // Constructeur par défaut pour le concepteur de formulaire
        protected FrmBase()
        {
            InitializeComponent();
        }

        // contructeur pour les formulaires secondaires, qui nécessite une session en paramètre (injection de dépendance)
        protected FrmBase(Session uneSession)
        {
            InitializeComponent();
            session = uneSession;
        }

        #region Procédures événementielles

        // <summary>
        /// Événement déclenché lors du chargement du formulaire.
        /// </summary>
        private void FrmBase_Load(object sender, EventArgs e)
        {
            ParametrerComposant();
        }

        private void FrmBase_FormClosed(object sender, FormClosedEventArgs e)
        {
            // s'il ne reste qu'un formulaire en mémoire, cela signifie que l'utilisateur a fermé l'application
            // il faut alors quitter le thread de l'application pour éviter que le formulaire parent reste ouvert en arrière-plan
            if (Application.OpenForms.Count == 1)
            {
                Application.ExitThread();
            }
        }


        private void ficheMédicamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // OuvrirFormulaire(new FrmMedicament(session));
        }

        private void programmerRendezVous_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new FrmVisiteAjout(session));
        }

        private void modifierRendezVous_Click(object sender, EventArgs e)
        {
            // OuvrirFormulaire(new FrmVisiteModification(session));
        }

        private void imprimerRendezvous_Click(object sender, EventArgs e)
        {
            // OuvrirFormulaire(new FrmVisiteImpression(session));
        }

        private void enregistrerBilan_Click(object sender, EventArgs e)
        {
            // OuvrirFormulaire(new FrmVisiteBilan(session));
        }

        private void consulterVisite_Click(object sender, EventArgs e)
        {
            // OuvrirFormulaire(new FrmVisiteConsultation(session));
        }

        private void listePraticien_Click(object sender, EventArgs e)
        {
            // OuvrirFormulaire(new FrmPraticienListe(session));
        }

        private void nouveauPraticien_Click(object sender, EventArgs e)
        {
            // OuvrirFormulaire(new FrmPraticienAjout(session));
        }

        private void modifierPraticien_Click(object sender, EventArgs e)
        {
            // OuvrirFormulaire(new FrmPraticienModification(session));
        }

        #endregion

        #region Procédures

        // <summary>
        /// Ouvre un formulaire secondaire 
        /// </summary>
        private void OuvrirFormulaire(Form frm)
        {
            frm.Show();

            if (this is FrmMenu)
                this.Hide();
            else
                this.Close();
        }


        private void ParametrerComposant()
        {
            Text = "Laboratoire pharmaceutique Galaxy-Swiss Bourdin - Gestion des visites";
            this.Icon = Properties.Resources.iconeGSB;
            KeyPreview = true;

            if (!DesignMode)
            {
                lblVisiteur.Text = session.NomVisiteur;

                // Activation / désactivation des menus selon la session

                // Modification des rendez-vous uniquement si des visites futures existent.

                // Enregistrement des bilans uniquement si des visites passées sans bilan existent.

                // Consultation des visites activée si au moins une visite est présente.
            }
        }

        #endregion

    }
}
