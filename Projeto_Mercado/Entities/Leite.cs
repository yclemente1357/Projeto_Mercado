using ConsoleApp6.Enum;
using ConsoleApp6.Interfaces;
using System.Globalization;
using ConsoleApp6.Services;

namespace ConsoleApp6.Entities;
class Leite : IProduto
{
    public string Nome { get; set; }
    public double Valor { get; set; } = 4.50;
    public Tipo _tipo { get; set; }
    public Compra _compra { get; set; } = new Compra();

    public Leite(string nome, Tipo tipo, int quantidade)
    {
        Nome = nome;
        this._tipo = tipo;
        _compra.Quantidade = quantidade;
    }

    public override string ToString()
    {
        return
            Nome
            + ", R$"
            + Valor.ToString("F2", CultureInfo.InvariantCulture)
            + " tipo: "
            + _tipo
            +" Quantidade: "
            + _compra.Quantidade;
    }


}
