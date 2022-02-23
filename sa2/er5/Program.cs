using EncontroRemoto5.Classes;

var inicio = DateTime.Now;
var espera = 400;

Spin(" INÍCIO ", " Carregando programa, aguarde um momento", ConsoleColor.Magenta, espera);
ExibirBoasVindas(ConsoleColor.Green);
ExibirMenu(ConsoleColor.Green, espera);

var termino = DateTime.Now.Subtract(inicio);

Spin(" FINALIZANDO ", $" Obrigado por utilizar nosso sistema! espera de uso: { Math.Round(termino.TotalSeconds, 0) } segundos", ConsoleColor.Magenta, espera);

static void CadastrarPF(int espera)
{
    var pf = new PessoaFisica()
    {
        CPF = "123.456.789-0",
        DataNascimento = new DateTime(1980,10,18),
        Nome = "Vanessa Ortega"
    };

    Console.WriteLine();
    Console.WriteLine($"✓ Nome: { pf.Nome }");
    Thread.Sleep(espera);
    Console.WriteLine($"✓ Data de nascimento: { pf.DataNascimento.ToShortDateString() }");
    Thread.Sleep(espera);
    Console.WriteLine($"✓ Maior? { pf.ValidarDataNascimento() }");
    Thread.Sleep(espera);
    Console.WriteLine($"✓ CPF: { pf.CPF }");
    Thread.Sleep(espera);    
    Console.WriteLine();
}

static void CadastrarPJ(int espera)
{
    var pj = new PessoaJuridica()
    {
        CNPJ = "12.345.678/0001-99",
        RazaoSocial = "SimpleCode Serviços de Informática Ltda."        
    };

    Console.WriteLine();
    Console.WriteLine($"✓ Razão social: { pj.RazaoSocial }");
    Thread.Sleep(espera);
    Console.WriteLine($"✓ CNPJ: { pj.CNPJ }");
    Thread.Sleep(espera);
    Console.WriteLine($"✓ CNPJ válido? { pj.ValidarCNPJ() }");
    Thread.Sleep(espera);
    Console.WriteLine();
}

static void ExibirMenu(ConsoleColor cor, int espera)
{
    string? opcaoEscolhida;

    do
    {
        Console.WriteLine();
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine();

        var opcoes = new Dictionary<int, string>()
        {
            {1, "Cadastrar pessoa física"},
            {2, "Cadastrar pessoa jurídica"}
        };

        foreach (var opcao in opcoes)
        {
            Console.ForegroundColor = cor;
            Console.Write($"    { opcao.Key }");

            Console.ResetColor();
            Console.WriteLine($" - { opcao.Value }");
        }

        Console.ResetColor();
        Console.WriteLine();
        Console.WriteLine("    0 - Sair");

        Console.WriteLine();
        Console.Write("Informe sua opção: ");

        opcaoEscolhida = Console.ReadLine();

        switch (opcaoEscolhida)
        {
            case "1":
                CadastrarPF(espera);
                break;
            case "2":
                CadastrarPJ(espera);
                break;
        }

    } while (opcaoEscolhida != "0");
}

static void ExibirBoasVindas(ConsoleColor cor)
{
    Console.Clear();
    Console.ForegroundColor = cor;


    Console.WriteLine(@$"                                                            
                    88      ,adba,                      ad88  
                    """"      8I  I8                     d8""    
                            ""8bdP'                     88     
        8b,dPPYba,  88      ,d8""8b  88    8b,dPPYba, MM88MMM  
        88P'    ""8a 88    .dP'   Yb,8I    88P'    ""8a  88     
        88       d8 88    8P      888'    88       d8  88     
        88b,   ,a8"" 88    8b,   ,dP8b     88b,   ,a8""  88     
        88`YbbdP""'  88    `Y8888P""  Yb    88`YbbdP""'   88     
        88         ,88                    88                  
        88       888P""                    88



    Bem-vindo ao sistema de cadastro de pessoa física e jurídica

                Rápido   -   fácil   -   seguro
");
    Console.ResetColor();
}

static void Spin(string titulo, string descricao, ConsoleColor cor, int espera)
{
    var counter = 0;
    Console.BackgroundColor = cor;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.Write(titulo);
    Console.ResetColor();
    Console.ForegroundColor = cor;
    Console.Write(descricao);
    do
    {
        switch (counter % 3)
        {
            case 0:
                Console.Write(".  ");
                break;
            case 1:
                Console.Write(" . ");
                break;
            case 2:
                Console.Write("  .");
                break;
        }
        Thread.Sleep(espera);
        Console.SetCursorPosition(Console.CursorLeft - 3, Console.CursorTop);
        counter++;

    } while (counter < 15);
    Console.ResetColor();
    Console.Clear();
}