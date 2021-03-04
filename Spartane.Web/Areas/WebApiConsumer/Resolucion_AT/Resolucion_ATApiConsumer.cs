using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Resolucion_AT;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Resolucion_AT
{
    public class Resolucion_ATApiConsumer : BaseApiConsumer,IResolucion_ATApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Resolucion_ATApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Resolucion_AT";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Resolucion_AT.Resolucion_AT>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Resolucion_AT.Resolucion_AT>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Resolucion_AT.Resolucion_AT>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Resolucion_AT.Resolucion_AT>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Resolucion_AT.Resolucion_AT>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Resolucion_AT.Resolucion_AT>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Resolucion_AT.Resolucion_AT>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Resolucion_AT.Resolucion_AT>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Resolucion_AT.Resolucion_AT> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Resolucion_AT.Resolucion_AT>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Resolucion_AT.Resolucion_AT>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Resolucion_AT.Resolucion_AT>(false, null);
            }
        }

        public ApiResponse<Resolucion_ATPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Resolucion_AT.Resolucion_ATPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Resolucion_AT.Clave='" + Key.ToString() + "'"
                        + "&Order=Resolucion_AT.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Resolucion_AT.Resolucion_ATPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Resolucion_AT.Resolucion_ATPagingModel>(false, new Resolucion_ATPagingModel() { Resolucion_ATs = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Resolucion_ATInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Resolucion_AT.Resolucion_AT entity, Core.Domain.User.GlobalData Resolucion_ATInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Resolucion_AT.Resolucion_AT entity, Core.Domain.User.GlobalData Resolucion_ATInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Resolucion_AT.Resolucion_AT>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Resolucion_AT.Resolucion_AT>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Resolucion_AT.Resolucion_AT>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Resolucion_ATPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Resolucion_AT.Resolucion_ATPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Resolucion_AT.Resolucion_ATPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Resolucion_AT.Resolucion_ATPagingModel>(false, new Resolucion_ATPagingModel() { Resolucion_ATs = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Resolucion_AT.Resolucion_AT>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Resolucion_ATGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Resolucion_AT_Datos_Generales entity)
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

        public ApiResponse<Resolucion_AT_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Resolucion_AT.Resolucion_AT_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Resolucion_AT.Resolucion_AT_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Resolucion_AT.Resolucion_AT_Datos_Generales>(false, null);
            }
        }

public ApiResponse<int> Update_Dictaminacion(Resolucion_AT_Dictaminacion entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Dictaminacion",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Resolucion_AT_Dictaminacion> Get_Dictaminacion(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Resolucion_AT.Resolucion_AT_Dictaminacion>(baseApi, ApiControllerUrl + "/Get_Dictaminacion?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Resolucion_AT.Resolucion_AT_Dictaminacion>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Resolucion_AT.Resolucion_AT_Dictaminacion>(false, null);
            }
        }


    }
}

