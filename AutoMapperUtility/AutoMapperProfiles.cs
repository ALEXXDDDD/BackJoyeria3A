using AutoMapper;
using DBZapateriaDLopezModel;
using RequestResponseModel.Request.Compra;
using RequestResponseModel.Request.Compra.ComprobanteDetalle;
using RequestResponseModel.Request.Compra.Material;
using RequestResponseModel.Request.Compra.Materiald;
using RequestResponseModel.Request.Produccion;
using RequestResponseModel.Request.Produccion.Area;
using RequestResponseModel.Request.Produccion.Empleado;
using RequestResponseModel.Request.Produccion.Modelo;
using RequestResponseModel.Request.Producto;
using RequestResponseModel.Request.Sistema;
using RequestResponseModel.Request.Venta.Cliente;
using RequestResponseModel.Response.Compra;
using RequestResponseModel.Response.Compra.ComprobanteDetalle;
using RequestResponseModel.Response.Compra.Material;
using RequestResponseModel.Response.Produccion;
using RequestResponseModel.Response.Produccion.Area;
using RequestResponseModel.Response.Produccion.Empleado;
using RequestResponseModel.Response.Produccion.Modelo;
using RequestResponseModel.Response.Produccion.Producto;
using RequestResponseModel.Response.Sistema;
using RequestResponseModel.Response.Venta.Cliente;

