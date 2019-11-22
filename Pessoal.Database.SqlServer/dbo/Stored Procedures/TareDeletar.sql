CREATE PROCEDURE TareDeletar
 @id int 
 AS
 DELETE [dbo].[Tarefa] WHERE ID = @id 