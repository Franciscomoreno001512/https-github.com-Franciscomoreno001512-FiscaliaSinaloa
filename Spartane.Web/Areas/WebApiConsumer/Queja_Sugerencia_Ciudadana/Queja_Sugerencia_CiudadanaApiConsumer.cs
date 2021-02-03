using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Queja_Sugerencia_Ciudadana;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Queja_Sugerencia_Ciudadana
{
    public class Queja_Sugerencia_CiudadanaApiConsumer : BaseApiConsumer,IQueja_Sugerencia_CiudadanaApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Queja_Sugerencia_CiudadanaApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Queja_Sugerencia_Ciudadana";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_Ciudadana>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_Ciudadana>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_Ciudadana>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_Ciudadana>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_Ciudadana>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_Ciudadana>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_Ciudadana>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_Ciudadana>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_Ciudadana> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_Ciudadana>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_Ciudadana>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_Ciudadana>(false, null);
            }
        }

        public ApiResponse<Queja_Sugerencia_CiudadanaPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_CiudadanaPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Queja_Sugerencia_Ciudadana.Folio='" + Key.ToString() + "'"
                        + "&Order=Queja_Sugerencia_Ciudadana.Folio ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_CiudadanaPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_CiudadanaPagingModel>(false, new Queja_Sugerencia_CiudadanaPagingModel() { Queja_Sugerencia_Ciudadanas = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Queja_Sugerencia_CiudadanaInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_Ciudadana entity, Core.Domain.User.GlobalData Queja_Sugerencia_CiudadanaInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_Ciudadana entity, Core.Domain.User.GlobalData Queja_Sugerencia_CiudadanaInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_Ciudadana>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_Ciudadana>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_Ciudadana>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Queja_Sugerencia_CiudadanaPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_CiudadanaPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_CiudadanaPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_CiudadanaPagingModel>(false, new Queja_Sugerencia_CiudadanaPagingModel() { Queja_Sugerencia_Ciudadanas = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_Ciudadana>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Queja_Sugerencia_CiudadanaGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Queja_Sugerencia_Ciudadana_Datos_Generales entity)
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

        public ApiResponse<Queja_Sugerencia_Ciudadana_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_Ciudadana_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_Ciudadana_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_Ciudadana_Datos_Generales>(false, null);
            }
        }


    }
}

