using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imobiliaria.Models
{
    public class Imovel {
        public int id_imovel { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public float valor { get; set; }
        public int imagem { get; set; }
        public int tipo_imovel { get; set; }
        public int tipo_localidade { get; set; }
        public int tipo_negocio { get; set; }
    }

    public class Imagem {
        public int id_imagem { get; set; }
        public int imagem { get; set; }
    }

    public class Tipo_Imovel {
        public int id_tipo_imovel { get; set; }
        public nome_tipo_imovel nome_tipo_imovel { get; set; }
    }

    public enum nome_tipo_imovel {
        Casa,
        Apartamento,
        Sítio
    }

    public class Tipo_Localidade {
        public int id_tipo_localidade { get; set; }
        public nome_tipo_localidade nome_tipo_localidade { get; set; }
    }

    public enum nome_tipo_localidade {
        Urbano,
        Rural
    }

    public class Tipo_Negocio {
        public int id_tipo_negocio { get; set; }
        public nome_tipo_negocio nome_tipo_negocio { get; set; }
    }

    public enum nome_tipo_negocio {
        Venda,
        Locação
    }
}