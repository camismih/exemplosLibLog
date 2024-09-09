# Log em .NET

Este documento tem por objetivo fazer um comparativo entre as principais bibliotecas de log para .NET.

As bibliotecas analisadas foram:

- [Microsoft.Extension.Logging](https://learn.microsoft.com/en-us/dotnet/core/extensions/logging?tabs=command-line);
- [SeriLog](https://github.com/serilog/serilog);
- [NLog](https://github.com/nlog/nlog);
- [Log4NET](https://github.com/apache/logging-log4net);

## Sobre as bibliotecas

Microsoft.Extension.Logging é a biblioteca padrão do .NET sendo desenvolvida e mantida pela Microsoft e a comunidade já que também é open source.

Ela fornece a abstração utilizada pela maioria das demais bibliotecas do ecosistema .NET.

Pode sr utilizada como base pois todas as demais bibliotecas podem se conectar como provedores permitindo uma melhor integração com base de códigos existentes.

O SeriLog é a biblioteca mais popular quando se diz respeito a logs estruturados.

É muito extensível e já possui diversos recursos através de contribuições da comunidade.

NLog também é uma biblioteca bastante popular, mas com uma complexidade maior de configuração.

Log4NET  é a biblioteca mais antiga, baseada no projeto Log4J para Java. Parece ser a menos utilizada.

## Comparaçao

| Requisito | Microsoft.Extensions.Logging | SeriLog | NLog | Log4NET |
| --- | --- | --- | --- | --- |
| Facilidade de uso | Alta. Integração nativa com .NET Core e ASP.NET. | Alta. Configuração fluente e suporte a diversos sinks. | Média. Configuração via XML ou código. | Média. Configuração via XML. |
| Personalização | Média. Personalização através de provedores de logging. | Alta. Extensível com diversos sinks e formatos de saída. | Alta. Suporte a múltiplos targets e layouts personalizáveis. | Alta. Extensível com diversos appenders e layouts. |
| Integração com o ecossistema | Alta. Suporte nativo em .NET Core, ASP.NET, Entity Framework, etc. | Alta. Integração com várias bibliotecas e serviços, como Elasticsearch, Seq, etc. | Alta. Suporte a diversas plataformas e serviços, como Azure, AWS, etc. | Média. Integração com várias bibliotecas, mas menos moderna. |
| Desempenho | Alta. Desempenho otimizado para aplicações .NET. | Alta. Desempenho eficiente com suporte a logging assíncrono. | Alta. Desempenho eficiente com suporte a logging assíncrono. | Média. Desempenho adequado, mas pode ser menos eficiente em cenários modernos. |
| Capacidade de log semântico | Média. Suporte básico a logs estruturados. | Alta. Suporte robusto a logs estruturados e semânticos. | Média. Suporte a logs estruturados, mas menos intuitivo que SeriLog. | Baixa. Suporte limitado a logs estruturados. |
