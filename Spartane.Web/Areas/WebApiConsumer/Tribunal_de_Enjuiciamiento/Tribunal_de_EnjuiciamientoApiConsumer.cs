using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Tribunal_de_Enjuiciamiento;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Tribunal_de_Enjuiciamiento
{
    public class Tribunal_de_EnjuiciamientoApiConsumer : BaseApiConsumer,ITribunal_de_EnjuiciamientoApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Tribunal_de_EnjuiciamientoApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Tribunal_de_Enjuiciamiento";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento>(false, null);
            }
        }

        public ApiResponse<Tribunal_de_EnjuiciamientoPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_EnjuiciamientoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Tribunal_de_Enjuiciamiento.Clave='" + Key.ToString() + "'"
                        + "&Order=Tribunal_de_Enjuiciamiento.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_EnjuiciamientoPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_EnjuiciamientoPagingModel>(false, new Tribunal_de_EnjuiciamientoPagingModel() { Tribunal_de_Enjuiciamientos = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Tribunal_de_EnjuiciamientoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento entity, Core.Domain.User.GlobalData Tribunal_de_EnjuiciamientoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento entity, Core.Domain.User.GlobalData Tribunal_de_EnjuiciamientoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Tribunal_de_EnjuiciamientoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_EnjuiciamientoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_EnjuiciamientoPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_EnjuiciamientoPagingModel>(false, new Tribunal_de_EnjuiciamientoPagingModel() { Tribunal_de_Enjuiciamientos = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Tribunal_de_EnjuiciamientoGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Tribunal_de_Enjuiciamiento_Datos_Generales entity)
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

        public ApiResponse<Tribunal_de_Enjuiciamiento_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento_Datos_Generales>(false, null);
            }
        }


    }
}

