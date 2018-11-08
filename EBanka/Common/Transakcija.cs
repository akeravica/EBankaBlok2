using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [DataContract]
    public class Transakcija
    {
        int id;
        float iznos;

        public Transakcija()
        {
        }

        public Transakcija(int i, float iz)
        {
            this.id = i;
            this.iznos = iz;
        }
        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        [DataMember]
        public float Iznos
        {
            get { return iznos; }
            set { iznos = value; }
        }
    }
}
