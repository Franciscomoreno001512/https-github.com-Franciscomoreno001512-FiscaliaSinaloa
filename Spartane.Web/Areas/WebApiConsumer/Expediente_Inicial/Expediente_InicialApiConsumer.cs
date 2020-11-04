using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Expediente_Inicial;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Expediente_Inicial
{
    public class Expediente_InicialApiConsumer : BaseApiConsumer,IExpediente_InicialApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Expediente_InicialApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Expediente_Inicial";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Expediente_Inicial.Expediente_Inicial>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Expediente_Inicial.Expediente_Inicial>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Expediente_Inicial.Expediente_Inicial>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Expediente_Inicial.Expediente_Inicial>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Expediente_Inicial.Expediente_Inicial>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Expediente_Inicial.Expediente_Inicial>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Expediente_Inicial.Expediente_Inicial> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Expediente_Inicial.Expediente_Inicial>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Expediente_Inicial.Expediente_Inicial>(false, null);
            }
        }

        public ApiResponse<Expediente_InicialPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Expediente_Inicial.Expediente_InicialPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Expediente_Inicial.Clave='" + Key.ToString() + "'"
                        + "&Order=Expediente_Inicial.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Expediente_Inicial.Expediente_InicialPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Expediente_Inicial.Expediente_InicialPagingModel>(false, new Expediente_InicialPagingModel() { Expediente_Inicials = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Expediente_InicialInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Expediente_Inicial.Expediente_Inicial entity, Core.Domain.User.GlobalData Expediente_InicialInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Expediente_Inicial.Expediente_Inicial entity, Core.Domain.User.GlobalData Expediente_InicialInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Expediente_Inicial.Expediente_Inicial>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Expediente_Inicial.Expediente_Inicial>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Expediente_Inicial.Expediente_Inicial>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Expediente_InicialPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Expediente_Inicial.Expediente_InicialPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Expediente_Inicial.Expediente_InicialPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Expediente_Inicial.Expediente_InicialPagingModel>(false, new Expediente_InicialPagingModel() { Expediente_Inicials = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Expediente_Inicial.Expediente_Inicial>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Expediente_InicialGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_del_Caso(Expediente_Inicial_Datos_del_Caso entity)
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

        public ApiResponse<Expediente_Inicial_Datos_del_Caso> Get_Datos_del_Caso(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Datos_del_Caso>(baseApi, ApiControllerUrl + "/Get_Datos_del_Caso?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Expediente_Inicial.Expediente_Inicial_Datos_del_Caso>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Expediente_Inicial.Expediente_Inicial_Datos_del_Caso>(false, null);
            }
        }

public ApiResponse<int> Update_Datos_de_la_Victima(Expediente_Inicial_Datos_de_la_Victima entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Datos_de_la_Victima",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Expediente_Inicial_Datos_de_la_Victima> Get_Datos_de_la_Victima(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Datos_de_la_Victima>(baseApi, ApiControllerUrl + "/Get_Datos_de_la_Victima?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Expediente_Inicial.Expediente_Inicial_Datos_de_la_Victima>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Expediente_Inicial.Expediente_Inicial_Datos_de_la_Victima>(false, null);
            }
        }

public ApiResponse<int> Update_Datos_del_Imputado(Expediente_Inicial_Datos_del_Imputado entity)
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

        public ApiResponse<Expediente_Inicial_Datos_del_Imputado> Get_Datos_del_Imputado(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Datos_del_Imputado>(baseApi, ApiControllerUrl + "/Get_Datos_del_Imputado?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Expediente_Inicial.Expediente_Inicial_Datos_del_Imputado>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Expediente_Inicial.Expediente_Inicial_Datos_del_Imputado>(false, null);
            }
        }

