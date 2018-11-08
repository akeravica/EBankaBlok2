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

        [DataMember]
        public int Id
        {
            get => id;
            set => id = value;
        }
        [DataMember]
        public float Iznos
        {
            get => iznos;
            set => iznos = value;
        }
    }
}
