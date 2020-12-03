using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Detalle_Aseguramiento_Inmuebles;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Detalle_Aseguramiento_Inmuebles
{
    public class Detalle_Aseguramiento_InmueblesApiConsumer : BaseApiConsumer,IDetalle_Aseguramiento_InmueblesApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Detalle_Aseguramiento_InmueblesApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Detalle_Aseguramiento_Inmuebles";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Detalle_Aseguramiento_Inmuebles.Detalle_Aseguramiento_Inmuebles>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Detalle_Aseguramiento_Inmuebles.Detalle_Aseguramiento_Inmuebles>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Detalle_Aseguramiento_Inmuebles.Detalle_Aseguramiento_Inmuebles>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Detalle_Aseguramiento_Inmuebles.Detalle_Aseguramiento_Inmuebles>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Detalle_Aseguramiento_Inmuebles.Detalle_Aseguramiento_Inmuebles>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Detalle_Aseguramiento_Inmuebles.Detalle_Aseguramiento_Inmuebles>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Detalle_Aseguramiento_Inmuebles.Detalle_Aseguramiento_Inmuebles>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Detalle_Aseguramiento_Inmuebles.Detalle_Aseguramiento_Inmuebles>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Detalle_Aseguramiento_Inmuebles.Detalle_Aseguramiento_Inmuebles> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Detalle_Aseguramiento_Inmuebles.Detalle_Aseguramiento_Inmuebles>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Detalle_Aseguramiento_Inmuebles.Detalle_Aseguramiento_Inmuebles>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Detalle_Aseguramiento_Inmuebles.Detalle_Aseguramiento_Inmuebles>(false, null);
            }
        }

        public ApiResponse<Detalle_Aseguramiento_InmueblesPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Detalle_Aseguramiento_Inmuebles.Detalle_Aseguramiento_InmueblesPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Detalle_Aseguramiento_Inmuebles.Clave='" + Key.ToString() + "'"
                        + "&Order=Detalle_Aseguramiento_Inmuebles.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Detalle_Aseguramiento_Inmuebles.Detalle_Aseguramiento_InmueblesPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Detalle_Aseguramiento_Inmuebles.Detalle_Aseguramiento_InmueblesPagingModel>(false, new Detalle_Aseguramiento_InmueblesPagingModel() { Detalle_Aseguramiento_Inmuebless = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Detalle_Aseguramiento_InmueblesInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Detalle_Aseguramiento_Inmuebles.Detalle_Aseguramiento_Inmuebles entity, Core.Domain.User.GlobalData Detalle_Aseguramiento_InmueblesInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Detalle_Aseguramiento_Inmuebles.Detalle_Aseguramiento_Inmuebles entity, Core.Domain.User.GlobalData Detalle_Aseguramiento_InmueblesInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Detalle_Aseguramiento_Inmuebles.Detalle_Aseguramiento_Inmuebles>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Detalle_Aseguramiento_Inmuebles.Detalle_Aseguramiento_Inmuebles>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Detalle_Aseguramiento_Inmuebles.Detalle_Aseguramiento_Inmuebles>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Detalle_Aseguramiento_InmueblesPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Detalle_Aseguramiento_Inmuebles.Detalle_Aseguramiento_InmueblesPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Detalle_Aseguramiento_Inmuebles.Detalle_Aseguramiento_InmueblesPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Detalle_Aseguramiento_Inmuebles.Detalle_Aseguramiento_InmueblesPagingModel>(false, new Detalle_Aseguramiento_InmueblesPagingModel() { Detalle_Aseguramiento_Inmuebless = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Detalle_Aseguramiento_Inmuebles.Detalle_Aseguramiento_Inmuebles>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Detalle_Aseguramiento_InmueblesGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Detalle_Aseguramiento_Inmuebles_Datos_Generales entity)
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

        public ApiResponse<Detalle_Aseguramiento_Inmuebles_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Detalle_Aseguramiento_Inmuebles.Detalle_Aseguramiento_Inmuebles_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Detalle_Aseguramiento_Inmuebles.Detalle_Aseguramiento_Inmuebles_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Detalle_Aseguramiento_Inmuebles.Detalle_Aseguramiento_Inmuebles_Datos_Generales>(false, null);
            }
        }


    }
}

