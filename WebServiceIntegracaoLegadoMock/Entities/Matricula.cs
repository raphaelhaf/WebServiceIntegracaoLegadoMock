using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace IntegracaoLegado.WebService.Entities
{
    [DataContract]
    public class Matricula
    {
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public string DataHora { get; set; }

        [DataMember]
        public string Cpf { set; get; }

        [DataMember]
        public long Ra { get; set; }

        [DataMember]
        public bool Ativo { get; set; }

        [DataMember]
        public string OrigemIntegracao { get; set; }

        [DataMember]
        public string IdUsuarioEmail { get; set; }
    }
}