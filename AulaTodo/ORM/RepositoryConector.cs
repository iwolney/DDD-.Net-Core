using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace ORM
{
    // Classe para capturar a string de conexão do arquivo .config da Aplicação (Projeto Application aqui)
    public class RepositoryConector
    {
        // Injeção de Dependências (retirando a responsabilidade da classe de estânciar)
        public IConfiguration _configuration;
        public RepositoryConector(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetConnection()
        {
            return _configuration.GetSection("Connections").GetSection("MinhaConnetctionString").Value;
        }
    }
}
