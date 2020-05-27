using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
chciałbym, żeby program po upływie czasu wyświetlał wszystkie wyrażenia/równania z wynikami podanymi przez użytkownika 
i wynikami prawidłowymi, wyliczonymi przez program.


    */

namespace MistrzLiczb
{
    enum PoziomTrudnosci
    {
        Trudny,
        Sredni,
        Latwy
    }
    public partial class Form1 : Form
    {
        static string nazwa = "Gracz";

        public Form1()
        {
            InitializeComponent();
            WczytajWyniki();
            nameMenu.Hide();
            tableMenu.Hide();
            diffMenu.Hide();
            gameMenu.Hide();
            scoreMenu.Hide();
            stoper.Tick += new EventHandler(Odliczaj);
        }

        string[] nazwy = new string[20];
        int[] wyniki = new int[20];
        int strona = 1;//aktualna strona na tabeli wyników
        private void WczytajWyniki()
        {
            string path = @"\wyniki.bin";
            path = Path.GetDirectoryName(Application.ExecutablePath) + path;
            tableLabel.Text = "";
            try
            {
                FileStream fs = new FileStream(path, FileMode.Open);
                BinaryReader wczytywacz = new BinaryReader(fs);
                for (int i = 0; i < 20; i++)
                {
                    nazwy[i] = wczytywacz.ReadString();
                    wyniki[i] = wczytywacz.ReadInt32();
                    if (i < 10)
                        tableLabel.Text += (i + 1) + ". " + nazwy[i] + " | " + wyniki[i] + " pkt\n";
                }
                fs.Close();
            }
            catch (FileNotFoundException)
            {
                FileStream fs = new FileStream(path, FileMode.Create);
                BinaryWriter zapis = new BinaryWriter(fs);
                for (int i = 0; i < 20; i++)
                {
                    nazwy[i] = "brak";
                    wyniki[i] = 0;
                    if (i < 10)
                        tableLabel.Text += (i + 1) + ". " + nazwy[i] + " | " + wyniki[i] + " pkt\n";
                    zapis.Write("brak");
                    zapis.Write(0);
                }
                fs.Close();
            }
            strona = 1;
        }

        private void ZapiszWynik()
        {
            int insertPos = -1;
            for (int i = 0; i < 20; i++)
            {
                if (punkty > wyniki[i])
                {
                    insertPos = i;
                    break;
                }
            }

            if (insertPos > -1)//
            {
                for (int i = 18; i > insertPos; i--)
                {
                    nazwy[i + 1] = nazwy[i];
                    wyniki[i + 1] = wyniki[i];
                }

                nazwy[insertPos] = nazwa;
                wyniki[insertPos] = punkty;
            }

            string path = @"\wyniki.bin";
            path = Path.GetDirectoryName(Application.ExecutablePath) + path;
            tableLabel.Text = "";
            FileStream fs = new FileStream(path, FileMode.Create);
            BinaryWriter zapis = new BinaryWriter(fs);
            for (int i = 0; i < 20; i++)
            {
                if (i < 10)
                    tableLabel.Text += (i + 1) + ". " + nazwy[i] + " | " + wyniki[i] + " pkt\n";
                zapis.Write(nazwy[i]);
                zapis.Write(wyniki[i]);
            }
            fs.Close();
            strona = 1;
        }
        //menu główne


        private void selectNameBtn_Click(object sender, EventArgs e)//zmien nazwe
        {
            nameMenu.Show();
            mainMenu.Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)//wyjdz
        {
            Environment.Exit(0);
        }

        private void tableBtn_Click(object sender, EventArgs e)//tabela wyników
        {
            mainMenu.Hide();
            tableMenu.Show();
        }

        private void newGameBtn_Click(object sender, EventArgs e) //nowa gra
        {
            mainMenu.Hide();
            diffMenu.Show();
        }




        //Zmiana nazwy gracza
        private void nameBtn_Click(object sender, EventArgs e)//Zatwierdz zmiane nazwy
        {
            if (nameBox.Text.Length > 0 && nameBox.Text.Length < 10)
            {
                nazwa = nameBox.Text;
                label2.Text = "Witaj " + nazwa + " w Mistrzu Liczb!";
                nameMenu.Hide();
                mainMenu.Show();
            }
        }



        //tabela wyników
        private void backBtn_Click(object sender, EventArgs e)
        {
            mainMenu.Show();
            tableMenu.Hide();
            strona = 1;
            tableLabel.Text = "";
            for (int i = 0; i < 10; i++)
            {
                tableLabel.Text += (i + 1) + ". " + nazwy[i] + " | " + wyniki[i] + " pkt\n";
            }
        }

        private void button3_Click(object sender, EventArgs e)//zmień strone
        {
            tableLabel.Text = "";
            if (strona == 1)
            {
                strona = 2;
                for (int i = 10; i < 20; i++)
                {
                    tableLabel.Text += (i + 1) + ". " + nazwy[i] + " | " + wyniki[i] + " pkt\n";
                }
            }
            else
            {
                strona = 1;
                for (int i = 0; i < 10; i++)
                {
                    tableLabel.Text += (i + 1) + ". " + nazwy[i] + " | " + wyniki[i] + " pkt\n";
                }
            }
        }

        //Wybór poziomu trudności
        private PoziomTrudnosci trudnosc = PoziomTrudnosci.Latwy;
        private void backBtn2_Click(object sender, EventArgs e)//Wróć
        {
            diffMenu.Hide();
            mainMenu.Show();
        }

