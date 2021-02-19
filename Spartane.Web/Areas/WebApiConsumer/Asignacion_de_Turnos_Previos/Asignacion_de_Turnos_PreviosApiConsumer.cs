using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Asignacion_de_Turnos_Previos;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Asignacion_de_Turnos_Previos
{
    public class Asignacion_de_Turnos_PreviosApiConsumer : BaseApiConsumer,IAsignacion_de_Turnos_PreviosApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Asignacion_de_Turnos_PreviosApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Asignacion_de_Turnos_Previos";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_Previos>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_Previos>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_Previos>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_Previos>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_Previos>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_Previos>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_Previos>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_Previos>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_Previos> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_Previos>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_Previos>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_Previos>(false, null);
            }
        }

        public ApiResponse<Asignacion_de_Turnos_PreviosPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_PreviosPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Asignacion_de_Turnos_Previos.Clave='" + Key.ToString() + "'"
                        + "&Order=Asignacion_de_Turnos_Previos.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_PreviosPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_PreviosPagingModel>(false, new Asignacion_de_Turnos_PreviosPagingModel() { Asignacion_de_Turnos_Previoss = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Asignacion_de_Turnos_PreviosInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_Previos entity, Core.Domain.User.GlobalData Asignacion_de_Turnos_PreviosInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_Previos entity, Core.Domain.User.GlobalData Asignacion_de_Turnos_PreviosInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_Previos>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_Previos>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_Previos>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Asignacion_de_Turnos_PreviosPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_PreviosPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_PreviosPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_PreviosPagingModel>(false, new Asignacion_de_Turnos_PreviosPagingModel() { Asignacion_de_Turnos_Previoss = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_Previos>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Asignacion_de_Turnos_PreviosGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Asignacion_de_Turnos_Previos_Datos_Generales entity)
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

        public ApiResponse<Asignacion_de_Turnos_Previos_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_Previos_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_Previos_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_Previos_Datos_Generales>(false, null);
            }
        }


    }
}

