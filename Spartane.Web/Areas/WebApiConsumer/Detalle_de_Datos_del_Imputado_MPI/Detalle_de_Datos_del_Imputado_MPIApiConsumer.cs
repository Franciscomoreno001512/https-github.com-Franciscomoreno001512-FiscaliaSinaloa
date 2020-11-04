using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_MPI;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Detalle_de_Datos_del_Imputado_MPI
{
    public class Detalle_de_Datos_del_Imputado_MPIApiConsumer : BaseApiConsumer,IDetalle_de_Datos_del_Imputado_MPIApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Detalle_de_Datos_del_Imputado_MPIApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Detalle_de_Datos_del_Imputado_MPI";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI>(false, null);
            }
        }

        public ApiResponse<Detalle_de_Datos_del_Imputado_MPIPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPIPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Detalle_de_Datos_del_Imputado_MPI.Clave='" + Key.ToString() + "'"
                        + "&Order=Detalle_de_Datos_del_Imputado_MPI.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPIPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPIPagingModel>(false, new Detalle_de_Datos_del_Imputado_MPIPagingModel() { Detalle_de_Datos_del_Imputado_MPIs = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Detalle_de_Datos_del_Imputado_MPIInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI entity, Core.Domain.User.GlobalData Detalle_de_Datos_del_Imputado_MPIInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI entity, Core.Domain.User.GlobalData Detalle_de_Datos_del_Imputado_MPIInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Detalle_de_Datos_del_Imputado_MPIPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPIPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPIPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPIPagingModel>(false, new Detalle_de_Datos_del_Imputado_MPIPagingModel() { Detalle_de_Datos_del_Imputado_MPIs = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Detalle_de_Datos_del_Imputado_MPIGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Detalle_de_Datos_del_Imputado_MPI_Datos_Generales entity)
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

        public ApiResponse<Detalle_de_Datos_del_Imputado_MPI_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI_Datos_Generales>(false, null);
            }
        }

public ApiResponse<int> Update__Datos_de_Media_Filiacion(Detalle_de_Datos_del_Imputado_MPI__Datos_de_Media_Filiacion entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put__Datos_de_Media_Filiacion",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Detalle_de_Datos_del_Imputado_MPI__Datos_de_Media_Filiacion> Get__Datos_de_Media_Filiacion(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI__Datos_de_Media_Filiacion>(baseApi, ApiControllerUrl + "/Get__Datos_de_Media_Filiacion?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI__Datos_de_Media_Filiacion>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI__Datos_de_Media_Filiacion>(false, null);
            }
        }

public ApiResponse<int> Update_Control_de_Tiempos(Detalle_de_Datos_del_Imputado_MPI_Control_de_Tiempos entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Control_de_Tiempos",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Detalle_de_Datos_del_Imputado_MPI_Control_de_Tiempos> Get_Control_de_Tiempos(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI_Control_de_Tiempos>(baseApi, ApiControllerUrl + "/Get_Control_de_Tiempos?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI_Control_de_Tiempos>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI_Control_de_Tiempos>(false, null);
            }
        }

public ApiResponse<int> Update_Datos_de_los_Hechos(Detalle_de_Datos_del_Imputado_MPI_Datos_de_los_Hechos entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Datos_de_los_Hechos",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Detalle_de_Datos_del_Imputado_MPI_Datos_de_los_Hechos> Get_Datos_de_los_Hechos(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI_Datos_de_los_Hechos>(baseApi, ApiControllerUrl + "/Get_Datos_de_los_Hechos?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI_Datos_de_los_Hechos>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI_Datos_de_los_Hechos>(false, null);
            }
        }

public ApiResponse<int> Update_Datos_del_Abogado(Detalle_de_Datos_del_Imputado_MPI_Datos_del_Abogado entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Datos_del_Abogado",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Detalle_de_Datos_del_Imputado_MPI_Datos_del_Abogado> Get_Datos_del_Abogado(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI_Datos_del_Abogado>(baseApi, ApiControllerUrl + "/Get_Datos_del_Abogado?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI_Datos_del_Abogado>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI_Datos_del_Abogado>(false, null);
            }
        }

public ApiResponse<int> Update_Datos_del_Tutor(Detalle_de_Datos_del_Imputado_MPI_Datos_del_Tutor entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Datos_del_Tutor",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Detalle_de_Datos_del_Imputado_MPI_Datos_del_Tutor> Get_Datos_del_Tutor(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI_Datos_del_Tutor>(baseApi, ApiControllerUrl + "/Get_Datos_del_Tutor?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI_Datos_del_Tutor>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI_Datos_del_Tutor>(false, null);
            }
        }

public ApiResponse<int> Update_Sentencias(Detalle_de_Datos_del_Imputado_MPI_Sentencias entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Sentencias",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Detalle_de_Datos_del_Imputado_MPI_Sentencias> Get_Sentencias(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI_Sentencias>(baseApi, ApiControllerUrl + "/Get_Sentencias?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI_Sentencias>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Detalle_de_Datos_del_Imputado_MPI.Detalle_de_Datos_del_Imputado_MPI_Sentencias>(false, null);
            }
        }


    }
}

