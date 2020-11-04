using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Detalle_de_Asignacion_de_Especialista
{
    public class Detalle_de_Asignacion_de_EspecialistaApiConsumer : BaseApiConsumer,IDetalle_de_Asignacion_de_EspecialistaApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Detalle_de_Asignacion_de_EspecialistaApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Detalle_de_Asignacion_de_Especialista";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista> GetByKey(short Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista>(false, null);
            }
        }

        public ApiResponse<Detalle_de_Asignacion_de_EspecialistaPagingModel> GetByKeyComplete(short Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_EspecialistaPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Detalle_de_Asignacion_de_Especialista.Clave='" + Key.ToString() + "'"
                        + "&Order=Detalle_de_Asignacion_de_Especialista.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_EspecialistaPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_EspecialistaPagingModel>(false, new Detalle_de_Asignacion_de_EspecialistaPagingModel() { Detalle_de_Asignacion_de_Especialistas = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(short Key, Core.Domain.User.GlobalData Detalle_de_Asignacion_de_EspecialistaInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<short> Insert(Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista entity, Core.Domain.User.GlobalData Detalle_de_Asignacion_de_EspecialistaInformation, DataLayerFieldsBitacora DataReference)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<short>(baseApi, ApiControllerUrl + "/Post",
                      Method.POST, ApiHeader, entity);

                return new ApiResponse<short>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<short>(false, -1 );
            }
        }

        public ApiResponse<short> Update(Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista entity, Core.Domain.User.GlobalData Detalle_de_Asignacion_de_EspecialistaInformation, DataLayerFieldsBitacora DataReference)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<short>(baseApi, ApiControllerUrl + "/Put?Id=" + entity.Clave,
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<short>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<short>(false, -1 );
            }
        }

        public ApiResponse<IList<Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Detalle_de_Asignacion_de_EspecialistaPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_EspecialistaPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_EspecialistaPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_EspecialistaPagingModel>(false, new Detalle_de_Asignacion_de_EspecialistaPagingModel() { Detalle_de_Asignacion_de_Especialistas = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<short> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<short>(baseApi, ApiControllerUrl + "/Detalle_de_Asignacion_de_EspecialistaGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<short>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<short>(false, -1 );
            }
        }
		
public ApiResponse<short> Update_Datos_Generales(Detalle_de_Asignacion_de_Especialista_Datos_Generales entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<short>(baseApi, ApiControllerUrl + "/Put_Datos_Generales",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<short>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<short>(false, -1 );
            }
        }

        public ApiResponse<Detalle_de_Asignacion_de_Especialista_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista_Datos_Generales>(false, null);
            }
        }


    }
}

