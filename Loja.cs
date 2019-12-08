using System;
using System.IO;
using System.Text;

class Loja{
	private string nome;
	private string[] produtos = new string[50];
	private float[] precos = new float[50];
	private Cliente[] clientes = new Cliente[50];
	private Entregador[] entregadores = new Entregador[3];

	public Loja(string nome){
		this.nome = nome;
	}
	public string getNome(){
		return nome;
	}

//metodos
	public void cadastrarEntregador(Entregador entre){
		for(int x=0;x<entregadores.Length;x++){
			if(entregadores[x] == null){
				entregadores[x] = entre;
				break;
			}
		}
	}
	public Entregador[] retornarEntregadores(){
		return entregadores;
	}
	public void cadastrarCliente(Cliente cli){
		for(int x=0;x<clientes.Length;x++){
			if(clientes[x] == null){
				clientes[x] = cli;
				break;
			}
		}
	}

	public string[] retornarProdutos(){
		return produtos;
	}
	public float[] retornarPrecos(){
		return precos;
	}
	public Cliente[] retornarClientes(){
		return clientes;
	}

	public void mostrarProdutos(){
		for(int x=0;x<produtos.Length;x++){
			if(produtos[x] != null){
			Console.WriteLine("ID: "+(x+1)+"- Produto: "+produtos[x]+" -Preço: "+precos[x]);
			}
		}

	}

	public void pegarProdutos(){
	FileStream lerTexto = new FileStream("dadosProdutos.txt",FileMode.Open,FileAccess.Read);

	StreamReader sr = new StreamReader(lerTexto,Encoding.UTF8);

	while(!sr.EndOfStream){
		string read = sr.ReadLine();
		string[] vetorLeitura = read.Split(";");
			string produto = vetorLeitura[0];
			float valorProduto = float.Parse(vetorLeitura[1]);

			for(int x=0;x<produtos.Length;x++){
				if(produtos[x] == null){
					produtos[x] = produto;
					precos[x] = valorProduto;
					break;
				}
			}

	}

		sr.Close();
		lerTexto.Close();
	}	

}