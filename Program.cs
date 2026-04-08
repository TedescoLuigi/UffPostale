namespace UffPostale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ciclo = true;

            // LISTE 
            List<string> spedizioni = new List<string>();
            List<string> finanza = new List<string>();
            List<string> spid = new List<string>();

            while (ciclo)
            {
                Console.WriteLine("BENVENUTI ALL UFFICIO POSTALE");
                Console.WriteLine("1 - ACCETTAZIONE");
                Console.WriteLine("2 - SERVI CLIENTE");
                Console.WriteLine("3 - CHIUSURA UFFICIO");

                int scelta = Convert.ToInt32(Console.ReadLine());

                // ACCETTAZIONE 
                if (scelta == 1)
                {
                    Console.WriteLine("Nome:");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Età:");
                    int eta = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Servizio:");
                    Console.WriteLine("1 - Spedizioni");
                    Console.WriteLine("2 - Finanza");
                    Console.WriteLine("3 - SPID");

                    int servizio = Convert.ToInt32(Console.ReadLine());



                    if (servizio == 1)
                    {
                        if (eta < 65)
                        {
                            spedizioni.Add(nome);
                            Console.WriteLine($"Cliente {nome} aggiunto in fondo alla coda Spedizioni (posizione {spedizioni.Count})");
                        }
                        else
                        {
                            spedizioni.Insert(spedizioni.Count / 2, nome);
                            Console.WriteLine($"Cliente {nome} inserito a meta della coda Spedizioni (posizione {spedizioni.Count / 2})");
                        }
                    }
                    else if (servizio == 2)
                    {
                        if (eta < 65)
                        {
                            finanza.Add(nome);
                            Console.WriteLine($"Cliente {nome} aggiunto in fondo alla coda Finanza (posizione {finanza.Count})");
                        }
                        else
                        {
                            finanza.Insert(finanza.Count / 2, nome);
                            Console.WriteLine($"Cliente {nome} inserito a meta della coda Finanza (posizione {finanza.Count / 2})");
                        }
                    }
                    else if (servizio == 3)
                    {
                        if (eta < 65)
                        {
                            spid.Add(nome);
                            Console.WriteLine($"Cliente {nome} aggiunto in fondo alla coda SPID (posizione {spid.Count})");
                        }
                        else
                        {
                            spid.Insert(spid.Count / 2, nome);
                            Console.WriteLine($"Cliente {nome} inserito a meta della coda SPID (posizione {spid.Count / 2})");
                        }
                    }
                }

                // SERVI CLIENTE 
                else if (scelta == 2)
                {
                    Console.WriteLine("Quale sportello?");
                    Console.WriteLine("1 - Spedizioni");
                    Console.WriteLine("2 - Finanza");
                    Console.WriteLine("3 - SPID");

                    int sportello = Convert.ToInt32(Console.ReadLine());

                    if (sportello == 1)
                    {
                        if (spedizioni.Count > 0)
                        {
                            Console.WriteLine("Servito: " + spedizioni[0]);
                            spedizioni.RemoveAt(0);
                        }
                        else
                        {
                            Console.WriteLine("Coda vuota!");
                        }
                    }

                    else if (sportello == 2)
                    {
                        if (finanza.Count > 0)
                        {
                            Console.WriteLine("Servito: " + finanza[0]);
                            finanza.RemoveAt(0);
                        }
                        else
                        {
                            Console.WriteLine("Coda vuota!");
                        }
                    }

                    else if (sportello == 3)
                    {
                        if (spid.Count > 0)
                        {
                            Console.WriteLine("Servito: " + spid[0]);
                            spid.RemoveAt(0);
                        }
                        else
                        {
                            Console.WriteLine("Coda vuota!");
                        }
                    }
                }

                //  CHIUSURA POSTE
                else if (scelta == 3)
                {
                    Console.WriteLine("Chiusura..................");

                    // svuota spedizioni
                    while (spedizioni.Count > 0)
                    {
                        Console.WriteLine("Servito: " + spedizioni[0]);
                        spedizioni.RemoveAt(0);
                    }

                    // svuota finanza
                    while (finanza.Count > 0)
                    {
                        Console.WriteLine("Servito: " + finanza[0]);
                        finanza.RemoveAt(0);
                    }

                    // svuota spid
                    while (spid.Count > 0)
                    {
                        Console.WriteLine("Servito: " + spid[0]);
                        spid.RemoveAt(0);
                    }

                    Console.WriteLine("UFFICIO CHIUSO");
                    ciclo = false;
                }
            }
        }
    }
}