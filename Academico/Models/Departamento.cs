using System.ComponentModel.DataAnnotations;

namespace Academico.Models
{
    public class Departamento
    {
        public int DepartamentoId { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set;}
        public string Cep { get; set; }
        [Display (Name =("E-mail"))]
        public string Email { get; set; }
        [Display(Name =("Instituição"))]
        public int InstituicaoId { get; set; }

        [Display(Name = ("Instituição"))]
        public Instituicao? InstituicaoOrigem { get; set; }

        [Display(Name = ("Coordenador"))]
        public string NomeCoordenador { get; set; }

    }
}
