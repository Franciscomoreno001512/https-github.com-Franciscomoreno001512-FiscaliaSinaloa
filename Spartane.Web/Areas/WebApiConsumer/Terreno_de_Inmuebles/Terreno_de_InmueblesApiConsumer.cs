using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Terreno_de_Inmuebles;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Terreno_de_Inmuebles
{
    public class Terreno_de_InmueblesApiConsumer : BaseApiConsumer,ITerreno_de_InmueblesApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Terreno_de_InmueblesApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Terreno_de_Inmuebles";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles> GetByKey(short Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles>(false, null);
            }
        }

        public ApiResponse<Terreno_de_InmueblesPagingModel> GetByKeyComplete(short Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Terreno_de_Inmuebles.Terreno_de_InmueblesPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Terreno_de_Inmuebles.Clave='" + Key.ToString() + "'"
                        + "&Order=Terreno_de_Inmuebles.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Terreno_de_Inmuebles.Terreno_de_InmueblesPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Terreno_de_Inmuebles.Terreno_de_InmueblesPagingModel>(false, new Terreno_de_InmueblesPagingModel() { Terreno_de_Inmuebless = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(short Key, Core.Domain.User.GlobalData Terreno_de_InmueblesInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<short> Insert(Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles entity, Core.Domain.User.GlobalData Terreno_de_InmueblesInformation, DataLayerFieldsBitacora DataReference)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<short>(baseApi, ApiControllerUrl + "/Post",
                      Method.POST, ApiHeader, entity);

                return new ApiResponse<short>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<short>(false, -1 );
            }
        }

        public ApiResponse<short> Update(Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles entity, Core.Domain.User.GlobalData Terreno_de_InmueblesInformation, DataLayerFieldsBitacora DataReference)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<short>(baseApi, ApiControllerUrl + "/Put?Id=" + entity.Clave,
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<short>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<short>(false, -1 );
            }
        }

        public ApiResponse<IList<Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Terreno_de_InmueblesPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Terreno_de_Inmuebles.Terreno_de_InmueblesPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Terreno_de_Inmuebles.Terreno_de_InmueblesPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Terreno_de_Inmuebles.Terreno_de_InmueblesPagingModel>(false, new Terreno_de_InmueblesPagingModel() { Terreno_de_Inmuebless = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<short> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<short>(baseApi, ApiControllerUrl + "/Terreno_de_InmueblesGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<short>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<short>(false, -1 );
            }
        }
		
public ApiResponse<short> Update_Datos_Generales(Terreno_de_Inmuebles_Datos_Generales entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<short>(baseApi, ApiControllerUrl + "/Put_Datos_Generales",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<short>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<short>(false, -1 );
            }
        }

        public ApiResponse<Terreno_de_Inmuebles_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Terreno_de_Inmuebles.Terreno_de_Inmuebles_Datos_Generales>(false, null);
            }
        }


    }
}

