using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Detalle_de_Solicitudes_de_Invitaciones;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Detalle_de_Solicitudes_de_Invitaciones
{
    public class Detalle_de_Solicitudes_de_InvitacionesApiConsumer : BaseApiConsumer,IDetalle_de_Solicitudes_de_InvitacionesApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Detalle_de_Solicitudes_de_InvitacionesApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Detalle_de_Solicitudes_de_Invitaciones";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones>(false, null);
            }
        }

        public ApiResponse<Detalle_de_Solicitudes_de_InvitacionesPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_InvitacionesPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Detalle_de_Solicitudes_de_Invitaciones.Clave='" + Key.ToString() + "'"
                        + "&Order=Detalle_de_Solicitudes_de_Invitaciones.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_InvitacionesPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_InvitacionesPagingModel>(false, new Detalle_de_Solicitudes_de_InvitacionesPagingModel() { Detalle_de_Solicitudes_de_Invitacioness = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Detalle_de_Solicitudes_de_InvitacionesInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones entity, Core.Domain.User.GlobalData Detalle_de_Solicitudes_de_InvitacionesInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones entity, Core.Domain.User.GlobalData Detalle_de_Solicitudes_de_InvitacionesInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Detalle_de_Solicitudes_de_InvitacionesPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_InvitacionesPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_InvitacionesPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_InvitacionesPagingModel>(false, new Detalle_de_Solicitudes_de_InvitacionesPagingModel() { Detalle_de_Solicitudes_de_Invitacioness = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Detalle_de_Solicitudes_de_InvitacionesGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Detalle_de_Solicitudes_de_Invitaciones_Datos_Generales entity)
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

        public ApiResponse<Detalle_de_Solicitudes_de_Invitaciones_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones_Datos_Generales>(false, null);
            }
        }

public ApiResponse<int> Update_Resultado_de_Notificacion(Detalle_de_Solicitudes_de_Invitaciones_Resultado_de_Notificacion entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Resultado_de_Notificacion",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Detalle_de_Solicitudes_de_Invitaciones_Resultado_de_Notificacion> Get_Resultado_de_Notificacion(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones_Resultado_de_Notificacion>(baseApi, ApiControllerUrl + "/Get_Resultado_de_Notificacion?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones_Resultado_de_Notificacion>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones_Resultado_de_Notificacion>(false, null);
            }
        }


    }
}

