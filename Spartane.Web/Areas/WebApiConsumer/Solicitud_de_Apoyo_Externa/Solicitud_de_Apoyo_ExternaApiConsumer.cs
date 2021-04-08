using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Solicitud_de_Apoyo_Externa;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Solicitud_de_Apoyo_Externa
{
    public class Solicitud_de_Apoyo_ExternaApiConsumer : BaseApiConsumer,ISolicitud_de_Apoyo_ExternaApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Solicitud_de_Apoyo_ExternaApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Solicitud_de_Apoyo_Externa";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa>(false, null);
            }
        }

        public ApiResponse<Solicitud_de_Apoyo_ExternaPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_ExternaPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Solicitud_de_Apoyo_Externa.Folio='" + Key.ToString() + "'"
                        + "&Order=Solicitud_de_Apoyo_Externa.Folio ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_ExternaPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_ExternaPagingModel>(false, new Solicitud_de_Apoyo_ExternaPagingModel() { Solicitud_de_Apoyo_Externas = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Solicitud_de_Apoyo_ExternaInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa entity, Core.Domain.User.GlobalData Solicitud_de_Apoyo_ExternaInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa entity, Core.Domain.User.GlobalData Solicitud_de_Apoyo_ExternaInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Solicitud_de_Apoyo_ExternaPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_ExternaPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_ExternaPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_ExternaPagingModel>(false, new Solicitud_de_Apoyo_ExternaPagingModel() { Solicitud_de_Apoyo_Externas = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Solicitud_de_Apoyo_ExternaGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Solicitud_de_Apoyo_Externa_Datos_Generales entity)
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

        public ApiResponse<Solicitud_de_Apoyo_Externa_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa_Datos_Generales>(false, null);
            }
        }

public ApiResponse<int> Update_Contestacion(Solicitud_de_Apoyo_Externa_Contestacion entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Contestacion",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Solicitud_de_Apoyo_Externa_Contestacion> Get_Contestacion(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa_Contestacion>(baseApi, ApiControllerUrl + "/Get_Contestacion?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa_Contestacion>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Solicitud_de_Apoyo_Externa.Solicitud_de_Apoyo_Externa_Contestacion>(false, null);
            }
        }


    }
}

