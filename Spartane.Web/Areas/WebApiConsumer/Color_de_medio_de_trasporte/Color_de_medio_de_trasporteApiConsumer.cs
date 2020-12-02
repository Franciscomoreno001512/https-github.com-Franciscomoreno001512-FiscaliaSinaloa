using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Color_de_medio_de_trasporte;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Color_de_medio_de_trasporte
{
    public class Color_de_medio_de_trasporteApiConsumer : BaseApiConsumer,IColor_de_medio_de_trasporteApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Color_de_medio_de_trasporteApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Color_de_medio_de_trasporte";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte> GetByKey(short Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte>(false, null);
            }
        }

        public ApiResponse<Color_de_medio_de_trasportePagingModel> GetByKeyComplete(short Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasportePagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Color_de_medio_de_trasporte.Clave='" + Key.ToString() + "'"
                        + "&Order=Color_de_medio_de_trasporte.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasportePagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasportePagingModel>(false, new Color_de_medio_de_trasportePagingModel() { Color_de_medio_de_trasportes = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(short Key, Core.Domain.User.GlobalData Color_de_medio_de_trasporteInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<short> Insert(Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte entity, Core.Domain.User.GlobalData Color_de_medio_de_trasporteInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<short> Update(Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte entity, Core.Domain.User.GlobalData Color_de_medio_de_trasporteInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Color_de_medio_de_trasportePagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasportePagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasportePagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasportePagingModel>(false, new Color_de_medio_de_trasportePagingModel() { Color_de_medio_de_trasportes = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<short> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<short>(baseApi, ApiControllerUrl + "/Color_de_medio_de_trasporteGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<short>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<short>(false, -1 );
            }
        }
		
public ApiResponse<short> Update_Datos_Generales(Color_de_medio_de_trasporte_Datos_Generales entity)
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

        public ApiResponse<Color_de_medio_de_trasporte_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte_Datos_Generales>(false, null);
            }
        }


    }
}

