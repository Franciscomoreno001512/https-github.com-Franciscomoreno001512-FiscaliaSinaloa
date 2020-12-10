using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Proceso_Penal;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Proceso_Penal
{
    public class Proceso_PenalApiConsumer : BaseApiConsumer,IProceso_PenalApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Proceso_PenalApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Proceso_Penal";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Proceso_Penal.Proceso_Penal>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Proceso_Penal.Proceso_Penal>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Proceso_Penal.Proceso_Penal>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Proceso_Penal.Proceso_Penal>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Proceso_Penal.Proceso_Penal>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Proceso_Penal.Proceso_Penal>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Proceso_Penal.Proceso_Penal>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Proceso_Penal.Proceso_Penal>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Proceso_Penal.Proceso_Penal> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Proceso_Penal.Proceso_Penal>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Proceso_Penal.Proceso_Penal>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Proceso_Penal.Proceso_Penal>(false, null);
            }
        }

        public ApiResponse<Proceso_PenalPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Proceso_Penal.Proceso_PenalPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Proceso_Penal.Folio='" + Key.ToString() + "'"
                        + "&Order=Proceso_Penal.Folio ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Proceso_Penal.Proceso_PenalPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Proceso_Penal.Proceso_PenalPagingModel>(false, new Proceso_PenalPagingModel() { Proceso_Penals = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Proceso_PenalInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Proceso_Penal.Proceso_Penal entity, Core.Domain.User.GlobalData Proceso_PenalInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Proceso_Penal.Proceso_Penal entity, Core.Domain.User.GlobalData Proceso_PenalInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Proceso_Penal.Proceso_Penal>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Proceso_Penal.Proceso_Penal>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Proceso_Penal.Proceso_Penal>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Proceso_PenalPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Proceso_Penal.Proceso_PenalPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Proceso_Penal.Proceso_PenalPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Proceso_Penal.Proceso_PenalPagingModel>(false, new Proceso_PenalPagingModel() { Proceso_Penals = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Proceso_Penal.Proceso_Penal>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Proceso_PenalGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Fase_Complementaria(Proceso_Penal_Fase_Complementaria entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Fase_Complementaria",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Proceso_Penal_Fase_Complementaria> Get_Fase_Complementaria(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Proceso_Penal.Proceso_Penal_Fase_Complementaria>(baseApi, ApiControllerUrl + "/Get_Fase_Complementaria?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Proceso_Penal.Proceso_Penal_Fase_Complementaria>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Proceso_Penal.Proceso_Penal_Fase_Complementaria>(false, null);
            }
        }

public ApiResponse<int> Update_Fase_Escrita(Proceso_Penal_Fase_Escrita entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Fase_Escrita",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Proceso_Penal_Fase_Escrita> Get_Fase_Escrita(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Proceso_Penal.Proceso_Penal_Fase_Escrita>(baseApi, ApiControllerUrl + "/Get_Fase_Escrita?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Proceso_Penal.Proceso_Penal_Fase_Escrita>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Proceso_Penal.Proceso_Penal_Fase_Escrita>(false, null);
            }
        }

public ApiResponse<int> Update_Audiencia_Intermedia(Proceso_Penal_Audiencia_Intermedia entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Audiencia_Intermedia",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Proceso_Penal_Audiencia_Intermedia> Get_Audiencia_Intermedia(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Proceso_Penal.Proceso_Penal_Audiencia_Intermedia>(baseApi, ApiControllerUrl + "/Get_Audiencia_Intermedia?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Proceso_Penal.Proceso_Penal_Audiencia_Intermedia>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Proceso_Penal.Proceso_Penal_Audiencia_Intermedia>(false, null);
            }
        }

public ApiResponse<int> Update_Juicio_Oral(Proceso_Penal_Juicio_Oral entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Juicio_Oral",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Proceso_Penal_Juicio_Oral> Get_Juicio_Oral(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Proceso_Penal.Proceso_Penal_Juicio_Oral>(baseApi, ApiControllerUrl + "/Get_Juicio_Oral?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Proceso_Penal.Proceso_Penal_Juicio_Oral>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Proceso_Penal.Proceso_Penal_Juicio_Oral>(false, null);
            }
        }

public ApiResponse<int> Update_Resolucion(Proceso_Penal_Resolucion entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Resolucion",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Proceso_Penal_Resolucion> Get_Resolucion(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Proceso_Penal.Proceso_Penal_Resolucion>(baseApi, ApiControllerUrl + "/Get_Resolucion?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Proceso_Penal.Proceso_Penal_Resolucion>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Proceso_Penal.Proceso_Penal_Resolucion>(false, null);
            }
        }


    }
}

