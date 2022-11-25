# api-ping-pong

## Sobre o trabalho

#### Trata-se de uma Api desenvolvida por Gustavo Dias e Marlon de Souza para um trabalho da faculdade. É um programa simples feito em c#, que ao enviar a palavra ping na URL retorna pong e ao enviar pong retorna ping. 

> Utiliza-se também json para realizar a requisição. 

## Documentação: :checkered_flag:

### Localhost

Para ver o funcionando da API, é necessário que você corra o programa e acesse o localhost:

```
https://localhost:{porta}/PingPong/{o-que-você-desejar}
```

### O pulo do gato

#### PingPong – Pong

Abaixo, parte do código responsável por dar o retorno Pong, ao receber Ping.

### Caminho

> PingPong/Ping

```C#
"msg": "Pong"
```


#### PingPong – Ping

Abaixo, parte do código responsável por dar o retorno Ping, ao receber Pong.

### Caminho

> PingPong/Pong

```C#
"msg": "Ping"
```

### PRÉ-Requisitos:

É necessário ter .NET6 instalado em seu computador.
E para rodar, utilizar o comando:

```console
$ dotnet run
```



