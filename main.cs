using System;

class MainClass {
  public static void Main (string[] args) {
    Caballo miBabieca = new Caballo("Babieca");
		Humano miJuan = new Humano("Juan");
		Gorila miGorila = new Gorila("Gorila");

		//array de los objetos 
		Mamiferos[] almacenMamiferos = new Mamiferos[3];
		almacenMamiferos[0] = miBabieca;
		almacenMamiferos[1] = miJuan;
		almacenMamiferos[2] = miGorila;

		almacenMamiferos[0].getNombre();
    almacenMamiferos[1].getNombre();
    almacenMamiferos[2].getNombre();
    miBabieca.pensar();
    miGorila.pensar();
    miJuan.pensar();
    almacenMamiferos[0].pensar();
    almacenMamiferos[1].pensar();
    almacenMamiferos[2].pensar();

    //polimorfismo
    Console.WriteLine("Ejemplo de polimorfismo:");
    for(int i = 0; i<3;i++){
      almacenMamiferos[i].pensar();
    }
  }
}

class Mamiferos{//superclase
  private string nombreSerVivo;
	public Mamiferos(string nombre){
		nombreSerVivo = nombre;
	}
  //metodos de superclase mamiferos 
	public void respirar(){
		Console.WriteLine("Soy capaz de respirar");
	}
	public void cuidarCrias(){
		Console.WriteLine("Soy capaz de cuidad crías");
	}
  //metodo con nombre igual al metodo de una subclase
	public virtual void pensar(){
	  Console.WriteLine("Pensamiento básico e instintivo");
	}
	public void getNombre(){
		Console.WriteLine("El nombre del ser vivo es: " + nombreSerVivo);
	}
}

//subclase caballo, humano y gorila adopta los metodos de la superclase, tiene base porque se ha creado un constructor explicito 
//por lo que el constructor implicito queda invalido 
class Caballo:Mamiferos{
	public Caballo(string nombreCaballo):base(nombreCaballo){}
	public void galopar(){
		Console.WriteLine("Soy capaz de galopar");
	}
}
class Humano:Mamiferos{
	public Humano(string nombreHumano):base(nombreHumano){}
  //posteriormente se creo un metodo en la superclase llamada igual "pensar" por lo que para diferenciarla de la superclase de debe añadir 
  //la palabra new
	public override void pensar(){
		Console.WriteLine("Soy capaz de pensar");
	}
}
class Gorila:Mamiferos{
	public Gorila(string nombreGorila):base(nombreGorila){}
	public void trepar(){
		Console.WriteLine("Soy capaz de trepar");
	}
  //este metodo añadido a gorila llamado pensar, cambia al metodo de la superclase "pensar" y lo modifica por el nuevo metodo del mismo nombre 
  //por lo que al llamarlo leera el metodo de la subclase al que se agrego remplazando al metodo del mismo nombre 
  //perteneciente a la superclase
  //la instruccion virtual indica al compilador que se esta modificando el metodo recibido de la superclase por el declarado en el metodo del
  //la subclase
  //override sobreescribe el metodo leyendo el metodo de la subclase por el metodo de la superclase con el mismo nombre
  //pero el compilador te pide escribir la palabra vitual en el metodo de la superclase para no arrojar error
  public override void pensar(){
    Console.WriteLine("Pensamiento animal");
  }
}
