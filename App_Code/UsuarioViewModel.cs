using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de UsuarioViewModel
/// </summary>
public class UsuarioViewModel
{
    public UsuarioViewModel()
    {
        //
        // TODO: Adicionar lógica do construtor aqui
        //
    }
    public UsuarioViewModel(dynamic obj)
    {
        Nome = obj.nome;
        Email = obj.email;
    }

    public string Nome { get; set; }
    public string Email { get; set; }    
}