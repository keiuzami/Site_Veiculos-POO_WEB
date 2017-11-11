using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.WebPages;

/// <summary>
/// Descrição resumida de Veiculo
/// </summary>
public class VeiculoViewModel
{

    public String Id { get; }
    public String Nome { get; set; }
    public String Modelo { get; set; }
    public String Imagem { get; set; }
    public int? Ano { get; set; }
    public int? Fabricante_Id { get; set; }
    public String FabricanteNome { get; set; }
    public decimal? PrecoMedio { get; set; }

    public VeiculoViewModel()
    {
    }


    public VeiculoViewModel(NameValueCollection data)
    {
        Id = data.Get("Id");
        Nome = data.Get("Nome");
        Modelo = data.Get("Modelo");
        Imagem = data.Get("Imagem");

        FabricanteNome = data.Get("FabricanteNome");

        Ano = data.Get("Ano").AsInt();
        if (Ano == 0) Ano = null;

        Fabricante_Id = data.Get("Fabricante_Id").AsInt();

        PrecoMedio = data.Get("PrecoMedio").AsDecimal();
        if (PrecoMedio == 0) PrecoMedio = null;

    }

    public VeiculoViewModel(dynamic data)
    {
        Id = data.Id.ToString();
        Nome = data.Nome;
        Modelo = data.Modelo;
        Imagem = data.Imagem;
        Ano = data.Ano;
        Fabricante_Id = data.Fabricante_Id;
        // o parametro pode nao existir, caso aconteça ignoramos
        try { FabricanteNome = data.FabricanteNome; } catch { }
        PrecoMedio = data.PrecoMedio;
    }

}