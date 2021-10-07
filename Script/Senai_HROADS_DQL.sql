USE SENAI_HROADS;
GO

SELECT * FROM TIPO_HABILIDADE
SELECT * FROM CLASSE
SELECT * FROM CLASSE_HABILIDADE
SELECT * FROM HABILIDADE
SELECT * FROM PERSONAGEM
SELECT * FROM TIPO_USUARIO
SELECT * FROM USUARIO

SELECT idHabilidade FROM HABILIDADE
GO

SELECT TipoHab FROM TIPO_HABILIDADE
GO

SELECT NOME, TipoHab FROM HABILIDADE
INNER JOIN TIPO_HABILIDADE
ON HABILIDADE.idTipoHab = TIPO_HABILIDADE.idTipoHab
GO

SELECT NomePer, TipoClasse FROM PERSONAGEM
INNER JOIN CLASSE
ON PERSONAGEM.idClasse = CLASSE.idClasse
GO

SELECT NomePer, TipoClasse FROM PERSONAGEM
RIGHT JOIN CLASSE
ON PERSONAGEM.idClasse = CLASSE.idClasse
GO

SELECT TipoClasse, Nome FROM CLASSE
LEFT JOIN HABILIDADE
ON CLASSE.idClasse = HABILIDADE.idHabilidade
GO

SELECT Nome, TipoClasse FROM HABILIDADE
INNER JOIN CLASSE
ON HABILIDADE.idHabilidade = CLASSE.idClasse
GO

SELECT Nome, TipoClasse FROM HABILIDADE
RIGHT JOIN CLASSE
ON HABILIDADE.idHabilidade = CLASSE.idClasse
GO