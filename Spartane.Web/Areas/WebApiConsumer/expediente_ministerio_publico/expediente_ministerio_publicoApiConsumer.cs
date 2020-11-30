using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.expediente_ministerio_publico;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.expediente_ministerio_publico
{
    public class expediente_ministerio_publicoApiConsumer : BaseApiConsumer,Iexpediente_ministerio_publicoApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public expediente_ministerio_publicoApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/expediente_ministerio_publico";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico>(false, null);
            }
        }

        public ApiResponse<expediente_ministerio_publicoPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publicoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=expediente_ministerio_publico.clave='" + Key.ToString() + "'"
                        + "&Order=expediente_ministerio_publico.clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.expediente_ministerio_publico.expediente_ministerio_publicoPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.expediente_ministerio_publico.expediente_ministerio_publicoPagingModel>(false, new expediente_ministerio_publicoPagingModel() { expediente_ministerio_publicos = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData expediente_ministerio_publicoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico entity, Core.Domain.User.GlobalData expediente_ministerio_publicoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico entity, Core.Domain.User.GlobalData expediente_ministerio_publicoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<expediente_ministerio_publicoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publicoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.expediente_ministerio_publico.expediente_ministerio_publicoPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.expediente_ministerio_publico.expediente_ministerio_publicoPagingModel>(false, new expediente_ministerio_publicoPagingModel() { expediente_ministerio_publicos = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/expediente_ministerio_publicoGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_del_Caso(expediente_ministerio_publico_Datos_del_Caso entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Datos_del_Caso",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<expediente_ministerio_publico_Datos_del_Caso> Get_Datos_del_Caso(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico_Datos_del_Caso>(baseApi, ApiControllerUrl + "/Get_Datos_del_Caso?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico_Datos_del_Caso>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico_Datos_del_Caso>(false, null);
            }
        }

public ApiResponse<int> Update_Hechos(expediente_ministerio_publico_Hechos entity)
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

        public ApiResponse<expediente_ministerio_publico_Hechos> Get_Hechos(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico_Hechos>(baseApi, ApiControllerUrl + "/Get_Hechos?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico_Hechos>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico_Hechos>(false, null);
            }
        }

public ApiResponse<int> Update_Canalizar(expediente_ministerio_publico_Canalizar entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Canalizar",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<expediente_ministerio_publico_Canalizar> Get_Canalizar(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico_Canalizar>(baseApi, ApiControllerUrl + "/Get_Canalizar?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico_Canalizar>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico_Canalizar>(false, null);
            }
        }

public ApiResponse<int> Update_Datos_del_Acuerdo(expediente_ministerio_publico_Datos_del_Acuerdo entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Datos_del_Acuerdo",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<expediente_ministerio_publico_Datos_del_Acuerdo> Get_Datos_del_Acuerdo(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico_Datos_del_Acuerdo>(baseApi, ApiControllerUrl + "/Get_Datos_del_Acuerdo?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico_Datos_del_Acuerdo>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico_Datos_del_Acuerdo>(false, null);
            }
        }

public ApiResponse<int> Update_Cierre_de_Expediente(expediente_ministerio_publico_Cierre_de_Expediente entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Cierre_de_Expediente",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<expediente_ministerio_publico_Cierre_de_Expediente> Get_Cierre_de_Expediente(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico_Cierre_de_Expediente>(baseApi, ApiControllerUrl + "/Get_Cierre_de_Expediente?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico_Cierre_de_Expediente>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.expediente_ministerio_publico.expediente_ministerio_publico_Cierre_de_Expediente>(false, null);
            }
        }


    }
}

