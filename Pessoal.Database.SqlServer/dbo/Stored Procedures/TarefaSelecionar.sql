CREATE PROCEDURE TarefaSelecionar
 @id int = null
 as
SELECT [Id]
      ,[Nome]
      ,[Prioridade]
      ,[Concluida]
      ,[Observacao]
  FROM [dbo].[Tarefa] WHERE ID = ISNULL(@id, Id) ORDER BY Concluida, Prioridade