        private void hardBtn_Click(object sender, EventArgs e)
        {
            trudnosc = PoziomTrudnosci.Trudny;
            diffMenu.Hide();
            gameMenu.Show();
        }

        private void medBtn_Click(object sender, EventArgs e)
        {
            trudnosc = PoziomTrudnosci.Sredni;
            diffMenu.Hide();
            gameMenu.Show();
        }

        private void easyBtn_Click(object sender, EventArgs e)
        {
            trudnosc = PoziomTrudnosci.Latwy;
            diffMenu.Hide();
            gameMenu.Show();
        }


        //Gra
        bool gra = false;//zmienna definiująca czy gra się rozpoczęła
        int liczba;
        int punkty;
        int czas = 120;
        static Timer stoper = new Timer();

        private int Granica(int typ)
        {
            if (typ == 0 || typ == 1)
            {
                if (trudnosc == PoziomTrudnosci.Latwy)
                {
                    return 101;
                }
                else if (trudnosc == PoziomTrudnosci.Sredni)
                {
                    return 201;
                }
                else if (trudnosc == PoziomTrudnosci.Trudny)
                {
                    return 301;
                }
            }
            else
            {
                if (trudnosc == PoziomTrudnosci.Latwy)
                {
                    return 21;
                }
                else if (trudnosc == PoziomTrudnosci.Sredni)
                {
                    return 101;
                }
                else if (trudnosc == PoziomTrudnosci.Trudny)
                {
                    return 201;
                }
            }

            return -1;
        }

        private void GenerujLiczbe()
        {
            Random generator = new Random();
            int dzialanie = generator.Next(0, 4);//0 - dodawanie 1 - odejmowanie 2-mnozenie 3- dzielenie
            int[] liczby = new int[2];
            liczby[0] = generator.Next(1, Granica(dzialanie));
            liczby[1] = generator.Next(1, Granica(dzialanie));
            if (dzialanie == 0)
            {
                liczba = liczby[0] + liczby[1];
                dzialanieLabel.Text = "Podaj wynik działania: " + liczby[0] + " + " + liczby[1];
            }
            else if (dzialanie == 1)
            {
                liczba = liczby[0] - liczby[1];
                dzialanieLabel.Text = "Podaj wynik działania: " + liczby[0] + " - " + liczby[1];
            }
            else if (dzialanie == 2)
            {
                liczba = liczby[0] * liczby[1];
                dzialanieLabel.Text = "Podaj wynik działania: " + liczby[0] + " * " + liczby[1];
            }
            else if (dzialanie == 3)
            {
                while (liczby[0] % liczby[1] != 0)
                {
                    liczby[0] = generator.Next(1, Granica(dzialanie));
                    liczby[1] = generator.Next(1, Granica(dzialanie));
                }
                liczba = liczby[0] / liczby[1];
                dzialanieLabel.Text = "Podaj wynik działania: " + liczby[0] + " / " + liczby[1];
            }
        }
        
        private void startkoniec_Click(object sender, EventArgs e)
        {
            if (!gra)
            {
                wynik.Enabled = true;
                gra = true;
                czas = 120;
                GenerujLiczbe();
                startkoniec.Text = "Zakończ";


                stoper.Interval = 1000;
                stoper.Start();
                punkty = 0;
                historyBox.Items.Clear();
            }
            else
            {
                gra = false;
                wynik.Enabled = false;
                gameMenu.Hide();
                scoreMenu.Show();
                stoper.Stop();
                startkoniec.Text = "START";
                punktyLabel.Text = "Aktualne punkty: 0";
                czasLabel.Text = "Czas: 120s";

            }
        }

        private void Odliczaj(Object myObject, EventArgs myEventArgs)
        {
            czas--;
            czasLabel.Text = "Czas: " + czas + "s";
            if (czas == 0)
            {
                KoniecGry();
                stoper.Stop();
                stoper.Dispose();
            }

        }

        private void KoniecGry()
        {
            wynik.Enabled = false;
            startkoniec.Text = "Wyjdź";
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (!wynik.Enabled) return;
            if (wynik.Text != string.Empty)
            {
                if (int.Parse(wynik.Text) == liczba)
                {
                    if (trudnosc == PoziomTrudnosci.Latwy)
                        punkty++;
                    else if (trudnosc == PoziomTrudnosci.Sredni)
                        punkty += 2;
                    else if (trudnosc == PoziomTrudnosci.Trudny)
                        punkty += 4;

                    historyBox.Items.Add("Prawidlowe: " + dzialanieLabel.Text + " : " + liczba);
                }
                else
                {
                    historyBox.Items.Add("Nieprawidlowe (" + int.Parse(wynik.Text) + "): " + dzialanieLabel.Text + " : " + liczba);
                }
            }
            else
            {
                historyBox.Items.Add("Nieprawidlowe (brak): " + dzialanieLabel.Text + " : " + liczba);
            }

            punktyLabel.Text = "Aktualne punkty: " + punkty;
            GenerujLiczbe();
            wynik.Text = "";
        }

        //Historia odpowiedzi
        private void backMainMenu_Click(object sender, EventArgs e)
        {
            scoreMenu.Hide();
            mainMenu.Show();
            ZapiszWynik();
        }
    }
}
