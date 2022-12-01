using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LivroCaixaAPI.Src.Modelos
{
    /// <summary>
    /// <para>Resumo: Classe responsavel por representar tb_postagens no banco.</para>
    /// <para>Criado por: Felipe Flor</para>
    /// <para>Versão: 1.0</para>
    /// <para>Data: 01/12/2022</para>
    /// </summary>
    [Table("tb_lancamentos")]
    public class Lancamento
    {
        #region Atributos
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime Date { get; set;  }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public enum TipoLancamento
        {
            Receita,
            Despesa
        }
        public bool Recorrencia { get; set; }

        [ForeignKey("fk_usuario")]
        public Usuario Criador { get; set; }
        #endregion
    }
}
