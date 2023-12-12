using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace apiUniversidade.DTO
{
    public class UsuarioToken
    {
        public bool Athenticated {get; set;}
        public DateTime Expiration {get; set;}
        public string Token {get; set;}
        public string Message {get; set;}
    }
}
