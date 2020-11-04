using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Registro_de_Tiempo_por_Estatus;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Registro_de_Tiempo_por_Estatus
{
    public class Registro_de_Tiempo_por_EstatusApiConsumer : BaseApiConsumer,IRegistro_de_Tiempo_por_EstatusApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Registro_de_Tiempo_por_EstatusApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Registro_de_Tiempo_por_Estatus";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Registro_de_Tiempo_por_Estatus.Registro_de_Tiempo_por_Estatus>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Registro_de_Tiempo_por_Estatus.Registro_de_Tiempo_por_Estatus>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Registro_de_Tiempo_por_Estatus.Registro_de_Tiempo_por_Estatus>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Registro_de_Tiempo_por_Estatus.Registro_de_Tiempo_por_Estatus>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Registro_de_Tiempo_por_Estatus.Registro_de_Tiempo_por_Estatus>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Registro_de_Tiempo_por_Estatus.Registro_de_Tiempo_por_Estatus>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Registro_de_Tiempo_por_Estatus.Registro_de_Tiempo_por_Estatus>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Registro_de_Tiempo_por_Estatus.Registro_de_Tiempo_por_Estatus>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Registro_de_Tiempo_por_Estatus.Registro_de_Tiempo_por_Estatus> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Registro_de_Tiempo_por_Estatus.Registro_de_Tiempo_por_Estatus>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Registro_de_Tiempo_por_Estatus.Registro_de_Tiempo_por_Estatus>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Registro_de_Tiempo_por_Estatus.Registro_de_Tiempo_por_Estatus>(false, null);
            }
        }

        public ApiResponse<Registro_de_Tiempo_por_EstatusPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Registro_de_Tiempo_por_Estatus.Registro_de_Tiempo_por_EstatusPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Registro_de_Tiempo_por_Estatus.Clave='" + Key.ToString() + "'"
                        + "&Order=Registro_de_Tiempo_por_Estatus.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Registro_de_Tiempo_por_Estatus.Registro_de_Tiempo_por_EstatusPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Registro_de_Tiempo_por_Estatus.Registro_de_Tiempo_por_EstatusPagingModel>(false, new Registro_de_Tiempo_por_EstatusPagingModel() { Registro_de_Tiempo_por_Estatuss = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Registro_de_Tiempo_por_EstatusInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Registro_de_Tiempo_por_Estatus.Registro_de_Tiempo_por_Estatus entity, Core.Domain.User.GlobalData Registro_de_Tiempo_por_EstatusInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Registro_de_Tiempo_por_Estatus.Registro_de_Tiempo_por_Estatus entity, Core.Domain.User.GlobalData Registro_de_Tiempo_por_EstatusInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Registro_de_Tiempo_por_Estatus.Registro_de_Tiempo_por_Estatus>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Registro_de_Tiempo_por_Estatus.Registro_de_Tiempo_por_Estatus>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Registro_de_Tiempo_por_Estatus.Registro_de_Tiempo_por_Estatus>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Registro_de_Tiempo_por_EstatusPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Registro_de_Tiempo_por_Estatus.Registro_de_Tiempo_por_EstatusPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Registro_de_Tiempo_por_Estatus.Registro_de_Tiempo_por_EstatusPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Registro_de_Tiempo_por_Estatus.Registro_de_Tiempo_por_EstatusPagingModel>(false, new Registro_de_Tiempo_por_EstatusPagingModel() { Registro_de_Tiempo_por_Estatuss = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Registro_de_Tiempo_por_Estatus.Registro_de_Tiempo_por_Estatus>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Registro_de_Tiempo_por_EstatusGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Registro_de_Tiempo_por_Estatus_Datos_Generales entity)
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

        public ApiResponse<Registro_de_Tiempo_por_Estatus_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Registro_de_Tiempo_por_Estatus.Registro_de_Tiempo_por_Estatus_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Registro_de_Tiempo_por_Estatus.Registro_de_Tiempo_por_Estatus_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Registro_de_Tiempo_por_Estatus.Registro_de_Tiempo_por_Estatus_Datos_Generales>(false, null);
            }
        }


    }
}

