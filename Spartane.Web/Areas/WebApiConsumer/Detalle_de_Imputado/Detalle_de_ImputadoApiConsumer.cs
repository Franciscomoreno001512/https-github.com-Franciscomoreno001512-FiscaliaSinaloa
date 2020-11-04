using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Detalle_de_Imputado;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Detalle_de_Imputado
{
    public class Detalle_de_ImputadoApiConsumer : BaseApiConsumer,IDetalle_de_ImputadoApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Detalle_de_ImputadoApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Detalle_de_Imputado";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado>(false, null);
            }
        }

        public ApiResponse<Detalle_de_ImputadoPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Detalle_de_Imputado.Detalle_de_ImputadoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Detalle_de_Imputado.Clave='" + Key.ToString() + "'"
                        + "&Order=Detalle_de_Imputado.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Detalle_de_Imputado.Detalle_de_ImputadoPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Detalle_de_Imputado.Detalle_de_ImputadoPagingModel>(false, new Detalle_de_ImputadoPagingModel() { Detalle_de_Imputados = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Detalle_de_ImputadoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado entity, Core.Domain.User.GlobalData Detalle_de_ImputadoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado entity, Core.Domain.User.GlobalData Detalle_de_ImputadoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Detalle_de_ImputadoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Detalle_de_Imputado.Detalle_de_ImputadoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Detalle_de_Imputado.Detalle_de_ImputadoPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Detalle_de_Imputado.Detalle_de_ImputadoPagingModel>(false, new Detalle_de_ImputadoPagingModel() { Detalle_de_Imputados = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Detalle_de_ImputadoGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Detalle_de_Imputado_Datos_Generales entity)
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

        public ApiResponse<Detalle_de_Imputado_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado_Datos_Generales>(false, null);
            }
        }

public ApiResponse<int> Update_Representante_Legal(Detalle_de_Imputado_Representante_Legal entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Representante_Legal",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Detalle_de_Imputado_Representante_Legal> Get_Representante_Legal(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado_Representante_Legal>(baseApi, ApiControllerUrl + "/Get_Representante_Legal?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado_Representante_Legal>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado_Representante_Legal>(false, null);
            }
        }

public ApiResponse<int> Update_Datos_de_Media_Filiacion(Detalle_de_Imputado_Datos_de_Media_Filiacion entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Datos_de_Media_Filiacion",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Detalle_de_Imputado_Datos_de_Media_Filiacion> Get_Datos_de_Media_Filiacion(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado_Datos_de_Media_Filiacion>(baseApi, ApiControllerUrl + "/Get_Datos_de_Media_Filiacion?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado_Datos_de_Media_Filiacion>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado_Datos_de_Media_Filiacion>(false, null);
            }
        }

public ApiResponse<int> Update_Datos_de_los_Hechos(Detalle_de_Imputado_Datos_de_los_Hechos entity)
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

        public ApiResponse<Detalle_de_Imputado_Datos_de_los_Hechos> Get_Datos_de_los_Hechos(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado_Datos_de_los_Hechos>(baseApi, ApiControllerUrl + "/Get_Datos_de_los_Hechos?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado_Datos_de_los_Hechos>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado_Datos_de_los_Hechos>(false, null);
            }
        }

public ApiResponse<int> Update_Datos_del_Tutor(Detalle_de_Imputado_Datos_del_Tutor entity)
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

        public ApiResponse<Detalle_de_Imputado_Datos_del_Tutor> Get_Datos_del_Tutor(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado_Datos_del_Tutor>(baseApi, ApiControllerUrl + "/Get_Datos_del_Tutor?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado_Datos_del_Tutor>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Detalle_de_Imputado.Detalle_de_Imputado_Datos_del_Tutor>(false, null);
            }
        }


    }
}

