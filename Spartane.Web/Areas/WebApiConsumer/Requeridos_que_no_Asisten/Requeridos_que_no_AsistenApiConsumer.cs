using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Requeridos_que_no_Asisten;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Requeridos_que_no_Asisten
{
    public class Requeridos_que_no_AsistenApiConsumer : BaseApiConsumer,IRequeridos_que_no_AsistenApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Requeridos_que_no_AsistenApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Requeridos_que_no_Asisten";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten>(false, null);
            }
        }

        public ApiResponse<Requeridos_que_no_AsistenPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_AsistenPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Requeridos_que_no_Asisten.Clave='" + Key.ToString() + "'"
                        + "&Order=Requeridos_que_no_Asisten.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_AsistenPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_AsistenPagingModel>(false, new Requeridos_que_no_AsistenPagingModel() { Requeridos_que_no_Asistens = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Requeridos_que_no_AsistenInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten entity, Core.Domain.User.GlobalData Requeridos_que_no_AsistenInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten entity, Core.Domain.User.GlobalData Requeridos_que_no_AsistenInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Requeridos_que_no_AsistenPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_AsistenPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_AsistenPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_AsistenPagingModel>(false, new Requeridos_que_no_AsistenPagingModel() { Requeridos_que_no_Asistens = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Requeridos_que_no_AsistenGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Requeridos_que_no_Asisten_Datos_Generales entity)
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

        public ApiResponse<Requeridos_que_no_Asisten_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Requeridos_que_no_Asisten.Requeridos_que_no_Asisten_Datos_Generales>(false, null);
            }
        }


    }
}

