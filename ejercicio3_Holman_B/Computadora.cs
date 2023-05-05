using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3_Holman_B
{
    internal class Computadora
    {
        int disco;
        int Esp_disp;
        bool encendido= false;

        public Computadora()
        {

        }
        public Computadora(int disco, int esp_disp, bool encendido)
        {
            this.Disco = disco;
            this.Esp_disp1 = esp_disp;
            this.Encendido = encendido;
        }

        public int Disco { get => disco; set => disco = value; }
        public int Esp_disp1 { get => Esp_disp; set => Esp_disp = value; }
        public bool Encendido { get => encendido; set => encendido = value; }

        public void encender()
        {
            Console.WriteLine("desea encender el equipo");
            if(this.Encendido)
            {
                
                Console.WriteLine("la computadora se encendio");
              
            }
            else
            {
                this.Encendido = false;
                Console.WriteLine("el dispositivo esta encendido");
               
            }
        }
        public void Apagar()
        {
            Console.WriteLine("precione N para apagar el equipo");
            char m= char.Parse(Console.ReadLine());
            if(m=='n'|| m=='n')
            {
                this.encendido=false;
                Console.WriteLine("el dispositivo esta apagado......");
               

            }
            else
            {

                this.Encendido=true;
                Console.WriteLine("se esta encendiendo el equipo");
                
            }
        }
        public void añadirdatos(int datos)
        {
            if (this.encendido)
            {


                if (datos <= this.disco)
                {
                    this.Esp_disp = this.disco - datos;
                    {
                        Console.WriteLine(" la capacidad de disco ha disminuido: {0}", Esp_disp);
                    }
                }
                else
                {
                    Console.WriteLine("no hay espacio en el disco");
                }
            }
            else
            {
                Console.WriteLine(" el equipo esta apagado....");
            }
        }
        public void Eliminardato(int dato)
        {

            if (this.encendido)
            {


                if (dato <= this.Esp_disp)
                {
                    this.disco = this.Esp_disp + dato;
                    {
                        Console.WriteLine(" se elimino el disco y la capacidad de disco ha aumentado: {0}", disco);
                    }
                }
                else
                {
                    Console.WriteLine("no se elimino el dato");
                }
            }
            else
            {
                Console.WriteLine(" el equipo esta apagado....");
            }
        }
    }
}
