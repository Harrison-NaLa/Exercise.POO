using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise.POO.Models
{
    public abstract class Aereo : Vehiculo
    {
        public ClasificacionAerea ClasificacionAerea { get; set; }
    }
}
