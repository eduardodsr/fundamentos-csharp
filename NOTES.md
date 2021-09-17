# Fundamentos do C# (C Sharp)

- Instrutor: André Baltieri

- Aprenda ou consolide todos os conhecimentos necessários para trabalhar com C# e .NET!

 - 12.2 horas
 - Fundamental

## Sobre o curso [2801]

Curso 2801 - Fundamentos do C#.

## Neste curso de C# você vai...
- Aprender todos os conceitos fundamentais da linguagem C#
- Aprender conceitos de programação que servem para outras linguagens de programação
- Conhecer um pouco sobre linguagens e compiladores
- Conhecer um pouco da história do C# e dos frameworks .NET da Microsoft
- Preparar seu ambiente de desenvolvimento
- Aprender os principais tipos de dados em linguagens orientadas à objetos
- Aprender a manipular strings, datas, moedas e arrays
- Aprender a converter os tipos de dados
- Aprender operadores aritméticos, de atribuição, de comparação e lógicos
- Aprender a utilizar estruturas condicionais como if e switch
- Aprender a utilizar estruturas de repetição, como For, While e Do/While
- Aprender a escrever métodos e funções utilizando boas práticas
- Aprender a utilizar Structs e Enums
- Entender e começar a trabalhar com exceções (Exceptions)
- Aprender a criar aplicações Console com C#

## Para quem é recomendado este curso de C#
- Iniciantes na área de programação
- Programadores com alguma experiência em outra linguagem que querem migrar para C#
- Profissionais que estão se preparando para uma entrevista técnica para trabalhar com .NET
- Profissionais experientes que querem fechar lacunas nos seus conhecimentos fundamentais

## Tecnologias e versões utilizadas
- .NET Core 3.1 LTS
- Visual Studio Code (Versão mais recente disponível)

## Projetos do curso
- Calculadora Console com as quatro operações básicas.
- Cronômetro para aprender Funções, Thread, Sleep.
- Editor de textos em Console para praticar controle de fluxo, ler e gravar arquivos e processar inputs do teclado.
- Editor de HTML em Console para praticar estruturas de repetição, e realizar um parsing/processamento básico de strings.

<hr>

#### Visual Studio Code - Instalação e Customização
``` https://balta.io/blog/visual-studio-code-instalacao-customizacao ``` 

#### Git e GitHub - Instalação, Configuração e Primeiros Passos
 ``` https://balta.io/blog/git-github-primeiros-passos ``` 

#### Download . NET - Supported versions
``` https://dotnet.microsoft.com/download/dotnet ``` 

<hr>

## MÓDULOS - RESUMO 

### 03. Frameworks :white_check_mark:

**.NET Framework**
- Framework são estruturas prontas
- C# é a linguagem
- O framework se chama .NET
- suporte somente Windows

**.NET Core (atual)**
- versão mais moderna do .NET Framework
- suporta outros SOs como Linux e Mac
- versão 3.1 mais estável e instalação Side by-Side

**.NET Standard (padronização)**
- rodar projetos: .NET Framework & .NET Core

**.NET 5 (.NET 6)**
- presente/futuro

**LTS (Long Term Support)**
- Optar por LTS (Versão estável)

**Versionamento**
- Opte sempre por versões LTS

- Dividida em fases:
    - Alpha
    - Beta
    - Release Candidate
    - Final

- Dividida em 3 partes:
    - Major (mudanças maiores)
    - Minor (mudanças pequenas)
    - Patch (correções)

**Definições:**

    MAJOR
            - Pode conter incompatibilidade com versões anteriores
            - Chamadas de Breaking Changes
            
    MINOR
            - Possui mudanças mas é totalmente compatível com versões anteriores
            - Backward Compatibility
            
    PATCH
            - Correções de bugs e outros itens simples
            
    Alpha
            - Ainda não sabe como vão ser as coisas
            - Muito ainda pode mudar
            
    Beta
            - Já tem ideia da estrutura
            - As coisas ainda podem mudar
            
    RC (Release Candidate)
            - Candidato a versão final
            
    Final
            - Versão Final

**Runtime**
    - `Runtime  executa!`
        
        - Executar a aplicação C#
       
    
**SDK (Software Development Kit)**
  - `SDK cria!`
  
        - Kit para desenvolvimento de software
        - Possui tudo que precisamos para criar aplicações
        - Já vem com o Runtime integrado
        - Não devemos utilizar em produção
      


### 04. .NET (DotNet) :white_check_mark:

**4.1 - Instalação (Microsoft, Linux, MAC)**

**Primeiros Passos**
```https://balta.io/blog/dotnet-instalacao-configuracao-e-primeiros-passos```

**.NET Core 3.1** 
```https://dotnet.microsoft.com/download/dotnet/3.1```

**.NET Core 3.1 SDK (v3.1.412) - macOS x64 Installer**
```https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-3.1.412-macos-x64-installer```


**INSTALL .NOT**
```
    The following was installed at 
    /usr/local/share/dotnet 
	$.NET Core SDK 3.1.412
	$/.NET Core Runtime 3.1.18
	$ ASP.NET Core Runtime 3.1.18    
```

