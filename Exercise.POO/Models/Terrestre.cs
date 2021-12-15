using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise.POO.Models
{
    public abstract class Terrestre: Vehiculo
    {
       public CantidadDeRuedas CantidadDeRuedas { get; set; }
    }
}
