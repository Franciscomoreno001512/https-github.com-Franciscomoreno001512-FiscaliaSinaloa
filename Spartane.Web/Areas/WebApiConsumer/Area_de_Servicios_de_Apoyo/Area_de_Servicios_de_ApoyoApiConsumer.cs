﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Area_de_Servicios_de_Apoyo;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Area_de_Servicios_de_Apoyo
{
    public class Area_de_Servicios_de_ApoyoApiConsumer : BaseApiConsumer,IArea_de_Servicios_de_ApoyoApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Area_de_Servicios_de_ApoyoApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Area_de_Servicios_de_Apoyo";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_Apoyo>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_Apoyo>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_Apoyo>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_Apoyo>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_Apoyo>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_Apoyo>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_Apoyo>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_Apoyo>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_Apoyo> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_Apoyo>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_Apoyo>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_Apoyo>(false, null);
            }
        }

        public ApiResponse<Area_de_Servicios_de_ApoyoPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_ApoyoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Area_de_Servicios_de_Apoyo.Clave='" + Key.ToString() + "'"
                        + "&Order=Area_de_Servicios_de_Apoyo.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_ApoyoPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_ApoyoPagingModel>(false, new Area_de_Servicios_de_ApoyoPagingModel() { Area_de_Servicios_de_Apoyos = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Area_de_Servicios_de_ApoyoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_Apoyo entity, Core.Domain.User.GlobalData Area_de_Servicios_de_ApoyoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_Apoyo entity, Core.Domain.User.GlobalData Area_de_Servicios_de_ApoyoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_Apoyo>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_Apoyo>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_Apoyo>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Area_de_Servicios_de_ApoyoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_ApoyoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_ApoyoPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_ApoyoPagingModel>(false, new Area_de_Servicios_de_ApoyoPagingModel() { Area_de_Servicios_de_Apoyos = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_Apoyo>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Area_de_Servicios_de_ApoyoGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Area_de_Servicios_de_Apoyo_Datos_Generales entity)
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

        public ApiResponse<Area_de_Servicios_de_Apoyo_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_Apoyo_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_Apoyo_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_Apoyo_Datos_Generales>(false, null);
            }
        }


    }
}

