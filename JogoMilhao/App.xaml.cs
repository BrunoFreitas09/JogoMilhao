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
                new Alternativa { correta = false, Descricao = "Líquido" },
                new Alternativa { correta = true, Descricao = "Sólido " },
                new Alternativa { correta = false, Descricao = "Gasoso" },
                new Alternativa { Correta = false, Descricao = "Vaporoso" }
            }
        }
    };
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
