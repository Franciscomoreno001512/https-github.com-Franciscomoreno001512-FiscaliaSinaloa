using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Autoridad_Servicio_Pericial;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Autoridad_Servicio_Pericial
{
    public class Autoridad_Servicio_PericialApiConsumer : BaseApiConsumer,IAutoridad_Servicio_PericialApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Autoridad_Servicio_PericialApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Autoridad_Servicio_Pericial";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Autoridad_Servicio_Pericial.Autoridad_Servicio_Pericial>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Autoridad_Servicio_Pericial.Autoridad_Servicio_Pericial>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Autoridad_Servicio_Pericial.Autoridad_Servicio_Pericial>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Autoridad_Servicio_Pericial.Autoridad_Servicio_Pericial>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Autoridad_Servicio_Pericial.Autoridad_Servicio_Pericial>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Autoridad_Servicio_Pericial.Autoridad_Servicio_Pericial>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Autoridad_Servicio_Pericial.Autoridad_Servicio_Pericial>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Autoridad_Servicio_Pericial.Autoridad_Servicio_Pericial>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Autoridad_Servicio_Pericial.Autoridad_Servicio_Pericial> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Autoridad_Servicio_Pericial.Autoridad_Servicio_Pericial>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Autoridad_Servicio_Pericial.Autoridad_Servicio_Pericial>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Autoridad_Servicio_Pericial.Autoridad_Servicio_Pericial>(false, null);
            }
        }

        public ApiResponse<Autoridad_Servicio_PericialPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Autoridad_Servicio_Pericial.Autoridad_Servicio_PericialPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Autoridad_Servicio_Pericial.Clave='" + Key.ToString() + "'"
                        + "&Order=Autoridad_Servicio_Pericial.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Autoridad_Servicio_Pericial.Autoridad_Servicio_PericialPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Autoridad_Servicio_Pericial.Autoridad_Servicio_PericialPagingModel>(false, new Autoridad_Servicio_PericialPagingModel() { Autoridad_Servicio_Pericials = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Autoridad_Servicio_PericialInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Autoridad_Servicio_Pericial.Autoridad_Servicio_Pericial entity, Core.Domain.User.GlobalData Autoridad_Servicio_PericialInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Autoridad_Servicio_Pericial.Autoridad_Servicio_Pericial entity, Core.Domain.User.GlobalData Autoridad_Servicio_PericialInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Autoridad_Servicio_Pericial.Autoridad_Servicio_Pericial>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Autoridad_Servicio_Pericial.Autoridad_Servicio_Pericial>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Autoridad_Servicio_Pericial.Autoridad_Servicio_Pericial>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Autoridad_Servicio_PericialPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Autoridad_Servicio_Pericial.Autoridad_Servicio_PericialPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Autoridad_Servicio_Pericial.Autoridad_Servicio_PericialPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Autoridad_Servicio_Pericial.Autoridad_Servicio_PericialPagingModel>(false, new Autoridad_Servicio_PericialPagingModel() { Autoridad_Servicio_Pericials = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Autoridad_Servicio_Pericial.Autoridad_Servicio_Pericial>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Autoridad_Servicio_PericialGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Autoridad_Servicio_Pericial_Datos_Generales entity)
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

        public ApiResponse<Autoridad_Servicio_Pericial_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Autoridad_Servicio_Pericial.Autoridad_Servicio_Pericial_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Autoridad_Servicio_Pericial.Autoridad_Servicio_Pericial_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Autoridad_Servicio_Pericial.Autoridad_Servicio_Pericial_Datos_Generales>(false, null);
            }
        }


    }
}

