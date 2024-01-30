using IBusiness.Compra.TB_ComprobanteDetalle;
using RequestResponseModel.Request.Compra.ComprobanteDetalle;
using RequestResponseModel.Response.Compra.ComprobanteDetalle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRepository.Compra.TB_ComprobanteDetalle;
using AutoMapper;
using Repository.Compra.TB_ComprobanteDetalle;
using DBZapateriaDLopezModel;
using IBusiness.Produccion;
using Business.Produccion;
using RequestResponseModel.Response.Produccion;
using RequestResponseModel.Response.Compra.Material;
using IRepository.Compra.TB_Material;
using Repository.Compra.TB_Material;
using IBusiness.Compra.TB_Material;
using Business.Compra.TB_Material;

namespace Business.Compra.TB_ComprobanteDetalle
{
    public class BusinessVWDetalleComprobante : IBusinessVWDetalleComprobante
    {
        #region Inyeccion de dependencias
        private readonly IRepositoryVWDetalleComprobante _repositoryVwDetalleComprobante;
        private readonly IBusinessUnidad _businessUnidad;
        private readonly IBusinessComprobanteDetalle _businessComprobanteDetalle;
        private readonly IBusinessMaterial _businessMaterial;
        private readonly IMapper _mapper;
        public BusinessVWDetalleComprobante(IMapper mapper)
        {
            _mapper = mapper;
            _repositoryVwDetalleComprobante = new RepositoryVWDetalleComprobante();
            _businessMaterial = new BusinessMaterial(mapper);   
            _businessUnidad = new BusinessUnidad(mapper);
            _businessComprobanteDetalle = new BusinessComprobanteDetalle(mapper);  
        }
        #endregion Inyeccion de dependencias
        #region CRUD
        public ResponseVWDetalleComprobante Create(RequestVWComprobanteDetalle entity)
        {
            throw new NotImplementedException();
        }

        public List<ResponseVWDetalleComprobante> CreateMultiple(List<RequestVWComprobanteDetalle> lista)
        {
            //*Declaracion de variable locales//
            ResponseVWDetalleComprobante response = new();
            response.Detalle = new();
            List<ResponseVWDetalleComprobante> listresponse = new();
            List<ResponseComprobanteDetalle> d = new();
            List<ResponseListComprobanteDetalle> listDetalle = new();
            List<RequestComprobanteDetalle> reqD = new();
            RequestComprobanteDetalle req = new();
            List<ResponseListMaterial> listMaterial = new();
            ResponseListMaterial resMaterial = new();

            //*Carga a detalle
            lista.ForEach(y=>
            {
                resMaterial = _businessMaterial.BuscarMaterial(y.NombreMaterial);
                req = _mapper.Map<RequestComprobanteDetalle>(resMaterial);
                req.Cantidad = y.Cantidad;
                req.IdComprobante = y.IdComprobante;
                req.PrecioUnitario = y.PrecioUnitario;
                req.FechaIngreso = y.FechaIngreso;
                reqD.Add(req);
            });
            //* Creacion Multiple

            d=_businessComprobanteDetalle.CreateMultiple(reqD);
            listDetalle = _mapper.Map<List<ResponseListComprobanteDetalle>>(d);
            listDetalle.ForEach(y =>
            {
                response.Detalle.Add(y);
            });
            listresponse.Add(response);
            return listresponse;

          
            
            
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            throw new NotImplementedException();
        }

        public int DeleteMultiple(List<RequestVWComprobanteDetalle> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ResponseVWDetalleComprobante> GetAll()
        {
            ResponseVWDetalleComprobante list = new();
            //Listar Informacion//
            List<VwDetalleComprovante> detalle = _repositoryVwDetalleComprobante.GetAll();
            list.Detalle = _mapper.Map<List<ResponseListComprobanteDetalle>>(detalle);
            List<ResponseVWDetalleComprobante> response = new();
            list.message = "Registros Listados";
            response.Add(list);
            return response;
        }

        public ResponseVWDetalleComprobante GetById(object id)
        {
            throw new NotImplementedException();
        }

        public ResponseVWDetalleComprobante Update(RequestVWComprobanteDetalle entity)
        {
            throw new NotImplementedException();
        }

        public List<ResponseVWDetalleComprobante> UpdateMultiple(List<RequestVWComprobanteDetalle> lista)
        {
            throw new NotImplementedException();
        }
        #endregion CRUD
    }
}
