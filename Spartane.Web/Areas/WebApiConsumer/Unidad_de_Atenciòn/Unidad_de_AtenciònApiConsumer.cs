using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Unidad_de_Atenciòn;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Unidad_de_Atenciòn
{
    public class Unidad_de_AtenciònApiConsumer : BaseApiConsumer,IUnidad_de_AtenciònApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Unidad_de_AtenciònApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Unidad_de_Atenciòn";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn>(false, null);
            }
        }

        public ApiResponse<Unidad_de_AtenciònPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Unidad_de_Atenciòn.Unidad_de_AtenciònPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Unidad_de_Atenciòn.Clave='" + Key.ToString() + "'"
                        + "&Order=Unidad_de_Atenciòn.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Unidad_de_Atenciòn.Unidad_de_AtenciònPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Unidad_de_Atenciòn.Unidad_de_AtenciònPagingModel>(false, new Unidad_de_AtenciònPagingModel() { Unidad_de_Atenciòns = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Unidad_de_AtenciònInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn entity, Core.Domain.User.GlobalData Unidad_de_AtenciònInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn entity, Core.Domain.User.GlobalData Unidad_de_AtenciònInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Unidad_de_AtenciònPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Unidad_de_Atenciòn.Unidad_de_AtenciònPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Unidad_de_Atenciòn.Unidad_de_AtenciònPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Unidad_de_Atenciòn.Unidad_de_AtenciònPagingModel>(false, new Unidad_de_AtenciònPagingModel() { Unidad_de_Atenciòns = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Unidad_de_AtenciònGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Unidad_de_Atenciòn_Datos_Generales entity)
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

        public ApiResponse<Unidad_de_Atenciòn_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn_Datos_Generales>(false, null);
            }
        }


    }
}

