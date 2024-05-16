using ConsoleApp6.Interfaces;
using System.Xml;

namespace ConsoleApp6.Services;
internal class Compra
{
    public int Quantidade { get; set; }
    public IProduto ItensCompra { get; set; }

    public void Somando(int _quantidade, IProduto name)
    {
       name.Valor = name.Valor * _quantidade;
    }
}
