using JogoMilhao.Models;
using System.Collections.Generic;

namespace JogoMilhao
{
    public partial class App : Application
    {
        // Lista de perguntas fáceis
        List<Pergunta> Perguntas_faceis = new()
        {
            new Pergunta
            {
                Id = 1,
                Enunciado = "Em que estado brasileiro nasceu a apresentadora Xuxa?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "RIO DE JANEIRO"},
                    new Alternativa {Correta = true, Descricao = "RIO GRANDE DO SUL"},
                    new Alternativa {Correta = false, Descricao = "SANTA CATARINA"},
                    new Alternativa {Correta = false, Descricao = "GOIÁS"},
                }
            },
            new Pergunta
            {
                Id = 2,
                Enunciado = "Qual é o nome dado ao estado da água em forma de gelo?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "LÍQUIDO"},
                    new Alternativa {Correta = true, Descricao = "SÓLIDO"},
                    new Alternativa {Correta = false, Descricao = "GASOSO"},
                    new Alternativa {Correta = false, Descricao = "VAPOROSO"},
                }
            },
            new Pergunta
            {
                Id = 3,
                Enunciado = "Qual era o apelido da cantora Elis Regina?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "GAUCHINHA"},
                    new Alternativa {Correta = false, Descricao = "PAULISTINHA"},
                    new Alternativa {Correta = true, Descricao = "PIMENTINHA"},
                    new Alternativa {Correta = false, Descricao = "ANDORINHA"},
                }
            },
            new Pergunta
            {
                Id = 4,
                Enunciado = "Quem é a namorada do Mickey?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "MARGARIDA"},
                    new Alternativa {Correta = true, Descricao = "MINNIE"},
                    new Alternativa {Correta = false, Descricao = "A PEQUENA SEREIA"},
                    new Alternativa {Correta = false, Descricao = "OLÍVIA PALITO"},
                }
            },
            new Pergunta
            {
                Id = 5,
                Enunciado = "Qual é o personagem do folclore brasileiro que tem uma perna só?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "CUCA"},
                    new Alternativa {Correta = false, Descricao = "NEGRINHO DO PASTOREIO"},
                    new Alternativa {Correta = false, Descricao = "BOITATÁ"},
                    new Alternativa {Correta = true, Descricao = "SACI-PERERÊ"},
                }
            },
            new Pergunta
            {
                Id = 6,
                Enunciado = "Fidel Castro nasceu em que país?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "JAMAICA"},
                    new Alternativa {Correta = true, Descricao = "CUBA"},
                    new Alternativa {Correta = false, Descricao = "EL SALVADOR"},
                    new Alternativa {Correta = false, Descricao = "MÉXICO"},
                }
            },
            new Pergunta
            {
                Id = 7,
                Enunciado = "Quem proclamou a república no Brasil em 1889?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "DUQUE DE CAXIAS"},
                    new Alternativa {Correta = false, Descricao = "MARECHAL RONDON"},
                    new Alternativa {Correta = false, Descricao = "DOM PEDRO II"},
                    new Alternativa {Correta = true, Descricao = "MARECHAL DEODORO"},
                }
            },
            new Pergunta
            {
                Id = 8,
                Enunciado = "Quem é o patrono do exército brasileiro?",
                Alternativas = new()
                {
                    new Alternativa {Correta = true, Descricao = "DUQUE DE CAXIAS"},
                    new Alternativa {Correta = false, Descricao = "MARECHAL DEODORO"},
                    new Alternativa {Correta = false, Descricao = "BARÃO DE MAUÁ"},
                    new Alternativa {Correta = false, Descricao = "MARQUÊS DE POMBAL"},
                }
            },
            new Pergunta
            {
                Id = 9,
                Enunciado = "Quem era o apresentador que reprovava os calouros tocando uma buzina?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "RAUL GIL"},
                    new Alternativa {Correta = false, Descricao = "BOLINHA"},
                    new Alternativa {Correta = false, Descricao = "FLÁVIO CAVALCANTI"},
                    new Alternativa {Correta = true, Descricao = "CHACRINHA"},
                }
            },
            new Pergunta
            {
                Id = 10,
                Enunciado = "O que era Frankenstein, de Mary Shelley?",
                Alternativas = new()
                {
                    new Alternativa {Correta = true, Descricao = "MONSTRO"},
                    new Alternativa {Correta = false, Descricao = "GORILA"},
                    new Alternativa {Correta = false, Descricao = "PRÍNCIPE"},
                    new Alternativa {Correta = false, Descricao = "SAPO"},
                }
            },
            new Pergunta
            {
                Id = 11,
                Enunciado = "Qual é o signo do zodíaco de quem nasce no dia do ano-novo?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "VIRGEM"},
                    new Alternativa {Correta = false, Descricao = "AQUÁRIO"},
                    new Alternativa {Correta = true, Descricao = "CAPRICÓRNIO"},
                    new Alternativa {Correta = false, Descricao = "ÁRIES"},
                }
            },
            new Pergunta
            {
                Id = 12,
                Enunciado = "Quem fundou a fábrica de automóveis Ford?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "HARRISON FORD"},
                    new Alternativa {Correta = false, Descricao = "GERALD FORD"},
                    new Alternativa {Correta = true, Descricao = "HENRY FORD"},
                    new Alternativa {Correta = false, Descricao = "ANNA FORD"},
                }
            },
            new Pergunta
            {
                Id = 13,
                Enunciado = "Qual é a cor que se associa com os grupos ecológicos?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "PRETA"},
                    new Alternativa {Correta = false, Descricao = "VERMELHA"},
                    new Alternativa {Correta = false, Descricao = "AZUL"},
                    new Alternativa {Correta = true, Descricao = "VERDE"},
                }
            },
            new Pergunta
            {
                Id = 14,
                Enunciado = "A água ferve a quantos graus centígrados?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "200"},
                    new Alternativa {Correta = true, Descricao = "100"},
                    new Alternativa {Correta = false, Descricao = "170"},
                    new Alternativa {Correta = false, Descricao = "220"},
                }
            },
            new Pergunta
            {
                Id = 15,
                Enunciado = "Quando é comemorado o dia da independência do Brasil?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "21 DE ABRIL"},
                    new Alternativa {Correta = false, Descricao = "12 DE OUTUBRO"},
                    new Alternativa {Correta = true, Descricao = "7 DE SETEMBRO"},
                    new Alternativa {Correta = false, Descricao = "25 DE DEZEMBRO"},
                }
            },
            new Pergunta
            {
                Id = 16,
                Enunciado = "Qual lugar é também chamado de Santa Sé?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "VENEZA"},
                    new Alternativa {Correta = false, Descricao = "VITÓRIA"},
                    new Alternativa {Correta = false, Descricao = "VANCOUVER"},
                    new Alternativa {Correta = true, Descricao = "VATICANO"},
                }
            },
            new Pergunta
            {
                Id = 17,
                Enunciado = "Quem tem por lema a frase: “Sempre alerta”?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "MÉDICOS"},
                    new Alternativa {Correta = true, Descricao = "ESCOTEIROS"},
                    new Alternativa {Correta = false, Descricao = "BOMBEIROS"},
                    new Alternativa {Correta = false, Descricao = "POLICIAIS"},
                }
            },
            new Pergunta
            {
                Id = 18,
                Enunciado = "Qual é a nacionalidade de Che Guevara?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "CUBANA"},
                    new Alternativa {Correta = true, Descricao = "ARGENTINA"},
                    new Alternativa {Correta = false, Descricao = "MEXICANA"},
                    new Alternativa {Correta = false, Descricao = "VENEZUELANA"},
                }
            },
            new Pergunta
            {
                Id = 19,
                Enunciado = "Quem fundou a Microsoft?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "STEVEN SPIELBERG"},
                    new Alternativa {Correta = false, Descricao = "BILL CLINTON"},
                    new Alternativa {Correta = true, Descricao = "BILL GATES"},
                    new Alternativa {Correta = false, Descricao = "STEVEN JOBS"},
                }
            },
            new Pergunta
            {
                Id = 20,
                Enunciado = "Onde vivia o Sultão Harun Al Rachid?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "DAMASCO"},
                    new Alternativa {Correta = true, Descricao = "BAGDÁ"},
                    new Alternativa {Correta = false, Descricao = "ISTAMBUL"},
                    new Alternativa {Correta = false, Descricao = "JERUSALÉM"},
                }
            }
        };

        List<Pergunta> Perguntas_medias = new()
        {
            new Pergunta
            {
                Id = 1,
                Enunciado = "Em que estado brasileiro nasceu a apresentadora Xuxa?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "RIO DE JANEIRO"},
                    new Alternativa {Correta = true, Descricao = "RIO GRANDE DO SUL"},
                    new Alternativa {Correta = false, Descricao = "SANTA CATARINA"},
                    new Alternativa {Correta = false, Descricao = "GOIÁS"},
                }
            },
            new Pergunta
            {
                Id = 2,
                Enunciado = "Qual é o nome dado ao estado da água em forma de gelo?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "LÍQUIDO"},
                    new Alternativa {Correta = true, Descricao = "SÓLIDO"},
                    new Alternativa {Correta = false, Descricao = "GASOSO"},
                    new Alternativa {Correta = false, Descricao = "VAPOROSO"},
                }
            },
            new Pergunta
            {
                Id = 3,
                Enunciado = "Qual era o apelido da cantora Elis Regina?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "GAUCHINHA"},
                    new Alternativa {Correta = false, Descricao = "PAULISTINHA"},
                    new Alternativa {Correta = true, Descricao = "PIMENTINHA"},
                    new Alternativa {Correta = false, Descricao = "ANDORINHA"},
                }
            },
            new Pergunta
            {
                Id = 4,
                Enunciado = "Quem é a namorada do Mickey?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "MARGARIDA"},
                    new Alternativa {Correta = true, Descricao = "MINNIE"},
                    new Alternativa {Correta = false, Descricao = "A PEQUENA SEREIA"},
                    new Alternativa {Correta = false, Descricao = "OLÍVIA PALITO"},
                }
            },
            new Pergunta
            {
                Id = 5,
                Enunciado = "Qual é o personagem do folclore brasileiro que tem uma perna só?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "CUCA"},
                    new Alternativa {Correta = false, Descricao = "NEGRINHO DO PASTOREIO"},
                    new Alternativa {Correta = false, Descricao = "BOITATÁ"},
                    new Alternativa {Correta = true, Descricao = "SACI-PERERÊ"},
                }
            },
            new Pergunta
            {
                Id = 6,
                Enunciado = "Fidel Castro nasceu em que país?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "JAMAICA"},
                    new Alternativa {Correta = true, Descricao = "CUBA"},
                    new Alternativa {Correta = false, Descricao = "EL SALVADOR"},
                    new Alternativa {Correta = false, Descricao = "MÉXICO"},
                }
            },
            new Pergunta
            {
                Id = 7,
                Enunciado = "Quem proclamou a república no Brasil em 1889?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "DUQUE DE CAXIAS"},
                    new Alternativa {Correta = false, Descricao = "MARECHAL RONDON"},
                    new Alternativa {Correta = false, Descricao = "DOM PEDRO II"},
                    new Alternativa {Correta = true, Descricao = "MARECHAL DEODORO"},
                }
            },
            new Pergunta
            {
                Id = 8,
                Enunciado = "Quem é o patrono do exército brasileiro?",
                Alternativas = new()
                {
                    new Alternativa {Correta = true, Descricao = "DUQUE DE CAXIAS"},
                    new Alternativa {Correta = false, Descricao = "MARECHAL DEODORO"},
                    new Alternativa {Correta = false, Descricao = "BARÃO DE MAUÁ"},
                    new Alternativa {Correta = false, Descricao = "MARQUÊS DE POMBAL"},
                }
            },
            new Pergunta
            {
                Id = 9,
                Enunciado = "Quem era o apresentador que reprovava os calouros tocando uma buzina?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "RAUL GIL"},
                    new Alternativa {Correta = false, Descricao = "BOLINHA"},
                    new Alternativa {Correta = false, Descricao = "FLÁVIO CAVALCANTI"},
                    new Alternativa {Correta = true, Descricao = "CHACRINHA"},
                }
            },
            new Pergunta
            {
                Id = 10,
                Enunciado = "O que era Frankenstein, de Mary Shelley?",
                Alternativas = new()
                {
                    new Alternativa {Correta = true, Descricao = "MONSTRO"},
                    new Alternativa {Correta = false, Descricao = "GORILA"},
                    new Alternativa {Correta = false, Descricao = "PRÍNCIPE"},
                    new Alternativa {Correta = false, Descricao = "SAPO"},
                }
            },
            new Pergunta
            {
                Id = 11,
                Enunciado = "Qual é o signo do zodíaco de quem nasce no dia do ano-novo?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "VIRGEM"},
                    new Alternativa {Correta = false, Descricao = "AQUÁRIO"},
                    new Alternativa {Correta = true, Descricao = "CAPRICÓRNIO"},
                    new Alternativa {Correta = false, Descricao = "ÁRIES"},
                }
            },
            new Pergunta
            {
                Id = 12,
                Enunciado = "Quem fundou a fábrica de automóveis Ford?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "HARRISON FORD"},
                    new Alternativa {Correta = false, Descricao = "GERALD FORD"},
                    new Alternativa {Correta = true, Descricao = "HENRY FORD"},
                    new Alternativa {Correta = false, Descricao = "ANNA FORD"},
                }
            },
            new Pergunta
            {
                Id = 13,
                Enunciado = "Qual é a cor que se associa com os grupos ecológicos?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "PRETA"},
                    new Alternativa {Correta = false, Descricao = "VERMELHA"},
                    new Alternativa {Correta = false, Descricao = "AZUL"},
                    new Alternativa {Correta = true, Descricao = "VERDE"},
                }
            },
            new Pergunta
            {
                Id = 14,
                Enunciado = "A água ferve a quantos graus centígrados?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "200"},
                    new Alternativa {Correta = true, Descricao = "100"},
                    new Alternativa {Correta = false, Descricao = "170"},
                    new Alternativa {Correta = false, Descricao = "220"},
                }
            },
            new Pergunta
            {
                Id = 15,
                Enunciado = "Quando é comemorado o dia da independência do Brasil?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "21 DE ABRIL"},
                    new Alternativa {Correta = false, Descricao = "12 DE OUTUBRO"},
                    new Alternativa {Correta = true, Descricao = "7 DE SETEMBRO"},
                    new Alternativa {Correta = false, Descricao = "25 DE DEZEMBRO"},
                }
            },
            new Pergunta
            {
                Id = 16,
                Enunciado = "Qual lugar é também chamado de Santa Sé?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "VENEZA"},
                    new Alternativa {Correta = false, Descricao = "VITÓRIA"},
                    new Alternativa {Correta = false, Descricao = "VANCOUVER"},
                    new Alternativa {Correta = true, Descricao = "VATICANO"},
                }
            },
            new Pergunta
            {
                Id = 17,
                Enunciado = "Quem tem por lema a frase: “Sempre alerta”?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "MÉDICOS"},
                    new Alternativa {Correta = true, Descricao = "ESCOTEIROS"},
                    new Alternativa {Correta = false, Descricao = "BOMBEIROS"},
                    new Alternativa {Correta = false, Descricao = "POLICIAIS"},
                }
            },
            new Pergunta
            {
                Id = 18,
                Enunciado = "Qual é a nacionalidade de Che Guevara?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "CUBANA"},
                    new Alternativa {Correta = true, Descricao = "ARGENTINA"},
                    new Alternativa {Correta = false, Descricao = "MEXICANA"},
                    new Alternativa {Correta = false, Descricao = "VENEZUELANA"},
                }
            },
            new Pergunta
            {
                Id = 19,
                Enunciado = "Quem fundou a Microsoft?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "STEVEN SPIELBERG"},
                    new Alternativa {Correta = false, Descricao = "BILL CLINTON"},
                    new Alternativa {Correta = true, Descricao = "BILL GATES"},
                    new Alternativa {Correta = false, Descricao = "STEVEN JOBS"},
                }
            },
            new Pergunta
            {
                Id = 20,
                Enunciado = "Onde vivia o Sultão Harun Al Rachid?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "DAMASCO"},
                    new Alternativa {Correta = true, Descricao = "BAGDÁ"},
                    new Alternativa {Correta = false, Descricao = "ISTAMBUL"},
                    new Alternativa {Correta = false, Descricao = "JERUSALÉM"},
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
