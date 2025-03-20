using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace prevdent.domain.Entities;

[Table("ch_tb_dentista")]
public class DentistaEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int id_dentista { get; set; }
    public string nome { get; set; }
    public int idade { get; set; }
    public string email { get; set; }
    public string cro { get; set; }
}
