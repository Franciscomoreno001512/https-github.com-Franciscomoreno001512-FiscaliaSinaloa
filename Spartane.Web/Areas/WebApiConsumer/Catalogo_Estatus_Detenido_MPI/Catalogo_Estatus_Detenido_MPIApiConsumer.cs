using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Catalogo_Estatus_Detenido_MPI;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Catalogo_Estatus_Detenido_MPI
{
    public class Catalogo_Estatus_Detenido_MPIApiConsumer : BaseApiConsumer,ICatalogo_Estatus_Detenido_MPIApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Catalogo_Estatus_Detenido_MPIApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Catalogo_Estatus_Detenido_MPI";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Catalogo_Estatus_Detenido_MPI.Catalogo_Estatus_Detenido_MPI>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Catalogo_Estatus_Detenido_MPI.Catalogo_Estatus_Detenido_MPI>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Catalogo_Estatus_Detenido_MPI.Catalogo_Estatus_Detenido_MPI>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Catalogo_Estatus_Detenido_MPI.Catalogo_Estatus_Detenido_MPI>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Catalogo_Estatus_Detenido_MPI.Catalogo_Estatus_Detenido_MPI>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Catalogo_Estatus_Detenido_MPI.Catalogo_Estatus_Detenido_MPI>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Catalogo_Estatus_Detenido_MPI.Catalogo_Estatus_Detenido_MPI>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Catalogo_Estatus_Detenido_MPI.Catalogo_Estatus_Detenido_MPI>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Catalogo_Estatus_Detenido_MPI.Catalogo_Estatus_Detenido_MPI> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Catalogo_Estatus_Detenido_MPI.Catalogo_Estatus_Detenido_MPI>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Catalogo_Estatus_Detenido_MPI.Catalogo_Estatus_Detenido_MPI>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Catalogo_Estatus_Detenido_MPI.Catalogo_Estatus_Detenido_MPI>(false, null);
            }
        }

        public ApiResponse<Catalogo_Estatus_Detenido_MPIPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Catalogo_Estatus_Detenido_MPI.Catalogo_Estatus_Detenido_MPIPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Catalogo_Estatus_Detenido_MPI.Clave='" + Key.ToString() + "'"
                        + "&Order=Catalogo_Estatus_Detenido_MPI.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Catalogo_Estatus_Detenido_MPI.Catalogo_Estatus_Detenido_MPIPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Catalogo_Estatus_Detenido_MPI.Catalogo_Estatus_Detenido_MPIPagingModel>(false, new Catalogo_Estatus_Detenido_MPIPagingModel() { Catalogo_Estatus_Detenido_MPIs = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Catalogo_Estatus_Detenido_MPIInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Catalogo_Estatus_Detenido_MPI.Catalogo_Estatus_Detenido_MPI entity, Core.Domain.User.GlobalData Catalogo_Estatus_Detenido_MPIInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Catalogo_Estatus_Detenido_MPI.Catalogo_Estatus_Detenido_MPI entity, Core.Domain.User.GlobalData Catalogo_Estatus_Detenido_MPIInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Catalogo_Estatus_Detenido_MPI.Catalogo_Estatus_Detenido_MPI>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Catalogo_Estatus_Detenido_MPI.Catalogo_Estatus_Detenido_MPI>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Catalogo_Estatus_Detenido_MPI.Catalogo_Estatus_Detenido_MPI>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Catalogo_Estatus_Detenido_MPIPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Catalogo_Estatus_Detenido_MPI.Catalogo_Estatus_Detenido_MPIPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Catalogo_Estatus_Detenido_MPI.Catalogo_Estatus_Detenido_MPIPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Catalogo_Estatus_Detenido_MPI.Catalogo_Estatus_Detenido_MPIPagingModel>(false, new Catalogo_Estatus_Detenido_MPIPagingModel() { Catalogo_Estatus_Detenido_MPIs = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Catalogo_Estatus_Detenido_MPI.Catalogo_Estatus_Detenido_MPI>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Catalogo_Estatus_Detenido_MPIGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Catalogo_Estatus_Detenido_MPI_Datos_Generales entity)
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

        public ApiResponse<Catalogo_Estatus_Detenido_MPI_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Catalogo_Estatus_Detenido_MPI.Catalogo_Estatus_Detenido_MPI_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Catalogo_Estatus_Detenido_MPI.Catalogo_Estatus_Detenido_MPI_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Catalogo_Estatus_Detenido_MPI.Catalogo_Estatus_Detenido_MPI_Datos_Generales>(false, null);
            }
        }


    }
}