namespace AutoMapperUtility
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles() 
        {
            #region Area
            CreateMap<Area, RequestArea>().ReverseMap();
            CreateMap<Area, ResponseArea>().ReverseMap();
            #endregion Area
            #region Rol

            CreateMap<Rol, RequestRol>().ReverseMap();
            CreateMap<Rol, RequestPersona>().ReverseMap();
            CreateMap<Rol, ResponsePersona>().ReverseMap();


            CreateMap<RequestRol, ResponseVWUsuario>().ReverseMap();
            CreateMap<ResponseVWUsuario, RequestRol>().ReverseMap();
                CreateMap<RequestRol, RequestVWUsuario>().ReverseMap();
            CreateMap<RequestVWUsuario, RequestRol>().ReverseMap();


            CreateMap<Rol, ResponsePersona>().ReverseMap();


            CreateMap<Rol, ResponseRol>().ReverseMap();
            #endregion Rol
            #region DetalleComprobante
            CreateMap<VwDetalleComprovante,ResponseVWDetalleComprobante>().ReverseMap();
            CreateMap<RequestVWComprobanteDetalle, ComprobanteProvedor>().ReverseMap();
            CreateMap<RequestVWComprobanteDetalle, Unidad>().ReverseMap();
            CreateMap<RequestVWComprobanteDetalle, Material>().ReverseMap();

            #endregion DetalleComprobante
            #region Login
            CreateMap<Persona,ResponsePersona>().ReverseMap();
            CreateMap<VwUsuario,ResponseVWUsuario>().ReverseMap();
            CreateMap<VwDetalleComprovante,ResponseListComprobanteDetalle>().ReverseMap();
            #endregion Login
            #region Provedor
            CreateMap<RequestVWProvedor,RequestPersona>().ReverseMap();
            CreateMap<RequestVWProvedor, ResponsePersona>().ReverseMap();
            CreateMap<VwProveedor,ResponseVWProvedor>().ReverseMap();
            CreateMap<VwProveedor,ResponseProvedor>().ReverseMap();
            #endregion Provedor
            #region ComproBanteProvedor
            CreateMap<VwComprobanteProvedor,ResponseVWComprobanteProvedor>().ReverseMap();
            CreateMap<ComprobanteProvedor, RequestVWComprobanteProvedor>().ReverseMap();
            CreateMap<ComprobanteProvedor, ResponseVWComprobanteProvedor>().ReverseMap();
            CreateMap<Provedor, ComprobanteProvedor>().ReverseMap();
            #endregion ComprobanteProvedor
            #region Persona
            CreateMap<Persona, RequestPersona>().ReverseMap();
            CreateMap<Persona, ResponsePersona>().ReverseMap();
            CreateMap<RequestPersona, ResponsePersona>().ReverseMap();
            #endregion Persona
            #region Material
            CreateMap<Material,RequestMaterial>().ReverseMap();
            CreateMap<Material,ResponseMaterial>().ReverseMap();

            CreateMap<VwMaterial,RequestVWMaterial>().ReverseMap();
            CreateMap<RequestMaterial, RequestVWMaterial>().ReverseMap();
            CreateMap<VwMaterial,ResponseVWMaterial>().ReverseMap();
            CreateMap<Material, ResponseVWMaterial>().ReverseMap();

            CreateMap<Material,ResponseListMaterial>().ReverseMap();
            CreateMap<ResponseListMaterial, RequestComprobanteDetalle>().ReverseMap();
            CreateMap<ResponseComprobanteDetalle, ResponseListComprobanteDetalle>().ReverseMap();
            #endregion Material
            #region Unidad
            CreateMap<Unidad,RequestUnidad>().ReverseMap();
            CreateMap<Unidad, ResponseUnidad>().ReverseMap();
            #endregion Unidad
            #region ComprobanteDetalle
            CreateMap<ComprobanteDetalle, RequestComprobanteDetalle>().ReverseMap();
            CreateMap<ComprobanteDetalle, ResponseComprobanteDetalle>().ReverseMap();
            #endregion ComprobanteDetalle
            #region Empleado
            CreateMap<VwEmpleado,ResponseVWEmpleado>().ReverseMap();
            CreateMap<RequestVWEmpleado, RequestPersona>().ReverseMap();
            CreateMap<RequestVWEmpleado,RequestEmpleado>().ReverseMap();
            CreateMap<RequestVWEmpleado,ResponseVWEmpleado>().ReverseMap();
            CreateMap<ResponseEmpleado, ResponseVWEmpleado>().ReverseMap();
            CreateMap<ResponsePersona, ResponseVWEmpleado>().ReverseMap();

            CreateMap<Empleado,RequestEmpleado>().ReverseMap();
            CreateMap<Empleado,ResponseListEmpleado>().ReverseMap();
            CreateMap<Empleado, ResponseVWEmpleado>().ReverseMap();

            CreateMap<RequestEmpleado, ResponseVWEmpleado>().ReverseMap();
            #endregion Empleado
            #region Cliente
            CreateMap<Cliente,RequestUsuario>().ReverseMap();
            CreateMap<Cliente,ResponseCliente>().ReverseMap();

            CreateMap<VwCliente,ResponseListCliente>().ReverseMap();
            CreateMap<RequestVWCliente,RequestPersona>().ReverseMap();
            CreateMap<RequestVWCliente,RequestUsuario>().ReverseMap();
            CreateMap<RequestVWCliente,ResponseListCliente>().ReverseMap();

            CreateMap<ResponseCliente, RequestUsuario>().ReverseMap();
            #endregion Cliente
            #region Usuario
            CreateMap<Usuario, RequestVWUsuario>().ReverseMap();
            CreateMap<Usuario, ResponseRol>().ReverseMap();
            CreateMap<Usuario, ResponsePersona>().ReverseMap();

            CreateMap<RequestVWUsuario, RequestUsuario>().ReverseMap();
            CreateMap<RequestVWUsuario, ResponseListUsuario>().ReverseMap();   
            CreateMap<ResponseVWUsuario, RequestPersona>().ReverseMap();
   
            CreateMap<ResponseVWUsuario, ResponseListUsuario>().ReverseMap();

            CreateMap<ResponseVWUsuario, ResponseListUsuario>().ReverseMap();
            CreateMap<RequestVWUsuario, RequestPersona>().ReverseMap();
            CreateMap<RequestVWUsuario, RequestUsuario>().ReverseMap();
            CreateMap<RequestVWUsuario, ResponseListUsuario>().ReverseMap();

            CreateMap<Usuario, RequestUsuario>().ReverseMap();
            CreateMap<Usuario, ResponseListUsuario>().ReverseMap();
            CreateMap<Usuario, ResponseVWUsuario>().ReverseMap();
            #endregion
            #region Producto
            CreateMap<Producto, RequestProducto>().ReverseMap();
            CreateMap<Producto, ResponseProducto>().ReverseMap();
            #endregion Prodcuto
            #region Modelo
            CreateMap<Modelo, RequestModelo>().ReverseMap();
            CreateMap<Modelo, ResponseModelo>().ReverseMap();
            #endregion Modelo
        }
    }
}