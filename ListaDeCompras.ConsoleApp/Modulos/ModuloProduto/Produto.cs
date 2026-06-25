using ListaDeCompras.ConsoleApp.Compartilhado;
using ListaDeCompras.ConsoleApp.Modulos.ModuloCategoria;

namespace ListaDeCompras.ConsoleApp.Modulos.ModuloProduto;

public static class GeradorIdsProduto
{
    private static int contadorIds = 1;

    public static int GerarId()
    {
        return contadorIds++;
    }
}

public enum UnidadeMedidaProduto
{
    Unidade,
    Caixa,
    Duzia,
    Kg,
    L,
    Ml,
    G
}

public class Produto : EntidadeBase
{
    public string Nome { get; private set; }
    public Categoria Categoria { get; private set; }
    public int ValorUnidadeMedida { get; private set; }
    public UnidadeMedidaProduto UnidadeMedida { get; private set; } = UnidadeMedidaProduto.Unidade;
    public decimal PrecoAproximado { get; private set; }

    public Produto(
        string nome,
        Categoria categoria,
        int valorUnidadeMedida,
        UnidadeMedidaProduto unidadeMedida,
        decimal precoAproximado)
    {
        Id = GeradorIdsProduto.GerarId();

        Nome = nome;
        Categoria = categoria;
        ValorUnidadeMedida = valorUnidadeMedida;
        UnidadeMedida = unidadeMedida;
        PrecoAproximado = precoAproximado;
    }

    public override void Atualizar(EntidadeBase entidadeAtualizada)
    {
        Produto produtoAtualizado = (Produto)entidadeAtualizada;

        Nome = produtoAtualizado.Nome;
        Categoria = produtoAtualizado.Categoria;
        ValorUnidadeMedida = produtoAtualizado.ValorUnidadeMedida;
        UnidadeMedida = produtoAtualizado.UnidadeMedida;
        PrecoAproximado = produtoAtualizado.PrecoAproximado;
    }
}
