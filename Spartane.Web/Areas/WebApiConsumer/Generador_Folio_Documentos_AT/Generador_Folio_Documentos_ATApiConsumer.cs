using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Generador_Folio_Documentos_AT;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Generador_Folio_Documentos_AT
{
    public class Generador_Folio_Documentos_ATApiConsumer : BaseApiConsumer,IGenerador_Folio_Documentos_ATApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Generador_Folio_Documentos_ATApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Generador_Folio_Documentos_AT";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT>(false, null);
            }
        }

        public ApiResponse<Generador_Folio_Documentos_ATPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_ATPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Generador_Folio_Documentos_AT.Folio='" + Key.ToString() + "'"
                        + "&Order=Generador_Folio_Documentos_AT.Folio ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_ATPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_ATPagingModel>(false, new Generador_Folio_Documentos_ATPagingModel() { Generador_Folio_Documentos_ATs = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Generador_Folio_Documentos_ATInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT entity, Core.Domain.User.GlobalData Generador_Folio_Documentos_ATInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT entity, Core.Domain.User.GlobalData Generador_Folio_Documentos_ATInformation, DataLayerFieldsBitacora DataReference)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put?Id=" + entity.Folio,
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<IList<Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Generador_Folio_Documentos_ATPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_ATPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_ATPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_ATPagingModel>(false, new Generador_Folio_Documentos_ATPagingModel() { Generador_Folio_Documentos_ATs = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Generador_Folio_Documentos_ATGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Generador_Folio_Documentos_AT_Datos_Generales entity)
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

        public ApiResponse<Generador_Folio_Documentos_AT_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT_Datos_Generales>(false, null);
            }
        }


    }
}

