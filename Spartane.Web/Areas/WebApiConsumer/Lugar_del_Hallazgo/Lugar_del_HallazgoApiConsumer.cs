using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Lugar_del_Hallazgo;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Lugar_del_Hallazgo
{
    public class Lugar_del_HallazgoApiConsumer : BaseApiConsumer,ILugar_del_HallazgoApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Lugar_del_HallazgoApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Lugar_del_Hallazgo";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo>(false, null);
            }
        }

        public ApiResponse<Lugar_del_HallazgoPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Lugar_del_Hallazgo.Lugar_del_HallazgoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Lugar_del_Hallazgo.Clave='" + Key.ToString() + "'"
                        + "&Order=Lugar_del_Hallazgo.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Lugar_del_Hallazgo.Lugar_del_HallazgoPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Lugar_del_Hallazgo.Lugar_del_HallazgoPagingModel>(false, new Lugar_del_HallazgoPagingModel() { Lugar_del_Hallazgos = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Lugar_del_HallazgoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo entity, Core.Domain.User.GlobalData Lugar_del_HallazgoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo entity, Core.Domain.User.GlobalData Lugar_del_HallazgoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Lugar_del_HallazgoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Lugar_del_Hallazgo.Lugar_del_HallazgoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Lugar_del_Hallazgo.Lugar_del_HallazgoPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Lugar_del_Hallazgo.Lugar_del_HallazgoPagingModel>(false, new Lugar_del_HallazgoPagingModel() { Lugar_del_Hallazgos = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Lugar_del_HallazgoGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Lugar_del_Hallazgo_Datos_Generales entity)
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

        public ApiResponse<Lugar_del_Hallazgo_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Lugar_del_Hallazgo.Lugar_del_Hallazgo_Datos_Generales>(false, null);
            }
        }


    }
}

