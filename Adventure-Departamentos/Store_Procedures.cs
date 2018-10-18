/*
 * 
 * YOSSENY GIMENA SANCHEZ CABRERA   03181998-01690
 * 
 * CREATE PROCEDURE sp_RegistrarDepartamento(
    @Nombre NVarchar(50)=NULL,
	@Descripcion NVarchar(50)=NULL,
	@FechaM DATETIME = NULL
)
AS
BEGIN

    INSERT INTO HumanResources.Department(Name, GroupName, ModifiedDate) VALUES(@Nombre, @Descripcion, @FechaM)
END

CREATE PROCEDURE sp_EditarDepartamento(
    @Codigo SMALLINT = NULL,
    @Nombre NVARCHAR(50)=NULL,
	@Descripcion NVARCHAR(50)=NULL,
	@FechaM DATETIME = NULL
)
AS
BEGIN


    UPDATE HumanResources.Department SET Name = @Nombre, GroupName = @Descripcion, ModifiedDate= @FechaM WHERE DepartmentID = @Codigo;
END


CREATE PROCEDURE sp_EliminarDepartamento(
    @Codigo SMALLINT = NULL
)
AS
BEGIN


    DELETE FROM HumanResources.Department WHERE DepartmentID=@Codigo;
END

*/