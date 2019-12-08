using System;
using System.IO;
using System.Text;

class Entregador : Pessoa{
	private bool disponibilidade;

	public Entregador(){
		disponibilidade = true;
	}

	public bool getDisponibilidade(){
		return disponibilidade;
	}
	public void setDisponibilidade(bool disponibilidade){
		this.disponibilidade = disponibilidade;
	}
	
}