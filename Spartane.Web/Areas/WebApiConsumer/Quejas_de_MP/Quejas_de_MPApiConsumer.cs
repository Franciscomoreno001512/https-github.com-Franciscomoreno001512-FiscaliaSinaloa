using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Quejas_de_MP;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Quejas_de_MP
{
    public class Quejas_de_MPApiConsumer : BaseApiConsumer,IQuejas_de_MPApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Quejas_de_MPApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Quejas_de_MP";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Quejas_de_MP.Quejas_de_MP>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Quejas_de_MP.Quejas_de_MP>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Quejas_de_MP.Quejas_de_MP>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Quejas_de_MP.Quejas_de_MP>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Quejas_de_MP.Quejas_de_MP>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Quejas_de_MP.Quejas_de_MP>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Quejas_de_MP.Quejas_de_MP>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Quejas_de_MP.Quejas_de_MP>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Quejas_de_MP.Quejas_de_MP> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Quejas_de_MP.Quejas_de_MP>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Quejas_de_MP.Quejas_de_MP>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Quejas_de_MP.Quejas_de_MP>(false, null);
            }
        }

        public ApiResponse<Quejas_de_MPPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Quejas_de_MP.Quejas_de_MPPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Quejas_de_MP.Clave='" + Key.ToString() + "'"
                        + "&Order=Quejas_de_MP.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Quejas_de_MP.Quejas_de_MPPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Quejas_de_MP.Quejas_de_MPPagingModel>(false, new Quejas_de_MPPagingModel() { Quejas_de_MPs = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Quejas_de_MPInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Quejas_de_MP.Quejas_de_MP entity, Core.Domain.User.GlobalData Quejas_de_MPInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Quejas_de_MP.Quejas_de_MP entity, Core.Domain.User.GlobalData Quejas_de_MPInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Quejas_de_MP.Quejas_de_MP>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Quejas_de_MP.Quejas_de_MP>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Quejas_de_MP.Quejas_de_MP>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Quejas_de_MPPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Quejas_de_MP.Quejas_de_MPPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Quejas_de_MP.Quejas_de_MPPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Quejas_de_MP.Quejas_de_MPPagingModel>(false, new Quejas_de_MPPagingModel() { Quejas_de_MPs = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Quejas_de_MP.Quejas_de_MP>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Quejas_de_MPGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Quejas_de_MP_Datos_Generales entity)
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

        public ApiResponse<Quejas_de_MP_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Quejas_de_MP.Quejas_de_MP_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Quejas_de_MP.Quejas_de_MP_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Quejas_de_MP.Quejas_de_MP_Datos_Generales>(false, null);
            }
        }

public ApiResponse<int> Update_Rasgos_Fisicos(Quejas_de_MP_Rasgos_Fisicos entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Rasgos_Fisicos",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Quejas_de_MP_Rasgos_Fisicos> Get_Rasgos_Fisicos(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Quejas_de_MP.Quejas_de_MP_Rasgos_Fisicos>(baseApi, ApiControllerUrl + "/Get_Rasgos_Fisicos?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Quejas_de_MP.Quejas_de_MP_Rasgos_Fisicos>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Quejas_de_MP.Quejas_de_MP_Rasgos_Fisicos>(false, null);
            }
        }

public ApiResponse<int> Update_Hechos_Sucedidos(Quejas_de_MP_Hechos_Sucedidos entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Hechos_Sucedidos",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Quejas_de_MP_Hechos_Sucedidos> Get_Hechos_Sucedidos(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Quejas_de_MP.Quejas_de_MP_Hechos_Sucedidos>(baseApi, ApiControllerUrl + "/Get_Hechos_Sucedidos?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Quejas_de_MP.Quejas_de_MP_Hechos_Sucedidos>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Quejas_de_MP.Quejas_de_MP_Hechos_Sucedidos>(false, null);
            }
        }

public ApiResponse<int> Update_Identificacion_del_Servidor_Publico(Quejas_de_MP_Identificacion_del_Servidor_Publico entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Identificacion_del_Servidor_Publico",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Quejas_de_MP_Identificacion_del_Servidor_Publico> Get_Identificacion_del_Servidor_Publico(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Quejas_de_MP.Quejas_de_MP_Identificacion_del_Servidor_Publico>(baseApi, ApiControllerUrl + "/Get_Identificacion_del_Servidor_Publico?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Quejas_de_MP.Quejas_de_MP_Identificacion_del_Servidor_Publico>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Quejas_de_MP.Quejas_de_MP_Identificacion_del_Servidor_Publico>(false, null);
            }
        }

public ApiResponse<int> Update_Domicilio_del_Servidor_Publico(Quejas_de_MP_Domicilio_del_Servidor_Publico entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Domicilio_del_Servidor_Publico",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Quejas_de_MP_Domicilio_del_Servidor_Publico> Get_Domicilio_del_Servidor_Publico(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Quejas_de_MP.Quejas_de_MP_Domicilio_del_Servidor_Publico>(baseApi, ApiControllerUrl + "/Get_Domicilio_del_Servidor_Publico?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Quejas_de_MP.Quejas_de_MP_Domicilio_del_Servidor_Publico>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Quejas_de_MP.Quejas_de_MP_Domicilio_del_Servidor_Publico>(false, null);
            }
        }


    }
}

