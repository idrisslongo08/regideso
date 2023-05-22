using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X500;
using System.Net.Mail;


namespace regideso
{
    public partial class REGIDESO : Form
    {
        string MyConnection2 = "Server=127.0.0.1;Database=regi;Uid=root;Pwd=;";

        MySqlConnection connection;
        MySqlDataReader reader;

        MySqlCommand command;

        MySqlConnection MyConn3 = new MySqlConnection("Server=127.0.0.1;Database=regi;Uid=root;Pwd=;");
        public REGIDESO()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialTextBox21_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            try
            {
                
                //Display query
                string Query = "select * from abonné;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //  MyConn2.Open();
                //For offline connection we weill use  MySqlDataAdapter class.
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.
                                                   // MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index= e.RowIndex;
            DataGridViewRow selectedrow= dataGridView1.Rows[index];
            identifiant.Text = selectedrow.Cells[0].Value.ToString();
            numero_abonne.Text = selectedrow.Cells[1].Value.ToString();
            nom_abonne.Text = selectedrow.Cells[2].Value.ToString();
            postnom_abonne.Text = selectedrow.Cells[3].Value.ToString();
            mail_abonne.Text = selectedrow.Cells[4].Value.ToString();
            telephone_abonne.Text = selectedrow.Cells[5].Value.ToString();

        }

        private void envoyer_facture_Click(object sender, EventArgs e)
        {
            try
            {
                string date_facture = DateTime.UtcNow.ToString("MM-dd-yyyy");


                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "insert into facture(`id_fact`, `numero`, `date`, `montant`, `numero_abonne`) values('" + "" + "','" + this.numero_fact.Text + "','" + date_facture.ToString() + "','" + int.Parse(this.prix_totale.Text) + "','" + this.numero_abonne.Text + "');";
                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sendMail();
        }

        private void numero_fact_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int min = 500;
            int max = 1000;
            int valeur =rnd.Next(min, max);
            numero_fact_text.Text=valeur.ToString();

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            
            try
            {
                MyConn3.Open();

            }
            catch(Exception ex2)
            {
                MessageBox.Show(ex2.Message);

            }
            
            using (var cmd2 = new MySqlCommand("select quantite from consomation where id_client=" + int.Parse(identifiant.Text),MyConn3))
            {
                try
                {
                    using (var reader2 = cmd2.ExecuteReader())
                    {
                        while (reader2.Read())
                        {

                            //numImmat.Text = reader2.GetString(2);
                            quantite_consomme.Text = reader2.GetString(0);

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            MyConn3.Close();
        }

        private void calculer_fact_Click(object sender, EventArgs e)
        {
            int quantTotale =int.Parse(quantite_consomme.Text) * int.Parse(prix.Text);
            prix_totale.Text=quantTotale.ToString();
        }

        public void sendMail()
        {
            string date_facture = DateTime.UtcNow.ToString("MM-dd-yyyy");
            //envoyer une notification
            string expediteur = "regideso.system@gmail.com";
            string destinataire = mail_abonne.Text.ToString();
            string server = "smtp.gmail.com";

            //Contenu du message de contrefaçon
            string body = "Nom: " + nom_abonne.Text.ToString() + " _________ " + "  N° : " + numero_fact_text.Text.ToString() + " _________ DATE:" + date_facture.ToString() + "\n" +
                "--------------------------------------------------------- \n" +
                "Post-Nom: " + postnom_abonne.Text.ToString() + "\n" +
                "Num abonné: " + numero_abonne.Text.ToString() + "\n" +
                "Telephone: " + telephone_abonne.Text.ToString() + "\n" +
                "Quantité en mettre cube: " + quantite_consomme.Text.ToString() + "\n" +
                "Prix unitaire: " + prix.Text.ToString() + "fc\n" +
                "TOTAL FACTURE: " + prix_totale.Text.ToString() + "fc" +
                "Libelle: " + message_abonne.Text.ToString() + "\n" +
                "TOTAL FACTURE: " + prix_totale.Text.ToString() + "fc";
            string objet = "FACTURE REGIDESO N° " + numero_fact.Text.ToString();
            string port = "587";

            // identifiant au compte de messagerie electonique
            string username = "regideso.system@gmail.com";
            string password = "ftssrivhiblbhmuo";
            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add(destinataire);

            // instance du mail
            mailMessage.From = new MailAddress(expediteur);
            mailMessage.Body = body;
            mailMessage.Subject = objet;

            //Instance SMTP
            SmtpClient smtpClient = new SmtpClient(server);
            smtpClient.EnableSsl = true;
            smtpClient.Port = 587;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Credentials = new System.Net.NetworkCredential(username, password);

            try
            {
                // envoi du message
                smtpClient.Send(mailMessage);
                MessageBox.Show("facture envoyée à " +nom_abonne.Text.ToString()+" "+postnom_abonne.Text.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Facture non envoyée! ");
            }

        }

        private void envoyer_sms_Click(object sender, EventArgs e)
        {
            string date_facture = DateTime.UtcNow.ToString("MM-dd-yyyy");
            //envoyer une notification
            string expediteur = "regideso.system@gmail.com";
            string destinataire = mail_abonne.Text.ToString();
            string server = "smtp.gmail.com";

            //Contenu du message de contrefaçon
            string body = "Nom: "+ nom_abonne.Text.ToString()+" _________ "+ "  N° : " +numero_fact_text.Text.ToString()+" _________ DATE:"+date_facture.ToString()+"\n"+
                "--------------------------------------------------------- \n"+
                "Post-Nom: " +postnom_abonne.Text.ToString()+ "\n"+
                "Num abonné: " +numero_abonne.Text.ToString()+ "\n"+
                "Telephone: " +telephone_abonne.Text.ToString()+ "\n"+
                "Quantité en mettre cube: " +quantite_consomme.Text.ToString()+ "\n"+
                "Prix unitaire: " + prix.Text.ToString()+ "fc\n"+
                "TOTAL FACTURE: " + prix_totale.Text.ToString() + "fc"+
                "Libelle: " +message_abonne.Text.ToString() + "\n" +
                "TOTAL FACTURE: " + prix_totale.Text.ToString()+"fc";
            string objet = "FACTURE REGIDESO N° "+numero_fact.Text.ToString();
            string port = "587";

            // identifiant au compte de messagerie electonique
            string username = "regideso.system@gmail.com";
            string password = "ftssrivhiblbhmuo";
            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add(destinataire);

            // instance du mail
            mailMessage.From = new MailAddress(expediteur);
            mailMessage.Body = body;
            mailMessage.Subject = objet;

            //Instance SMTP
            SmtpClient smtpClient = new SmtpClient(server);
            smtpClient.EnableSsl = true;
            smtpClient.Port = 587;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Credentials = new System.Net.NetworkCredential(username, password);

            try
            {
                // envoi du message
                smtpClient.Send(mailMessage);
                MessageBox.Show("facture envoyée");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Facture non envoyée! ");
            }

        }
    }
}
