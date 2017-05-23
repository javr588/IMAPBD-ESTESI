using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IMAPBD.Models
{
    public class LugarCalModel : IEquatable<LugarCalModel>
    {
        public int Año { get; set; }
        public double bueno { get; set; }
        public string dia { get; set; }
        public string lugar { get; set; }
        public double malo { get; set; }
        public int mes { get; set; }
        public string pais { get; set; }
        public double regular { get; set; }
        public double tedioso { get; set; }

        public bool Equals(LugarCalModel other)
        {

            //Check whether the compared object is null. 
            if (Object.ReferenceEquals(other, null)) return false;

            //Check whether the compared object references the same data. 
            if (Object.ReferenceEquals(this, other)) return true;

            //Check whether the products' properties are equal. 
            return lugar.Equals(other.lugar)
                && pais.Equals(other.pais);
        }

        public override int GetHashCode()
        {
            return this.pais.GetHashCode();
        }

    }
}