using IntegracaoLegado.WebService.Entities;
using IntegracaoLegado.WebService.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace IntegracaoLegado.WebService
{
    [ServiceContract]
    public interface IMatriculaService
    {
        [OperationContract]
        IntegraMatriculaResponse IntegraMatricula(Matricula matricula);
    }
}
