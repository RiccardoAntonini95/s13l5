namespace s13l5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //per riconoscere il simbolo euro
            bool flagInput = false;
            Console.WriteLine("███████████████████████████████████████████████████████████████████\r\n█▌ ██████╗ █████╗ ██╗      ██████╗ ██████╗ ██╗      ██████╗      ▐█\r\n█▌██╔════╝██╔══██╗██║     ██╔════╝██╔═══██╗██║     ██╔═══██╗     ▐█\r\n█▌██║     ███████║██║     ██║     ██║   ██║██║     ██║   ██║     ▐█\r\n█▌██║     ██╔══██║██║     ██║     ██║   ██║██║     ██║   ██║     ▐█\r\n█▌╚██████╗██║  ██║███████╗╚██████╗╚██████╔╝███████╗╚██████╔╝     ▐█\r\n█▌ ╚═════╝╚═╝  ╚═╝╚══════╝ ╚═════╝ ╚═════╝ ╚══════╝ ╚═════╝      ▐█\r\n█▌                                                               ▐█\r\n█▌ █████╗ ██╗     ██╗ ██████╗ ██╗   ██╗ ██████╗ ████████╗ █████╗ ▐█\r\n█▌██╔══██╗██║     ██║██╔═══██╗██║   ██║██╔═══██╗╚══██╔══╝██╔══██╗▐█\r\n█▌███████║██║     ██║██║   ██║██║   ██║██║   ██║   ██║   ███████║▐█\r\n█▌██╔══██║██║     ██║██║▄▄ ██║██║   ██║██║   ██║   ██║   ██╔══██║▐█\r\n█▌██║  ██║███████╗██║╚██████╔╝╚██████╔╝╚██████╔╝   ██║   ██║  ██║▐█\r\n█▌╚═╝  ╚═╝╚══════╝╚═╝ ╚══▀▀═╝  ╚═════╝  ╚═════╝    ╚═╝   ╚═╝  ╚═╝▐█\r\n███████████████████████████████████████████████████████████████████");
            Contribuente contribuente1 = new Contribuente();
            //COGNOME
            Console.WriteLine("Inserisci il tuo cognome: ");
            string inputCognome = Console.ReadLine();
            contribuente1.Cognome = char.ToUpper(inputCognome[0]) + inputCognome.Substring(1);
            //NOME
            Console.WriteLine("Inserisci il tuo nome: ");
            string inputNome = Console.ReadLine();
            contribuente1.Nome = char.ToUpper (inputNome[0]) + inputNome.Substring(1);
            //DATA DI NASCITA
            do
            {
             Console.WriteLine("Inserisci la tua data di nascita: (yyyy-MM-dd) ");
             string inputData = Console.ReadLine();
             if (DateOnly.TryParse(inputData, out DateOnly dataConvertita)) //converte input stringa in DateOnly
             {
                 contribuente1.DataNascita = dataConvertita;
                 flagInput = false;
             }
             else
             {
                 Console.BackgroundColor = ConsoleColor.Red;
                 Console.WriteLine("Formato data non valido");
                 Console.ResetColor();
                 flagInput = true;
             }
            } while (flagInput);
            //CODICE FISCALE
            do
            {
                Console.WriteLine("Inserisci il tuo codice fiscale: ");
                string inputCodiceFiscale = Console.ReadLine().ToUpper();
                if (inputCodiceFiscale.Length == 16)
                {
                    flagInput = false;
                    contribuente1.CodiceFiscale = inputCodiceFiscale;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Codice fiscale non valido");
                    Console.ResetColor();
                    flagInput = true;
                }
            } while (flagInput);
            //SESSO
            do
            {
             Console.WriteLine("Sesso: (M/F) ");
             char inputSesso = char.Parse(Console.ReadLine());
             if(inputSesso != 'm' && inputSesso != 'f')
             {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Input non valido, selezionare M o F");
                Console.ResetColor();
                flagInput = true;
             }
             else
                {
                  inputSesso = inputSesso.ToString().ToUpper()[0];
                  flagInput = false;
                  contribuente1.Sesso = inputSesso;
                }
            } while (flagInput);
            //COMUNE DI RESIDENZA
            Console.WriteLine("Inserisci il tuo comune di residenza: ");
            string inputComune = Console.ReadLine();
            contribuente1.ComuneResidenza = char.ToUpper(inputComune[0]) + inputComune.Substring(1);
            //REDDITO ANNUALE DICHIARATO
            do
            {
             Console.WriteLine("Inserisci il tuo reddito annuale: ");
             string inputReddito = Console.ReadLine();
             if (double.TryParse(inputReddito, out double redditoDichiarato) && redditoDichiarato > 0) //Viene convertito in double per i decimali ma deve essere un numero positivo
             {
                 contribuente1.RedditoAnnuale = redditoDichiarato;
                 flagInput = false;
             }
             else
             {
                 Console.BackgroundColor = ConsoleColor.Red;
                 Console.WriteLine("Formato del reddito non valido");
                 Console.ResetColor();
                 flagInput = true;
             }
            } while (flagInput);
            //RIEPILOGO
            Console.Clear();
            Console.WriteLine("██████████████████████████████████████████████████████████████████████████\r\n█▌ ▄▄▄      ▓█████▄ ▓█████▄  ██▓ ▒█████                                 ▐█\r\n█▌▒████▄    ▒██▀ ██▌▒██▀ ██▌▓██▒▒██▒  ██▒                               ▐█\r\n█▌▒██  ▀█▄  ░██   █▌░██   █▌▒██▒▒██░  ██▒                               ▐█\r\n█▌░██▄▄▄▄██ ░▓█▄   ▌░▓█▄   ▌░██░▒██   ██░                               ▐█\r\n█▌ ▓█   ▓██▒░▒████▓ ░▒████▓ ░██░░ ████▓▒░                               ▐█\r\n█▌ ▒▒   ▓▒█░ ▒▒▓  ▒  ▒▒▓  ▒ ░▓  ░ ▒░▒░▒░                                ▐█\r\n█▌  ▒   ▒▒ ░ ░ ▒  ▒  ░ ▒  ▒  ▒ ░  ░ ▒ ▒░                                ▐█\r\n█▌  ░   ▒    ░ ░  ░  ░ ░  ░  ▒ ░░ ░ ░ ▒                                 ▐█\r\n█▌      ░  ░   ░       ░     ░      ░ ░                                 ▐█\r\n█▌           ░       ░                                                  ▐█\r\n█▌  ██████ ▄▄▄█████▓ ██▓ ██▓███  ▓█████  ███▄    █ ▓█████▄  ██▓ ▒█████  ▐█\r\n█▌▒██    ▒ ▓  ██▒ ▓▒▓██▒▓██░  ██▒▓█   ▀  ██ ▀█   █ ▒██▀ ██▌▓██▒▒██▒  ██▒▐█\r\n█▌░ ▓██▄   ▒ ▓██░ ▒░▒██▒▓██░ ██▓▒▒███   ▓██  ▀█ ██▒░██   █▌▒██▒▒██░  ██▒▐█\r\n█▌  ▒   ██▒░ ▓██▓ ░ ░██░▒██▄█▓▒ ▒▒▓█  ▄ ▓██▒  ▐▌██▒░▓█▄   ▌░██░▒██   ██░▐█\r\n█▌▒██████▒▒  ▒██▒ ░ ░██░▒██▒ ░  ░░▒████▒▒██░   ▓██░░▒████▓ ░██░░ ████▓▒░▐█\r\n█▌▒ ▒▓▒ ▒ ░  ▒ ░░   ░▓  ▒▓▒░ ░  ░░░ ▒░ ░░ ▒░   ▒ ▒  ▒▒▓  ▒ ░▓  ░ ▒░▒░▒░ ▐█\r\n█▌░ ░▒  ░ ░    ░     ▒ ░░▒ ░      ░ ░  ░░ ░░   ░ ▒░ ░ ▒  ▒  ▒ ░  ░ ▒ ▒░ ▐█\r\n█▌░  ░  ░    ░       ▒ ░░░          ░      ░   ░ ░  ░ ░  ░  ▒ ░░ ░ ░ ▒  ▐█\r\n█▌      ░            ░              ░  ░         ░    ░     ░      ░ ░  ▐█\r\n█▌                                                  ░                   ▐█\r\n██████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("===============================================");
            Console.WriteLine("CALCOLO DELL'IMPOSTA DA VERSARE:");
            Console.WriteLine($"Contribuente: {contribuente1.Nome} {contribuente1.Cognome}");
            Console.WriteLine($"Nato/a il {contribuente1.DataNascita} ({contribuente1.Sesso}),");
            Console.WriteLine($"Residente in: {contribuente1.ComuneResidenza}");
            Console.WriteLine($"Codice Fiscale: {contribuente1.CodiceFiscale}");
            Console.WriteLine($"Reddito dichiarato: \u20AC{contribuente1.RedditoAnnuale}");
            //CALCOLO IMPOSTA
            Console.WriteLine($"IMPOSTA DA VERSARE: \u20AC{contribuente1.CalcoloImposta(contribuente1.RedditoAnnuale)}");
            Console.WriteLine("===============================================");
        }

        public class Contribuente
        {
            //Fields
            private string _nome;
            private string _cognome;
            private DateOnly _dataNascita;
            private string _codiceFiscale;
            private char _sesso;
            private string _comuneResidenza;
            private double _redditoAnnuale;

            //Properties
            public string Nome
            {
                get { return _nome; }
                set { _nome = value; }
            }
            public string Cognome
            {
                get { return _cognome; }
                set { _cognome = value; }
            }
            public DateOnly DataNascita
            {
                get { return _dataNascita;}
                set { _dataNascita = value;}
            }
            public string CodiceFiscale
            {
                get { return _codiceFiscale;}
                set { _codiceFiscale = value;}
            }
            public char Sesso
            {
                get { return _sesso; }
                set { _sesso = value; }
            }
            public string ComuneResidenza
            {
                get { return _comuneResidenza;}
                set { _comuneResidenza = value; }
            }
            public double RedditoAnnuale
            {
                get { return _redditoAnnuale; }
                set { _redditoAnnuale = value; }
            }

            //Methods 
            public double CalcoloImposta(double redditoDichiarato)
            {
                double imposta;
                if (redditoDichiarato >= 0 && redditoDichiarato <= 15000)
                {
                    imposta = redditoDichiarato * 0.23;
                    return imposta;
                }
                else if (redditoDichiarato >= 15001 && redditoDichiarato <= 28000)
                {
                    double parteEccedente = redditoDichiarato - 15000;
                    imposta = 3450 + (parteEccedente * 0.27);
                    return imposta;
                }
                else if (redditoDichiarato >= 28001 && redditoDichiarato <= 55000)
                {
                    double parteEccedente = redditoDichiarato - 28000;
                    imposta = 6960 + (parteEccedente * 0.38);
                    return imposta;
                }
                else if (redditoDichiarato >= 55001 && redditoDichiarato <= 75000)
                {
                    double parteEccedente = redditoDichiarato - 55000;
                    imposta = 17220 + (parteEccedente * 0.41);
                    return imposta;

                }
                else
                {
                    double parteEccedente = redditoDichiarato - 75000;
                    imposta = 25420 + (parteEccedente * 0.43);
                    return imposta;
                }
            }
            //Constructors
            public Contribuente()
            {

            }
        }
    }
}
