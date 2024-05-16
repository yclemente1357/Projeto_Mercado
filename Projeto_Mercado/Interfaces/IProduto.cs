using ConsoleApp6.Enum;
using System.Runtime.CompilerServices;

namespace ConsoleApp6.Interfaces;
interface IProduto
{
    public string Nome { get; set; }
    public double Valor { get; set; }
    public Tipo _tipo { get; set; }

}

