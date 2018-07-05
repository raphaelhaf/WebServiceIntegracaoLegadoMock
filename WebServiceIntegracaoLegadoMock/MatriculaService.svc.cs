using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using IntegracaoLegado.WebService.Entities;
using IntegracaoLegado.WebService.Response;

namespace IntegracaoLegado.WebService
{
    public class MatriculaService : IMatriculaService
    {
        public IntegraMatriculaResponse IntegraMatricula(Matricula matricula)
        {
            return new IntegraMatriculaResponse {
                Id = matricula.Id,
                DataHora = matricula.DataHora,
                Cpf = matricula.Cpf,
                Ra = matricula.Ra,
                Ativo = matricula.Ativo,
                OrigemIntegracao = matricula.OrigemIntegracao,
                Mensagem = "Matricula integrada com sucesso!",
                IdUsuarioEmail = matricula.IdUsuarioEmail
            };
        }
    }
}
