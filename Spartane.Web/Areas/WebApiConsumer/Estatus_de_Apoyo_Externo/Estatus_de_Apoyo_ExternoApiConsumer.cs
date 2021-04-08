﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Estatus_de_Apoyo_Externo;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Estatus_de_Apoyo_Externo
{
    public class Estatus_de_Apoyo_ExternoApiConsumer : BaseApiConsumer,IEstatus_de_Apoyo_ExternoApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Estatus_de_Apoyo_ExternoApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Estatus_de_Apoyo_Externo";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Estatus_de_Apoyo_Externo.Estatus_de_Apoyo_Externo>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Estatus_de_Apoyo_Externo.Estatus_de_Apoyo_Externo>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Estatus_de_Apoyo_Externo.Estatus_de_Apoyo_Externo>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Estatus_de_Apoyo_Externo.Estatus_de_Apoyo_Externo>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Estatus_de_Apoyo_Externo.Estatus_de_Apoyo_Externo>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Estatus_de_Apoyo_Externo.Estatus_de_Apoyo_Externo>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Estatus_de_Apoyo_Externo.Estatus_de_Apoyo_Externo>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Estatus_de_Apoyo_Externo.Estatus_de_Apoyo_Externo>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Estatus_de_Apoyo_Externo.Estatus_de_Apoyo_Externo> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Estatus_de_Apoyo_Externo.Estatus_de_Apoyo_Externo>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Estatus_de_Apoyo_Externo.Estatus_de_Apoyo_Externo>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Estatus_de_Apoyo_Externo.Estatus_de_Apoyo_Externo>(false, null);
            }
        }

        public ApiResponse<Estatus_de_Apoyo_ExternoPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Estatus_de_Apoyo_Externo.Estatus_de_Apoyo_ExternoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Estatus_de_Apoyo_Externo.Clave='" + Key.ToString() + "'"
                        + "&Order=Estatus_de_Apoyo_Externo.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Estatus_de_Apoyo_Externo.Estatus_de_Apoyo_ExternoPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Estatus_de_Apoyo_Externo.Estatus_de_Apoyo_ExternoPagingModel>(false, new Estatus_de_Apoyo_ExternoPagingModel() { Estatus_de_Apoyo_Externos = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Estatus_de_Apoyo_ExternoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Estatus_de_Apoyo_Externo.Estatus_de_Apoyo_Externo entity, Core.Domain.User.GlobalData Estatus_de_Apoyo_ExternoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Estatus_de_Apoyo_Externo.Estatus_de_Apoyo_Externo entity, Core.Domain.User.GlobalData Estatus_de_Apoyo_ExternoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Estatus_de_Apoyo_Externo.Estatus_de_Apoyo_Externo>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Estatus_de_Apoyo_Externo.Estatus_de_Apoyo_Externo>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Estatus_de_Apoyo_Externo.Estatus_de_Apoyo_Externo>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Estatus_de_Apoyo_ExternoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Estatus_de_Apoyo_Externo.Estatus_de_Apoyo_ExternoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Estatus_de_Apoyo_Externo.Estatus_de_Apoyo_ExternoPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Estatus_de_Apoyo_Externo.Estatus_de_Apoyo_ExternoPagingModel>(false, new Estatus_de_Apoyo_ExternoPagingModel() { Estatus_de_Apoyo_Externos = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Estatus_de_Apoyo_Externo.Estatus_de_Apoyo_Externo>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Estatus_de_Apoyo_ExternoGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Estatus_de_Apoyo_Externo_Datos_Generales entity)
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

        public ApiResponse<Estatus_de_Apoyo_Externo_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Estatus_de_Apoyo_Externo.Estatus_de_Apoyo_Externo_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Estatus_de_Apoyo_Externo.Estatus_de_Apoyo_Externo_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Estatus_de_Apoyo_Externo.Estatus_de_Apoyo_Externo_Datos_Generales>(false, null);
            }
        }


    }
}

