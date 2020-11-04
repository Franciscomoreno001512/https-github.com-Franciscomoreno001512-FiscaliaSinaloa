using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Clasificacion_en_Orden_de_Resultado
{
    public class Clasificacion_en_Orden_de_ResultadoApiConsumer : BaseApiConsumer,IClasificacion_en_Orden_de_ResultadoApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Clasificacion_en_Orden_de_ResultadoApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Clasificacion_en_Orden_de_Resultado";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado>(false, null);
            }
        }

        public ApiResponse<Clasificacion_en_Orden_de_ResultadoPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_ResultadoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Clasificacion_en_Orden_de_Resultado.Clave='" + Key.ToString() + "'"
                        + "&Order=Clasificacion_en_Orden_de_Resultado.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_ResultadoPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_ResultadoPagingModel>(false, new Clasificacion_en_Orden_de_ResultadoPagingModel() { Clasificacion_en_Orden_de_Resultados = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Clasificacion_en_Orden_de_ResultadoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado entity, Core.Domain.User.GlobalData Clasificacion_en_Orden_de_ResultadoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado entity, Core.Domain.User.GlobalData Clasificacion_en_Orden_de_ResultadoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Clasificacion_en_Orden_de_ResultadoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_ResultadoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_ResultadoPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_ResultadoPagingModel>(false, new Clasificacion_en_Orden_de_ResultadoPagingModel() { Clasificacion_en_Orden_de_Resultados = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Clasificacion_en_Orden_de_ResultadoGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Clasificacion_en_Orden_de_Resultado_Datos_Generales entity)
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

        public ApiResponse<Clasificacion_en_Orden_de_Resultado_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado_Datos_Generales>(false, null);
            }
        }


    }
}

