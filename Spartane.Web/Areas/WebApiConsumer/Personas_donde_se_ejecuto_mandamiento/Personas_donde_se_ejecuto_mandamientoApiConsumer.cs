using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Personas_donde_se_ejecuto_mandamiento;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Personas_donde_se_ejecuto_mandamiento
{
    public class Personas_donde_se_ejecuto_mandamientoApiConsumer : BaseApiConsumer,IPersonas_donde_se_ejecuto_mandamientoApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Personas_donde_se_ejecuto_mandamientoApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Personas_donde_se_ejecuto_mandamiento";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento>(false, null);
            }
        }

        public ApiResponse<Personas_donde_se_ejecuto_mandamientoPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamientoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Personas_donde_se_ejecuto_mandamiento.Folio='" + Key.ToString() + "'"
                        + "&Order=Personas_donde_se_ejecuto_mandamiento.Folio ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamientoPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamientoPagingModel>(false, new Personas_donde_se_ejecuto_mandamientoPagingModel() { Personas_donde_se_ejecuto_mandamientos = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Personas_donde_se_ejecuto_mandamientoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento entity, Core.Domain.User.GlobalData Personas_donde_se_ejecuto_mandamientoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento entity, Core.Domain.User.GlobalData Personas_donde_se_ejecuto_mandamientoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Personas_donde_se_ejecuto_mandamientoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamientoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamientoPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamientoPagingModel>(false, new Personas_donde_se_ejecuto_mandamientoPagingModel() { Personas_donde_se_ejecuto_mandamientos = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Personas_donde_se_ejecuto_mandamientoGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Personas_donde_se_ejecuto_mandamiento_Datos_Generales entity)
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

        public ApiResponse<Personas_donde_se_ejecuto_mandamiento_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento_Datos_Generales>(false, null);
            }
        }


    }
}

