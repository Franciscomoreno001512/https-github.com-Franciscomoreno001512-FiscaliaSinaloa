using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Modulo_de_Atencion_Inicial;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Modulo_de_Atencion_Inicial
{
    public class Modulo_de_Atencion_InicialApiConsumer : BaseApiConsumer,IModulo_de_Atencion_InicialApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Modulo_de_Atencion_InicialApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Modulo_de_Atencion_Inicial";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial>(false, null);
            }
        }

        public ApiResponse<Modulo_de_Atencion_InicialPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_InicialPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Modulo_de_Atencion_Inicial.Folio='" + Key.ToString() + "'"
                        + "&Order=Modulo_de_Atencion_Inicial.Folio ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_InicialPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_InicialPagingModel>(false, new Modulo_de_Atencion_InicialPagingModel() { Modulo_de_Atencion_Inicials = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Modulo_de_Atencion_InicialInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial entity, Core.Domain.User.GlobalData Modulo_de_Atencion_InicialInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial entity, Core.Domain.User.GlobalData Modulo_de_Atencion_InicialInformation, DataLayerFieldsBitacora DataReference)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put?Id=" + entity.Folio,
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<IList<Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Modulo_de_Atencion_InicialPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_InicialPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_InicialPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_InicialPagingModel>(false, new Modulo_de_Atencion_InicialPagingModel() { Modulo_de_Atencion_Inicials = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Modulo_de_Atencion_InicialGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_del_Caso(Modulo_de_Atencion_Inicial_Datos_del_Caso entity)
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

        public ApiResponse<Modulo_de_Atencion_Inicial_Datos_del_Caso> Get_Datos_del_Caso(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial_Datos_del_Caso>(baseApi, ApiControllerUrl + "/Get_Datos_del_Caso?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial_Datos_del_Caso>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial_Datos_del_Caso>(false, null);
            }
        }

public ApiResponse<int> Update_Datos_Generales(Modulo_de_Atencion_Inicial_Datos_Generales entity)
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

        public ApiResponse<Modulo_de_Atencion_Inicial_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial_Datos_Generales>(false, null);
            }
        }

public ApiResponse<int> Update_Datos_del_Tutor(Modulo_de_Atencion_Inicial_Datos_del_Tutor entity)
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

        public ApiResponse<Modulo_de_Atencion_Inicial_Datos_del_Tutor> Get_Datos_del_Tutor(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial_Datos_del_Tutor>(baseApi, ApiControllerUrl + "/Get_Datos_del_Tutor?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial_Datos_del_Tutor>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial_Datos_del_Tutor>(false, null);
            }
        }

public ApiResponse<int> Update_Datos_del_Representante_Legal(Modulo_de_Atencion_Inicial_Datos_del_Representante_Legal entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Datos_del_Representante_Legal",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Modulo_de_Atencion_Inicial_Datos_del_Representante_Legal> Get_Datos_del_Representante_Legal(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial_Datos_del_Representante_Legal>(baseApi, ApiControllerUrl + "/Get_Datos_del_Representante_Legal?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial_Datos_del_Representante_Legal>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial_Datos_del_Representante_Legal>(false, null);
            }
        }

public ApiResponse<int> Update_Datos_de_los_Hechos(Modulo_de_Atencion_Inicial_Datos_de_los_Hechos entity)
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

        public ApiResponse<Modulo_de_Atencion_Inicial_Datos_de_los_Hechos> Get_Datos_de_los_Hechos(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial_Datos_de_los_Hechos>(baseApi, ApiControllerUrl + "/Get_Datos_de_los_Hechos?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial_Datos_de_los_Hechos>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial_Datos_de_los_Hechos>(false, null);
            }
        }

public ApiResponse<int> Update_Datos_de_Servicios_de_Apoyo(Modulo_de_Atencion_Inicial_Datos_de_Servicios_de_Apoyo entity)
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

        public ApiResponse<Modulo_de_Atencion_Inicial_Datos_de_Servicios_de_Apoyo> Get_Datos_de_Servicios_de_Apoyo(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial_Datos_de_Servicios_de_Apoyo>(baseApi, ApiControllerUrl + "/Get_Datos_de_Servicios_de_Apoyo?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial_Datos_de_Servicios_de_Apoyo>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial_Datos_de_Servicios_de_Apoyo>(false, null);
            }
        }

public ApiResponse<int> Update_Servicios_de_Apoyo(Modulo_de_Atencion_Inicial_Servicios_de_Apoyo entity)
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

        public ApiResponse<Modulo_de_Atencion_Inicial_Servicios_de_Apoyo> Get_Servicios_de_Apoyo(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial_Servicios_de_Apoyo>(baseApi, ApiControllerUrl + "/Get_Servicios_de_Apoyo?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial_Servicios_de_Apoyo>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial_Servicios_de_Apoyo>(false, null);
            }
        }

public ApiResponse<int> Update_Tipo_de_Compareciente(Modulo_de_Atencion_Inicial_Tipo_de_Compareciente entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Tipo_de_Compareciente",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Modulo_de_Atencion_Inicial_Tipo_de_Compareciente> Get_Tipo_de_Compareciente(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial_Tipo_de_Compareciente>(baseApi, ApiControllerUrl + "/Get_Tipo_de_Compareciente?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial_Tipo_de_Compareciente>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial_Tipo_de_Compareciente>(false, null);
            }
        }

public ApiResponse<int> Update_Datos_de_los_Hechos_en_MPO(Modulo_de_Atencion_Inicial_Datos_de_los_Hechos_en_MPO entity)
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

        public ApiResponse<Modulo_de_Atencion_Inicial_Datos_de_los_Hechos_en_MPO> Get_Datos_de_los_Hechos_en_MPO(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial_Datos_de_los_Hechos_en_MPO>(baseApi, ApiControllerUrl + "/Get_Datos_de_los_Hechos_en_MPO?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial_Datos_de_los_Hechos_en_MPO>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Modulo_de_Atencion_Inicial.Modulo_de_Atencion_Inicial_Datos_de_los_Hechos_en_MPO>(false, null);
            }
        }


    }
}

