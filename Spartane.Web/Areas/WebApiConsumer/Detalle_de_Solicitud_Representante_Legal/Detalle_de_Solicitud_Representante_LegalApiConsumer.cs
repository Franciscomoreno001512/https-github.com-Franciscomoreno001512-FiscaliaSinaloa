using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Detalle_de_Solicitud_Representante_Legal;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Detalle_de_Solicitud_Representante_Legal
{
    public class Detalle_de_Solicitud_Representante_LegalApiConsumer : BaseApiConsumer,IDetalle_de_Solicitud_Representante_LegalApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Detalle_de_Solicitud_Representante_LegalApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Detalle_de_Solicitud_Representante_Legal";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Detalle_de_Solicitud_Representante_Legal.Detalle_de_Solicitud_Representante_Legal>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Detalle_de_Solicitud_Representante_Legal.Detalle_de_Solicitud_Representante_Legal>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Detalle_de_Solicitud_Representante_Legal.Detalle_de_Solicitud_Representante_Legal>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Detalle_de_Solicitud_Representante_Legal.Detalle_de_Solicitud_Representante_Legal>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Detalle_de_Solicitud_Representante_Legal.Detalle_de_Solicitud_Representante_Legal>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Detalle_de_Solicitud_Representante_Legal.Detalle_de_Solicitud_Representante_Legal>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Detalle_de_Solicitud_Representante_Legal.Detalle_de_Solicitud_Representante_Legal>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Detalle_de_Solicitud_Representante_Legal.Detalle_de_Solicitud_Representante_Legal>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Detalle_de_Solicitud_Representante_Legal.Detalle_de_Solicitud_Representante_Legal> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Detalle_de_Solicitud_Representante_Legal.Detalle_de_Solicitud_Representante_Legal>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Detalle_de_Solicitud_Representante_Legal.Detalle_de_Solicitud_Representante_Legal>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Detalle_de_Solicitud_Representante_Legal.Detalle_de_Solicitud_Representante_Legal>(false, null);
            }
        }

        public ApiResponse<Detalle_de_Solicitud_Representante_LegalPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Detalle_de_Solicitud_Representante_Legal.Detalle_de_Solicitud_Representante_LegalPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Detalle_de_Solicitud_Representante_Legal.Clave='" + Key.ToString() + "'"
                        + "&Order=Detalle_de_Solicitud_Representante_Legal.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Detalle_de_Solicitud_Representante_Legal.Detalle_de_Solicitud_Representante_LegalPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Detalle_de_Solicitud_Representante_Legal.Detalle_de_Solicitud_Representante_LegalPagingModel>(false, new Detalle_de_Solicitud_Representante_LegalPagingModel() { Detalle_de_Solicitud_Representante_Legals = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Detalle_de_Solicitud_Representante_LegalInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Detalle_de_Solicitud_Representante_Legal.Detalle_de_Solicitud_Representante_Legal entity, Core.Domain.User.GlobalData Detalle_de_Solicitud_Representante_LegalInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Detalle_de_Solicitud_Representante_Legal.Detalle_de_Solicitud_Representante_Legal entity, Core.Domain.User.GlobalData Detalle_de_Solicitud_Representante_LegalInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Detalle_de_Solicitud_Representante_Legal.Detalle_de_Solicitud_Representante_Legal>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Detalle_de_Solicitud_Representante_Legal.Detalle_de_Solicitud_Representante_Legal>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Detalle_de_Solicitud_Representante_Legal.Detalle_de_Solicitud_Representante_Legal>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Detalle_de_Solicitud_Representante_LegalPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Detalle_de_Solicitud_Representante_Legal.Detalle_de_Solicitud_Representante_LegalPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Detalle_de_Solicitud_Representante_Legal.Detalle_de_Solicitud_Representante_LegalPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Detalle_de_Solicitud_Representante_Legal.Detalle_de_Solicitud_Representante_LegalPagingModel>(false, new Detalle_de_Solicitud_Representante_LegalPagingModel() { Detalle_de_Solicitud_Representante_Legals = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Detalle_de_Solicitud_Representante_Legal.Detalle_de_Solicitud_Representante_Legal>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Detalle_de_Solicitud_Representante_LegalGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Detalle_de_Solicitud_Representante_Legal_Datos_Generales entity)
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

        public ApiResponse<Detalle_de_Solicitud_Representante_Legal_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Detalle_de_Solicitud_Representante_Legal.Detalle_de_Solicitud_Representante_Legal_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Detalle_de_Solicitud_Representante_Legal.Detalle_de_Solicitud_Representante_Legal_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Detalle_de_Solicitud_Representante_Legal.Detalle_de_Solicitud_Representante_Legal_Datos_Generales>(false, null);
            }
        }


    }
}

