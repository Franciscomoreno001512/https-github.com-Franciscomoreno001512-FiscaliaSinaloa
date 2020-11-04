using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Orientador;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Orientador
{
    public class OrientadorApiConsumer : BaseApiConsumer,IOrientadorApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public OrientadorApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Orientador";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Orientador.Orientador>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Orientador.Orientador>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Orientador.Orientador>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Orientador.Orientador>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Orientador.Orientador>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Orientador.Orientador>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Orientador.Orientador>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Orientador.Orientador>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Orientador.Orientador> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Orientador.Orientador>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Orientador.Orientador>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Orientador.Orientador>(false, null);
            }
        }

        public ApiResponse<OrientadorPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Orientador.OrientadorPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Orientador.Clave='" + Key.ToString() + "'"
                        + "&Order=Orientador.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Orientador.OrientadorPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Orientador.OrientadorPagingModel>(false, new OrientadorPagingModel() { Orientadors = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData OrientadorInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Orientador.Orientador entity, Core.Domain.User.GlobalData OrientadorInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Orientador.Orientador entity, Core.Domain.User.GlobalData OrientadorInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Orientador.Orientador>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Orientador.Orientador>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Orientador.Orientador>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<OrientadorPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Orientador.OrientadorPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Orientador.OrientadorPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Orientador.OrientadorPagingModel>(false, new OrientadorPagingModel() { Orientadors = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Orientador.Orientador>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/OrientadorGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_de_Servicios_de_Apoyo(Orientador_Datos_de_Servicios_de_Apoyo entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Datos_de_Servicios_de_Apoyo",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Orientador_Datos_de_Servicios_de_Apoyo> Get_Datos_de_Servicios_de_Apoyo(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Orientador.Orientador_Datos_de_Servicios_de_Apoyo>(baseApi, ApiControllerUrl + "/Get_Datos_de_Servicios_de_Apoyo?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Orientador.Orientador_Datos_de_Servicios_de_Apoyo>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Orientador.Orientador_Datos_de_Servicios_de_Apoyo>(false, null);
            }
        }

public ApiResponse<int> Update_Datos_del_Imputado(Orientador_Datos_del_Imputado entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Datos_del_Imputado",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Orientador_Datos_del_Imputado> Get_Datos_del_Imputado(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Orientador.Orientador_Datos_del_Imputado>(baseApi, ApiControllerUrl + "/Get_Datos_del_Imputado?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Orientador.Orientador_Datos_del_Imputado>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Orientador.Orientador_Datos_del_Imputado>(false, null);
            }
        }

public ApiResponse<int> Update_Datos_de_los_Hechos(Orientador_Datos_de_los_Hechos entity)
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

        public ApiResponse<Orientador_Datos_de_los_Hechos> Get_Datos_de_los_Hechos(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Orientador.Orientador_Datos_de_los_Hechos>(baseApi, ApiControllerUrl + "/Get_Datos_de_los_Hechos?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Orientador.Orientador_Datos_de_los_Hechos>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Orientador.Orientador_Datos_de_los_Hechos>(false, null);
            }
        }

public ApiResponse<int> Update_Datos_del_Delito(Orientador_Datos_del_Delito entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Datos_del_Delito",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Orientador_Datos_del_Delito> Get_Datos_del_Delito(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Orientador.Orientador_Datos_del_Delito>(baseApi, ApiControllerUrl + "/Get_Datos_del_Delito?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Orientador.Orientador_Datos_del_Delito>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Orientador.Orientador_Datos_del_Delito>(false, null);
            }
        }

public ApiResponse<int> Update_Datos_de_Robo_de_Vehiculo(Orientador_Datos_de_Robo_de_Vehiculo entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Datos_de_Robo_de_Vehiculo",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Orientador_Datos_de_Robo_de_Vehiculo> Get_Datos_de_Robo_de_Vehiculo(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Orientador.Orientador_Datos_de_Robo_de_Vehiculo>(baseApi, ApiControllerUrl + "/Get_Datos_de_Robo_de_Vehiculo?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Orientador.Orientador_Datos_de_Robo_de_Vehiculo>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Orientador.Orientador_Datos_de_Robo_de_Vehiculo>(false, null);
            }
        }

public ApiResponse<int> Update_Datos_de_Levantamiento_de_Cadaver(Orientador_Datos_de_Levantamiento_de_Cadaver entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Datos_de_Levantamiento_de_Cadaver",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Orientador_Datos_de_Levantamiento_de_Cadaver> Get_Datos_de_Levantamiento_de_Cadaver(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Orientador.Orientador_Datos_de_Levantamiento_de_Cadaver>(baseApi, ApiControllerUrl + "/Get_Datos_de_Levantamiento_de_Cadaver?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Orientador.Orientador_Datos_de_Levantamiento_de_Cadaver>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Orientador.Orientador_Datos_de_Levantamiento_de_Cadaver>(false, null);
            }
        }

public ApiResponse<int> Update_Imputado(Orientador_Imputado entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Imputado",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Orientador_Imputado> Get_Imputado(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Orientador.Orientador_Imputado>(baseApi, ApiControllerUrl + "/Get_Imputado?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Orientador.Orientador_Imputado>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Orientador.Orientador_Imputado>(false, null);
            }
        }


    }
}

