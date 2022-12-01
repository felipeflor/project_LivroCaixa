using LivroCaixaAPI.Src.Modelos;
using Microsoft.EntityFrameworkCore;

namespace LivroCaixaAPI.Src.Contextos
{
    /// <summary>
    /// <para>Resumo: Classe contexto, responsavel por carregar contexto e definir DbSets</para>
    /// <para>Criado por: Felipe Flor</para>
    /// <para>Versão: 1.0</para>
    /// <para>Data: 01/12/2022</para>/
    /// </summary>

    public class LivroCaixaContexto : DbContext
    {
        #region Atributos
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Lancamento> Lancamentos { get; set; }
        #endregion

        #region Construtores
        public LivroCaixaContexto(DbContextOptions<LivroCaixaContexto> opt) : base(opt)
        {

        }
        #endregion
    }
}
