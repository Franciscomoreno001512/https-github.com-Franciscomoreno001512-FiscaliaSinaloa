﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Tipo_de_Pista_de_Aterrizaje;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Tipo_de_Pista_de_Aterrizaje
{
    public class Tipo_de_Pista_de_AterrizajeApiConsumer : BaseApiConsumer,ITipo_de_Pista_de_AterrizajeApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Tipo_de_Pista_de_AterrizajeApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Tipo_de_Pista_de_Aterrizaje";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Tipo_de_Pista_de_Aterrizaje.Tipo_de_Pista_de_Aterrizaje>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Tipo_de_Pista_de_Aterrizaje.Tipo_de_Pista_de_Aterrizaje>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Tipo_de_Pista_de_Aterrizaje.Tipo_de_Pista_de_Aterrizaje>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Tipo_de_Pista_de_Aterrizaje.Tipo_de_Pista_de_Aterrizaje>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Tipo_de_Pista_de_Aterrizaje.Tipo_de_Pista_de_Aterrizaje>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Tipo_de_Pista_de_Aterrizaje.Tipo_de_Pista_de_Aterrizaje>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Tipo_de_Pista_de_Aterrizaje.Tipo_de_Pista_de_Aterrizaje>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Tipo_de_Pista_de_Aterrizaje.Tipo_de_Pista_de_Aterrizaje>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Tipo_de_Pista_de_Aterrizaje.Tipo_de_Pista_de_Aterrizaje> GetByKey(short Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Tipo_de_Pista_de_Aterrizaje.Tipo_de_Pista_de_Aterrizaje>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Tipo_de_Pista_de_Aterrizaje.Tipo_de_Pista_de_Aterrizaje>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Tipo_de_Pista_de_Aterrizaje.Tipo_de_Pista_de_Aterrizaje>(false, null);
            }
        }

        public ApiResponse<Tipo_de_Pista_de_AterrizajePagingModel> GetByKeyComplete(short Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Tipo_de_Pista_de_Aterrizaje.Tipo_de_Pista_de_AterrizajePagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Tipo_de_Pista_de_Aterrizaje.Clave='" + Key.ToString() + "'"
                        + "&Order=Tipo_de_Pista_de_Aterrizaje.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Tipo_de_Pista_de_Aterrizaje.Tipo_de_Pista_de_AterrizajePagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Tipo_de_Pista_de_Aterrizaje.Tipo_de_Pista_de_AterrizajePagingModel>(false, new Tipo_de_Pista_de_AterrizajePagingModel() { Tipo_de_Pista_de_Aterrizajes = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(short Key, Core.Domain.User.GlobalData Tipo_de_Pista_de_AterrizajeInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<short> Insert(Core.Domain.Tipo_de_Pista_de_Aterrizaje.Tipo_de_Pista_de_Aterrizaje entity, Core.Domain.User.GlobalData Tipo_de_Pista_de_AterrizajeInformation, DataLayerFieldsBitacora DataReference)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<short>(baseApi, ApiControllerUrl + "/Post",
                      Method.POST, ApiHeader, entity);

                return new ApiResponse<short>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<short>(false, -1 );
            }
        }

        public ApiResponse<short> Update(Core.Domain.Tipo_de_Pista_de_Aterrizaje.Tipo_de_Pista_de_Aterrizaje entity, Core.Domain.User.GlobalData Tipo_de_Pista_de_AterrizajeInformation, DataLayerFieldsBitacora DataReference)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<short>(baseApi, ApiControllerUrl + "/Put?Id=" + entity.Clave,
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<short>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<short>(false, -1 );
            }
        }

        public ApiResponse<IList<Core.Domain.Tipo_de_Pista_de_Aterrizaje.Tipo_de_Pista_de_Aterrizaje>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Tipo_de_Pista_de_Aterrizaje.Tipo_de_Pista_de_Aterrizaje>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Tipo_de_Pista_de_Aterrizaje.Tipo_de_Pista_de_Aterrizaje>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Tipo_de_Pista_de_AterrizajePagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Tipo_de_Pista_de_Aterrizaje.Tipo_de_Pista_de_AterrizajePagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Tipo_de_Pista_de_Aterrizaje.Tipo_de_Pista_de_AterrizajePagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Tipo_de_Pista_de_Aterrizaje.Tipo_de_Pista_de_AterrizajePagingModel>(false, new Tipo_de_Pista_de_AterrizajePagingModel() { Tipo_de_Pista_de_Aterrizajes = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Tipo_de_Pista_de_Aterrizaje.Tipo_de_Pista_de_Aterrizaje>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<short> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<short>(baseApi, ApiControllerUrl + "/Tipo_de_Pista_de_AterrizajeGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<short>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<short>(false, -1 );
            }
        }
		
public ApiResponse<short> Update_Datos_Generales(Tipo_de_Pista_de_Aterrizaje_Datos_Generales entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<short>(baseApi, ApiControllerUrl + "/Put_Datos_Generales",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<short>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<short>(false, -1 );
            }
        }

        public ApiResponse<Tipo_de_Pista_de_Aterrizaje_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Tipo_de_Pista_de_Aterrizaje.Tipo_de_Pista_de_Aterrizaje_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Tipo_de_Pista_de_Aterrizaje.Tipo_de_Pista_de_Aterrizaje_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Tipo_de_Pista_de_Aterrizaje.Tipo_de_Pista_de_Aterrizaje_Datos_Generales>(false, null);
            }
        }


    }
}

