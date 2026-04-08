namespace UffPostale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ciclo = true;
            while (ciclo = true)
            {
                Console.WriteLine("BENVENUTI ALL UFFICIO POSTALE");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Premere 1 - ACCETTAZIONE ");
                Console.WriteLine("Premere 2 - SERVIZI");
                Console.WriteLine("Premere 3 - CHIUSURA UFFICIO");
                Console.WriteLine("--------------------------------");

                
                int inputMenuA = Convert.ToInt32(Console.ReadLine());
                if (inputMenuA == 1)
                {
                    List<string> nomi = new List<string>();
                    int eta = 0;
                    string input;
                    Console.WriteLine("INSERISCI IL NOME");
                    input = Console.ReadLine();
                   
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("INSERISCI ETA");
                    eta = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("A QUALE SERVIZIO VUOLE ACCEDERE");
                    Console.WriteLine("Premere 1 - SPEDIZIONI");
                    Console.WriteLine("Premere 2 - FINANZA");
                    Console.WriteLine("Premere 3 - SPID");
                    Console.WriteLine("--------------------------------");
                    int inputMenuB = Convert.ToInt32(Console.ReadLine());

                    if (eta < 65)//INSERISCI INFONDO ALLA LISTA
                    {
                        if (inputMenuB == 1)
                        {
                            List<string> spedizioni = new List<string>();
                            nomi.Add(input);
                            Console.WriteLine("hai aggiunto correttamente l'utente " + nomi + "alla lista spedizioni in fondo ");

                        }
                        else if (inputMenuB == 2)
                        {
                            List<string> finanza = new List<string>();
                            nomi.Add(input);
                            Console.WriteLine("hai aggiunto correttamente l'utente" + nomi + "alla lista finanza in fondo ");

                        }
                        else if (inputMenuB == 3)
                        {
                            List<string> spid = new List<string>();
                            nomi.Add(input);
                            Console.WriteLine("hai aggiunto correttamente l'utente" + nomi + "alla lista spid in fondo");

                        }
                    }
                    else if(eta > 65)//INSERICI A META DELLA LISTA 
                    {
                        if (inputMenuB == 1)
                        {
                            List<string> spedizioni = new List<string>();
                            spedizioni.Insert(spedizioni.Count/2, input);


                        }
                        else if (inputMenuB == 2)
                        {
                            List<string> finanza = new List<string>();
                            finanza.Insert(finanza.Count / 2, input);


                        }
                        else if (inputMenuB == 3)
                        {
                            List<string> spid = new List<string>();
                            spid.Insert(spid.Count / 2, input);

                        }
                    }
                   



                }
                else if (inputMenuA == 2)
                {
                    /*PRENDERE IL PRIMO DELLA ODA E SERVIRLO E ELIMINARLO DALLA LISTA CON REMOVE Il sistema deve chiamare
                     * il prossimo cliente in attesa per quello specifico sportello, mostrare il suo nome a video e rimuoverlo dalla fila.*/

                }
                else if (inputMenuA == 3)
                {

                    /*Chiusura Ufficio 
                    L'ufficio chiude le porte e non accetta più nuovi clienti, ma il programma non può terminare bruscamente se c'è ancora gente all'interno.
                    Il sistema deve simulare lo smaltimento rapido degli ultimi clienti presenti, chiamando e rimuovendo automaticamente i clienti rimasti, svuotando
                    prima la coda Spedizioni, poi la Finanziaria e infine lo SPID.
                    Solo quando nell'ufficio non ci sarà più nessun cliente in attesa in nessuna delle tre code, il programma stamperà un messaggio di chiusura definitiva 
                    e l'esecuzione terminerà.*/



                }


            }
        }
    }
}
