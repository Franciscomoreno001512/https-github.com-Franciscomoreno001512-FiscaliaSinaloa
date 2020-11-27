using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.detalle_de_observaciones_mpi;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.detalle_de_observaciones_mpi
{
    public class detalle_de_observaciones_mpiApiConsumer : BaseApiConsumer,Idetalle_de_observaciones_mpiApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public detalle_de_observaciones_mpiApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/detalle_de_observaciones_mpi";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi>(false, null);
            }
        }

        public ApiResponse<detalle_de_observaciones_mpiPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpiPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=detalle_de_observaciones_mpi.clave='" + Key.ToString() + "'"
                        + "&Order=detalle_de_observaciones_mpi.clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpiPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpiPagingModel>(false, new detalle_de_observaciones_mpiPagingModel() { detalle_de_observaciones_mpis = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData detalle_de_observaciones_mpiInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi entity, Core.Domain.User.GlobalData detalle_de_observaciones_mpiInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi entity, Core.Domain.User.GlobalData detalle_de_observaciones_mpiInformation, DataLayerFieldsBitacora DataReference)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put?Id=" + entity.clave,
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<IList<Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<detalle_de_observaciones_mpiPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpiPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpiPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpiPagingModel>(false, new detalle_de_observaciones_mpiPagingModel() { detalle_de_observaciones_mpis = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/detalle_de_observaciones_mpiGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(detalle_de_observaciones_mpi_Datos_Generales entity)
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

        public ApiResponse<detalle_de_observaciones_mpi_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.detalle_de_observaciones_mpi.detalle_de_observaciones_mpi_Datos_Generales>(false, null);
            }
        }


    }
}

