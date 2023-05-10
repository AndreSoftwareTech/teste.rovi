# Rovite.Status.Rastreio.Logistica.Api

# Micro Serviço

 Projeto com responsabilidade única 

Realizar uma consulta no banco de dados para verificar se o serviço de rastreio logístico esta ativo,
esta consulta nao e realizada o todo tempo, ele e gerenciado pelo hangfire 

o servico do hangfire ultilizado é chamado Recuring Job Ele é executado em alguns intervlos de tempos trazendo assim o status da consulta do Rastreio