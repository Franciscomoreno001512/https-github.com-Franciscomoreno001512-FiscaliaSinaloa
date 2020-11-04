using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Acta_de_Lectura_de_Derechos;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Acta_de_Lectura_de_Derechos
{
    public class Acta_de_Lectura_de_DerechosApiConsumer : BaseApiConsumer,IActa_de_Lectura_de_DerechosApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Acta_de_Lectura_de_DerechosApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Acta_de_Lectura_de_Derechos";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos>(false, null);
            }
        }

        public ApiResponse<Acta_de_Lectura_de_DerechosPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_DerechosPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Acta_de_Lectura_de_Derechos.Clave='" + Key.ToString() + "'"
                        + "&Order=Acta_de_Lectura_de_Derechos.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_DerechosPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_DerechosPagingModel>(false, new Acta_de_Lectura_de_DerechosPagingModel() { Acta_de_Lectura_de_Derechoss = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Acta_de_Lectura_de_DerechosInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos entity, Core.Domain.User.GlobalData Acta_de_Lectura_de_DerechosInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos entity, Core.Domain.User.GlobalData Acta_de_Lectura_de_DerechosInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Acta_de_Lectura_de_DerechosPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_DerechosPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_DerechosPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_DerechosPagingModel>(false, new Acta_de_Lectura_de_DerechosPagingModel() { Acta_de_Lectura_de_Derechoss = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Acta_de_Lectura_de_DerechosGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Acta_de_Lectura_de_Derechos_Datos_Generales entity)
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

        public ApiResponse<Acta_de_Lectura_de_Derechos_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Acta_de_Lectura_de_Derechos.Acta_de_Lectura_de_Derechos_Datos_Generales>(false, null);
            }
        }


    }
}

