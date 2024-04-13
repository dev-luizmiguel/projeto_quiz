// Quiz
int placar = 0;
System.Console.WriteLine("Bem vindo ao Quiz bora testar seu conhecimento!!");
System.Console.WriteLine("Digite seu nome");
string nm=Console.ReadLine();
System.Console.WriteLine("Bem vindo "+ nm);

       
        string[] perguntas = {
            "Qual é a capital da França?",
            "Qual é o maior planeta do nosso sistema solar?",
            "Quem Ganhou a copa do mundo de 1994",
            "Qual eo maior continente do mundo?",
            "Em que ano teve ataque as torres gemeas",
            "Quem eo clube brasileiro que mais revela jogadores",
            "Quem eo criador do World Wide Web (WWW)",
            "Em qual ano Bill Gates fundou a Microsoft",
            "Em qual ano C# foi criado ",
            "Em qual ano foi criado javascript"
        };

        string[] opcao = {
            "a) Londres   b) Paris   c) Berlim   d) Roma",
            "a) Terra   b) Júpiter   c) Saturno   d) Netuno",
            "a) Holanda   b) Italia   c) Brasil    d) França",
            "a) Europa   b) Asia   c) Africa   d) America",
            "a) 2001    b)2003    c)2004    d)1999",
            "a) São Paulo   b)Santos  c)Palmeiras  d)Flamengo ",
            "a) Bill Gates b) Allan Turing c) Tim Bernes Lee d) Steve Jobs",
            "a) 1970   b)1982  c)1975  d)1972",
            "a)2003  b)1999  c)1995  d)2001",
            "a)1995  b)1990  c)1979  d)1998"
        };

        string[] respostas = { "b", "b", "c","b", "a", "b","c","c","d","a" };

        
        for (int i = 0; i < perguntas.Length; i++)
        {
            Console.WriteLine(perguntas[i]);
            Console.WriteLine(opcao[i]);

            Console.Write("Qual alternativa e ?: ");
            string jogador = Console.ReadLine();

            // testando a resposta do meu jogador
            if (jogador.ToLower() == respostas[i])
            {
                Console.WriteLine("Resposta correta!\n");
                placar++;
            }
            else
            {
                Console.WriteLine("Resposta incorreta!\n");
            }
        }
        System.Console.WriteLine("Vamos ao placar do jogo!");
       System.Console.WriteLine($"O jogador {nm} acertou {placar} / {perguntas.Length} Perguntas");