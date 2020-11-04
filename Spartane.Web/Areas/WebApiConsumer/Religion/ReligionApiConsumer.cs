using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Religion;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Religion
{
    public class ReligionApiConsumer : BaseApiConsumer,IReligionApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public ReligionApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Religion";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Religion.Religion>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Religion.Religion>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Religion.Religion>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Religion.Religion>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Religion.Religion>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Religion.Religion>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Religion.Religion>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Religion.Religion>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Religion.Religion> GetByKey(short Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Religion.Religion>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Religion.Religion>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Religion.Religion>(false, null);
            }
        }

        public ApiResponse<ReligionPagingModel> GetByKeyComplete(short Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Religion.ReligionPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Religion.Clave='" + Key.ToString() + "'"
                        + "&Order=Religion.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Religion.ReligionPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Religion.ReligionPagingModel>(false, new ReligionPagingModel() { Religions = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(short Key, Core.Domain.User.GlobalData ReligionInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<short> Insert(Core.Domain.Religion.Religion entity, Core.Domain.User.GlobalData ReligionInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<short> Update(Core.Domain.Religion.Religion entity, Core.Domain.User.GlobalData ReligionInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Religion.Religion>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Religion.Religion>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Religion.Religion>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<ReligionPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Religion.ReligionPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Religion.ReligionPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Religion.ReligionPagingModel>(false, new ReligionPagingModel() { Religions = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Religion.Religion>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<short> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<short>(baseApi, ApiControllerUrl + "/ReligionGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<short>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<short>(false, -1 );
            }
        }
		
public ApiResponse<short> Update_Datos_Generales(Religion_Datos_Generales entity)
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

        public ApiResponse<Religion_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Religion.Religion_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Religion.Religion_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Religion.Religion_Datos_Generales>(false, null);
            }
        }


    }
}

