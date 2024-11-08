using System.Security.Cryptography.X509Certificates;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        public double BrojDanaUkupni;
        public List<Zaposlenik> zList = new List<Zaposlenik>();
        public Form1()
        {
            InitializeComponent();

            zList.Add(new Zaposlenik() { Ime = "Mario", Prezime = "Knez", Mjesto = "Ogulin", Udaljenost = 80 });
            zList.Add(new Zaposlenik() { Ime = "Ivan", Prezime = "Juriæ", Mjesto = "Zagreb", Udaljenost = 180 });
            zList.Add(new Zaposlenik() { Ime = "Tomislav", Prezime = "Mihiæ", Mjesto = "Osijek", Udaljenost = 94 });
            zList.Add(new Zaposlenik() { Ime = "Valentin", Prezime = "Mihiæ", Mjesto = "Županja", Udaljenost = 51 });
            zList.Add(new Zaposlenik() { Ime = "Danijela", Prezime = "Herceg", Mjesto = "Selna", Udaljenost = 20 });
            zList.Add(new Zaposlenik() { Ime = "Ivona", Prezime = "Mraz", Mjesto = "Požega", Udaljenost = 45 });

            cbx_zaposlenik.DataSource = zList;
            cbx_zaposlenik.DisplayMember = "Prezime";
        }

        private void Full_name(object sender, ListControlConvertEventArgs e)
        {
            string ime = (e.ListItem as Zaposlenik).Ime;
            string prezime = (e.ListItem as Zaposlenik).Prezime;
            e.Value = ime + " " + prezime;
        }

        private void mC_Kalendar_DateSelected(object sender, DateRangeEventArgs e)
        {

            BrojDanaUkupni = 0;


            if (e.Start.Date <= e.End.Date)
            {

                DateTime DanPocetni = e.Start.Date;
                DateTime DanZavrsni = e.End.Date;


                TimeSpan dani = DanZavrsni - DanPocetni;
                double ukupnoDana = dani.TotalDays;


                BrojDanaUkupni += ukupnoDana;


                Troskovnik.Text = "Ukupan broj dana je: " + Math.Round(BrojDanaUkupni).ToString() + Environment.NewLine;
            }
        }

        private void cbx_zaposlenik_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in zList)
            {
                string a = item.Ime + " " + item.Prezime;

                if (a == cbx_zaposlenik.Text)
                {
                    Udaljenost.Text = item.Udaljenost.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {



            var odabraniZaposlenik = cbx_zaposlenik.SelectedItem as Zaposlenik;

            if (odabraniZaposlenik != null)
            {

                double ukupno = Math.Round(BrojDanaUkupni) * 2 * odabraniZaposlenik.Udaljenost;


                Troskovnik.Text = "Odabrani zaposlenik: " + odabraniZaposlenik.Ime + " " + odabraniZaposlenik.Prezime + Environment.NewLine;
                Troskovnik.Text += "Ukupan broj dana je: " + Math.Round(BrojDanaUkupni).ToString() + Environment.NewLine;
                Troskovnik.Text += "Udaljenost u jednom smjeru je: " + odabraniZaposlenik.Udaljenost.ToString() + " km" + Environment.NewLine;
                Troskovnik.Text += "Cijena po km je: 1" + Environment.NewLine;
                Troskovnik.Text += "Ukupna isplata: " + ukupno.ToString() + "€";
            }
            else
            {

                MessageBox.Show("Molimo odaberite zaposlenika.");
            }




        }
    }
}