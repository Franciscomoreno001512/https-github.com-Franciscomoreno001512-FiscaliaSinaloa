﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Audiencia_de_Control_Procedimiento;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Audiencia_de_Control_Procedimiento
{
    public class Audiencia_de_Control_ProcedimientoApiConsumer : BaseApiConsumer,IAudiencia_de_Control_ProcedimientoApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Audiencia_de_Control_ProcedimientoApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Audiencia_de_Control_Procedimiento";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_Procedimiento>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_Procedimiento>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_Procedimiento>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_Procedimiento>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_Procedimiento>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_Procedimiento>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_Procedimiento>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_Procedimiento>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_Procedimiento> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_Procedimiento>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_Procedimiento>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_Procedimiento>(false, null);
            }
        }

        public ApiResponse<Audiencia_de_Control_ProcedimientoPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_ProcedimientoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Audiencia_de_Control_Procedimiento.Clave='" + Key.ToString() + "'"
                        + "&Order=Audiencia_de_Control_Procedimiento.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_ProcedimientoPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_ProcedimientoPagingModel>(false, new Audiencia_de_Control_ProcedimientoPagingModel() { Audiencia_de_Control_Procedimientos = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Audiencia_de_Control_ProcedimientoInformation, DataLayerFieldsBitacora DataReference)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<bool>(baseApi, ApiControllerUrl + "/Delete?Id=" + Key,
                      Method.DELETE, ApiHeader);

                return new ApiResponse<bool>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<bool>(false, false);
            }
        }

        public ApiResponse<int> Insert(Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_Procedimiento entity, Core.Domain.User.GlobalData Audiencia_de_Control_ProcedimientoInformation, DataLayerFieldsBitacora DataReference)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Post",
                      Method.POST, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<int> Update(Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_Procedimiento entity, Core.Domain.User.GlobalData Audiencia_de_Control_ProcedimientoInformation, DataLayerFieldsBitacora DataReference)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put?Id=" + entity.Clave,
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<IList<Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_Procedimiento>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_Procedimiento>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_Procedimiento>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Audiencia_de_Control_ProcedimientoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_ProcedimientoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_ProcedimientoPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_ProcedimientoPagingModel>(false, new Audiencia_de_Control_ProcedimientoPagingModel() { Audiencia_de_Control_Procedimientos = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_Procedimiento>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Audiencia_de_Control_ProcedimientoGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Audiencia_de_Control_Procedimiento_Datos_Generales entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Datos_Generales",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Audiencia_de_Control_Procedimiento_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_Procedimiento_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_Procedimiento_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_Procedimiento_Datos_Generales>(false, null);
            }
        }


    }
}

