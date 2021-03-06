using CSharp.ClassesEMetodos;
using CSharp.Colecoes;
using CSharp.EstruturasDeControle;
using CSharp.Fundamentos;
using CSharp.OO;
using CSharp.MetodosEFuncoes;
using CSharp.Excecoes;
using CSharp.API;
using CSharp.TopicosAvancados;

using System;
using System.Collections.Generic;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Váriaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Números - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Únarios - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar},

                //Estruturas de Controle
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar},

                // Classes e Métodos
                {"Membros - Classes e Métodos", Membros.Executar},
                {"Construtores - Classes e Métodos", Construtores.Executar},
                {"Métodos com Retorno - Classes e Métodos", MetodosComRetorno.Executar},
                {"Métodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar},
                {"Params - Classes e Métodos", Params.Executar},
                {"Parametros Nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                {"Get Set - Classes e Métodos", GetSet.Executar},
                {"Props - Classes e Métodos", Props.Executar},
                {"Readonly - Classes e Métodos", Readonly.Executar},
                {"Enum - Classes e Métodos", ExemploEnum.Executar},
                {"Struct - Classes e Métodos", ExemploStruct.Executar},
                {"Struct vs Classe- Classes e Métodos", StructVsClasse.Executar},
                {"Valor vs Referencia- Classes e Métodos", ValorVsReferencia.Executar},
                {"Parametro por Referencia- Classes e Métodos", ParametrosPorReferencia.Executar},
                {"Parametro Padrão- Classes e Métodos", ParametroPadrao.Executar},

                //Coleções
                {"Array - Coleções", CSharp.Colecoes.Array.Executar},
                {"List - Coleções", ColecoesList.Executar},
                {"Array List - Coleções", ColecoesArrayList.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
                {"Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", ColecoesStack.Executar},
                {"Dictionary - Coleções", ColecoesDictionary.Executar},

                //OO
                {"Heranca - OO", Heranca.Executar},
                {"Construtor This - OO", ConstrutorThis.Executar},
                {"Encapsulamento - OO", CSharp.OO.Encapsulamento.Executar},
                {"Polimorfismo - OO", Polimorfismo.Executar},
                {"Abstract - OO", Abstract.Executar},
                {"Interface - OO", Interface.Executar},
                {"Sealed - OO", Sealed.Executar},

                //Metodos e Funcoes
                {"Lambda - Metodos e Funções", Sealed.Executar},
                {"Lambda Delegate - Metodos e Funções", LambdasDelegate.Executar},
                {"Usando Delegate - Metodos e Funções", UsandoDelegate.Executar},
                {"Delegate Func Anonima - Metodos e Funções", DelegateFunAnonima.Executar},
                {"Delegate Como Parametros - Metodos e Funções", DelegatesComoParametros.Executar},
                {"Métodos de Extensão - Metodos e Funções", MetodosDeExtensao.Executar},

                //Exceções
                {"Exceções - Exceções", PrimeiraExcecao.Executar},
                {"Exceções Personalizadas - Exceções", ExcecoesPersonalizadas.Executar},

                //API
                {"Primeiro Arquivo - API", PrimeiroArquivo.Executar},
                {"Lendo Arquivos - API", LendoArquivos.Executar},
                {"File Info - API", ExemploFileInfo.Executar},
                {"Diretorios - API", Diretorios.Executar},
                {"Directory Info - API", ExemploDirectoryInfo.Executar},
                {"Path - API", ExemploPath.Executar},
                {"Date Time - API", ExemploDateTime.Executar},
                {"Time Span - API", ExemploTimeSpan.Executar},

                //Topicos Avançados
                {"LINQ1 - Topicos Avaçados", LINQ1.Executar},
                {"LINQ2 - Topicos Avaçados", LINQ2.Executar},
                {"Nullables - Topicos Avaçados", Nullables.Executar},
                {"Dynamic - Topicos Avaçados", Dynamics.Executar},
                {"Genericos - Topicos Avaçados", Genericos.Executar},

            }); ;

            central.SelecionarEExecutar();
        }
    }
}