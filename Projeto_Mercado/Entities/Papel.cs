using ConsoleApp6.Enum;
using ConsoleApp6.Interfaces;
using ConsoleApp6.Services;
using System.Globalization;

namespace ConsoleApp6.Entities;
class Papel : IProduto
{
    public string Nome { get; set; }
    public double Valor { get; set; } = 12.0;
    public Tipo _tipo { get; set; }
    public Compra _compra { get; set; } = new Compra();

    public Papel(string nome, Tipo tipo, int quantidade) 
    {
        Nome = nome;
        this._tipo = tipo;
        _compra.Quantidade = quantidade;
    }


    public override string ToString()
    {
        return Nome
            + ", R$"
            + Valor.ToString("F2", CultureInfo.InvariantCulture)
            + " tipo: "
            + _tipo
            +" Quantidade: "
            + _compra.Quantidade;
    }
}
