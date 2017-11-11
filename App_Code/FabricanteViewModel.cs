using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de FabricanteViewModel
/// </summary>
public class FabricanteViewModel
{
    public int Id { get; set; }
    public string Nome { get; set; }

    public FabricanteViewModel()
    {
        //
        // TODO: Adicionar lógica do construtor aqui
        //
    }

    public FabricanteViewModel(NameValueCollection data)
    {
        Id = Convert.ToInt32(data.Get("Id"));
        Nome = data.Get("Nome");
    }

    public FabricanteViewModel(dynamic data)
    {
        Id = data.Id;
        Nome = data.Nome;
    }
}