public ApiResponse<int> Update_Datos_del_Delito(Expediente_Inicial_Datos_del_Delito entity)
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

        public ApiResponse<Expediente_Inicial_Datos_del_Delito> Get_Datos_del_Delito(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Datos_del_Delito>(baseApi, ApiControllerUrl + "/Get_Datos_del_Delito?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Expediente_Inicial.Expediente_Inicial_Datos_del_Delito>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Expediente_Inicial.Expediente_Inicial_Datos_del_Delito>(false, null);
            }
        }

public ApiResponse<int> Update_Datos_de_los_Hechos(Expediente_Inicial_Datos_de_los_Hechos entity)
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

        public ApiResponse<Expediente_Inicial_Datos_de_los_Hechos> Get_Datos_de_los_Hechos(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Datos_de_los_Hechos>(baseApi, ApiControllerUrl + "/Get_Datos_de_los_Hechos?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Expediente_Inicial.Expediente_Inicial_Datos_de_los_Hechos>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Expediente_Inicial.Expediente_Inicial_Datos_de_los_Hechos>(false, null);
            }
        }

public ApiResponse<int> Update_Datos_de_la_Persona_Moral(Expediente_Inicial_Datos_de_la_Persona_Moral entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Datos_de_la_Persona_Moral",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Expediente_Inicial_Datos_de_la_Persona_Moral> Get_Datos_de_la_Persona_Moral(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Datos_de_la_Persona_Moral>(baseApi, ApiControllerUrl + "/Get_Datos_de_la_Persona_Moral?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Expediente_Inicial.Expediente_Inicial_Datos_de_la_Persona_Moral>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Expediente_Inicial.Expediente_Inicial_Datos_de_la_Persona_Moral>(false, null);
            }
        }

public ApiResponse<int> Update_Servicios_de_Apoyo(Expediente_Inicial_Servicios_de_Apoyo entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Servicios_de_Apoyo",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Expediente_Inicial_Servicios_de_Apoyo> Get_Servicios_de_Apoyo(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Servicios_de_Apoyo>(baseApi, ApiControllerUrl + "/Get_Servicios_de_Apoyo?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Expediente_Inicial.Expediente_Inicial_Servicios_de_Apoyo>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Expediente_Inicial.Expediente_Inicial_Servicios_de_Apoyo>(false, null);
            }
        }

public ApiResponse<int> Update_Datos_del_Testigo(Expediente_Inicial_Datos_del_Testigo entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Datos_del_Testigo",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Expediente_Inicial_Datos_del_Testigo> Get_Datos_del_Testigo(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Datos_del_Testigo>(baseApi, ApiControllerUrl + "/Get_Datos_del_Testigo?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Expediente_Inicial.Expediente_Inicial_Datos_del_Testigo>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Expediente_Inicial.Expediente_Inicial_Datos_del_Testigo>(false, null);
            }
        }

public ApiResponse<int> Update_Asignar_MP(Expediente_Inicial_Asignar_MP entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Asignar_MP",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Expediente_Inicial_Asignar_MP> Get_Asignar_MP(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Asignar_MP>(baseApi, ApiControllerUrl + "/Get_Asignar_MP?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Expediente_Inicial.Expediente_Inicial_Asignar_MP>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Expediente_Inicial.Expediente_Inicial_Asignar_MP>(false, null);
            }
        }

public ApiResponse<int> Update_Diligencias(Expediente_Inicial_Diligencias entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Diligencias",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Expediente_Inicial_Diligencias> Get_Diligencias(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Diligencias>(baseApi, ApiControllerUrl + "/Get_Diligencias?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Expediente_Inicial.Expediente_Inicial_Diligencias>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Expediente_Inicial.Expediente_Inicial_Diligencias>(false, null);
            }
        }

public ApiResponse<int> Update_IPH(Expediente_Inicial_IPH entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_IPH",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Expediente_Inicial_IPH> Get_IPH(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_IPH>(baseApi, ApiControllerUrl + "/Get_IPH?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Expediente_Inicial.Expediente_Inicial_IPH>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Expediente_Inicial.Expediente_Inicial_IPH>(false, null);
            }
        }

