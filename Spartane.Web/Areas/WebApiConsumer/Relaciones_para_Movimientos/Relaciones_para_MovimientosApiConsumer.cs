using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Relaciones_para_Movimientos;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Relaciones_para_Movimientos
{
    public class Relaciones_para_MovimientosApiConsumer : BaseApiConsumer,IRelaciones_para_MovimientosApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Relaciones_para_MovimientosApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Relaciones_para_Movimientos";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Relaciones_para_Movimientos.Relaciones_para_Movimientos>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Relaciones_para_Movimientos.Relaciones_para_Movimientos>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Relaciones_para_Movimientos.Relaciones_para_Movimientos>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Relaciones_para_Movimientos.Relaciones_para_Movimientos>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Relaciones_para_Movimientos.Relaciones_para_Movimientos>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Relaciones_para_Movimientos.Relaciones_para_Movimientos>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Relaciones_para_Movimientos.Relaciones_para_Movimientos>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Relaciones_para_Movimientos.Relaciones_para_Movimientos>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Relaciones_para_Movimientos.Relaciones_para_Movimientos> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Relaciones_para_Movimientos.Relaciones_para_Movimientos>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Relaciones_para_Movimientos.Relaciones_para_Movimientos>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Relaciones_para_Movimientos.Relaciones_para_Movimientos>(false, null);
            }
        }

        public ApiResponse<Relaciones_para_MovimientosPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Relaciones_para_Movimientos.Relaciones_para_MovimientosPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Relaciones_para_Movimientos.ObjectId='" + Key.ToString() + "'"
                        + "&Order=Relaciones_para_Movimientos.ObjectId ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Relaciones_para_Movimientos.Relaciones_para_MovimientosPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Relaciones_para_Movimientos.Relaciones_para_MovimientosPagingModel>(false, new Relaciones_para_MovimientosPagingModel() { Relaciones_para_Movimientoss = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Relaciones_para_MovimientosInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Relaciones_para_Movimientos.Relaciones_para_Movimientos entity, Core.Domain.User.GlobalData Relaciones_para_MovimientosInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Relaciones_para_Movimientos.Relaciones_para_Movimientos entity, Core.Domain.User.GlobalData Relaciones_para_MovimientosInformation, DataLayerFieldsBitacora DataReference)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put?Id=" + entity.ObjectId,
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<IList<Core.Domain.Relaciones_para_Movimientos.Relaciones_para_Movimientos>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Relaciones_para_Movimientos.Relaciones_para_Movimientos>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Relaciones_para_Movimientos.Relaciones_para_Movimientos>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Relaciones_para_MovimientosPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Relaciones_para_Movimientos.Relaciones_para_MovimientosPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Relaciones_para_Movimientos.Relaciones_para_MovimientosPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Relaciones_para_Movimientos.Relaciones_para_MovimientosPagingModel>(false, new Relaciones_para_MovimientosPagingModel() { Relaciones_para_Movimientoss = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Relaciones_para_Movimientos.Relaciones_para_Movimientos>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Relaciones_para_MovimientosGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Relaciones_para_Movimientos_Datos_Generales entity)
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

        public ApiResponse<Relaciones_para_Movimientos_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Relaciones_para_Movimientos.Relaciones_para_Movimientos_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Relaciones_para_Movimientos.Relaciones_para_Movimientos_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Relaciones_para_Movimientos.Relaciones_para_Movimientos_Datos_Generales>(false, null);
            }
        }


    }
}

