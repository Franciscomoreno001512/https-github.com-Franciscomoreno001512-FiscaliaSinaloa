﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Resolucion_de_Mandamiento_Judicial;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Resolucion_de_Mandamiento_Judicial
{
    public class Resolucion_de_Mandamiento_JudicialApiConsumer : BaseApiConsumer,IResolucion_de_Mandamiento_JudicialApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Resolucion_de_Mandamiento_JudicialApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Resolucion_de_Mandamiento_Judicial";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Resolucion_de_Mandamiento_Judicial.Resolucion_de_Mandamiento_Judicial>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Resolucion_de_Mandamiento_Judicial.Resolucion_de_Mandamiento_Judicial>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Resolucion_de_Mandamiento_Judicial.Resolucion_de_Mandamiento_Judicial>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Resolucion_de_Mandamiento_Judicial.Resolucion_de_Mandamiento_Judicial>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Resolucion_de_Mandamiento_Judicial.Resolucion_de_Mandamiento_Judicial>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Resolucion_de_Mandamiento_Judicial.Resolucion_de_Mandamiento_Judicial>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Resolucion_de_Mandamiento_Judicial.Resolucion_de_Mandamiento_Judicial>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Resolucion_de_Mandamiento_Judicial.Resolucion_de_Mandamiento_Judicial>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Resolucion_de_Mandamiento_Judicial.Resolucion_de_Mandamiento_Judicial> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Resolucion_de_Mandamiento_Judicial.Resolucion_de_Mandamiento_Judicial>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Resolucion_de_Mandamiento_Judicial.Resolucion_de_Mandamiento_Judicial>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Resolucion_de_Mandamiento_Judicial.Resolucion_de_Mandamiento_Judicial>(false, null);
            }
        }

        public ApiResponse<Resolucion_de_Mandamiento_JudicialPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Resolucion_de_Mandamiento_Judicial.Resolucion_de_Mandamiento_JudicialPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Resolucion_de_Mandamiento_Judicial.Clave='" + Key.ToString() + "'"
                        + "&Order=Resolucion_de_Mandamiento_Judicial.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Resolucion_de_Mandamiento_Judicial.Resolucion_de_Mandamiento_JudicialPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Resolucion_de_Mandamiento_Judicial.Resolucion_de_Mandamiento_JudicialPagingModel>(false, new Resolucion_de_Mandamiento_JudicialPagingModel() { Resolucion_de_Mandamiento_Judicials = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Resolucion_de_Mandamiento_JudicialInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Resolucion_de_Mandamiento_Judicial.Resolucion_de_Mandamiento_Judicial entity, Core.Domain.User.GlobalData Resolucion_de_Mandamiento_JudicialInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Resolucion_de_Mandamiento_Judicial.Resolucion_de_Mandamiento_Judicial entity, Core.Domain.User.GlobalData Resolucion_de_Mandamiento_JudicialInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Resolucion_de_Mandamiento_Judicial.Resolucion_de_Mandamiento_Judicial>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Resolucion_de_Mandamiento_Judicial.Resolucion_de_Mandamiento_Judicial>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Resolucion_de_Mandamiento_Judicial.Resolucion_de_Mandamiento_Judicial>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Resolucion_de_Mandamiento_JudicialPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Resolucion_de_Mandamiento_Judicial.Resolucion_de_Mandamiento_JudicialPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Resolucion_de_Mandamiento_Judicial.Resolucion_de_Mandamiento_JudicialPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Resolucion_de_Mandamiento_Judicial.Resolucion_de_Mandamiento_JudicialPagingModel>(false, new Resolucion_de_Mandamiento_JudicialPagingModel() { Resolucion_de_Mandamiento_Judicials = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Resolucion_de_Mandamiento_Judicial.Resolucion_de_Mandamiento_Judicial>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Resolucion_de_Mandamiento_JudicialGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Resolucion_de_Mandamiento_Judicial_Datos_Generales entity)
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

        public ApiResponse<Resolucion_de_Mandamiento_Judicial_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Resolucion_de_Mandamiento_Judicial.Resolucion_de_Mandamiento_Judicial_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Resolucion_de_Mandamiento_Judicial.Resolucion_de_Mandamiento_Judicial_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Resolucion_de_Mandamiento_Judicial.Resolucion_de_Mandamiento_Judicial_Datos_Generales>(false, null);
            }
        }


    }
}

