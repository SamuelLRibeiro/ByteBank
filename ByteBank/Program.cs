using ByteBank;

ContaCorrente conta_do_Andre = new ContaCorrente();
conta_do_Andre.titular = "André Silva";
conta_do_Andre.numero_agencia = 15;
conta_do_Andre.conta = "1010-X";
conta_do_Andre.saldo = 100;
Console.WriteLine("Saldo da conta do André Silva: " + conta_do_Andre.saldo);


ContaCorrente conta_da_Maria = new ContaCorrente();
conta_da_Maria.titular = "Maria Souza";
conta_da_Maria.numero_agencia = 17;
conta_da_Maria.conta = "1010-5";
conta_da_Maria.saldo = 350;
Console.WriteLine("Saldo da conta da Maria Souza: " + conta_da_Maria.saldo);


conta_do_Andre.Transferir(50, conta_da_Maria);
Console.WriteLine("Saldo da conta de André Silva: " + conta_do_Andre.saldo);
Console.WriteLine("Saldo da conta de Maria Souza: " + conta_da_Maria.saldo);

