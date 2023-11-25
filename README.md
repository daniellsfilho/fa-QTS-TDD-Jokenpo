# Exercício de Fixação sobre TDD

Exercício selecionado do site https://dojopuzzles.com/problems/jokenpo/

## Tecnologias
- .NET
- C#
- XUnit

## Instalação e utilização

```bash
# Clonar o repositório
$ git clone https://github.com/daniellsfilho/fa-QTS-TDD-Jokenpo.git

# Navegar até a pasta fa-QTS-TDD-Jokenpo
$ cd ./fa-QTS-TDD-Jokenpo

# Rodar testes da solução
$ dotnet test ./fa-QTS-tdd-jokenpo/fa-QTS-tdd-jokenpo.csproj --logger "console;verbosity=detailed"
```

## Print dos testes
![image](https://github.com/daniellsfilho/fa-QTS-TDD-Jokenpo/assets/79336346/748a7ca9-fdfd-4757-be7c-31ddc822c010)

## Testes de mutação
```
# Instalar o dotnet-stryker
$ dotnet tool install -g dotnet-stryker

# Executar os testes de mutação, com relatório
$ dotnet stryker --mutation-level complete --open-report

```
