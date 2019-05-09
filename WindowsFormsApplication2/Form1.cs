using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            radioButton7.Visible = false;
            richTextBox1.Visible = false;
        }


        int korak = 0;
        int a = 0;
        int b = 0;
        int c = 0;
        int d = 0;
        int ee = 0;
        int f = 0;
        int g = 0;
        int skor = 0;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            a = 1;
            b = 0;
            c = 0;
            d = 0;
            ee = 0;
            f = 0;
            g = 0;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            b = 1;
            c = 0;
            d = 0;
            ee = 0;
            f = 0;
            g = 0;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            b = 0;
            c = 1;
            d = 0;
            ee = 0;
            f = 0;
            g = 0;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            b = 0;
            c = 0;
            d = 1;
            ee = 0;
            f = 0;
            g = 0;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            b = 0;
            c = 0;
            d = 0;
            ee = 1;
            f = 0;
            g = 0;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            b = 0;
            c = 0;
            d = 0;
            ee = 0;
            f = 1;
            g = 0;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            a = 0;
            b = 0;
            c = 0;
            d = 0;
            ee = 0;
            f = 0;
            g = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Drugo pitanje
            
            if (korak == 0)
            {
                if (a == 1)
                {
                    skor = skor + 2;
                }
                else if (b == 1)
                {
                    skor = skor + 4;
                }
                else if (c == 1)
                {
                    skor = skor + 6;
                }
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                ee = 0;
                f = 0;
                g = 0;
                label1.Text = "2. Kad hodate, hodate…";
                radioButton1.Text = "a) Dosta brzo, dugim koracima";
                radioButton2.Text = "b) Relativno brzo, sitnim koracima";
                radioButton3.Text = "c) Ne baš brzo, uspravne glave, gledajući ispred sebe";
                radioButton4.Text = "d) Ne baš brzo, sagnute glave";
                radioButton5.Text = "e) Vrlo polako";
                radioButton4.Visible = true;
                radioButton5.Visible = true;


            }
            //Treće pitanje
            else if (korak == 1)
            {
                if (a == 1)
                {
                    skor = skor + 6;
                }
                else if (b == 1)
                {
                    skor = skor + 4;
                }
                else if (c == 1)
                {
                    skor = skor + 7;
                }
                else if (d == 1)
                {
                    skor = skor + 2;
                }
                else if (ee == 1)
                {
                    skor = skor + 1;
                }
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                ee = 0;
                f = 0;
                g = 0;
                label1.Text = "3. Kad pričate s ljudima…";
                radioButton1.Text = "a) Stojite prekriženih ruku";
                radioButton2.Text = "b) Imate sklopljene ruke";
                radioButton3.Text = "c) Jednu ili obje ruke držite na bokovima ";
                radioButton4.Text = "d) Dodirujete ili gurkate osobu s kojom razgovarate";
                radioButton5.Text = "e) Igrate se sa svojim uhom, dodirujete bradu ili uvijate kosu";
            }
            //Četvrto pitanje
            else if (korak == 2)
            {
                if (a == 1)
                {
                    skor = skor + 4;
                }
                else if (b == 1)
                {
                    skor = skor + 2;
                }
                else if (c == 1)
                {
                    skor = skor + 5;
                }
                else if (d == 1)
                {
                    skor = skor + 7;
                }
                else if (ee == 1)
                {
                    skor = skor + 6;
                }
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                ee = 0;
                f = 0;
                g = 0;
                label1.Text = "4. Kad se odmarate, sjedite…";
                radioButton1.Text = "a) Savinutih koljena, noge su opuštene jedna uz drugu";
                radioButton2.Text = "b) Prekriženih nogu";
                radioButton3.Text = "c) Ravno ispruženih nogu";
                radioButton4.Text = "d) Na jednoj nozi savinutoj ispod vas";
                radioButton5.Visible = false;

            }
                //Peto pitanje
            else if (korak == 3)
            {
                if (a == 1)
                {
                    skor = skor + 4;
                }
                else if (b == 1)
                {
                    skor = skor + 6;
                }
                else if (c == 1)
                {
                    skor = skor + 2;
                }
                else if (d == 1)
                {
                    skor = skor + 1;
                }
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                ee = 0;
                f = 0;
                g = 0;
                label1.Text = "5. Kad vas nešto uistinu zabavlja, reagirate…";
                radioButton1.Text = "a) Glasnim smijehom";
                radioButton2.Text = "b) Smijehom, ali ne glasnim";
                radioButton3.Text = "c) Tihim smijuckanjem";
                radioButton4.Text = "d) Sramežljivim smiješkom";
                

            }
                //Šesto pitanje
            else if (korak == 4)
            {
                if (a == 1)
                {
                    skor = skor + 6;
                }
                else if (b == 1)
                {
                    skor = skor + 4;
                }
                else if (c == 1)
                {
                    skor = skor + 3;
                }
                else if (d == 1)
                {
                    skor = skor + 2;
                }
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                ee = 0;
                f = 0;
                g = 0;
                label1.Text = "6. Kad idete na neko društveno okupljanje…";
                radioButton1.Text = "a) Glasni ste pri dolasku, tako da vas svatko uoči";
                radioButton2.Text = "b) Dolazite nezapaženo i gledate uokolo u potrazi za poznatim ljudima";
                radioButton3.Text = "c) Potpuno ste neprimjetni i pokušavate da vas se ne zapazi";
                radioButton4.Visible = false;
            }
                //Sedmo pitanje
            else if (korak == 5)
            {
                if (a == 1)
                {
                    skor = skor + 6;
                }
                else if (b == 1)
                {
                    skor = skor + 4;
                }
                else if (c == 1)
                {
                    skor = skor + 2;
                }
                
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                ee = 0;
                f = 0;
                g = 0;
                label1.Text = "7. Jako ste se udubili u nešto, vrlo ste zaposleni i netko vas prekida…";
                radioButton1.Text = "a) Sretni ste zbog prekida";
                radioButton2.Text = "b) Krajnje ste iznervirani zbog toga";
                radioButton3.Text = "c) Negdje ste između te dvije krajnosti";
            }
                //Osmo pitanje
            else if (korak == 6)
            {
                if (a == 1)
                {
                    skor = skor + 6;
                }
                else if (b == 1)
                {
                    skor = skor + 2;
                }
                else if (c == 1)
                {
                    skor = skor + 4;
                }

                a = 0;
                b = 0;
                c = 0;
                d = 0;
                ee = 0;
                f = 0;
                g = 0;
                label1.Text = "8. Koja vam je boja najdraža?";
                radioButton1.Text = "a) Crvena ili narančasta";
                radioButton2.Text = "b) Crna";
                radioButton3.Text = "c) Žuta ili svjetloplava";
                radioButton4.Text = "d) Zelena";
                radioButton5.Text = "e) Tamnoplava ili ljubičasta";
                radioButton6.Text = "f) Bijela";
                radioButton7.Text = "g) Smeđa ili siva";
                radioButton4.Visible = true;
                radioButton5.Visible = true;
                radioButton6.Visible = true;
                radioButton7.Visible = true;

            }
                //Deveto pitanje
            else if (korak == 7)
            {
                if (a == 1)
                {
                    skor = skor + 6;
                }
                else if (b == 1)
                {
                    skor = skor + 7;
                }
                else if (c == 1)
                {
                    skor = skor + 5;
                }
                else if (d == 1)
                {
                    skor = skor + 4;
                }
                else if (ee == 1)
                {
                    skor = skor + 3;
                }
                else if (f == 1)
                {
                    skor = skor + 2;
                }
                else if (g == 1)
                {
                    skor = skor + 1;
                }

                a = 0;
                b = 0;
                c = 0;
                d = 0;
                ee = 0;
                f = 0;
                g = 0;
                label1.Text = "9. Kad ste navečer u krevetu, nekoliko trenutaka prije nego što ćete zaspati…";
                radioButton1.Text = "a) Ispruženi ste na leđima";
                radioButton2.Text = "b) Ispruženi ste potrbuške";
                radioButton3.Text = "c) Lagano ste se savinuli na boku";
                radioButton4.Text = "d) Glavu ste oslonili na jednu ruku";
                radioButton5.Text = "e) Glava vam je ispod pokrivača";         
                radioButton6.Visible = false;
                radioButton7.Visible = false;

            }
                //Deseto pitanje
            else if (korak == 8)
            {
                if (a == 1)
                {
                    skor = skor + 7;
                }
                else if (b == 1)
                {
                    skor = skor + 6;
                }
                else if (c == 1)
                {
                    skor = skor + 4;
                }
                else if (d == 1)
                {
                    skor = skor + 2;
                }
                else if (ee == 1)
                {
                    skor = skor + 1;
                }

                a = 0;
                b = 0;
                c = 0;
                d = 0;
                ee = 0;
                f = 0;
                g = 0;
                label1.Text = "10. Često sanjate da…";
                radioButton1.Text = "a) Padate";
                radioButton2.Text = "b) Se tučete ili borite";
                radioButton3.Text = "c) Nešto ili nekoga tražite";
                radioButton4.Text = "d) Da letite ili lebdite";
                radioButton5.Text = "e) Uglavnom ne sanjate";
                radioButton6.Text = "f) Snovi su vam uvijek ugodni";
                radioButton6.Visible = true;
                button1.Text = "Konačan rezultat";
                
            }

            else if (korak == 9)
            {
                if (a == 1)
                {
                    skor = skor + 4;
                }
                else if (b == 1)
                {
                    skor = skor + 2;
                }
                else if (c == 1)
                {
                    skor = skor + 3;
                }
                else if (d == 1)
                {
                    skor = skor + 5;
                }
                else if (ee == 1)
                {
                    skor = skor + 6;
                }
                else if (f == 1)
                {
                    skor = skor + 1;
                }
                else if (g == 1)
                {
                    skor = skor + 1;
                }

                a = 0;
                b = 0;
                c = 0;
                d = 0;
                ee = 0;
                f = 0;
                g = 0;
                
           
                if (skor > 60)
                    richTextBox1.Text = "Preko 60 bodova: DOMINANTNOST\n Drugi vas vide kao osobu s kojojm treba “pažljivo postupati”, kao oholu, egocentričnu i izrazito dominantnu osobu. Neki vam se dive i žele biti poput vas, ali vam ne vjeruju uvijek i oklijevaju stupiti s vama u neki dublji odnos.";
                else if ((skor >= 51) && (skor <= 60))
                    richTextBox1.Text = "51 do 60 bodova: TEMPERAMENTNOST\n Drugi vas vide kao uzbudljivu osobu, eksplozivnog temperamenta, impulzivnu, kao prirodnog vođu koji brzo donosi odluke, iako ne uvijek ispravne. Smatraju vas hrabrim, avanturistički nastrojenim, kao nekoga tko će se uvijek usuditi pokušati i tko uživa u avanturi. Uživaju biti u vašem društvu zbog uzbudljivosti kojom zračite.";
                else if ((skor >= 41) && (skor <= 50))
                    richTextBox1.Text = "41 do 50 bodova: PRAKTIČNOST\n Drugi vas vide kao direktnu, živahnu, šarmantnu, zabavnu, praktičnu i uvijek zanimljivu osobu koja je uvijek u centru pažnje, ali koja je dovoljno uravnotežena da joj to ne udari u glavu. Također vas smatraju ljubaznom, obzirnom osobom punom razumijevanja koja će uvijek razveseliti i pomoći.";
                else if ((skor >= 31) && (skor <= 40))
                    richTextBox1.Text = "31 do 40 bodova: ODANOST\n Drugi vas vide kao razumnu, opreznu, brižnu osobu, pametnu, talentiranu, ali skromnu. Niste osoba koja prebrzo sklapa prijateljstva, ali ste izrazito odani onima koji postanu vašim prijateljima i za uzvrat očekujete istu odanost. Oni koji vas stvarno upoznaju, shvaćaju da je potrebno uistinu puno da se vaša vjera u prijatelja pokoleba, ali vam isto tako treba puno da zaboravite, ako se to uistinu i dogodi.";
                else if ((skor >= 21) && (skor <= 30))
                    richTextBox1.Text = "21 do 30 bodova: OPREZNOST\n Prijatelji vas smatraju savjesnom i pedantnom osobom. Vide vas kao vrlo opreznu, izrazito brižnu osobu, kao nekoga tko polagano i ustrajno radi. Uistinu bi ih iznenadilo da iznenada reagirate impulzivno, budući da očekuju od vas da sve ispitujete pažljivo iz svakog ugla i tek onda odustanete. Smatraju da je razlog tome vaša oprezna priroda.";
                else if (skor < 21)
                    richTextBox1.Text = "Manje od 21 bod: NEODLUČNOST\n Ljudi vas smatraju sramežljivom, nervoznom, neodlučnom osobom, za koju se potrebno brinuti, koja uvijek želi da netko drugi donese odluku i koja se ne želi ni u što miješati. Vi ste za njih vječno uznemirena osoba koja samo vidi nepostojeće probleme. Neki ljudi vas smatraju dosadnima. Samo oni koji vas dobro poznaju znaju da to niste.";
                button1.Text = "Igraj ponovno";
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;
                radioButton7.Visible = false;

                richTextBox1.Visible = true;
            }
            else if (korak == 10)
            {
                Form1 NewForm = new Form1();
                NewForm.Show();
                this.Dispose(false);
            }
            korak = korak + 1;




        }
    }
}
