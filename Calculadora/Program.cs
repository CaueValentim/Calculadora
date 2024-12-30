namespace Calculadora
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            Operacoes operacoes = new Operacoes(); // Objeto criado para poder utilizar as operações da classe operações.
            bool continuar = true; // uma variavel de descisão para poder utilizar um loop para utilizar o menu repetidamente
            
            while (continuar){ // while para que o menu seja repetido apos a utilização da calculadora.
                Console.WriteLine("Escolha uma operação:");
                Console.WriteLine("1. Adição");
                Console.WriteLine("2. Subtração");
                Console.WriteLine("3. Multiplicação");
                Console.WriteLine("4. Divisão");
                Console.WriteLine("5. Sair");
                Console.Write("Digite o número da operação: \n");

                string escolha = Console.ReadLine(); // variavel para armazenar a escolha do usuario.
                
                if (escolha == "5") // estrutura para caso o usuario queira sair da calculadora, escolhe a opção 5 e o loop encerra.
                {
                    continuar = false; // como o a variavel bool originalmente é true para o loop funcionar, caso o usuario escolha a opção 5, muda para false encerrando o loop
                    Console.WriteLine("Saindo...");
                    break;
                }
                
                Console.WriteLine("Digite o primeiro numero: "); // variaveis para armazenar os numeros que o usuario vai digitar.
                double num1 = Convert.ToDouble(Console.ReadLine());
                
                Console.WriteLine("Digite o segundo numero: ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                
                double resultado; // variavel criada para utilizar dentro do switch.


                switch (escolha)
                {
                    case "1":
                        resultado = operacoes.somar(num1, num2); // utilizando a variavel resultado, atribuindo ela ao objeto operações e utilizando o metodo somar da classe Operacoes.
                        Console.WriteLine($"O resultado é: {num1} + {num2} = {resultado}\n");
                        
                        break;
                    case "2":
                        resultado = operacoes.subtracao(num1, num2); // utilizando a variavel resultado, atribuindo ela ao objeto operações e utilizando o metodo subtracao da classe Operacoes.
                        Console.WriteLine($"O resultado é: {num1} - {num2} = {resultado}\n");
                        break;
                    case "3":
                        resultado = operacoes.multiplicacao(num1, num2); // utilizando a variavel resultado, atribuindo ela ao objeto operações e utilizando o metodo multiplicacao da classe Operacoes.
                        Console.WriteLine($"O resultado é: {num1} * {num2} = {resultado}\n");
                        break;
                    case "4":
                        try
                        {
                            resultado = operacoes.divisao(num1, num2); // utilizando a variavel resultado, atribuindo ela ao objeto operações e utilizando o metodo duvisao da classe Operacoes.
                            Console.WriteLine($"Resultado: {num1} / {num2} = {resultado}\n");
                        }
                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    default:
                        Console.WriteLine("Opção invalida");
                        break;
                }
                Console.WriteLine();
            }

        }
    }
}

