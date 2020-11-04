using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Spartan_Object_ByPass;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Spartan_Object_ByPass
{
    public class Spartan_Object_ByPassApiConsumer : BaseApiConsumer,ISpartan_Object_ByPassApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Spartan_Object_ByPassApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Spartan_Object_ByPass";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass>(false, null);
            }
        }

        public ApiResponse<Spartan_Object_ByPassPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPassPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Spartan_Object_ByPass.ObjectId='" + Key.ToString() + "'"
                        + "&Order=Spartan_Object_ByPass.ObjectId ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPassPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPassPagingModel>(false, new Spartan_Object_ByPassPagingModel() { Spartan_Object_ByPasss = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Spartan_Object_ByPassInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass entity, Core.Domain.User.GlobalData Spartan_Object_ByPassInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass entity, Core.Domain.User.GlobalData Spartan_Object_ByPassInformation, DataLayerFieldsBitacora DataReference)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put?Id=" + entity.ObjectId,
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<IList<Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Spartan_Object_ByPassPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPassPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPassPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPassPagingModel>(false, new Spartan_Object_ByPassPagingModel() { Spartan_Object_ByPasss = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Spartan_Object_ByPassGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Spartan_Object_ByPass_Datos_Generales entity)
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

        public ApiResponse<Spartan_Object_ByPass_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass_Datos_Generales>(false, null);
            }
        }


    }
}

