using System;
using System.IO;
using System.Text;


class MainClass {
	static Loja comercio = new Loja("Zé petisco");
  public static void Main (string[] args) {
		
		comercio.pegarProdutos();
		Entregador entre = new Entregador();
		for(int y=0;y<3;y++){
			comercio.cadastrarEntregador(entre);
			
		}
		

		bool condicao = true;
		Console.WriteLine("");
		Console.WriteLine("Atendimento do "+comercio.getNome());


		while(condicao == true){
		Console.WriteLine("Deseja criar um pedido(1) ou criar um cadastro(2), sair(3): ");
		int decisao = int.Parse(Console.ReadLine());
		switch(decisao){
			case(1):
			MainClass.fazerPedido();

			break;
			case(2):
			MainClass.fazerCadastro();

			break;
			case(3):
			condicao = false;
			break;
		}
		
		
		}


    
  }
	public static void fazerPedido(){
		int indexCliente = 0;
		bool condicao = true;
		while (condicao == true){
		Console.WriteLine("O cliente possui cadastro: sim ou não ?");
		string cad =Console.ReadLine().ToUpper();
		if (cad =="SIM"){
			Console.WriteLine("digite seu cpf");
			string cp= Console.ReadLine();
			for(int i=0;i<comercio.retornarClientes().Length;i++){
				if(comercio.retornarClientes()[i] != null){
					if(comercio.retornarClientes()[i].getCpf() == cp){
						indexCliente = i;
					}
				}
			}

			condicao = false;
		}
		else{

			if(cad =="NAO" || cad == "NÃO"){
				Cliente cli = MainClass.fazerCadastro();


				comercio.cadastrarCliente(cli);
				for(int x=0;x< comercio.retornarClientes().Length;x++){
					if(comercio.retornarClientes()[x] != null){
					if(cli.getNome() == comercio.retornarClientes()[x].getNome()){
						indexCliente = x;
					}
				}
				}
				
				condicao = false;
			}
				else{
					Console.WriteLine("Comando não valido, tente novamente.");
				}
			}
		}
		
		float conta = MainClass.carrinho(indexCliente);
		Console.WriteLine("Deseja realizar o pedido ?");
		string decisao2 = Console.ReadLine().ToUpper();
		if(decisao2 =="NAO" || decisao2 == "NÃO"){
			comercio.retornarClientes()[indexCliente] = null;
			condicao=false;

		}else{
			if(decisao2 == "SIM"){
				MainClass.encaminharEntregador();

			}
		}




		


	}
	public static Cliente fazerCadastro(){
		Console.WriteLine("Digite o nome do cliente");
		string nome = Console.ReadLine();
		Console.WriteLine("Digite o cpf do cliente");
		string cpf = Console.ReadLine();
		Console.WriteLine("Digite o numero de telefone do cliente");
		string num = Console.ReadLine();
		Console.WriteLine("Digite o endereço do cliente");
		string ende = Console.ReadLine();
		Cliente cli = new Cliente(nome,cpf,num,ende);
		return cli;
		
	}
	public static float carrinho(int indexCliente){
		bool fecharCarrinho = true;
		float conta =0;
		while(fecharCarrinho==true){
			Console.WriteLine("Deseja Comprar Qual Produto?");
			Console.WriteLine("Digite 0 para sair.");
			comercio.mostrarProdutos();
			int num = int.Parse(Console.ReadLine());
			num--;
			for(int x=0;x<comercio.retornarProdutos().Length;x++){
				if(comercio.retornarProdutos()[x] != null){
					if(num == x){
						comercio.retornarClientes()[indexCliente].adicionarLista(comercio.retornarProdutos()[x]);
						conta += comercio.retornarPrecos()[x];

					}
				}

			}

			Console.WriteLine("Deseja mais produtos? : sim ou não");
			string cad =Console.ReadLine().ToUpper();
			if(cad == "NÃO" || cad=="NAO"){
				return conta;
				fecharCarrinho = false;
			}
		}
		
	return 0;
	}
	public static void encaminharEntregador(){
		for(int x=0;x<3;x++){
			Console.WriteLine("Entregador "+(x+1)+" "+comercio.retornarEntregadores()[x].getDisponibilidade());
		}
		Console.WriteLine("Selecione um entregador para fazer a entrega:(1),(2)ou (3) ");
		int demanda = int.Parse(Console.ReadLine());
		switch(demanda){
			case(1):
			comercio.retornarEntregadores()[0].setDisponibilidade(false);
			Console.WriteLine("Encomenda realizada");
			break;
			case(2):
			comercio.retornarEntregadores()[0].setDisponibilidade(false);
			Console.WriteLine("Encomenda realizada");
			break;
			case(3):
			comercio.retornarEntregadores()[0].setDisponibilidade(false);
			Console.WriteLine("Encomenda realizada");

			break;

		}


	}

}