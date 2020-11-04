using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Lugares_Frecuentes_Involucrado;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Lugares_Frecuentes_Involucrado
{
    public class Lugares_Frecuentes_InvolucradoApiConsumer : BaseApiConsumer,ILugares_Frecuentes_InvolucradoApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Lugares_Frecuentes_InvolucradoApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Lugares_Frecuentes_Involucrado";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_Involucrado>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_Involucrado>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_Involucrado>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_Involucrado>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_Involucrado>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_Involucrado>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_Involucrado>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_Involucrado>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_Involucrado> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_Involucrado>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_Involucrado>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_Involucrado>(false, null);
            }
        }

        public ApiResponse<Lugares_Frecuentes_InvolucradoPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_InvolucradoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Lugares_Frecuentes_Involucrado.Clave='" + Key.ToString() + "'"
                        + "&Order=Lugares_Frecuentes_Involucrado.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_InvolucradoPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_InvolucradoPagingModel>(false, new Lugares_Frecuentes_InvolucradoPagingModel() { Lugares_Frecuentes_Involucrados = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Lugares_Frecuentes_InvolucradoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_Involucrado entity, Core.Domain.User.GlobalData Lugares_Frecuentes_InvolucradoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_Involucrado entity, Core.Domain.User.GlobalData Lugares_Frecuentes_InvolucradoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_Involucrado>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_Involucrado>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_Involucrado>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Lugares_Frecuentes_InvolucradoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_InvolucradoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_InvolucradoPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_InvolucradoPagingModel>(false, new Lugares_Frecuentes_InvolucradoPagingModel() { Lugares_Frecuentes_Involucrados = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_Involucrado>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Lugares_Frecuentes_InvolucradoGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Lugares_Frecuentes_Involucrado_Datos_Generales entity)
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

        public ApiResponse<Lugares_Frecuentes_Involucrado_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_Involucrado_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_Involucrado_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_Involucrado_Datos_Generales>(false, null);
            }
        }


    }
}

