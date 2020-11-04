using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Catalogo_de_Inicio_de_Cadena_de_Custodia;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Catalogo_de_Inicio_de_Cadena_de_Custodia
{
    public class Catalogo_de_Inicio_de_Cadena_de_CustodiaApiConsumer : BaseApiConsumer,ICatalogo_de_Inicio_de_Cadena_de_CustodiaApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Catalogo_de_Inicio_de_Cadena_de_CustodiaApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Catalogo_de_Inicio_de_Cadena_de_Custodia";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Catalogo_de_Inicio_de_Cadena_de_Custodia.Catalogo_de_Inicio_de_Cadena_de_Custodia>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Catalogo_de_Inicio_de_Cadena_de_Custodia.Catalogo_de_Inicio_de_Cadena_de_Custodia>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Catalogo_de_Inicio_de_Cadena_de_Custodia.Catalogo_de_Inicio_de_Cadena_de_Custodia>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Catalogo_de_Inicio_de_Cadena_de_Custodia.Catalogo_de_Inicio_de_Cadena_de_Custodia>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Catalogo_de_Inicio_de_Cadena_de_Custodia.Catalogo_de_Inicio_de_Cadena_de_Custodia>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Catalogo_de_Inicio_de_Cadena_de_Custodia.Catalogo_de_Inicio_de_Cadena_de_Custodia>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Catalogo_de_Inicio_de_Cadena_de_Custodia.Catalogo_de_Inicio_de_Cadena_de_Custodia>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Catalogo_de_Inicio_de_Cadena_de_Custodia.Catalogo_de_Inicio_de_Cadena_de_Custodia>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Catalogo_de_Inicio_de_Cadena_de_Custodia.Catalogo_de_Inicio_de_Cadena_de_Custodia> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Catalogo_de_Inicio_de_Cadena_de_Custodia.Catalogo_de_Inicio_de_Cadena_de_Custodia>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Catalogo_de_Inicio_de_Cadena_de_Custodia.Catalogo_de_Inicio_de_Cadena_de_Custodia>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Catalogo_de_Inicio_de_Cadena_de_Custodia.Catalogo_de_Inicio_de_Cadena_de_Custodia>(false, null);
            }
        }

        public ApiResponse<Catalogo_de_Inicio_de_Cadena_de_CustodiaPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Catalogo_de_Inicio_de_Cadena_de_Custodia.Catalogo_de_Inicio_de_Cadena_de_CustodiaPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Catalogo_de_Inicio_de_Cadena_de_Custodia.Clave='" + Key.ToString() + "'"
                        + "&Order=Catalogo_de_Inicio_de_Cadena_de_Custodia.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Catalogo_de_Inicio_de_Cadena_de_Custodia.Catalogo_de_Inicio_de_Cadena_de_CustodiaPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Catalogo_de_Inicio_de_Cadena_de_Custodia.Catalogo_de_Inicio_de_Cadena_de_CustodiaPagingModel>(false, new Catalogo_de_Inicio_de_Cadena_de_CustodiaPagingModel() { Catalogo_de_Inicio_de_Cadena_de_Custodias = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Catalogo_de_Inicio_de_Cadena_de_CustodiaInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Catalogo_de_Inicio_de_Cadena_de_Custodia.Catalogo_de_Inicio_de_Cadena_de_Custodia entity, Core.Domain.User.GlobalData Catalogo_de_Inicio_de_Cadena_de_CustodiaInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Catalogo_de_Inicio_de_Cadena_de_Custodia.Catalogo_de_Inicio_de_Cadena_de_Custodia entity, Core.Domain.User.GlobalData Catalogo_de_Inicio_de_Cadena_de_CustodiaInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Catalogo_de_Inicio_de_Cadena_de_Custodia.Catalogo_de_Inicio_de_Cadena_de_Custodia>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Catalogo_de_Inicio_de_Cadena_de_Custodia.Catalogo_de_Inicio_de_Cadena_de_Custodia>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Catalogo_de_Inicio_de_Cadena_de_Custodia.Catalogo_de_Inicio_de_Cadena_de_Custodia>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Catalogo_de_Inicio_de_Cadena_de_CustodiaPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Catalogo_de_Inicio_de_Cadena_de_Custodia.Catalogo_de_Inicio_de_Cadena_de_CustodiaPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Catalogo_de_Inicio_de_Cadena_de_Custodia.Catalogo_de_Inicio_de_Cadena_de_CustodiaPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Catalogo_de_Inicio_de_Cadena_de_Custodia.Catalogo_de_Inicio_de_Cadena_de_CustodiaPagingModel>(false, new Catalogo_de_Inicio_de_Cadena_de_CustodiaPagingModel() { Catalogo_de_Inicio_de_Cadena_de_Custodias = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Catalogo_de_Inicio_de_Cadena_de_Custodia.Catalogo_de_Inicio_de_Cadena_de_Custodia>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Catalogo_de_Inicio_de_Cadena_de_CustodiaGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Catalogo_de_Inicio_de_Cadena_de_Custodia_Datos_Generales entity)
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

        public ApiResponse<Catalogo_de_Inicio_de_Cadena_de_Custodia_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Catalogo_de_Inicio_de_Cadena_de_Custodia.Catalogo_de_Inicio_de_Cadena_de_Custodia_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Catalogo_de_Inicio_de_Cadena_de_Custodia.Catalogo_de_Inicio_de_Cadena_de_Custodia_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Catalogo_de_Inicio_de_Cadena_de_Custodia.Catalogo_de_Inicio_de_Cadena_de_Custodia_Datos_Generales>(false, null);
            }
        }


    }
}

