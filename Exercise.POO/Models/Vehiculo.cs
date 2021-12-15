using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise.POO.Models
{
    public abstract class Vehiculo
    {
        public string Nombre { get; set; }
        public string Referencia { get; set; }
        public string Modelo { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public string Propietario { get; set; }
        public string Dimenciones { get; set; }
        public float Peso { get; set; }
        public abstract Motores Motores { get;} 
        public void ProducirSonido()
        {
            Console.Write("Estoy sonando");
        }
        public abstract void Desplazarse();
        public abstract TipoDeCombustion TipoDeCombustion { get; set; }
        public abstract TipoDeDesplazamiento TipoDeDesplazamiento { get; }
    }
}
