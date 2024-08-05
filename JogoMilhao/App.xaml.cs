using JogoMilhao.Models;

namespace JogoMilhao
{
    public partial class App : Application
    {
        List<Pergunta> Perguntas_faceis = new()
        {
            new Pergunta
            {
                Id = 1,
                Enunciado = "Qual o nome dado a água em forma de gelo?" ,
                Alternativas = new (),
                new Alternativa { correta = false, Descricao = "Líquido" },
                new Alternativa { correta = true, Descricao = "Sólido " },
                new Alternativa { correta = false, Descricao = "Gasoso" },
                new Alternativa { Correta = false, Descricao = "Vaporoso" }
            },

            new Pergunta
            {
                Id =  2,
                Enunciado = "Em que estado brasileir nasceu a apresentadora Xuxa?",
                Alternativas = new () ,
                new Alternativa { correta = false, Descricao = "Rio de Janeiro" },
                new Alternativa { correta = true, Descricao = "Rio Grande Do Sul " },
                new Alternativa { correta = false, Descricao = "Santa catarina" },
                new Alternativa { Correta = false, Descricao = "Goiás" }

            },

            new Pergunta
            {
                Id =  3,
                Enunciado = " Qual era o apelido da cantora Elis Regina?" ,
                Alternativas = new () ,
                new Alternativa { correta = false, Descricao = "Gauchinha" },
                new Alternativa { correta = true, Descricao = "Paulistinha" },
                new Alternativa { correta = false, Descricao = "Pimentinha" },
                new Alternativa { Correta = false, Descricao = "Andorinha" }

            }


        };


    };
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
