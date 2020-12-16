using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Modo_de_Asegurado_de_Drogas;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Modo_de_Asegurado_de_Drogas
{
    public class Modo_de_Asegurado_de_DrogasApiConsumer : BaseApiConsumer,IModo_de_Asegurado_de_DrogasApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Modo_de_Asegurado_de_DrogasApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Modo_de_Asegurado_de_Drogas";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas>(false, null);
            }
        }

        public ApiResponse<Modo_de_Asegurado_de_DrogasPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_DrogasPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Modo_de_Asegurado_de_Drogas.Clave='" + Key.ToString() + "'"
                        + "&Order=Modo_de_Asegurado_de_Drogas.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_DrogasPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_DrogasPagingModel>(false, new Modo_de_Asegurado_de_DrogasPagingModel() { Modo_de_Asegurado_de_Drogass = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Modo_de_Asegurado_de_DrogasInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas entity, Core.Domain.User.GlobalData Modo_de_Asegurado_de_DrogasInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas entity, Core.Domain.User.GlobalData Modo_de_Asegurado_de_DrogasInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Modo_de_Asegurado_de_DrogasPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_DrogasPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_DrogasPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_DrogasPagingModel>(false, new Modo_de_Asegurado_de_DrogasPagingModel() { Modo_de_Asegurado_de_Drogass = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Modo_de_Asegurado_de_DrogasGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Modo_de_Asegurado_de_Drogas_Datos_Generales entity)
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

        public ApiResponse<Modo_de_Asegurado_de_Drogas_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Modo_de_Asegurado_de_Drogas.Modo_de_Asegurado_de_Drogas_Datos_Generales>(false, null);
            }
        }


    }
}

