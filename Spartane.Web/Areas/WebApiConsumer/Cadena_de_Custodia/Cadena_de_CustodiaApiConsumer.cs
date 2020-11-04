using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Cadena_de_Custodia;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Cadena_de_Custodia
{
    public class Cadena_de_CustodiaApiConsumer : BaseApiConsumer,ICadena_de_CustodiaApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Cadena_de_CustodiaApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Cadena_de_Custodia";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia>(false, null);
            }
        }

        public ApiResponse<Cadena_de_CustodiaPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_CustodiaPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Cadena_de_Custodia.Clave='" + Key.ToString() + "'"
                        + "&Order=Cadena_de_Custodia.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Cadena_de_Custodia.Cadena_de_CustodiaPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Cadena_de_Custodia.Cadena_de_CustodiaPagingModel>(false, new Cadena_de_CustodiaPagingModel() { Cadena_de_Custodias = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Cadena_de_CustodiaInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia entity, Core.Domain.User.GlobalData Cadena_de_CustodiaInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia entity, Core.Domain.User.GlobalData Cadena_de_CustodiaInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Cadena_de_CustodiaPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_CustodiaPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Cadena_de_Custodia.Cadena_de_CustodiaPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Cadena_de_Custodia.Cadena_de_CustodiaPagingModel>(false, new Cadena_de_CustodiaPagingModel() { Cadena_de_Custodias = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Cadena_de_CustodiaGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Asignacion(Cadena_de_Custodia_Asignacion entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Asignacion",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Cadena_de_Custodia_Asignacion> Get_Asignacion(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Asignacion>(baseApi, ApiControllerUrl + "/Get_Asignacion?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Asignacion>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Asignacion>(false, null);
            }
        }

public ApiResponse<int> Update_Cadena_de_Custodia(Cadena_de_Custodia_Cadena_de_Custodia entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Cadena_de_Custodia",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Cadena_de_Custodia_Cadena_de_Custodia> Get_Cadena_de_Custodia(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Cadena_de_Custodia>(baseApi, ApiControllerUrl + "/Get_Cadena_de_Custodia?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Cadena_de_Custodia>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Cadena_de_Custodia>(false, null);
            }
        }

public ApiResponse<int> Update_Fijacion_Planimetrica(Cadena_de_Custodia_Fijacion_Planimetrica entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Fijacion_Planimetrica",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Cadena_de_Custodia_Fijacion_Planimetrica> Get_Fijacion_Planimetrica(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Fijacion_Planimetrica>(baseApi, ApiControllerUrl + "/Get_Fijacion_Planimetrica?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Fijacion_Planimetrica>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Fijacion_Planimetrica>(false, null);
            }
        }

public ApiResponse<int> Update_Fotos(Cadena_de_Custodia_Fotos entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Fotos",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Cadena_de_Custodia_Fotos> Get_Fotos(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Fotos>(baseApi, ApiControllerUrl + "/Get_Fotos?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Fotos>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Fotos>(false, null);
            }
        }

public ApiResponse<int> Update_Videos(Cadena_de_Custodia_Videos entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Videos",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Cadena_de_Custodia_Videos> Get_Videos(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Videos>(baseApi, ApiControllerUrl + "/Get_Videos?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Videos>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Videos>(false, null);
            }
        }

public ApiResponse<int> Update_Registro_de_Intervinientes(Cadena_de_Custodia_Registro_de_Intervinientes entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Registro_de_Intervinientes",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Cadena_de_Custodia_Registro_de_Intervinientes> Get_Registro_de_Intervinientes(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Registro_de_Intervinientes>(baseApi, ApiControllerUrl + "/Get_Registro_de_Intervinientes?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Registro_de_Intervinientes>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Registro_de_Intervinientes>(false, null);
            }
        }

public ApiResponse<int> Update_Chat(Cadena_de_Custodia_Chat entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Chat",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Cadena_de_Custodia_Chat> Get_Chat(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Chat>(baseApi, ApiControllerUrl + "/Get_Chat?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Chat>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Chat>(false, null);
            }
        }

public ApiResponse<int> Update_Documentos(Cadena_de_Custodia_Documentos entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Documentos",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Cadena_de_Custodia_Documentos> Get_Documentos(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Documentos>(baseApi, ApiControllerUrl + "/Get_Documentos?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Documentos>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Documentos>(false, null);
            }
        }

public ApiResponse<int> Update_Retroalimentacion(Cadena_de_Custodia_Retroalimentacion entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Retroalimentacion",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Cadena_de_Custodia_Retroalimentacion> Get_Retroalimentacion(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Retroalimentacion>(baseApi, ApiControllerUrl + "/Get_Retroalimentacion?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Retroalimentacion>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Retroalimentacion>(false, null);
            }
        }

public ApiResponse<int> Update_Registro_de_Emergencia(Cadena_de_Custodia_Registro_de_Emergencia entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Registro_de_Emergencia",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Cadena_de_Custodia_Registro_de_Emergencia> Get_Registro_de_Emergencia(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Registro_de_Emergencia>(baseApi, ApiControllerUrl + "/Get_Registro_de_Emergencia?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Registro_de_Emergencia>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Registro_de_Emergencia>(false, null);
            }
        }

public ApiResponse<int> Update_Registro_de_Detenidos(Cadena_de_Custodia_Registro_de_Detenidos entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Registro_de_Detenidos",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Cadena_de_Custodia_Registro_de_Detenidos> Get_Registro_de_Detenidos(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Registro_de_Detenidos>(baseApi, ApiControllerUrl + "/Get_Registro_de_Detenidos?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Registro_de_Detenidos>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Registro_de_Detenidos>(false, null);
            }
        }

public ApiResponse<int> Update_Registro_de_Testigos(Cadena_de_Custodia_Registro_de_Testigos entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Registro_de_Testigos",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Cadena_de_Custodia_Registro_de_Testigos> Get_Registro_de_Testigos(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Registro_de_Testigos>(baseApi, ApiControllerUrl + "/Get_Registro_de_Testigos?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Registro_de_Testigos>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Registro_de_Testigos>(false, null);
            }
        }

public ApiResponse<int> Update_Datos_Generales(Cadena_de_Custodia_Datos_Generales entity)
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

        public ApiResponse<Cadena_de_Custodia_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Datos_Generales>(false, null);
            }
        }

public ApiResponse<int> Update_Asignaciones(Cadena_de_Custodia_Asignaciones entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Asignaciones",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Cadena_de_Custodia_Asignaciones> Get_Asignaciones(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Asignaciones>(baseApi, ApiControllerUrl + "/Get_Asignaciones?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Asignaciones>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Asignaciones>(false, null);
            }
        }

public ApiResponse<int> Update_Datos_de_Traslado(Cadena_de_Custodia_Datos_de_Traslado entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Datos_de_Traslado",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Cadena_de_Custodia_Datos_de_Traslado> Get_Datos_de_Traslado(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Datos_de_Traslado>(baseApi, ApiControllerUrl + "/Get_Datos_de_Traslado?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Datos_de_Traslado>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Cadena_de_Custodia.Cadena_de_Custodia_Datos_de_Traslado>(false, null);
            }
        }


    }
}

