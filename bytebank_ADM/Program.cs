using bytebank_ADM.Funcionarios;
using bytebank_ADM.ParceriaComercial;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitarios;


//CalcularBonificacao();
UsarSistema();

void CalcularBonificacao()
{
    GerencidorDeBonificacoes gerenciador = new();
    Designer pedro = new("833.222.046-39");
    pedro.Nome = "Pedro";

    Diretor paula = new("159.753.398-04");
    paula.Nome = "Paula";

    Auxiliar igor = new("981.198.778-53");
    igor.Nome = "Igor";

    GerenteDeContas camila = new("362.985.628.89");
    camila.Nome = "Camila";

    Desenvolvedor carla = new("987.654.321.-00");
    carla.Nome = "Carla";

    gerenciador.Registrar(pedro);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(camila);
    gerenciador.Registrar(carla);

    Console.WriteLine($"Total de Bonificaçaõ: {gerenciador.getBonificacao()}");
}

void UsarSistema()
{
    SistemaInterno sistemainterno = new SistemaInterno();

    Diretor roberta = new("123.456.789-10");
    roberta.Nome = "Roberta";
    roberta.Senha = "123";
    roberta.Login = "rob";

    GerenteDeContas ursula = new("456.123.789-85");
    ursula.Nome = "Ursula";
    ursula.Senha = "321";
    ursula.Login = "urs";

    //Designer pedro = new("456.123.889-85");
    //pedro.Nome = "Pedro";
    //pedro.Senha = "987";

    ParceiroComercial joao = new();
    joao.Nome = "João";
    joao.Login = "joaozinho";
    joao.Senha = "159";

    sistemainterno.Logar(roberta, "rob", "123");
    sistemainterno.Logar(ursula, "urs", "321");
    sistemainterno.Logar(joao, joao.Login, joao.Senha);
    //sistemainterno.Logar(pedro, "987");
}


//Console.WriteLine("Boas Vindas ao ByteBank administração");

//GerencidorDeBonificacoes gerencidor = new();
//Funcionario joao = new("12345678900", 2000);
//joao.Nome = "João";
////joao.Cpf = "";
////joao.Salario = ;

////Console.WriteLine($"Nome: {joao.Nome}");
////Console.WriteLine($"CPF: {joao.Cpf}");
////Console.WriteLine($"Salario: {joao.Salario}");
//Console.WriteLine($"Bonificação: {joao.getBonificacao()}");
//Console.WriteLine($"Total de Funcionarios: {Funcionario.totalDeFuncionarios}");

//Funcionario camila = new Diretor("00987654321");
//camila.Nome = "Camila";
////camila.Cpf = "";
////camila.Salario = ;

////Console.WriteLine($"Nome: {camila.Nome}");
////Console.WriteLine($"CPF: {camila.Cpf}");
////Console.WriteLine($"Salario: {camila.Salario}");
//Console.WriteLine($"Bonificação: {camila.getBonificacao()}");
//Console.WriteLine($"Total de Funcionarios: {Funcionario.totalDeFuncionarios}");
////Funcionario.totalDeFuncionarios = 5;

//Funcionario andre = new Diretor("11122233345");
//andre.Nome = "Andre";
////andre.Cpf = ;
////andre.Salario = ;

//Console.WriteLine($"Bonificação: {andre.getBonificacao()}");
//Console.WriteLine($"Total de Funcionarios: {Funcionario.totalDeFuncionarios}");

//gerencidor.Registrar(joao);
//gerencidor.Registrar(camila);
//gerencidor.Registrar(andre);

//Console.WriteLine($"Total de Bonificação: {gerencidor.getBonificacao()}");

//joao.AumentarSalario();
//Console.WriteLine($"Novo salario do João: {joao.Salario}");

//andre.AumentarSalario();
//Console.WriteLine($"Novo salario do Andre: {andre.Salario}");