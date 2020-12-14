using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Judicializacion;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Judicializacion
{
    public class JudicializacionApiConsumer : BaseApiConsumer,IJudicializacionApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public JudicializacionApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Judicializacion";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Judicializacion.Judicializacion>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Judicializacion.Judicializacion>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Judicializacion.Judicializacion>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Judicializacion.Judicializacion>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Judicializacion.Judicializacion>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Judicializacion.Judicializacion>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Judicializacion.Judicializacion>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Judicializacion.Judicializacion>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Judicializacion.Judicializacion> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Judicializacion.Judicializacion>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Judicializacion.Judicializacion>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Judicializacion.Judicializacion>(false, null);
            }
        }

        public ApiResponse<JudicializacionPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Judicializacion.JudicializacionPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Judicializacion.Clave='" + Key.ToString() + "'"
                        + "&Order=Judicializacion.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Judicializacion.JudicializacionPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Judicializacion.JudicializacionPagingModel>(false, new JudicializacionPagingModel() { Judicializacions = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData JudicializacionInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Judicializacion.Judicializacion entity, Core.Domain.User.GlobalData JudicializacionInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Judicializacion.Judicializacion entity, Core.Domain.User.GlobalData JudicializacionInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Judicializacion.Judicializacion>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Judicializacion.Judicializacion>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Judicializacion.Judicializacion>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<JudicializacionPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Judicializacion.JudicializacionPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Judicializacion.JudicializacionPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Judicializacion.JudicializacionPagingModel>(false, new JudicializacionPagingModel() { Judicializacions = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Judicializacion.Judicializacion>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/JudicializacionGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Judicializacion_Datos_Generales entity)
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

        public ApiResponse<Judicializacion_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Judicializacion.Judicializacion_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Judicializacion.Judicializacion_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Judicializacion.Judicializacion_Datos_Generales>(false, null);
            }
        }

public ApiResponse<int> Update_Actos_de_Investigacion(Judicializacion_Actos_de_Investigacion entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Actos_de_Investigacion",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Judicializacion_Actos_de_Investigacion> Get_Actos_de_Investigacion(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Judicializacion.Judicializacion_Actos_de_Investigacion>(baseApi, ApiControllerUrl + "/Get_Actos_de_Investigacion?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Judicializacion.Judicializacion_Actos_de_Investigacion>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Judicializacion.Judicializacion_Actos_de_Investigacion>(false, null);
            }
        }

public ApiResponse<int> Update_Genericos(Judicializacion_Genericos entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Genericos",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Judicializacion_Genericos> Get_Genericos(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Judicializacion.Judicializacion_Genericos>(baseApi, ApiControllerUrl + "/Get_Genericos?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Judicializacion.Judicializacion_Genericos>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Judicializacion.Judicializacion_Genericos>(false, null);
            }
        }

public ApiResponse<int> Update_Fase_Inicial(Judicializacion_Fase_Inicial entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Fase_Inicial",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Judicializacion_Fase_Inicial> Get_Fase_Inicial(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Judicializacion.Judicializacion_Fase_Inicial>(baseApi, ApiControllerUrl + "/Get_Fase_Inicial?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Judicializacion.Judicializacion_Fase_Inicial>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Judicializacion.Judicializacion_Fase_Inicial>(false, null);
            }
        }

public ApiResponse<int> Update_Fase_Intermedia(Judicializacion_Fase_Intermedia entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Fase_Intermedia",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Judicializacion_Fase_Intermedia> Get_Fase_Intermedia(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Judicializacion.Judicializacion_Fase_Intermedia>(baseApi, ApiControllerUrl + "/Get_Fase_Intermedia?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Judicializacion.Judicializacion_Fase_Intermedia>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Judicializacion.Judicializacion_Fase_Intermedia>(false, null);
            }
        }

public ApiResponse<int> Update_Fase_Juicio_Oral(Judicializacion_Fase_Juicio_Oral entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Fase_Juicio_Oral",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Judicializacion_Fase_Juicio_Oral> Get_Fase_Juicio_Oral(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Judicializacion.Judicializacion_Fase_Juicio_Oral>(baseApi, ApiControllerUrl + "/Get_Fase_Juicio_Oral?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Judicializacion.Judicializacion_Fase_Juicio_Oral>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Judicializacion.Judicializacion_Fase_Juicio_Oral>(false, null);
            }
        }

public ApiResponse<int> Update_Salidas_Alternas(Judicializacion_Salidas_Alternas entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Salidas_Alternas",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Judicializacion_Salidas_Alternas> Get_Salidas_Alternas(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Judicializacion.Judicializacion_Salidas_Alternas>(baseApi, ApiControllerUrl + "/Get_Salidas_Alternas?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Judicializacion.Judicializacion_Salidas_Alternas>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Judicializacion.Judicializacion_Salidas_Alternas>(false, null);
            }
        }

public ApiResponse<int> Update_Sobreseimientos(Judicializacion_Sobreseimientos entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Sobreseimientos",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Judicializacion_Sobreseimientos> Get_Sobreseimientos(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Judicializacion.Judicializacion_Sobreseimientos>(baseApi, ApiControllerUrl + "/Get_Sobreseimientos?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Judicializacion.Judicializacion_Sobreseimientos>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Judicializacion.Judicializacion_Sobreseimientos>(false, null);
            }
        }

public ApiResponse<int> Update_Movimientos(Judicializacion_Movimientos entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Movimientos",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Judicializacion_Movimientos> Get_Movimientos(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Judicializacion.Judicializacion_Movimientos>(baseApi, ApiControllerUrl + "/Get_Movimientos?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Judicializacion.Judicializacion_Movimientos>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Judicializacion.Judicializacion_Movimientos>(false, null);
            }
        }


    }
}

