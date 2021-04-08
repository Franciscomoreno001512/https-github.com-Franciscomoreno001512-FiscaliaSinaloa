using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Area_envia_Cumplimiento;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Area_envia_Cumplimiento
{
    public class Area_envia_CumplimientoApiConsumer : BaseApiConsumer,IArea_envia_CumplimientoApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Area_envia_CumplimientoApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Area_envia_Cumplimiento";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento>(false, null);
            }
        }

        public ApiResponse<Area_envia_CumplimientoPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Area_envia_Cumplimiento.Area_envia_CumplimientoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Area_envia_Cumplimiento.Clave='" + Key.ToString() + "'"
                        + "&Order=Area_envia_Cumplimiento.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Area_envia_Cumplimiento.Area_envia_CumplimientoPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Area_envia_Cumplimiento.Area_envia_CumplimientoPagingModel>(false, new Area_envia_CumplimientoPagingModel() { Area_envia_Cumplimientos = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Area_envia_CumplimientoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento entity, Core.Domain.User.GlobalData Area_envia_CumplimientoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento entity, Core.Domain.User.GlobalData Area_envia_CumplimientoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Area_envia_CumplimientoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Area_envia_Cumplimiento.Area_envia_CumplimientoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Area_envia_Cumplimiento.Area_envia_CumplimientoPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Area_envia_Cumplimiento.Area_envia_CumplimientoPagingModel>(false, new Area_envia_CumplimientoPagingModel() { Area_envia_Cumplimientos = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Area_envia_CumplimientoGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Area_envia_Cumplimiento_Datos_Generales entity)
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

        public ApiResponse<Area_envia_Cumplimiento_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento_Datos_Generales>(false, null);
            }
        }


    }
}

