using System;
using Imobiliaria.Models;

class Program
{
    static void Main(string[] args)
    {
        Imovel i1 = new Imovel();
        
        i1.id_imovel = 1;
        i1.nome = "Apartamento 201";
        i1.descricao = "Apartamento com 1 cozinha, 1 sala, 1 banheiro, 2 quartos, 1 lavanderia, 3 sacadas";
        i1.valor = 500000;
        i1.tipo_imovel = (int)nome_tipo_imovel.Apartamento;
        i1.tipo_localidade = (int)nome_tipo_localidade.Urbano;
        i1.tipo_negocio = (int)nome_tipo_negocio.Venda;
        
        Console.WriteLine("---------------------------");
        Console.WriteLine($"Nome: {i1.nome}");
        Console.WriteLine($"Descrição: {i1.descricao}");
        Console.WriteLine($"Valor: R$ {i1.valor}");
        Console.WriteLine($"Tipo de Imóvel: {Enum.GetName(typeof(nome_tipo_imovel), i1.tipo_imovel)}");
        Console.WriteLine($"Tipo de Localidade: {Enum.GetName(typeof(nome_tipo_localidade), i1.tipo_localidade)}");
        Console.WriteLine($"Tipo de Negócio: {Enum.GetName(typeof(nome_tipo_negocio), i1.tipo_negocio)}");
    }
}
