using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Partida_que_Cumplimenta;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Partida_que_Cumplimenta
{
    public class Partida_que_CumplimentaApiConsumer : BaseApiConsumer,IPartida_que_CumplimentaApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Partida_que_CumplimentaApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Partida_que_Cumplimenta";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta>(false, null);
            }
        }

        public ApiResponse<Partida_que_CumplimentaPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Partida_que_Cumplimenta.Partida_que_CumplimentaPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Partida_que_Cumplimenta.Clave='" + Key.ToString() + "'"
                        + "&Order=Partida_que_Cumplimenta.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Partida_que_Cumplimenta.Partida_que_CumplimentaPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Partida_que_Cumplimenta.Partida_que_CumplimentaPagingModel>(false, new Partida_que_CumplimentaPagingModel() { Partida_que_Cumplimentas = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Partida_que_CumplimentaInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta entity, Core.Domain.User.GlobalData Partida_que_CumplimentaInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta entity, Core.Domain.User.GlobalData Partida_que_CumplimentaInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Partida_que_CumplimentaPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Partida_que_Cumplimenta.Partida_que_CumplimentaPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Partida_que_Cumplimenta.Partida_que_CumplimentaPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Partida_que_Cumplimenta.Partida_que_CumplimentaPagingModel>(false, new Partida_que_CumplimentaPagingModel() { Partida_que_Cumplimentas = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Partida_que_CumplimentaGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Partida_que_Cumplimenta_Datos_Generales entity)
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

        public ApiResponse<Partida_que_Cumplimenta_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta_Datos_Generales>(false, null);
            }
        }


    }
}

