using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Auto_de_Vinculacion_a_Proceso;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Auto_de_Vinculacion_a_Proceso
{
    public class Auto_de_Vinculacion_a_ProcesoApiConsumer : BaseApiConsumer,IAuto_de_Vinculacion_a_ProcesoApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Auto_de_Vinculacion_a_ProcesoApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Auto_de_Vinculacion_a_Proceso";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Auto_de_Vinculacion_a_Proceso.Auto_de_Vinculacion_a_Proceso>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Auto_de_Vinculacion_a_Proceso.Auto_de_Vinculacion_a_Proceso>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Auto_de_Vinculacion_a_Proceso.Auto_de_Vinculacion_a_Proceso>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Auto_de_Vinculacion_a_Proceso.Auto_de_Vinculacion_a_Proceso>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Auto_de_Vinculacion_a_Proceso.Auto_de_Vinculacion_a_Proceso>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Auto_de_Vinculacion_a_Proceso.Auto_de_Vinculacion_a_Proceso>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Auto_de_Vinculacion_a_Proceso.Auto_de_Vinculacion_a_Proceso>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Auto_de_Vinculacion_a_Proceso.Auto_de_Vinculacion_a_Proceso>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Auto_de_Vinculacion_a_Proceso.Auto_de_Vinculacion_a_Proceso> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Auto_de_Vinculacion_a_Proceso.Auto_de_Vinculacion_a_Proceso>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Auto_de_Vinculacion_a_Proceso.Auto_de_Vinculacion_a_Proceso>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Auto_de_Vinculacion_a_Proceso.Auto_de_Vinculacion_a_Proceso>(false, null);
            }
        }

        public ApiResponse<Auto_de_Vinculacion_a_ProcesoPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Auto_de_Vinculacion_a_Proceso.Auto_de_Vinculacion_a_ProcesoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Auto_de_Vinculacion_a_Proceso.Clave='" + Key.ToString() + "'"
                        + "&Order=Auto_de_Vinculacion_a_Proceso.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Auto_de_Vinculacion_a_Proceso.Auto_de_Vinculacion_a_ProcesoPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Auto_de_Vinculacion_a_Proceso.Auto_de_Vinculacion_a_ProcesoPagingModel>(false, new Auto_de_Vinculacion_a_ProcesoPagingModel() { Auto_de_Vinculacion_a_Procesos = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Auto_de_Vinculacion_a_ProcesoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Auto_de_Vinculacion_a_Proceso.Auto_de_Vinculacion_a_Proceso entity, Core.Domain.User.GlobalData Auto_de_Vinculacion_a_ProcesoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Auto_de_Vinculacion_a_Proceso.Auto_de_Vinculacion_a_Proceso entity, Core.Domain.User.GlobalData Auto_de_Vinculacion_a_ProcesoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Auto_de_Vinculacion_a_Proceso.Auto_de_Vinculacion_a_Proceso>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Auto_de_Vinculacion_a_Proceso.Auto_de_Vinculacion_a_Proceso>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Auto_de_Vinculacion_a_Proceso.Auto_de_Vinculacion_a_Proceso>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Auto_de_Vinculacion_a_ProcesoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Auto_de_Vinculacion_a_Proceso.Auto_de_Vinculacion_a_ProcesoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Auto_de_Vinculacion_a_Proceso.Auto_de_Vinculacion_a_ProcesoPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Auto_de_Vinculacion_a_Proceso.Auto_de_Vinculacion_a_ProcesoPagingModel>(false, new Auto_de_Vinculacion_a_ProcesoPagingModel() { Auto_de_Vinculacion_a_Procesos = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Auto_de_Vinculacion_a_Proceso.Auto_de_Vinculacion_a_Proceso>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Auto_de_Vinculacion_a_ProcesoGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Auto_de_Vinculacion_a_Proceso_Datos_Generales entity)
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

        public ApiResponse<Auto_de_Vinculacion_a_Proceso_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Auto_de_Vinculacion_a_Proceso.Auto_de_Vinculacion_a_Proceso_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Auto_de_Vinculacion_a_Proceso.Auto_de_Vinculacion_a_Proceso_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Auto_de_Vinculacion_a_Proceso.Auto_de_Vinculacion_a_Proceso_Datos_Generales>(false, null);
            }
        }


    }
}

