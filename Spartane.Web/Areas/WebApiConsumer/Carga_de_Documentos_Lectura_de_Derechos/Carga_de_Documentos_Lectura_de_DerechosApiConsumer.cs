using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Carga_de_Documentos_Lectura_de_Derechos;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Carga_de_Documentos_Lectura_de_Derechos
{
    public class Carga_de_Documentos_Lectura_de_DerechosApiConsumer : BaseApiConsumer,ICarga_de_Documentos_Lectura_de_DerechosApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Carga_de_Documentos_Lectura_de_DerechosApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Carga_de_Documentos_Lectura_de_Derechos";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Carga_de_Documentos_Lectura_de_Derechos.Carga_de_Documentos_Lectura_de_Derechos>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Carga_de_Documentos_Lectura_de_Derechos.Carga_de_Documentos_Lectura_de_Derechos>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Carga_de_Documentos_Lectura_de_Derechos.Carga_de_Documentos_Lectura_de_Derechos>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Carga_de_Documentos_Lectura_de_Derechos.Carga_de_Documentos_Lectura_de_Derechos>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Carga_de_Documentos_Lectura_de_Derechos.Carga_de_Documentos_Lectura_de_Derechos>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Carga_de_Documentos_Lectura_de_Derechos.Carga_de_Documentos_Lectura_de_Derechos>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Carga_de_Documentos_Lectura_de_Derechos.Carga_de_Documentos_Lectura_de_Derechos>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Carga_de_Documentos_Lectura_de_Derechos.Carga_de_Documentos_Lectura_de_Derechos>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Carga_de_Documentos_Lectura_de_Derechos.Carga_de_Documentos_Lectura_de_Derechos> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Carga_de_Documentos_Lectura_de_Derechos.Carga_de_Documentos_Lectura_de_Derechos>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Carga_de_Documentos_Lectura_de_Derechos.Carga_de_Documentos_Lectura_de_Derechos>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Carga_de_Documentos_Lectura_de_Derechos.Carga_de_Documentos_Lectura_de_Derechos>(false, null);
            }
        }

        public ApiResponse<Carga_de_Documentos_Lectura_de_DerechosPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Carga_de_Documentos_Lectura_de_Derechos.Carga_de_Documentos_Lectura_de_DerechosPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Carga_de_Documentos_Lectura_de_Derechos.Folio='" + Key.ToString() + "'"
                        + "&Order=Carga_de_Documentos_Lectura_de_Derechos.Folio ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Carga_de_Documentos_Lectura_de_Derechos.Carga_de_Documentos_Lectura_de_DerechosPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Carga_de_Documentos_Lectura_de_Derechos.Carga_de_Documentos_Lectura_de_DerechosPagingModel>(false, new Carga_de_Documentos_Lectura_de_DerechosPagingModel() { Carga_de_Documentos_Lectura_de_Derechoss = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Carga_de_Documentos_Lectura_de_DerechosInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Carga_de_Documentos_Lectura_de_Derechos.Carga_de_Documentos_Lectura_de_Derechos entity, Core.Domain.User.GlobalData Carga_de_Documentos_Lectura_de_DerechosInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Carga_de_Documentos_Lectura_de_Derechos.Carga_de_Documentos_Lectura_de_Derechos entity, Core.Domain.User.GlobalData Carga_de_Documentos_Lectura_de_DerechosInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Carga_de_Documentos_Lectura_de_Derechos.Carga_de_Documentos_Lectura_de_Derechos>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Carga_de_Documentos_Lectura_de_Derechos.Carga_de_Documentos_Lectura_de_Derechos>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Carga_de_Documentos_Lectura_de_Derechos.Carga_de_Documentos_Lectura_de_Derechos>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Carga_de_Documentos_Lectura_de_DerechosPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Carga_de_Documentos_Lectura_de_Derechos.Carga_de_Documentos_Lectura_de_DerechosPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Carga_de_Documentos_Lectura_de_Derechos.Carga_de_Documentos_Lectura_de_DerechosPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Carga_de_Documentos_Lectura_de_Derechos.Carga_de_Documentos_Lectura_de_DerechosPagingModel>(false, new Carga_de_Documentos_Lectura_de_DerechosPagingModel() { Carga_de_Documentos_Lectura_de_Derechoss = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Carga_de_Documentos_Lectura_de_Derechos.Carga_de_Documentos_Lectura_de_Derechos>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Carga_de_Documentos_Lectura_de_DerechosGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Carga_de_Documentos_Lectura_de_Derechos_Datos_Generales entity)
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

        public ApiResponse<Carga_de_Documentos_Lectura_de_Derechos_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Carga_de_Documentos_Lectura_de_Derechos.Carga_de_Documentos_Lectura_de_Derechos_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Carga_de_Documentos_Lectura_de_Derechos.Carga_de_Documentos_Lectura_de_Derechos_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Carga_de_Documentos_Lectura_de_Derechos.Carga_de_Documentos_Lectura_de_Derechos_Datos_Generales>(false, null);
            }
        }


    }
}

