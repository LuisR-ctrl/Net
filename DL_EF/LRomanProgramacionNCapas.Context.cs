﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DL_EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class LRomanProgramacionNCapasEntities : DbContext
    {
        public LRomanProgramacionNCapasEntities()
            : base("name=LRomanProgramacionNCapasEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Aseguradora> Aseguradoras { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<Colonia> Colonias { get; set; }
        public virtual DbSet<Direccion> Direccions { get; set; }
        public virtual DbSet<Empleado> Empleadoes { get; set; }
        public virtual DbSet<Empresa> Empresas { get; set; }
        public virtual DbSet<Estado> Estadoes { get; set; }
        public virtual DbSet<Municipio> Municipios { get; set; }
        public virtual DbSet<Pai> Pais { get; set; }
        public virtual DbSet<Poliza> Polizas { get; set; }
        public virtual DbSet<SubPoliza> SubPolizas { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
    
        public virtual int AseguradoraAdd(string nombre, Nullable<int> idUsuario, string imagen)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            var imagenParameter = imagen != null ?
                new ObjectParameter("Imagen", imagen) :
                new ObjectParameter("Imagen", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AseguradoraAdd", nombreParameter, idUsuarioParameter, imagenParameter);
        }
    
        public virtual int AseguradoraDelete(Nullable<int> idAseguradora)
        {
            var idAseguradoraParameter = idAseguradora.HasValue ?
                new ObjectParameter("IdAseguradora", idAseguradora) :
                new ObjectParameter("IdAseguradora", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AseguradoraDelete", idAseguradoraParameter);
        }
    
        public virtual ObjectResult<AseguradoraGetAll_Result> AseguradoraGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AseguradoraGetAll_Result>("AseguradoraGetAll");
        }
    
        public virtual ObjectResult<AseguradoraGetById_Result> AseguradoraGetById(Nullable<int> idAseguradora)
        {
            var idAseguradoraParameter = idAseguradora.HasValue ?
                new ObjectParameter("IdAseguradora", idAseguradora) :
                new ObjectParameter("IdAseguradora", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AseguradoraGetById_Result>("AseguradoraGetById", idAseguradoraParameter);
        }
    
        public virtual int AseguradoraUpdate(Nullable<int> idAseguradora, string nombre, Nullable<int> idUsuario, string imagen)
        {
            var idAseguradoraParameter = idAseguradora.HasValue ?
                new ObjectParameter("IdAseguradora", idAseguradora) :
                new ObjectParameter("IdAseguradora", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            var imagenParameter = imagen != null ?
                new ObjectParameter("Imagen", imagen) :
                new ObjectParameter("Imagen", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AseguradoraUpdate", idAseguradoraParameter, nombreParameter, idUsuarioParameter, imagenParameter);
        }
    
        public virtual ObjectResult<ColoniaGetByIdMunicipio_Result> ColoniaGetByIdMunicipio(Nullable<int> idMunicipio)
        {
            var idMunicipioParameter = idMunicipio.HasValue ?
                new ObjectParameter("IdMunicipio", idMunicipio) :
                new ObjectParameter("IdMunicipio", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ColoniaGetByIdMunicipio_Result>("ColoniaGetByIdMunicipio", idMunicipioParameter);
        }
    
        public virtual int EmpleadoAdd(string numeroEmpleado, string rFC, string nombre, string apellidoPaterno, string apellidoMaterno, string email, string telefono, Nullable<System.DateTime> fechaNacimiento, string nSS, Nullable<System.DateTime> fechaIngreso, string foto, Nullable<int> idEmpresa, Nullable<int> idPoliza)
        {
            var numeroEmpleadoParameter = numeroEmpleado != null ?
                new ObjectParameter("NumeroEmpleado", numeroEmpleado) :
                new ObjectParameter("NumeroEmpleado", typeof(string));
    
            var rFCParameter = rFC != null ?
                new ObjectParameter("RFC", rFC) :
                new ObjectParameter("RFC", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoPaternoParameter = apellidoPaterno != null ?
                new ObjectParameter("ApellidoPaterno", apellidoPaterno) :
                new ObjectParameter("ApellidoPaterno", typeof(string));
    
            var apellidoMaternoParameter = apellidoMaterno != null ?
                new ObjectParameter("ApellidoMaterno", apellidoMaterno) :
                new ObjectParameter("ApellidoMaterno", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento.HasValue ?
                new ObjectParameter("FechaNacimiento", fechaNacimiento) :
                new ObjectParameter("FechaNacimiento", typeof(System.DateTime));
    
            var nSSParameter = nSS != null ?
                new ObjectParameter("NSS", nSS) :
                new ObjectParameter("NSS", typeof(string));
    
            var fechaIngresoParameter = fechaIngreso.HasValue ?
                new ObjectParameter("FechaIngreso", fechaIngreso) :
                new ObjectParameter("FechaIngreso", typeof(System.DateTime));
    
            var fotoParameter = foto != null ?
                new ObjectParameter("Foto", foto) :
                new ObjectParameter("Foto", typeof(string));
    
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            var idPolizaParameter = idPoliza.HasValue ?
                new ObjectParameter("IdPoliza", idPoliza) :
                new ObjectParameter("IdPoliza", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EmpleadoAdd", numeroEmpleadoParameter, rFCParameter, nombreParameter, apellidoPaternoParameter, apellidoMaternoParameter, emailParameter, telefonoParameter, fechaNacimientoParameter, nSSParameter, fechaIngresoParameter, fotoParameter, idEmpresaParameter, idPolizaParameter);
        }
    
        public virtual int EmpleadoAddUpdate(string numeroEmpleado, string rFC, string nombre, string apellidoPaterno, string apellidoMaterno, string email, string telefono, Nullable<System.DateTime> fechaNacimiento, string nSS, Nullable<System.DateTime> fechaIngreso, string foto, Nullable<int> idEmpresa, Nullable<int> idPoliza)
        {
            var numeroEmpleadoParameter = numeroEmpleado != null ?
                new ObjectParameter("NumeroEmpleado", numeroEmpleado) :
                new ObjectParameter("NumeroEmpleado", typeof(string));
    
            var rFCParameter = rFC != null ?
                new ObjectParameter("RFC", rFC) :
                new ObjectParameter("RFC", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoPaternoParameter = apellidoPaterno != null ?
                new ObjectParameter("ApellidoPaterno", apellidoPaterno) :
                new ObjectParameter("ApellidoPaterno", typeof(string));
    
            var apellidoMaternoParameter = apellidoMaterno != null ?
                new ObjectParameter("ApellidoMaterno", apellidoMaterno) :
                new ObjectParameter("ApellidoMaterno", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento.HasValue ?
                new ObjectParameter("FechaNacimiento", fechaNacimiento) :
                new ObjectParameter("FechaNacimiento", typeof(System.DateTime));
    
            var nSSParameter = nSS != null ?
                new ObjectParameter("NSS", nSS) :
                new ObjectParameter("NSS", typeof(string));
    
            var fechaIngresoParameter = fechaIngreso.HasValue ?
                new ObjectParameter("FechaIngreso", fechaIngreso) :
                new ObjectParameter("FechaIngreso", typeof(System.DateTime));
    
            var fotoParameter = foto != null ?
                new ObjectParameter("Foto", foto) :
                new ObjectParameter("Foto", typeof(string));
    
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            var idPolizaParameter = idPoliza.HasValue ?
                new ObjectParameter("IdPoliza", idPoliza) :
                new ObjectParameter("IdPoliza", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EmpleadoAddUpdate", numeroEmpleadoParameter, rFCParameter, nombreParameter, apellidoPaternoParameter, apellidoMaternoParameter, emailParameter, telefonoParameter, fechaNacimientoParameter, nSSParameter, fechaIngresoParameter, fotoParameter, idEmpresaParameter, idPolizaParameter);
        }
    
        public virtual int EmpleadoDelete(string numeroEmpleado)
        {
            var numeroEmpleadoParameter = numeroEmpleado != null ?
                new ObjectParameter("NumeroEmpleado", numeroEmpleado) :
                new ObjectParameter("NumeroEmpleado", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EmpleadoDelete", numeroEmpleadoParameter);
        }
    
        public virtual ObjectResult<EmpleadoGetAll_Result> EmpleadoGetAll(string nombre, string apellidoPaterno, Nullable<int> idEmpresa)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoPaternoParameter = apellidoPaterno != null ?
                new ObjectParameter("ApellidoPaterno", apellidoPaterno) :
                new ObjectParameter("ApellidoPaterno", typeof(string));
    
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EmpleadoGetAll_Result>("EmpleadoGetAll", nombreParameter, apellidoPaternoParameter, idEmpresaParameter);
        }
    
        public virtual ObjectResult<EmpleadoGetById_Result> EmpleadoGetById(string numeroEmpleado)
        {
            var numeroEmpleadoParameter = numeroEmpleado != null ?
                new ObjectParameter("NumeroEmpleado", numeroEmpleado) :
                new ObjectParameter("NumeroEmpleado", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EmpleadoGetById_Result>("EmpleadoGetById", numeroEmpleadoParameter);
        }
    
        public virtual int EmpleadoUpdate(string numeroEmpleado, string rFC, string nombre, string apellidoPaterno, string apellidoMaterno, string email, string telefono, Nullable<System.DateTime> fechaNacimiento, string nSS, Nullable<System.DateTime> fechaIngreso, string foto, Nullable<int> idEmpresa, Nullable<int> idPoliza)
        {
            var numeroEmpleadoParameter = numeroEmpleado != null ?
                new ObjectParameter("NumeroEmpleado", numeroEmpleado) :
                new ObjectParameter("NumeroEmpleado", typeof(string));
    
            var rFCParameter = rFC != null ?
                new ObjectParameter("RFC", rFC) :
                new ObjectParameter("RFC", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoPaternoParameter = apellidoPaterno != null ?
                new ObjectParameter("ApellidoPaterno", apellidoPaterno) :
                new ObjectParameter("ApellidoPaterno", typeof(string));
    
            var apellidoMaternoParameter = apellidoMaterno != null ?
                new ObjectParameter("ApellidoMaterno", apellidoMaterno) :
                new ObjectParameter("ApellidoMaterno", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento.HasValue ?
                new ObjectParameter("FechaNacimiento", fechaNacimiento) :
                new ObjectParameter("FechaNacimiento", typeof(System.DateTime));
    
            var nSSParameter = nSS != null ?
                new ObjectParameter("NSS", nSS) :
                new ObjectParameter("NSS", typeof(string));
    
            var fechaIngresoParameter = fechaIngreso.HasValue ?
                new ObjectParameter("FechaIngreso", fechaIngreso) :
                new ObjectParameter("FechaIngreso", typeof(System.DateTime));
    
            var fotoParameter = foto != null ?
                new ObjectParameter("Foto", foto) :
                new ObjectParameter("Foto", typeof(string));
    
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            var idPolizaParameter = idPoliza.HasValue ?
                new ObjectParameter("IdPoliza", idPoliza) :
                new ObjectParameter("IdPoliza", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EmpleadoUpdate", numeroEmpleadoParameter, rFCParameter, nombreParameter, apellidoPaternoParameter, apellidoMaternoParameter, emailParameter, telefonoParameter, fechaNacimientoParameter, nSSParameter, fechaIngresoParameter, fotoParameter, idEmpresaParameter, idPolizaParameter);
        }
    
        public virtual int EmpresaAdd(string nombre, string telefono, string email, string direccionWeb, string logo)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var direccionWebParameter = direccionWeb != null ?
                new ObjectParameter("DireccionWeb", direccionWeb) :
                new ObjectParameter("DireccionWeb", typeof(string));
    
            var logoParameter = logo != null ?
                new ObjectParameter("Logo", logo) :
                new ObjectParameter("Logo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EmpresaAdd", nombreParameter, telefonoParameter, emailParameter, direccionWebParameter, logoParameter);
        }
    
        public virtual int EmpresaDelete(Nullable<int> idEmpresa)
        {
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EmpresaDelete", idEmpresaParameter);
        }
    
        public virtual ObjectResult<EmpresaGetAll_Result> EmpresaGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EmpresaGetAll_Result>("EmpresaGetAll");
        }
    
        public virtual ObjectResult<EmpresaGetById_Result> EmpresaGetById(Nullable<int> idEmpresa)
        {
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EmpresaGetById_Result>("EmpresaGetById", idEmpresaParameter);
        }
    
        public virtual int EmpresaUpdate(Nullable<int> idEmpresa, string nombre, string telefono, string email, string direccionWeb, string logo)
        {
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var direccionWebParameter = direccionWeb != null ?
                new ObjectParameter("DireccionWeb", direccionWeb) :
                new ObjectParameter("DireccionWeb", typeof(string));
    
            var logoParameter = logo != null ?
                new ObjectParameter("Logo", logo) :
                new ObjectParameter("Logo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EmpresaUpdate", idEmpresaParameter, nombreParameter, telefonoParameter, emailParameter, direccionWebParameter, logoParameter);
        }
    
        public virtual ObjectResult<EstadoGetByIdPais_Result> EstadoGetByIdPais(Nullable<int> idPais)
        {
            var idPaisParameter = idPais.HasValue ?
                new ObjectParameter("IdPais", idPais) :
                new ObjectParameter("IdPais", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EstadoGetByIdPais_Result>("EstadoGetByIdPais", idPaisParameter);
        }
    
        public virtual ObjectResult<MunicipioGetByIdEstado_Result> MunicipioGetByIdEstado(Nullable<int> idEstado)
        {
            var idEstadoParameter = idEstado.HasValue ?
                new ObjectParameter("IdEstado", idEstado) :
                new ObjectParameter("IdEstado", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MunicipioGetByIdEstado_Result>("MunicipioGetByIdEstado", idEstadoParameter);
        }
    
        public virtual ObjectResult<PaisGetAll_Result> PaisGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PaisGetAll_Result>("PaisGetAll");
        }
    
        public virtual ObjectResult<RolGetAll_Result> RolGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RolGetAll_Result>("RolGetAll");
        }
    
        public virtual int UsuarioAdd(string userName, string nombre, string apellidoPaterno, string apellidoMaterno, string email, string sexo, string telefono, string celular, Nullable<System.DateTime> fechaNacimiento, string curp, string imagen, Nullable<int> rol, string password, string calle, string numeroInterior, string numeroExterior, Nullable<int> idColonia)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoPaternoParameter = apellidoPaterno != null ?
                new ObjectParameter("ApellidoPaterno", apellidoPaterno) :
                new ObjectParameter("ApellidoPaterno", typeof(string));
    
            var apellidoMaternoParameter = apellidoMaterno != null ?
                new ObjectParameter("ApellidoMaterno", apellidoMaterno) :
                new ObjectParameter("ApellidoMaterno", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var sexoParameter = sexo != null ?
                new ObjectParameter("Sexo", sexo) :
                new ObjectParameter("Sexo", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            var celularParameter = celular != null ?
                new ObjectParameter("Celular", celular) :
                new ObjectParameter("Celular", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento.HasValue ?
                new ObjectParameter("FechaNacimiento", fechaNacimiento) :
                new ObjectParameter("FechaNacimiento", typeof(System.DateTime));
    
            var curpParameter = curp != null ?
                new ObjectParameter("Curp", curp) :
                new ObjectParameter("Curp", typeof(string));
    
            var imagenParameter = imagen != null ?
                new ObjectParameter("Imagen", imagen) :
                new ObjectParameter("Imagen", typeof(string));
    
            var rolParameter = rol.HasValue ?
                new ObjectParameter("Rol", rol) :
                new ObjectParameter("Rol", typeof(int));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var calleParameter = calle != null ?
                new ObjectParameter("Calle", calle) :
                new ObjectParameter("Calle", typeof(string));
    
            var numeroInteriorParameter = numeroInterior != null ?
                new ObjectParameter("NumeroInterior", numeroInterior) :
                new ObjectParameter("NumeroInterior", typeof(string));
    
            var numeroExteriorParameter = numeroExterior != null ?
                new ObjectParameter("NumeroExterior", numeroExterior) :
                new ObjectParameter("NumeroExterior", typeof(string));
    
            var idColoniaParameter = idColonia.HasValue ?
                new ObjectParameter("IdColonia", idColonia) :
                new ObjectParameter("IdColonia", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UsuarioAdd", userNameParameter, nombreParameter, apellidoPaternoParameter, apellidoMaternoParameter, emailParameter, sexoParameter, telefonoParameter, celularParameter, fechaNacimientoParameter, curpParameter, imagenParameter, rolParameter, passwordParameter, calleParameter, numeroInteriorParameter, numeroExteriorParameter, idColoniaParameter);
        }
    
        public virtual int UsuarioDelete(Nullable<int> idDireccion, Nullable<int> idUsuario)
        {
            var idDireccionParameter = idDireccion.HasValue ?
                new ObjectParameter("IdDireccion", idDireccion) :
                new ObjectParameter("IdDireccion", typeof(int));
    
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UsuarioDelete", idDireccionParameter, idUsuarioParameter);
        }
    
        public virtual int UsuarioUpdate(Nullable<int> idUsuario, string userName, string nombre, string apellidoPaterno, string apellidoMaterno, string email, string sexo, string telefono, string celular, Nullable<System.DateTime> fechaNacimiento, string curp, string imagen, Nullable<int> rol, Nullable<bool> estatus, string password, string calle, string numeroInterior, string numeroExterior, Nullable<int> idColonia)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoPaternoParameter = apellidoPaterno != null ?
                new ObjectParameter("ApellidoPaterno", apellidoPaterno) :
                new ObjectParameter("ApellidoPaterno", typeof(string));
    
            var apellidoMaternoParameter = apellidoMaterno != null ?
                new ObjectParameter("ApellidoMaterno", apellidoMaterno) :
                new ObjectParameter("ApellidoMaterno", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var sexoParameter = sexo != null ?
                new ObjectParameter("Sexo", sexo) :
                new ObjectParameter("Sexo", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            var celularParameter = celular != null ?
                new ObjectParameter("Celular", celular) :
                new ObjectParameter("Celular", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento.HasValue ?
                new ObjectParameter("FechaNacimiento", fechaNacimiento) :
                new ObjectParameter("FechaNacimiento", typeof(System.DateTime));
    
            var curpParameter = curp != null ?
                new ObjectParameter("Curp", curp) :
                new ObjectParameter("Curp", typeof(string));
    
            var imagenParameter = imagen != null ?
                new ObjectParameter("Imagen", imagen) :
                new ObjectParameter("Imagen", typeof(string));
    
            var rolParameter = rol.HasValue ?
                new ObjectParameter("Rol", rol) :
                new ObjectParameter("Rol", typeof(int));
    
            var estatusParameter = estatus.HasValue ?
                new ObjectParameter("Estatus", estatus) :
                new ObjectParameter("Estatus", typeof(bool));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var calleParameter = calle != null ?
                new ObjectParameter("Calle", calle) :
                new ObjectParameter("Calle", typeof(string));
    
            var numeroInteriorParameter = numeroInterior != null ?
                new ObjectParameter("NumeroInterior", numeroInterior) :
                new ObjectParameter("NumeroInterior", typeof(string));
    
            var numeroExteriorParameter = numeroExterior != null ?
                new ObjectParameter("NumeroExterior", numeroExterior) :
                new ObjectParameter("NumeroExterior", typeof(string));
    
            var idColoniaParameter = idColonia.HasValue ?
                new ObjectParameter("IdColonia", idColonia) :
                new ObjectParameter("IdColonia", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UsuarioUpdate", idUsuarioParameter, userNameParameter, nombreParameter, apellidoPaternoParameter, apellidoMaternoParameter, emailParameter, sexoParameter, telefonoParameter, celularParameter, fechaNacimientoParameter, curpParameter, imagenParameter, rolParameter, estatusParameter, passwordParameter, calleParameter, numeroInteriorParameter, numeroExteriorParameter, idColoniaParameter);
        }
    
        public virtual int PolizaAdd(string nombre, Nullable<int> idSubPoliza, string numeroPoliza, Nullable<int> idUsuario)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var idSubPolizaParameter = idSubPoliza.HasValue ?
                new ObjectParameter("IdSubPoliza", idSubPoliza) :
                new ObjectParameter("IdSubPoliza", typeof(int));
    
            var numeroPolizaParameter = numeroPoliza != null ?
                new ObjectParameter("NumeroPoliza", numeroPoliza) :
                new ObjectParameter("NumeroPoliza", typeof(string));
    
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PolizaAdd", nombreParameter, idSubPolizaParameter, numeroPolizaParameter, idUsuarioParameter);
        }
    
        public virtual int PolizaDelete(Nullable<int> idPoliza)
        {
            var idPolizaParameter = idPoliza.HasValue ?
                new ObjectParameter("IdPoliza", idPoliza) :
                new ObjectParameter("IdPoliza", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PolizaDelete", idPolizaParameter);
        }
    
        public virtual ObjectResult<PolizaGetById_Result> PolizaGetById(Nullable<int> idPoliza)
        {
            var idPolizaParameter = idPoliza.HasValue ?
                new ObjectParameter("IdPoliza", idPoliza) :
                new ObjectParameter("IdPoliza", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PolizaGetById_Result>("PolizaGetById", idPolizaParameter);
        }
    
        public virtual int PolizaUpdate(Nullable<int> idPoliza, string nombre, Nullable<int> idSubPoliza, string numeroPoliza, Nullable<int> idUsuario)
        {
            var idPolizaParameter = idPoliza.HasValue ?
                new ObjectParameter("IdPoliza", idPoliza) :
                new ObjectParameter("IdPoliza", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var idSubPolizaParameter = idSubPoliza.HasValue ?
                new ObjectParameter("IdSubPoliza", idSubPoliza) :
                new ObjectParameter("IdSubPoliza", typeof(int));
    
            var numeroPolizaParameter = numeroPoliza != null ?
                new ObjectParameter("NumeroPoliza", numeroPoliza) :
                new ObjectParameter("NumeroPoliza", typeof(string));
    
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PolizaUpdate", idPolizaParameter, nombreParameter, idSubPolizaParameter, numeroPolizaParameter, idUsuarioParameter);
        }
    
        public virtual ObjectResult<PolizaGetAll_Result> PolizaGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PolizaGetAll_Result>("PolizaGetAll");
        }
    
        public virtual ObjectResult<SubPolizaGetAll_Result> SubPolizaGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SubPolizaGetAll_Result>("SubPolizaGetAll");
        }
    
        public virtual ObjectResult<UsuarioGetAll_Result> UsuarioGetAll(string nombre, string apellidoPaterno, string userName)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoPaternoParameter = apellidoPaterno != null ?
                new ObjectParameter("ApellidoPaterno", apellidoPaterno) :
                new ObjectParameter("ApellidoPaterno", typeof(string));
    
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UsuarioGetAll_Result>("UsuarioGetAll", nombreParameter, apellidoPaternoParameter, userNameParameter);
        }
    
        public virtual ObjectResult<UsuarioGetById_Result> UsuarioGetById(Nullable<int> idUsuario)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UsuarioGetById_Result>("UsuarioGetById", idUsuarioParameter);
        }
    }
}