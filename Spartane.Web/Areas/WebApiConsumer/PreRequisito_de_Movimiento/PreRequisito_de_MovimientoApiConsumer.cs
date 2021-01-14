using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.PreRequisito_de_Movimiento;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.PreRequisito_de_Movimiento
{
    public class PreRequisito_de_MovimientoApiConsumer : BaseApiConsumer,IPreRequisito_de_MovimientoApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public PreRequisito_de_MovimientoApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/PreRequisito_de_Movimiento";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.PreRequisito_de_Movimiento.PreRequisito_de_Movimiento>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.PreRequisito_de_Movimiento.PreRequisito_de_Movimiento>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.PreRequisito_de_Movimiento.PreRequisito_de_Movimiento>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.PreRequisito_de_Movimiento.PreRequisito_de_Movimiento>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.PreRequisito_de_Movimiento.PreRequisito_de_Movimiento>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.PreRequisito_de_Movimiento.PreRequisito_de_Movimiento>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.PreRequisito_de_Movimiento.PreRequisito_de_Movimiento>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.PreRequisito_de_Movimiento.PreRequisito_de_Movimiento>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.PreRequisito_de_Movimiento.PreRequisito_de_Movimiento> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.PreRequisito_de_Movimiento.PreRequisito_de_Movimiento>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.PreRequisito_de_Movimiento.PreRequisito_de_Movimiento>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.PreRequisito_de_Movimiento.PreRequisito_de_Movimiento>(false, null);
            }
        }

        public ApiResponse<PreRequisito_de_MovimientoPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.PreRequisito_de_Movimiento.PreRequisito_de_MovimientoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=PreRequisito_de_Movimiento.Clave='" + Key.ToString() + "'"
                        + "&Order=PreRequisito_de_Movimiento.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.PreRequisito_de_Movimiento.PreRequisito_de_MovimientoPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.PreRequisito_de_Movimiento.PreRequisito_de_MovimientoPagingModel>(false, new PreRequisito_de_MovimientoPagingModel() { PreRequisito_de_Movimientos = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData PreRequisito_de_MovimientoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.PreRequisito_de_Movimiento.PreRequisito_de_Movimiento entity, Core.Domain.User.GlobalData PreRequisito_de_MovimientoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.PreRequisito_de_Movimiento.PreRequisito_de_Movimiento entity, Core.Domain.User.GlobalData PreRequisito_de_MovimientoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.PreRequisito_de_Movimiento.PreRequisito_de_Movimiento>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.PreRequisito_de_Movimiento.PreRequisito_de_Movimiento>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.PreRequisito_de_Movimiento.PreRequisito_de_Movimiento>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<PreRequisito_de_MovimientoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.PreRequisito_de_Movimiento.PreRequisito_de_MovimientoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.PreRequisito_de_Movimiento.PreRequisito_de_MovimientoPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.PreRequisito_de_Movimiento.PreRequisito_de_MovimientoPagingModel>(false, new PreRequisito_de_MovimientoPagingModel() { PreRequisito_de_Movimientos = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.PreRequisito_de_Movimiento.PreRequisito_de_Movimiento>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/PreRequisito_de_MovimientoGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(PreRequisito_de_Movimiento_Datos_Generales entity)
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

        public ApiResponse<PreRequisito_de_Movimiento_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.PreRequisito_de_Movimiento.PreRequisito_de_Movimiento_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.PreRequisito_de_Movimiento.PreRequisito_de_Movimiento_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.PreRequisito_de_Movimiento.PreRequisito_de_Movimiento_Datos_Generales>(false, null);
            }
        }


    }
}

