using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Contestacion_de_Portal_Ciudadano;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Contestacion_de_Portal_Ciudadano
{
    public class Contestacion_de_Portal_CiudadanoApiConsumer : BaseApiConsumer,IContestacion_de_Portal_CiudadanoApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Contestacion_de_Portal_CiudadanoApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Contestacion_de_Portal_Ciudadano";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_Ciudadano>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_Ciudadano>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_Ciudadano>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_Ciudadano>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_Ciudadano>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_Ciudadano>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_Ciudadano>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_Ciudadano>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_Ciudadano> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_Ciudadano>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_Ciudadano>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_Ciudadano>(false, null);
            }
        }

        public ApiResponse<Contestacion_de_Portal_CiudadanoPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_CiudadanoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Contestacion_de_Portal_Ciudadano.Clave='" + Key.ToString() + "'"
                        + "&Order=Contestacion_de_Portal_Ciudadano.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_CiudadanoPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_CiudadanoPagingModel>(false, new Contestacion_de_Portal_CiudadanoPagingModel() { Contestacion_de_Portal_Ciudadanos = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Contestacion_de_Portal_CiudadanoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_Ciudadano entity, Core.Domain.User.GlobalData Contestacion_de_Portal_CiudadanoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_Ciudadano entity, Core.Domain.User.GlobalData Contestacion_de_Portal_CiudadanoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_Ciudadano>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_Ciudadano>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_Ciudadano>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Contestacion_de_Portal_CiudadanoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_CiudadanoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_CiudadanoPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_CiudadanoPagingModel>(false, new Contestacion_de_Portal_CiudadanoPagingModel() { Contestacion_de_Portal_Ciudadanos = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_Ciudadano>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Contestacion_de_Portal_CiudadanoGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Contestacion_de_Portal_Ciudadano_Datos_Generales entity)
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

        public ApiResponse<Contestacion_de_Portal_Ciudadano_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_Ciudadano_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_Ciudadano_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Contestacion_de_Portal_Ciudadano.Contestacion_de_Portal_Ciudadano_Datos_Generales>(false, null);
            }
        }


    }
}

