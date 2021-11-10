using System;

namespace DIO.Series
{
    class Program
    {
        static void Main(string[] args)
        {
            //testando
            SerieRepositorio repositorio = new SerieRepositorio();

            string opcaoUsuario = ObterOpcaoUsuario();

            while(opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                        //AtualizarSerie();
                        break;
                    case "4":
                        //ExcluirSerie();
                        break;
                    case "5":
                        //VisualizarSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();

                Console.WriteLine("Obrigado por utilizar nossos serviços.");
                Console.WriteLine();
            }

            void ListarSeries()
            {
                Console.WriteLine("Listar séries");

                var lista = repositorio.Lista();
                
                if (lista.Count == 0)
                {
                    Console.WriteLine("Nenhuma série cadastrada");
                    return;
                }

                foreach (var serie in lista)
                {
                    Console.WriteLine("#ID {0}: - {1}", serie.retornaId(), serie.retornaTitulo());
                }
            }

            void InserirSerie()
            {
                Console.WriteLine("Inserir uma série");

                foreach(int i in Enum.GetValues(typeof(Genero)))
                {
                    Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
                }

                Console.WriteLine("Digite o gênero entre as opções acima: ");
                int entraGenero = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o título da série: ");
                string entraTitulo = Console.ReadLine();

                Console.WriteLine("Digite o ano de início da série");
                int entraAno = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a descrição da série: ");
                string entraDescricao = Console.ReadLine();

                Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                            genero: (Genero)entraGenero,
                                            titulo: entraTitulo,
                                            ano: entraAno,
                                            descricao: entraDescricao);

                repositorio.Insere(novaSerie);
            }

            static string ObterOpcaoUsuario()
            {
                Console.WriteLine();
                Console.WriteLine("DIO Séries a seu dispor!!");
                Console.WriteLine("Informe a opção desejada:");

                Console.WriteLine("1 - Listar séries");
                Console.WriteLine("2 - Inserir nova série");
                Console.WriteLine("3 - Atualizar série");
                Console.WriteLine("4 - Excluir série");
                Console.WriteLine("5 - Visualizar série");
                Console.WriteLine("C - Limpar tela");
                Console.WriteLine("X - Sair");
                Console.WriteLine();

                string opcaoUsuario = Console.ReadLine().ToUpper();
                Console.WriteLine();
                return opcaoUsuario;
            }
        }
    }
}
