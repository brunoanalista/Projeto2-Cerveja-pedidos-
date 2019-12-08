using System;
using System.IO;
using System.Text;

class Cliente : Pessoa{
	private string endereco;
	private float comprasRealizadas;
	private float desconto;
	private string[] lista = new string[50];

	public Cliente(string nome,string cpf,string numero,string endereco){
		this.nome = nome;
		this.cpf = cpf;
		this.numeroCel = numero;
		this.endereco = endereco;
		
	}
	

	public void adicionarLista(string adicao){
		for(int x=0; x<lista.Length; x++){
			if(lista[x]==null){
				lista[x] = adicao;
				break;
			}
		}

	}









}