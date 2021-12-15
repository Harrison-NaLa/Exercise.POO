using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise.POO.Models
{
    public abstract class Lancha : Acuatico
    {
        public override Motores Motores { get => Motores.tres; }
        public override void Desplazarse() {

        }
    }
}
