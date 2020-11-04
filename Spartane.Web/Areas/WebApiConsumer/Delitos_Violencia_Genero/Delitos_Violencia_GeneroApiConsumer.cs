using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Delitos_Violencia_Genero;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Delitos_Violencia_Genero
{
    public class Delitos_Violencia_GeneroApiConsumer : BaseApiConsumer,IDelitos_Violencia_GeneroApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Delitos_Violencia_GeneroApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Delitos_Violencia_Genero";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_Genero>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_Genero>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_Genero>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_Genero>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_Genero>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_Genero>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_Genero>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_Genero>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_Genero> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_Genero>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_Genero>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_Genero>(false, null);
            }
        }

        public ApiResponse<Delitos_Violencia_GeneroPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_GeneroPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Delitos_Violencia_Genero.Clave='" + Key.ToString() + "'"
                        + "&Order=Delitos_Violencia_Genero.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_GeneroPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_GeneroPagingModel>(false, new Delitos_Violencia_GeneroPagingModel() { Delitos_Violencia_Generos = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Delitos_Violencia_GeneroInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_Genero entity, Core.Domain.User.GlobalData Delitos_Violencia_GeneroInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_Genero entity, Core.Domain.User.GlobalData Delitos_Violencia_GeneroInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_Genero>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_Genero>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_Genero>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Delitos_Violencia_GeneroPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_GeneroPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_GeneroPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_GeneroPagingModel>(false, new Delitos_Violencia_GeneroPagingModel() { Delitos_Violencia_Generos = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_Genero>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Delitos_Violencia_GeneroGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Delitos_Violencia_Genero_Datos_Generales entity)
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

        public ApiResponse<Delitos_Violencia_Genero_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_Genero_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_Genero_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Delitos_Violencia_Genero.Delitos_Violencia_Genero_Datos_Generales>(false, null);
            }
        }


    }
}

