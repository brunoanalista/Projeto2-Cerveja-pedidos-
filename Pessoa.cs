using System;
using System.IO;
using System.Text;

class Pessoa{
	protected string nome;
	protected string cpf;
	protected string numeroCel;
	//gets e sets
	public string getNome(){
		return nome;
	}
	public void setNome(string nome){
		this.nome = nome;
	}
	public string getCpf(){
		return cpf;
	}
	public void setCpf(string cpf){
		this.cpf = cpf;
	}
	public string getnumeroCel(){
	return numeroCel;
	}
	public void setnumeroCel(string num){
		this.numeroCel = num;
	}


	
}