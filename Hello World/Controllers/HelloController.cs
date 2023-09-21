using Microsoft.AspNetCore.Mvc;

namespace helloworld.Controllers
{
    [Route("~/")]
    [ApiController]
    public class HelloController
    {
        [HttpGet]
        public string Hello()
        {
            return "\n\n\n \t\t\t\t\t Hello Turma .NET03 !! Prazer, meu nome é Fernando.";
        }

        [HttpGet("/bsms")]
        public string BsmsGen()
        {
            return "\t\t\t\t\t MENTALIDADES \n\n" +

                   "\t\t\t\t\t Persistência \n" +
                   "\t\t\t\t\t Mentalidade de Crescimento \n" +
                   "\t\t\t\t\t Responsabilidade Pessoal\n" +
                   "\t\t\t\t\t Orientação ao Futuro\n\n" +

                   "\t\t\t\t\t HABILIDADES COMPORTAMENTAIS \n\n" +

                   "\t\t\t\t\t Comunicação \n" +
                   "\t\t\t\t\t Orientação ao Detalhe\n" +
                   "\t\t\t\t\t Proatividade\n" +
                   "\t\t\t\t\t Trabalho em Equipe\n";
        }

        [HttpGet("/objetivosaprendizagem")]
        public string ObjetivosAprendizagem()
        {
            return "\n\n\n \t\t\t\t\t   Conseguir até o fim de samana, de preferência até amanhã ao fim do dia, concluir o conteúdo \n" +
                   "\t\t\t técnico do Asp.Net passado até agora com uma razoável compreensão e conseguindo aplicar, fazendo conexões com \n" +
                   "\t\t\t matérias que já foram passadas.";
        }

        [HttpGet("/infocompleta")]
        public string InfoCompleta()
        {
            return "\n\n\n \t\t\t\t\t Hello Turma .NET03 !! Prazer, meu nome é Fernando. \n\n\n" +

                   "\t\t\t\t\t MENTALIDADES \n\n" +

                   "\t\t\t\t\t Persistência \n" +
                   "\t\t\t\t\t Mentalidade de Crescimento \n" +
                   "\t\t\t\t\t Responsabilidade Pessoal\n" +
                   "\t\t\t\t\t Orientação ao Futuro\n\n" +

                   "\t\t\t\t\t HABILIDADES COMPORTAMENTAIS \n\n" +

                   "\t\t\t\t\t Comunicação \n" +
                   "\t\t\t\t\t Orientação ao Detalhe\n" +
                   "\t\t\t\t\t Proatividade\n" +
                   "\t\t\t\t\t Trabalho em Equipe\n" +

                   "\n\n\n \t\t\t\t\t\tConseguir até o fim de samana, de preferência até amanhã ao fim do dia, concluir o conteúdo \n" +
                   "\t\t\t\t\t técnico do Asp.Net passado até agora com uma razoável compreensão e conseguindo aplicar, fazendo conexões com \n" +
                   "\t\t\t\t\t matérias que já foram passadas.";

        }
    }
}
