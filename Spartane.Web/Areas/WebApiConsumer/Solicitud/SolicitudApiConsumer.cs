using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Solicitud;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Solicitud
{
    public class SolicitudApiConsumer : BaseApiConsumer,ISolicitudApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public SolicitudApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Solicitud";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Solicitud.Solicitud>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Solicitud.Solicitud>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Solicitud.Solicitud>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Solicitud.Solicitud>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Solicitud.Solicitud>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Solicitud.Solicitud>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Solicitud.Solicitud>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Solicitud.Solicitud>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Solicitud.Solicitud> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Solicitud.Solicitud>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Solicitud.Solicitud>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Solicitud.Solicitud>(false, null);
            }
        }

        public ApiResponse<SolicitudPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Solicitud.SolicitudPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Solicitud.Clave='" + Key.ToString() + "'"
                        + "&Order=Solicitud.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Solicitud.SolicitudPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Solicitud.SolicitudPagingModel>(false, new SolicitudPagingModel() { Solicituds = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData SolicitudInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Solicitud.Solicitud entity, Core.Domain.User.GlobalData SolicitudInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Solicitud.Solicitud entity, Core.Domain.User.GlobalData SolicitudInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Solicitud.Solicitud>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Solicitud.Solicitud>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Solicitud.Solicitud>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<SolicitudPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Solicitud.SolicitudPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Solicitud.SolicitudPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Solicitud.SolicitudPagingModel>(false, new SolicitudPagingModel() { Solicituds = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Solicitud.Solicitud>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/SolicitudGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Solicitud(Solicitud_Solicitud entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Solicitud",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Solicitud_Solicitud> Get_Solicitud(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Solicitud.Solicitud_Solicitud>(baseApi, ApiControllerUrl + "/Get_Solicitud?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Solicitud.Solicitud_Solicitud>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Solicitud.Solicitud_Solicitud>(false, null);
            }
        }

public ApiResponse<int> Update_Control(Solicitud_Control entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Control",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Solicitud_Control> Get_Control(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Solicitud.Solicitud_Control>(baseApi, ApiControllerUrl + "/Get_Control?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Solicitud.Solicitud_Control>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Solicitud.Solicitud_Control>(false, null);
            }
        }

public ApiResponse<int> Update_Hechos(Solicitud_Hechos entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Hechos",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Solicitud_Hechos> Get_Hechos(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Solicitud.Solicitud_Hechos>(baseApi, ApiControllerUrl + "/Get_Hechos?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Solicitud.Solicitud_Hechos>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Solicitud.Solicitud_Hechos>(false, null);
            }
        }

public ApiResponse<int> Update_Asignacion(Solicitud_Asignacion entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Asignacion",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Solicitud_Asignacion> Get_Asignacion(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Solicitud.Solicitud_Asignacion>(baseApi, ApiControllerUrl + "/Get_Asignacion?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Solicitud.Solicitud_Asignacion>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Solicitud.Solicitud_Asignacion>(false, null);
            }
        }

public ApiResponse<int> Update_Bitacora_de_Coincidencias(Solicitud_Bitacora_de_Coincidencias entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Bitacora_de_Coincidencias",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Solicitud_Bitacora_de_Coincidencias> Get_Bitacora_de_Coincidencias(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Solicitud.Solicitud_Bitacora_de_Coincidencias>(baseApi, ApiControllerUrl + "/Get_Bitacora_de_Coincidencias?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Solicitud.Solicitud_Bitacora_de_Coincidencias>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Solicitud.Solicitud_Bitacora_de_Coincidencias>(false, null);
            }
        }

public ApiResponse<int> Update_Cierre(Solicitud_Cierre entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Cierre",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Solicitud_Cierre> Get_Cierre(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Solicitud.Solicitud_Cierre>(baseApi, ApiControllerUrl + "/Get_Cierre?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Solicitud.Solicitud_Cierre>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Solicitud.Solicitud_Cierre>(false, null);
            }
        }

public ApiResponse<int> Update_Historial_de_Movimientos(Solicitud_Historial_de_Movimientos entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Historial_de_Movimientos",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Solicitud_Historial_de_Movimientos> Get_Historial_de_Movimientos(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Solicitud.Solicitud_Historial_de_Movimientos>(baseApi, ApiControllerUrl + "/Get_Historial_de_Movimientos?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Solicitud.Solicitud_Historial_de_Movimientos>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Solicitud.Solicitud_Historial_de_Movimientos>(false, null);
            }
        }


    }
}

