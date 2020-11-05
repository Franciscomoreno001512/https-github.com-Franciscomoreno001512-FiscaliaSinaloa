using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Modulo_Atencion_Inicial;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Modulo_Atencion_Inicial
{
    public class Modulo_Atencion_InicialApiConsumer : BaseApiConsumer,IModulo_Atencion_InicialApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Modulo_Atencion_InicialApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Modulo_Atencion_Inicial";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial>(false, null);
            }
        }

        public ApiResponse<Modulo_Atencion_InicialPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_InicialPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Modulo_Atencion_Inicial.Clave='" + Key.ToString() + "'"
                        + "&Order=Modulo_Atencion_Inicial.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_InicialPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_InicialPagingModel>(false, new Modulo_Atencion_InicialPagingModel() { Modulo_Atencion_Inicials = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Modulo_Atencion_InicialInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial entity, Core.Domain.User.GlobalData Modulo_Atencion_InicialInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial entity, Core.Domain.User.GlobalData Modulo_Atencion_InicialInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Modulo_Atencion_InicialPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_InicialPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_InicialPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_InicialPagingModel>(false, new Modulo_Atencion_InicialPagingModel() { Modulo_Atencion_Inicials = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Modulo_Atencion_InicialGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_del_Caso(Modulo_Atencion_Inicial_Datos_del_Caso entity)
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

        public ApiResponse<Modulo_Atencion_Inicial_Datos_del_Caso> Get_Datos_del_Caso(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial_Datos_del_Caso>(baseApi, ApiControllerUrl + "/Get_Datos_del_Caso?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial_Datos_del_Caso>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial_Datos_del_Caso>(false, null);
            }
        }

public ApiResponse<int> Update_Informacion_de_Turno(Modulo_Atencion_Inicial_Informacion_de_Turno entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Informacion_de_Turno",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Modulo_Atencion_Inicial_Informacion_de_Turno> Get_Informacion_de_Turno(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial_Informacion_de_Turno>(baseApi, ApiControllerUrl + "/Get_Informacion_de_Turno?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial_Informacion_de_Turno>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial_Informacion_de_Turno>(false, null);
            }
        }

public ApiResponse<int> Update_Servicios_de_Apoyo(Modulo_Atencion_Inicial_Servicios_de_Apoyo entity)
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

        public ApiResponse<Modulo_Atencion_Inicial_Servicios_de_Apoyo> Get_Servicios_de_Apoyo(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial_Servicios_de_Apoyo>(baseApi, ApiControllerUrl + "/Get_Servicios_de_Apoyo?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial_Servicios_de_Apoyo>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial_Servicios_de_Apoyo>(false, null);
            }
        }

public ApiResponse<int> Update_Canalizar(Modulo_Atencion_Inicial_Canalizar entity)
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

        public ApiResponse<Modulo_Atencion_Inicial_Canalizar> Get_Canalizar(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial_Canalizar>(baseApi, ApiControllerUrl + "/Get_Canalizar?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial_Canalizar>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial_Canalizar>(false, null);
            }
        }

public ApiResponse<int> Update_Datos_Generales(Modulo_Atencion_Inicial_Datos_Generales entity)
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

        public ApiResponse<Modulo_Atencion_Inicial_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial_Datos_Generales>(false, null);
            }
        }

public ApiResponse<int> Update_Datos_de_los_Hechos_en_MPO(Modulo_Atencion_Inicial_Datos_de_los_Hechos_en_MPO entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Datos_de_los_Hechos_en_MPO",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Modulo_Atencion_Inicial_Datos_de_los_Hechos_en_MPO> Get_Datos_de_los_Hechos_en_MPO(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial_Datos_de_los_Hechos_en_MPO>(baseApi, ApiControllerUrl + "/Get_Datos_de_los_Hechos_en_MPO?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial_Datos_de_los_Hechos_en_MPO>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial_Datos_de_los_Hechos_en_MPO>(false, null);
            }
        }

public ApiResponse<int> Update_Datos_del_Acuerdo(Modulo_Atencion_Inicial_Datos_del_Acuerdo entity)
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

        public ApiResponse<Modulo_Atencion_Inicial_Datos_del_Acuerdo> Get_Datos_del_Acuerdo(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial_Datos_del_Acuerdo>(baseApi, ApiControllerUrl + "/Get_Datos_del_Acuerdo?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial_Datos_del_Acuerdo>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial_Datos_del_Acuerdo>(false, null);
            }
        }

public ApiResponse<int> Update_Bitacora_de_Coincidencias(Modulo_Atencion_Inicial_Bitacora_de_Coincidencias entity)
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

        public ApiResponse<Modulo_Atencion_Inicial_Bitacora_de_Coincidencias> Get_Bitacora_de_Coincidencias(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial_Bitacora_de_Coincidencias>(baseApi, ApiControllerUrl + "/Get_Bitacora_de_Coincidencias?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial_Bitacora_de_Coincidencias>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial_Bitacora_de_Coincidencias>(false, null);
            }
        }

public ApiResponse<int> Update_Cierre(Modulo_Atencion_Inicial_Cierre entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Cierre",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Modulo_Atencion_Inicial_Cierre> Get_Cierre(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial_Cierre>(baseApi, ApiControllerUrl + "/Get_Cierre?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial_Cierre>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial_Cierre>(false, null);
            }
        }

public ApiResponse<int> Update_Historial_de_movimientos(Modulo_Atencion_Inicial_Historial_de_movimientos entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Historial_de_movimientos",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Modulo_Atencion_Inicial_Historial_de_movimientos> Get_Historial_de_movimientos(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial_Historial_de_movimientos>(baseApi, ApiControllerUrl + "/Get_Historial_de_movimientos?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial_Historial_de_movimientos>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial_Historial_de_movimientos>(false, null);
            }
        }

public ApiResponse<int> Update_Campos_Ocultos(Modulo_Atencion_Inicial_Campos_Ocultos entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Campos_Ocultos",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Modulo_Atencion_Inicial_Campos_Ocultos> Get_Campos_Ocultos(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial_Campos_Ocultos>(baseApi, ApiControllerUrl + "/Get_Campos_Ocultos?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial_Campos_Ocultos>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial_Campos_Ocultos>(false, null);
            }
        }
		
		        public ApiResponse<int> Update_Estatus_de_Turno(Modulo_Atencion_Inicial_Datos_del_Caso entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Estatus_de_Turno",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1);
            }
        }


    }
}

