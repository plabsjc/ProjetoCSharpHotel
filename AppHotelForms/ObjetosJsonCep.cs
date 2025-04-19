using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AppHotelForms
{
    internal class ObjetosJsonCep
    {

        [JsonProperty(PropertyName = "logradouro")]
        public string Logradouro { get; set; }
        [JsonProperty(PropertyName = "complemento")]
        public string Complemento { get; set; }
        [JsonProperty(PropertyName = "bairro")]
        public string Bairro { get; set; }
        [JsonProperty(PropertyName = "localidade")]
        public string Localidade { get; set; }
        [JsonProperty(PropertyName = "uf")]
        public string Uf { get; set; }
        [JsonProperty(PropertyName = "estado")]
        public string Estado { get; set; }
        [JsonProperty(PropertyName = "regiao")]
        public string Regiao { get; set; }


    }


}


/*{
  "cep": "12211-360",
  "logradouro": "Praça Tabajara",
  "complemento": "",
  "unidade": "",
  "bairro": "Vila Jaci",
  "localidade": "São José dos Campos",
  "uf": "SP",
  "estado": "São Paulo",
  "regiao": "Sudeste",
  "ibge": "3549904",
  "gia": "6452",
  "ddd": "12",
  "siafi": "7099"
}*/