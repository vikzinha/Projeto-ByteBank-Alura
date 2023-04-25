using _1_bytebank.Conta;
using _1_bytebank.Titular;

//// definir o tipo do objeto -> nome da variável que vai receber o objeto -> new Objeto()

///*
//contaDoAndre.depositar(100);

//Console.WriteLine("Saldo da conta do André pós depósito = " + contaDoAndre.saldo);

//if (contaDoAndre.sacar(300) == true)
//{
//    Console.WriteLine("Saldo da conta do André pós-saque = " + contaDoAndre.saldo);
//}
//else
//{
//    Console.WriteLine("Saldo insuficiente para saque.");
//}
//*/

//contaCorrente contaDaMaria = new contaCorrente();
//contaDaMaria.titular = "Maria Souza";
//contaDaMaria.numeroAgencia = 17;
//contaDaMaria.conta = "1010-5";
//contaDaMaria.saldo = 350;

//Console.WriteLine("Saldo da conta da Maria = " + contaDaMaria.saldo);

//contaDoAndre.transferir(50, contaDaMaria);
//Console.WriteLine("Saldo da conta do André após transferir= " + contaDoAndre.saldo);
//Console.WriteLine("Saldo da conta da Maria após receber transferência= " + contaDaMaria.saldo);

//contaCorrente contaDoPedro = new contaCorrente();
//contaDoPedro.titular = "Pedro Silva";
//Console.WriteLine(contaDoPedro.titular);
//Console.WriteLine(contaDoPedro.saldo);
//Console.WriteLine(contaDoPedro.numeroAgencia);
//Console.WriteLine(contaDoPedro.conta);


//Cliente cliente = new Cliente();
//cliente.nome = "André Silva";
//cliente.cpf = "123456789";
//cliente.profissao = "Analista";

//contaCorrente conta = new contaCorrente();
//conta.titular = cliente;
//conta.conta = "1010-X";
//conta.numeroAgencia = 15;
//conta.saldo = 100;

//Console.WriteLine("Titular = "+ conta.titular.nome);
//Console.WriteLine("CPF = " + conta.titular.cpf);
//Console.WriteLine("Profissão = " + conta.titular.profissao);
//Console.WriteLine("N Conta = " + conta.conta);
//Console.WriteLine("Saldo= " + conta.saldo);
//Console.WriteLine("N Agencia: "+ conta.numeroAgencia);

//contaCorrente conta2 = new contaCorrente();
//conta2.titular = new Cliente();
//conta2.titular.nome = "José Souza";
//conta2.titular.profissao = "Tester";
//conta2.titular.cpf = "9838732874";
//conta2.conta = "9999-X";
//conta2.numeroAgencia = 18;
//conta2.saldo = 500;

//Console.WriteLine(conta2.titular.nome);

//contaCorrente conta3 = new contaCorrente();
//conta3.SetSaldo(-10);
//Console.WriteLine(conta3.GetSaldo());

//contaCorrente conta4 = new contaCorrente(18, "1010-X");
//conta4.SetSaldo(500);
//conta4.Titular = new Cliente();

//Console.WriteLine(conta4.GetSaldo());
//Console.WriteLine(conta4.NumeroAgencia);
//Console.WriteLine(conta4.Conta);

// acessar uma propriedade estática da classe (static) - membro estático
contaCorrente conta5 = new contaCorrente(283, "1234-X");
Console.WriteLine(contaCorrente.TotalDeContasCriadas);

contaCorrente conta6 = new contaCorrente(284, "9874-Z");
Console.WriteLine(contaCorrente.TotalDeContasCriadas);

