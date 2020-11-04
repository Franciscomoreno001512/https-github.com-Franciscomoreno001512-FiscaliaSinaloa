using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Correccion_de_Error_en_Estatus;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Correccion_de_Error_en_Estatus
{
    public class Correccion_de_Error_en_EstatusApiConsumer : BaseApiConsumer,ICorreccion_de_Error_en_EstatusApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Correccion_de_Error_en_EstatusApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Correccion_de_Error_en_Estatus";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus>(false, null);
            }
        }

        public ApiResponse<Correccion_de_Error_en_EstatusPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_EstatusPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Correccion_de_Error_en_Estatus.Clave='" + Key.ToString() + "'"
                        + "&Order=Correccion_de_Error_en_Estatus.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_EstatusPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_EstatusPagingModel>(false, new Correccion_de_Error_en_EstatusPagingModel() { Correccion_de_Error_en_Estatuss = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Correccion_de_Error_en_EstatusInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus entity, Core.Domain.User.GlobalData Correccion_de_Error_en_EstatusInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus entity, Core.Domain.User.GlobalData Correccion_de_Error_en_EstatusInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Correccion_de_Error_en_EstatusPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_EstatusPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_EstatusPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_EstatusPagingModel>(false, new Correccion_de_Error_en_EstatusPagingModel() { Correccion_de_Error_en_Estatuss = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Correccion_de_Error_en_EstatusGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Correccion_de_Error_en_Estatus_Datos_Generales entity)
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

        public ApiResponse<Correccion_de_Error_en_Estatus_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus_Datos_Generales>(false, null);
            }
        }


    }
}

