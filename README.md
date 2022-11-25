# api-ping-pong 🏓

## Sobre o trabalho 👨‍💻
👨‍ 💻
#### Trata-se de uma API desenvolvida por Gustavo Dias e Marlon de Souza para um trabalho da faculdade. É um programa simples feito em C#, que ao enviar a palavra ping na URL retorna pong e ao enviar pong retorna ping. 

> Utiliza-se também json para realizar a requisição. 

## Documentação: :checkered_flag:

### PRÉ-Requisitos:

É necessário ter .NET6 instalado em seu computador.
E para rodar, utilizar o comando:

```console
$ dotnet run
```

### Localhost

Para ver o funcionamento da API, é necessário que você rode o programa e acesse o localhost:

```
https://localhost:{porta}/PingPong/{o-que-você-desejar}
```

### O pulo do gato :octocat:

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