**TERMINAL - Validar instalação do .NET**
```
    dotnet -- version
    3.1.412
```

**4.2 CLI (Command Line Interface) - Comandos**
    
- Definido pelo comando `dotnet`
    
`dotnet –version` -> Verifica a versão atual

`3.1.412`

`dotnet --list-sdks` -> Lista os SDKs instalados

`3.1.412 [/usr/local/share/dotnet/sdk]`  


`dotnet --list-runtimes` -> Lista os Runtimes instalados

    `Microsoft.AspNetCore.App 3.1.18`
    [/usr/local/share/dotnet/shared/Microsoft.AspNetCore.App]
    `Microsoft.NETCore.App 3.1.18`
    [/usr/local/share/dotnet/shared/Microsoft.NETCore.App]`

`dotnet help`              -> Exibe a ajuda/Lista de comandos disponíveis
...


**4.3 VS Code - Extensões:**

- C# - ms-dotnettools.csharp [`EXTENSÃO -   Obrigatória`]
```https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp```

`publisher:"Microsoft"`

- Material Icon Theme [Pacote de Ícones]
```https://marketplace.visualstudio.com/items?itemName=PKief.material-icon-theme```


**4.4 Tipos de projeto**

- Comando `dotnet ...` :

`dotnet`

`dotnet new console `   => Novo Console Application

`dotnet new classlib `  => Nova Class Library

`dotnet new web `       => Novo projeto ASP.NET Core

`dotnet new mvc `       => Novo projeto ASP.NET Core

`dotnet new webapi `    => Novo projeto ASP.NET Core

`dotnet new mstest`     => Novo projeto Microsoft Test

- Como criar um novo projeto:

`mkdir Teste`

`cd Teste`

`dotnet new console`

    Será criado 3 arquivos dentro do diretório "Teste":
    /Teste.csproj
    /Program.cs
    /pasta obj (debug)

- Para especificar uma pasta (diretório), podemos utilizar o “-o”
- Criar uma nova pasta chamada MeuApp com os arquivos dentro

`dotnet new console –o MeuApp`


**4.5 Fluxo de execução**

`dotnet restore`
-  Restaura todos os pacotes que a aplicação precisa para ser executada

`dotnet build`  
- Compila a aplicação 

`dotnet clean`  
- Limpa as compilações anteriores / Limpa o cache

`dotnet run`    
- Compila e executa a aplicação

`dotnet run`      
`Hello World!`


**4.6 Variáveis de ambiente**

- É comum termos vários ambientes para nossas aplicações
    - Desenvolvimento
    - Homologação
    - Produção
- Cada ambiente possui suas configurações
    - Chaves de acesso externo
    - Conexões com bancos de dados

- Desta forma, podemos dizer ao .NET qual ambiente estamos utilizando:

`dotnet run --environment=$SEU_AMBIENTE`

`dotnet run --environment=development`

`dotnet run --environment=production`


**4.7 Estrutura do Console - App**

- Arquivo `.csproj`
    - Formato XML
    - Definições do projeto
    - Presente em todo projeto .NET

- `Program.cs`
    - Arquivo principal (C#)
    - Porta de entrada
    - Será o primeiro a ser executado

- `CSPROJ`
    - `SDK`
        - Define a SDK que estamos utilizando
    - `Output Type`
        - Arquivo final a ser gerado (EXE no caso)
    - `Target Framework`
        - Versão do Framework utilizada

- Estrutura do Console
    - `bin`
        - Resultado final do App compilado
    - `obj`
        - Armazena arquivos temporários utilizados para compilação final
    - `.vscode`
        - Armazena as configurações utilizadas pelo VS Code

- .NET Standard (Suporte à implementação do .NET)
    -  A motivação por trás da .NET Standard era estabelecer uma maior uniformidade no ecossistema do .NET. 
    - No entanto, o .NET 5 adota uma abordagem diferente para estabelecer a uniformidade, e essa nova abordagem elimina a necessidade de .NET Standard em muitos cenários. 

- Suporte à implementação do .NET
    - A tabela a seguir lista as versões mínimas de implementação que oferecem suporte a cada versão de .net Standard. 
    - Isso significa que as versões posteriores de uma implementação listada também oferecem suporte à versão de .NET Standard correspondente. 
    
`link:` ``` https://docs.microsoft.com/pt-br/dotnet/standard/net-standard ```


**4.8 Debug**
    -   Exemplo Prático

### 05. Linguagem de Programação com C#

- As pastas são organizações físicas

**Escopo de um programa:**
- Importações (bibliotecas)
`using System;`

- Namespace (divisões lógicas)
`namespace MeuApp {...}`

- Classe Principal
`class Program {...}`

- Método Principal 
`static void Main(string[] args) { ... }`

```csharp
namespace  MeuApp
{
	class  Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World");
		}
	}
}
```

**Neste módulo aprendemos**
- Console, Variáveis, Constantes
- Tipos de dados
- Conversão de Dados
- Operadores (Aritméticos, Atribuição, Comparação e Lógicos)
- Estruturas Condicionais (If e Sqitch)
- Laços de Repetição (For, While e Do/While)
- Funções e Métodos
- Tipos de Referência e Tipos de Valor
- Estruturas
- Enumeradores
