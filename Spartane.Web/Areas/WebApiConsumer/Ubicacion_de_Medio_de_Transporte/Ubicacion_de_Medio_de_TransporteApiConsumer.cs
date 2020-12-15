using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Ubicacion_de_Medio_de_Transporte;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Ubicacion_de_Medio_de_Transporte
{
    public class Ubicacion_de_Medio_de_TransporteApiConsumer : BaseApiConsumer,IUbicacion_de_Medio_de_TransporteApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Ubicacion_de_Medio_de_TransporteApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Ubicacion_de_Medio_de_Transporte";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Ubicacion_de_Medio_de_Transporte.Ubicacion_de_Medio_de_Transporte>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Ubicacion_de_Medio_de_Transporte.Ubicacion_de_Medio_de_Transporte>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Ubicacion_de_Medio_de_Transporte.Ubicacion_de_Medio_de_Transporte>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Ubicacion_de_Medio_de_Transporte.Ubicacion_de_Medio_de_Transporte>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Ubicacion_de_Medio_de_Transporte.Ubicacion_de_Medio_de_Transporte>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Ubicacion_de_Medio_de_Transporte.Ubicacion_de_Medio_de_Transporte>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Ubicacion_de_Medio_de_Transporte.Ubicacion_de_Medio_de_Transporte>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Ubicacion_de_Medio_de_Transporte.Ubicacion_de_Medio_de_Transporte>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Ubicacion_de_Medio_de_Transporte.Ubicacion_de_Medio_de_Transporte> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Ubicacion_de_Medio_de_Transporte.Ubicacion_de_Medio_de_Transporte>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Ubicacion_de_Medio_de_Transporte.Ubicacion_de_Medio_de_Transporte>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Ubicacion_de_Medio_de_Transporte.Ubicacion_de_Medio_de_Transporte>(false, null);
            }
        }

        public ApiResponse<Ubicacion_de_Medio_de_TransportePagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Ubicacion_de_Medio_de_Transporte.Ubicacion_de_Medio_de_TransportePagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Ubicacion_de_Medio_de_Transporte.Clave='" + Key.ToString() + "'"
                        + "&Order=Ubicacion_de_Medio_de_Transporte.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Ubicacion_de_Medio_de_Transporte.Ubicacion_de_Medio_de_TransportePagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Ubicacion_de_Medio_de_Transporte.Ubicacion_de_Medio_de_TransportePagingModel>(false, new Ubicacion_de_Medio_de_TransportePagingModel() { Ubicacion_de_Medio_de_Transportes = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Ubicacion_de_Medio_de_TransporteInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Ubicacion_de_Medio_de_Transporte.Ubicacion_de_Medio_de_Transporte entity, Core.Domain.User.GlobalData Ubicacion_de_Medio_de_TransporteInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Ubicacion_de_Medio_de_Transporte.Ubicacion_de_Medio_de_Transporte entity, Core.Domain.User.GlobalData Ubicacion_de_Medio_de_TransporteInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Ubicacion_de_Medio_de_Transporte.Ubicacion_de_Medio_de_Transporte>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Ubicacion_de_Medio_de_Transporte.Ubicacion_de_Medio_de_Transporte>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Ubicacion_de_Medio_de_Transporte.Ubicacion_de_Medio_de_Transporte>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Ubicacion_de_Medio_de_TransportePagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Ubicacion_de_Medio_de_Transporte.Ubicacion_de_Medio_de_TransportePagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Ubicacion_de_Medio_de_Transporte.Ubicacion_de_Medio_de_TransportePagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Ubicacion_de_Medio_de_Transporte.Ubicacion_de_Medio_de_TransportePagingModel>(false, new Ubicacion_de_Medio_de_TransportePagingModel() { Ubicacion_de_Medio_de_Transportes = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Ubicacion_de_Medio_de_Transporte.Ubicacion_de_Medio_de_Transporte>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Ubicacion_de_Medio_de_TransporteGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Ubicacion_de_Medio_de_Transporte_Datos_Generales entity)
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

        public ApiResponse<Ubicacion_de_Medio_de_Transporte_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Ubicacion_de_Medio_de_Transporte.Ubicacion_de_Medio_de_Transporte_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Ubicacion_de_Medio_de_Transporte.Ubicacion_de_Medio_de_Transporte_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Ubicacion_de_Medio_de_Transporte.Ubicacion_de_Medio_de_Transporte_Datos_Generales>(false, null);
            }
        }


    }
}

