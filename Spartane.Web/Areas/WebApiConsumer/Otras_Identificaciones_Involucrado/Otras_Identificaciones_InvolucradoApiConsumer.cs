using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Otras_Identificaciones_Involucrado;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Otras_Identificaciones_Involucrado
{
    public class Otras_Identificaciones_InvolucradoApiConsumer : BaseApiConsumer,IOtras_Identificaciones_InvolucradoApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Otras_Identificaciones_InvolucradoApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Otras_Identificaciones_Involucrado";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_Involucrado>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_Involucrado>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_Involucrado>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_Involucrado>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_Involucrado>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_Involucrado>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_Involucrado>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_Involucrado>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_Involucrado> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_Involucrado>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_Involucrado>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_Involucrado>(false, null);
            }
        }

        public ApiResponse<Otras_Identificaciones_InvolucradoPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_InvolucradoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Otras_Identificaciones_Involucrado.Clave='" + Key.ToString() + "'"
                        + "&Order=Otras_Identificaciones_Involucrado.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_InvolucradoPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_InvolucradoPagingModel>(false, new Otras_Identificaciones_InvolucradoPagingModel() { Otras_Identificaciones_Involucrados = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Otras_Identificaciones_InvolucradoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_Involucrado entity, Core.Domain.User.GlobalData Otras_Identificaciones_InvolucradoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_Involucrado entity, Core.Domain.User.GlobalData Otras_Identificaciones_InvolucradoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_Involucrado>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_Involucrado>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_Involucrado>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Otras_Identificaciones_InvolucradoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_InvolucradoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_InvolucradoPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_InvolucradoPagingModel>(false, new Otras_Identificaciones_InvolucradoPagingModel() { Otras_Identificaciones_Involucrados = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_Involucrado>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Otras_Identificaciones_InvolucradoGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Otras_Identificaciones_Involucrado_Datos_Generales entity)
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

        public ApiResponse<Otras_Identificaciones_Involucrado_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_Involucrado_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_Involucrado_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Otras_Identificaciones_Involucrado.Otras_Identificaciones_Involucrado_Datos_Generales>(false, null);
            }
        }


    }
}

