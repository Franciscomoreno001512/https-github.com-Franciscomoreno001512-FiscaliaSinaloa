using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Catalogo_Unidad_Administrativa_CC;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Catalogo_Unidad_Administrativa_CC
{
    public class Catalogo_Unidad_Administrativa_CCApiConsumer : BaseApiConsumer,ICatalogo_Unidad_Administrativa_CCApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Catalogo_Unidad_Administrativa_CCApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Catalogo_Unidad_Administrativa_CC";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Catalogo_Unidad_Administrativa_CC.Catalogo_Unidad_Administrativa_CC>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Catalogo_Unidad_Administrativa_CC.Catalogo_Unidad_Administrativa_CC>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Catalogo_Unidad_Administrativa_CC.Catalogo_Unidad_Administrativa_CC>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Catalogo_Unidad_Administrativa_CC.Catalogo_Unidad_Administrativa_CC>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Catalogo_Unidad_Administrativa_CC.Catalogo_Unidad_Administrativa_CC>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Catalogo_Unidad_Administrativa_CC.Catalogo_Unidad_Administrativa_CC>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Catalogo_Unidad_Administrativa_CC.Catalogo_Unidad_Administrativa_CC>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Catalogo_Unidad_Administrativa_CC.Catalogo_Unidad_Administrativa_CC>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Catalogo_Unidad_Administrativa_CC.Catalogo_Unidad_Administrativa_CC> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Catalogo_Unidad_Administrativa_CC.Catalogo_Unidad_Administrativa_CC>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Catalogo_Unidad_Administrativa_CC.Catalogo_Unidad_Administrativa_CC>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Catalogo_Unidad_Administrativa_CC.Catalogo_Unidad_Administrativa_CC>(false, null);
            }
        }

        public ApiResponse<Catalogo_Unidad_Administrativa_CCPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Catalogo_Unidad_Administrativa_CC.Catalogo_Unidad_Administrativa_CCPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Catalogo_Unidad_Administrativa_CC.Clave='" + Key.ToString() + "'"
                        + "&Order=Catalogo_Unidad_Administrativa_CC.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Catalogo_Unidad_Administrativa_CC.Catalogo_Unidad_Administrativa_CCPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Catalogo_Unidad_Administrativa_CC.Catalogo_Unidad_Administrativa_CCPagingModel>(false, new Catalogo_Unidad_Administrativa_CCPagingModel() { Catalogo_Unidad_Administrativa_CCs = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Catalogo_Unidad_Administrativa_CCInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Catalogo_Unidad_Administrativa_CC.Catalogo_Unidad_Administrativa_CC entity, Core.Domain.User.GlobalData Catalogo_Unidad_Administrativa_CCInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Catalogo_Unidad_Administrativa_CC.Catalogo_Unidad_Administrativa_CC entity, Core.Domain.User.GlobalData Catalogo_Unidad_Administrativa_CCInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Catalogo_Unidad_Administrativa_CC.Catalogo_Unidad_Administrativa_CC>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Catalogo_Unidad_Administrativa_CC.Catalogo_Unidad_Administrativa_CC>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Catalogo_Unidad_Administrativa_CC.Catalogo_Unidad_Administrativa_CC>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Catalogo_Unidad_Administrativa_CCPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Catalogo_Unidad_Administrativa_CC.Catalogo_Unidad_Administrativa_CCPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Catalogo_Unidad_Administrativa_CC.Catalogo_Unidad_Administrativa_CCPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Catalogo_Unidad_Administrativa_CC.Catalogo_Unidad_Administrativa_CCPagingModel>(false, new Catalogo_Unidad_Administrativa_CCPagingModel() { Catalogo_Unidad_Administrativa_CCs = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Catalogo_Unidad_Administrativa_CC.Catalogo_Unidad_Administrativa_CC>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Catalogo_Unidad_Administrativa_CCGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Catalogo_Unidad_Administrativa_CC_Datos_Generales entity)
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

        public ApiResponse<Catalogo_Unidad_Administrativa_CC_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Catalogo_Unidad_Administrativa_CC.Catalogo_Unidad_Administrativa_CC_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Catalogo_Unidad_Administrativa_CC.Catalogo_Unidad_Administrativa_CC_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Catalogo_Unidad_Administrativa_CC.Catalogo_Unidad_Administrativa_CC_Datos_Generales>(false, null);
            }
        }


    }
}

