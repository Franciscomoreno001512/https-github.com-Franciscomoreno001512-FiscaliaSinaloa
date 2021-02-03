﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Continuacion_de_Proceso;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Continuacion_de_Proceso
{
    public class Continuacion_de_ProcesoApiConsumer : BaseApiConsumer,IContinuacion_de_ProcesoApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Continuacion_de_ProcesoApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Continuacion_de_Proceso";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Continuacion_de_Proceso.Continuacion_de_Proceso>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Continuacion_de_Proceso.Continuacion_de_Proceso>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Continuacion_de_Proceso.Continuacion_de_Proceso>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Continuacion_de_Proceso.Continuacion_de_Proceso>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Continuacion_de_Proceso.Continuacion_de_Proceso>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Continuacion_de_Proceso.Continuacion_de_Proceso>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Continuacion_de_Proceso.Continuacion_de_Proceso>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Continuacion_de_Proceso.Continuacion_de_Proceso>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Continuacion_de_Proceso.Continuacion_de_Proceso> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Continuacion_de_Proceso.Continuacion_de_Proceso>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Continuacion_de_Proceso.Continuacion_de_Proceso>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Continuacion_de_Proceso.Continuacion_de_Proceso>(false, null);
            }
        }

        public ApiResponse<Continuacion_de_ProcesoPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Continuacion_de_Proceso.Continuacion_de_ProcesoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Continuacion_de_Proceso.Clave='" + Key.ToString() + "'"
                        + "&Order=Continuacion_de_Proceso.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Continuacion_de_Proceso.Continuacion_de_ProcesoPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Continuacion_de_Proceso.Continuacion_de_ProcesoPagingModel>(false, new Continuacion_de_ProcesoPagingModel() { Continuacion_de_Procesos = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Continuacion_de_ProcesoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Continuacion_de_Proceso.Continuacion_de_Proceso entity, Core.Domain.User.GlobalData Continuacion_de_ProcesoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Continuacion_de_Proceso.Continuacion_de_Proceso entity, Core.Domain.User.GlobalData Continuacion_de_ProcesoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Continuacion_de_Proceso.Continuacion_de_Proceso>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Continuacion_de_Proceso.Continuacion_de_Proceso>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Continuacion_de_Proceso.Continuacion_de_Proceso>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Continuacion_de_ProcesoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Continuacion_de_Proceso.Continuacion_de_ProcesoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Continuacion_de_Proceso.Continuacion_de_ProcesoPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Continuacion_de_Proceso.Continuacion_de_ProcesoPagingModel>(false, new Continuacion_de_ProcesoPagingModel() { Continuacion_de_Procesos = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Continuacion_de_Proceso.Continuacion_de_Proceso>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Continuacion_de_ProcesoGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Continuacion_de_Proceso_Datos_Generales entity)
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

        public ApiResponse<Continuacion_de_Proceso_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Continuacion_de_Proceso.Continuacion_de_Proceso_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Continuacion_de_Proceso.Continuacion_de_Proceso_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Continuacion_de_Proceso.Continuacion_de_Proceso_Datos_Generales>(false, null);
            }
        }


    }
}

