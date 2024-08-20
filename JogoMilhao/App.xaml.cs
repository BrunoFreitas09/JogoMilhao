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
                Enunciado = "Quem tem por lema a frase “O amor é a resposta”?",
                Alternativas = new()
                {
                    new Alternativa {Correta = true, Descricao = "BEATLES"},
                    new Alternativa {Correta = false, Descricao = "MICHAEL JACKSON"},
                    new Alternativa {Correta = false, Descricao = "KISS"},
                    new Alternativa {Correta = false, Descricao = "ROD STEWART"},
                }
            },
            new Pergunta
            {
                Id = 18,
                Enunciado = "Qual é o principal alimento dos pandas?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "FRUTAS"},
                    new Alternativa {Correta = false, Descricao = "INSETOS"},
                    new Alternativa {Correta = false, Descricao = "PEIXES"},
                    new Alternativa {Correta = true, Descricao = "BAMBU"},
                }
            },
            new Pergunta
            {
                Id = 19,
                Enunciado = "Qual é o maior planeta do sistema solar?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "SATURNO"},
                    new Alternativa {Correta = false, Descricao = "NETUNO"},
                    new Alternativa {Correta = false, Descricao = "URANO"},
                    new Alternativa {Correta = true, Descricao = "JÚPITER"},
                }
            },
            new Pergunta
            {
                Id = 20,
                Enunciado = "Qual é a capital da Austrália?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "SYDNEY"},
                    new Alternativa {Correta = false, Descricao = "MELBOURNE"},
                    new Alternativa {Correta = true, Descricao = "CANBERRA"},
                    new Alternativa {Correta = false, Descricao = "PERTH"},
                }
            }
        };

        // Lista de perguntas médias
        List<Pergunta> Perguntas_medianas = new()
        {
            new Pergunta
            {
                Id = 1,
                Enunciado = "Qual é a fórmula da água?",
                Alternativas = new()
                {
                    new Alternativa {Correta = true, Descricao = "H2O"},
                    new Alternativa {Correta = false, Descricao = "CO2"},
                    new Alternativa {Correta = false, Descricao = "CH4"},
                    new Alternativa {Correta = false, Descricao = "O2"},
                }
            },
            new Pergunta
            {
                Id = 2,
                Enunciado = "Quem é o autor de 'Dom Quixote'?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "MIGUEL DE CERVANTES"},
                    new Alternativa {Correta = true, Descricao = "JOSÉ SARAMAGO"},
                    new Alternativa {Correta = false, Descricao = "MACHADO DE ASSIS"},
                    new Alternativa {Correta = false, Descricao = "JORGE AMADO"},
                }
            },
            new Pergunta
            {
                Id = 3,
                Enunciado = "Qual é a capital do Japão?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "PEQUIM"},
                    new Alternativa {Correta = false, Descricao = "SEOUL"},
                    new Alternativa {Correta = true, Descricao = "TÓQUIO"},
                    new Alternativa {Correta = false, Descricao = "HONG KONG"},
                }
            },
            new Pergunta
            {
                Id = 4,
                Enunciado = "Em que ano o homem pisou na Lua pela primeira vez?",
                Alternativas = new()
                {
                    new Alternativa {Correta = true, Descricao = "1969"},
                    new Alternativa {Correta = false, Descricao = "1959"},
                    new Alternativa {Correta = false, Descricao = "1971"},
                    new Alternativa {Correta = false, Descricao = "1980"},
                }
            },
            new Pergunta
            {
                Id = 5,
                Enunciado = "Qual é o símbolo químico do ouro?",
                Alternativas = new()
                {
                    new Alternativa {Correta = true, Descricao = "AU"},
                    new Alternativa {Correta = false, Descricao = "AG"},
                    new Alternativa {Correta = false, Descricao = "FE"},
                    new Alternativa {Correta = false, Descricao = "PB"},
                }
            },
            new Pergunta
            {
                Id = 6,
                Enunciado = "Qual é a principal função do coração?",
                Alternativas = new()
                {
                    new Alternativa {Correta = true, Descricao = "PUMPAR O SANGUE"},
                    new Alternativa {Correta = false, Descricao = "FILTRAR O SANGUE"},
                    new Alternativa {Correta = false, Descricao = "CONTROLAR A PRESSÃO"},
                    new Alternativa {Correta = false, Descricao = "ARMAZENAR O SANGUE"},
                }
            },
            new Pergunta
            {
                Id = 7,
                Enunciado = "Qual é a língua oficial da China?",
                Alternativas = new()
                {
                    new Alternativa {Correta = true, Descricao = "MANDARIM"},
                    new Alternativa {Correta = false, Descricao = "JAPONÊS"},
                    new Alternativa {Correta = false, Descricao = "COREANO"},
                    new Alternativa {Correta = false, Descricao = "VIETNAME"},
                }
            },
            new Pergunta
            {
                Id = 8,
                Enunciado = "Quem escreveu 'O Senhor dos Anéis'?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "C.S. LEWIS"},
                    new Alternativa {Correta = true, Descricao = "J.R.R. TOLKIEN"},
                    new Alternativa {Correta = false, Descricao = "GEORGE R.R. MARTIN"},
                    new Alternativa {Correta = false, Descricao = "H.P. LOVECRAFT"},
                }
            },
            new Pergunta
            {
                Id = 9,
                Enunciado = "Qual é o planeta mais próximo do Sol?",
                Alternativas = new()
                {
                    new Alternativa {Correta = true, Descricao = "MERCÚRIO"},
                    new Alternativa {Correta = false, Descricao = "VÊNUS"},
                    new Alternativa {Correta = false, Descricao = "TERRA"},
                    new Alternativa {Correta = false, Descricao = "MARTE"},
                }
            },
            new Pergunta
            {
                Id = 10,
                Enunciado = "Qual é a maior montanha do mundo?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "MONT BLANC"},
                    new Alternativa {Correta = false, Descricao = "MONT EVEREST"},
                    new Alternativa {Correta = false, Descricao = "MONT FUJI"},
                    new Alternativa {Correta = true, Descricao = "MONT EVEREST"},
                }
            },
            new Pergunta
            {
                Id = 11,
                Enunciado = "Qual é o maior oceano do mundo?",
                Alternativas = new()
                {
                    new Alternativa {Correta = true, Descricao = "OCEANO PACÍFICO"},
                    new Alternativa {Correta = false, Descricao = "OCEANO ATLÂNTICO"},
                    new Alternativa {Correta = false, Descricao = "OCEANO ÁRTICO"},
                    new Alternativa {Correta = false, Descricao = "OCEANO ANTÁRTICO"},
                }
            },
            new Pergunta
            {
                Id = 12,
                Enunciado = "Qual é a capital da França?",
                Alternativas = new()
                {
                    new Alternativa {Correta = true, Descricao = "PARIS"},
                    new Alternativa {Correta = false, Descricao = "LONDRES"},
                    new Alternativa {Correta = false, Descricao = "BERLIM"},
                    new Alternativa {Correta = false, Descricao = "MADRI"},
                }
            },
            new Pergunta
            {
                Id = 13,
                Enunciado = "Qual é a principal religião do Japão?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "CRISTIANISMO"},
                    new Alternativa {Correta = false, Descricao = "ISLAMISMO"},
                    new Alternativa {Correta = true, Descricao = "XINTOÍSMO"},
                    new Alternativa {Correta = false, Descricao = "HINDUÍSMO"},
                }
            },
            new Pergunta
            {
                Id = 14,
                Enunciado = "Qual é a fórmula química da glicose?",
                Alternativas = new()
                {
                    new Alternativa {Correta = true, Descricao = "C6H12O6"},
                    new Alternativa {Correta = false, Descricao = "C6H6O6"},
                    new Alternativa {Correta = false, Descricao = "C6H12O7"},
                    new Alternativa {Correta = false, Descricao = "C5H10O5"},
                }
            },
            new Pergunta
            {
                Id = 15,
                Enunciado = "Quem foi o primeiro presidente do Brasil?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "D. PEDRO I"},
                    new Alternativa {Correta = true, Descricao = "MARECHAL DEODORO DA FONSECA"},
                    new Alternativa {Correta = false, Descricao = "GETÚLIO VARGAS"},
                    new Alternativa {Correta = false, Descricao = "JUSCELINO KUBITSCHEK"},
                }
            },
            new Pergunta
            {
                Id = 16,
                Enunciado = "Qual é o maior deserto do mundo?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "DESERTO DO SAARA"},
                    new Alternativa {Correta = false, Descricao = "DESERTO DE GOBI"},
                    new Alternativa {Correta = false, Descricao = "DESERTO DE ATACAMA"},
                    new Alternativa {Correta = true, Descricao = "DESERTO ANTÁRTICO"},
                }
            },
            new Pergunta
            {
                Id = 17,
                Enunciado = "Quem pintou a 'Mona Lisa'?",
                Alternativas = new()
                {
                    new Alternativa {Correta = true, Descricao = "LEONARDO DA VINCI"},
                    new Alternativa {Correta = false, Descricao = "VINCENT VAN GOGH"},
                    new Alternativa {Correta = false, Descricao = "PABLO PICASSO"},
                    new Alternativa {Correta = false, Descricao = "RENNÉ MAGRITTE"},
                }
            },
            new Pergunta
            {
                Id = 18,
                Enunciado = "Qual é o continente mais populoso?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "ÁFRICA"},
                    new Alternativa {Correta = false, Descricao = "AMÉRICA"},
                    new Alternativa {Correta = false, Descricao = "EUROPA"},
                    new Alternativa {Correta = true, Descricao = "ÁSIA"},
                }
            },
            new Pergunta
            {
                Id = 19,
                Enunciado = "Qual é o maior animal terrestre?",
                Alternativas = new()
                {
                    new Alternativa {Correta = false, Descricao = "RINOCERONTE"},
                    new Alternativa {Correta = false, Descricao = "HIPOPÓTAMO"},
                    new Alternativa {Correta = false, Descricao = "GORILA"},
                    new Alternativa {Correta = true, Descricao = "ELEFANTE"},
                }
            },
            new Pergunta
            {
                Id = 20,
                Enunciado = "Qual é a unidade básica da vida?",
                Alternativas = new()
                {
                    new Alternativa {Correta = true, Descricao = "CÉLULA"},
                    new Alternativa {Correta = false, Descricao = "ÓRGÃO"},
                    new Alternativa {Correta = false, Descricao = "TISSU"},
                    new Alternativa {Correta = false, Descricao = "SISTEMA"},
                }
            }
        };

        // Lista de perguntas difíceis
        List<Pergunta> Perguntas_dificeis = new()
        {
            new Pergunta
            {
                Id = 1,
                Enunciado = "Em qual espécie o macho choca os ovos e a fêmea procura alimento?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "ANDORINHA" },
                    new Alternativa { Correta = false, Descricao = "PATO SELVAGEM" },
                    new Alternativa { Correta = true, Descricao = "PINGÜIM" },
                    new Alternativa { Correta = false, Descricao = "MARRECO" },
                }
            },
            new Pergunta
            {
                Id = 2,
                Enunciado = "Em qual país está localizado o 'Muro das lamentações'?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "ALEMANHA" },
                    new Alternativa { Correta = false, Descricao = "BRASIL" },
                    new Alternativa { Correta = false, Descricao = "VENEZUELA" },
                    new Alternativa { Correta = true, Descricao = "ISRAEL" },
                }
            },
            new Pergunta
            {
                Id = 3,
                Enunciado = "Qual desses países não fica na Ásia?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "PAQUISTÃO" },
                    new Alternativa { Correta = false, Descricao = "JAPÃO" },
                    new Alternativa { Correta = false, Descricao = "TAILÂNDIA" },
                    new Alternativa { Correta = true, Descricao = "EGITO" },
                }
            },
            new Pergunta
            {
                Id = 4,
                Enunciado = "Qual desses astros de filmes de ação é belga?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "ARNOLD SCHWARZENEGGER" },
                    new Alternativa { Correta = false, Descricao = "SYLVESTER STALLONE" },
                    new Alternativa { Correta = false, Descricao = "STEVEN SEAGAL" },
                    new Alternativa { Correta = true, Descricao = "JEAN CLAUDE VAN DAMME" },
                }
            },
            new Pergunta
            {
                Id = 5,
                Enunciado = "Onde foi conduzida a vitória das forças aliadas na Segunda Guerra Mundial?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "CANNES" },
                    new Alternativa { Correta = true, Descricao = "NORMANDIA" },
                    new Alternativa { Correta = false, Descricao = "CAPRI" },
                    new Alternativa { Correta = false, Descricao = "MARSELHA" },
                }
            },
            new Pergunta
            {
                Id = 6,
                Enunciado = "Onde nasceu Van Gogh, o grande pintor impressionista?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "POLÔNIA" },
                    new Alternativa { Correta = false, Descricao = "FRANÇA" },
                    new Alternativa { Correta = false, Descricao = "ITÁLIA" },
                    new Alternativa { Correta = true, Descricao = "HOLANDA" },
                }
            },
            new Pergunta
            {
                Id = 7,
                Enunciado = "Qual é a primeira letra do alfabeto grego?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "DELTA" },
                    new Alternativa { Correta = false, Descricao = "BETA" },
                    new Alternativa { Correta = true, Descricao = "ALFA" },
                    new Alternativa { Correta = false, Descricao = "GAMA" },
                }
            },
            new Pergunta
            {
                Id = 8,
                Enunciado = "Qual presidente brasileiro instituiu o AI-5?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "COSTA E SILVA" },
                    new Alternativa { Correta = false, Descricao = "ERNESTO GEISEL" },
                    new Alternativa { Correta = false, Descricao = "JOÃO FIGUEIREDO" },
                    new Alternativa { Correta = false, Descricao = "ITAMAR FRANCO" },
                }
            },
            new Pergunta
            {
                Id = 9,
                Enunciado = "O que significa literalmente Perestroika?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "CONVERSÃO" },
                    new Alternativa { Correta = false, Descricao = "INVOLUÇÃO" },
                    new Alternativa { Correta = true, Descricao = "REESTRUTURAÇÃO" },
                    new Alternativa { Correta = false, Descricao = "REGRESSÃO" },
                }
            },
            new Pergunta
            {
                Id = 10,
                Enunciado = "Qual desses quatro pesos é o mais leve?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "10 ONÇAS" },
                    new Alternativa { Correta = true, Descricao = "10 GRAMAS" },
                    new Alternativa { Correta = false, Descricao = "10 QUILOS" },
                    new Alternativa { Correta = false, Descricao = "10 LIBRAS" },
                }
            },
            new Pergunta
            {
                Id = 11,
                Enunciado = "Brahma é o deus de que religião?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "HINDUÍSMO" },
                    new Alternativa { Correta = false, Descricao = "XINTOÍSMO" },
                    new Alternativa { Correta = false, Descricao = "BUDISMO" },
                    new Alternativa { Correta = false, Descricao = "ISLAMISMO" },
                }
            },
            new Pergunta
            {
                Id = 12,
                Enunciado = "Os nazistas foram julgados em:",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "BERLIM" },
                    new Alternativa { Correta = true, Descricao = "NUREMBERGUE" },
                    new Alternativa { Correta = false, Descricao = "MUNIQUE" },
                    new Alternativa { Correta = false, Descricao = "PARIS" },
                }
            },
            new Pergunta
            {
                Id = 13,
                Enunciado = "Que ramo da pecuária ocupa-se de bodes e cabras?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "ASININO" },
                    new Alternativa { Correta = false, Descricao = "CAPRINO" },
                    new Alternativa { Correta = false, Descricao = "BUFALINO" },
                    new Alternativa { Correta = false, Descricao = "MUAR" },
                }
            },
            new Pergunta
            {
                Id = 14,
                Enunciado = "Qual oceano tem o maior volume de água?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "ATLÂNTICO" },
                    new Alternativa { Correta = true, Descricao = "PACÍFICO" },
                    new Alternativa { Correta = false, Descricao = "ÍNDICO" },
                    new Alternativa { Correta = false, Descricao = "ÁRTICO" },
                }
            },
            new Pergunta
            {
                Id = 15,
                Enunciado = "Qual foi o último presidente militar do Brasil?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "FERNANDO COLLOR" },
                    new Alternativa { Correta = false, Descricao = "JOÃO FIGUEIREDO" },
                    new Alternativa { Correta = false, Descricao = "TANCREDO NEVES" },
                    new Alternativa { Correta = false, Descricao = "JOÃO GOULART" },
                }
            },
            new Pergunta
            {
                Id = 16,
                Enunciado = "Que conflito ideológico envolveu os EUA e a União Soviética?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "GUERRA FRIA" },
                    new Alternativa { Correta = false, Descricao = "GUERRA DO VIETNÃ" },
                    new Alternativa { Correta = false, Descricao = "GUERRA NAS ESTRELAS" },
                    new Alternativa { Correta = false, Descricao = "GUERRA DA CORÉIA" },
                }
            },
            new Pergunta
            {
                Id = 17,
                Enunciado = "O trapézio é um músculo que está situado:",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "NO PESCOÇO" },
                    new Alternativa { Correta = true, Descricao = "NO OMBRO" },
                    new Alternativa { Correta = false, Descricao = "NA CABEÇA" },
                    new Alternativa { Correta = false, Descricao = "NO BRAÇO" },
                }
            },
            new Pergunta
            {
                Id = 18,
                Enunciado = "Quem escreveu o livro 'A sangue frio' em 1966?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "TRUMAN CAPOTE" },
                    new Alternativa { Correta = false, Descricao = "HENRY JAMES" },
                    new Alternativa { Correta = false, Descricao = "JOHN STEINBECK" },
                    new Alternativa { Correta = false, Descricao = "TONI MORRISON" },
                }
            },
            new Pergunta
            {
                Id = 19,
                Enunciado = "Quem escreveu 'Ulisses' em 1922?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "ERNEST HEMINGWAY" },
                    new Alternativa { Correta = false, Descricao = "MARCEL PROUST" },
                    new Alternativa { Correta = false, Descricao = "T.S. ELLIOT" },
                    new Alternativa { Correta = true, Descricao = "JAMES JOYCE" },
                }
            },
            new Pergunta
            {
                Id = 20,
                Enunciado = "Qual o símbolo químico do radônio?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "Rr" },
                    new Alternativa { Correta = false, Descricao = "Rd" },
                    new Alternativa { Correta = true, Descricao = "Rn" },
                    new Alternativa { Correta = false, Descricao = "Ro" },
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

