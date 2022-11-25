# api-ping-pong

## Sobre o trabalho

#### Trata-se de uma Api desenvolvida por Gustavo Dias e Marlon de Souza para um trabalho da faculdade. É um programa simples feito em c#, que ao enviar a palavra ping retorna pong e ao enviar pong retorna ping. 

> Utiliza-se também json para realizar a requisição. 

## Documentação: :checkered_flag:

### GET

#### PingPong – Pong

Abaixo, parte do código responsável por dar o retorno Pong, ao receber Ping.

```C#
{
            case "pong": msg = "Ping"; break;
}
```


#### PingPong – Ping

Abaixo, parte do código responsável por dar o retorno Ping, ao receber Pong.

```C#
{
case "ping": msg = "Pong"; break;
}
```

> Código responsável por apresentar mensagem de erro:

Caso a API não receba nenhum dos parâmetros (ping ou pong) retorna uma mensagem de erro. Segue código responsável por esta mensagem. 

```C#
{
default: msg = "-1"; break;
}
```

### PRÉ-Requisitos:

É necessário ter .NET6 instalado em seu computador.
E para rodar, utilizar o comando:

```console
$ dotnet run
```