public ApiResponse<int> Update_Agenda_de_Audiencias_y_Citatorios(Expediente_Inicial_Agenda_de_Audiencias_y_Citatorios entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Agenda_de_Audiencias_y_Citatorios",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Expediente_Inicial_Agenda_de_Audiencias_y_Citatorios> Get_Agenda_de_Audiencias_y_Citatorios(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Agenda_de_Audiencias_y_Citatorios>(baseApi, ApiControllerUrl + "/Get_Agenda_de_Audiencias_y_Citatorios?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Expediente_Inicial.Expediente_Inicial_Agenda_de_Audiencias_y_Citatorios>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Expediente_Inicial.Expediente_Inicial_Agenda_de_Audiencias_y_Citatorios>(false, null);
            }
        }

public ApiResponse<int> Update_Audiencias_Citatorios(Expediente_Inicial_Audiencias_Citatorios entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Audiencias_Citatorios",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Expediente_Inicial_Audiencias_Citatorios> Get_Audiencias_Citatorios(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Audiencias_Citatorios>(baseApi, ApiControllerUrl + "/Get_Audiencias_Citatorios?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Expediente_Inicial.Expediente_Inicial_Audiencias_Citatorios>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Expediente_Inicial.Expediente_Inicial_Audiencias_Citatorios>(false, null);
            }
        }

public ApiResponse<int> Update_Documentos(Expediente_Inicial_Documentos entity)
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

        public ApiResponse<Expediente_Inicial_Documentos> Get_Documentos(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Documentos>(baseApi, ApiControllerUrl + "/Get_Documentos?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Expediente_Inicial.Expediente_Inicial_Documentos>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Expediente_Inicial.Expediente_Inicial_Documentos>(false, null);
            }
        }

public ApiResponse<int> Update_Bitacora_de_Coincidencias(Expediente_Inicial_Bitacora_de_Coincidencias entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Bitacora_de_Coincidencias",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Expediente_Inicial_Bitacora_de_Coincidencias> Get_Bitacora_de_Coincidencias(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Bitacora_de_Coincidencias>(baseApi, ApiControllerUrl + "/Get_Bitacora_de_Coincidencias?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Expediente_Inicial.Expediente_Inicial_Bitacora_de_Coincidencias>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Expediente_Inicial.Expediente_Inicial_Bitacora_de_Coincidencias>(false, null);
            }
        }

public ApiResponse<int> Update_Indicios(Expediente_Inicial_Indicios entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Indicios",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Expediente_Inicial_Indicios> Get_Indicios(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Indicios>(baseApi, ApiControllerUrl + "/Get_Indicios?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Expediente_Inicial.Expediente_Inicial_Indicios>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Expediente_Inicial.Expediente_Inicial_Indicios>(false, null);
            }
        }

public ApiResponse<int> Update_Canalizar(Expediente_Inicial_Canalizar entity)
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

        public ApiResponse<Expediente_Inicial_Canalizar> Get_Canalizar(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Canalizar>(baseApi, ApiControllerUrl + "/Get_Canalizar?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Expediente_Inicial.Expediente_Inicial_Canalizar>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Expediente_Inicial.Expediente_Inicial_Canalizar>(false, null);
            }
        }

public ApiResponse<int> Update_Datos_del_Acuerdo(Expediente_Inicial_Datos_del_Acuerdo entity)
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

        public ApiResponse<Expediente_Inicial_Datos_del_Acuerdo> Get_Datos_del_Acuerdo(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial_Datos_del_Acuerdo>(baseApi, ApiControllerUrl + "/Get_Datos_del_Acuerdo?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Expediente_Inicial.Expediente_Inicial_Datos_del_Acuerdo>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Expediente_Inicial.Expediente_Inicial_Datos_del_Acuerdo>(false, null);
            }
        }


    }
}

