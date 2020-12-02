using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Aparato_Electronicos_y_Multimedia;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Aparato_Electronicos_y_Multimedia
{
    public class Aparato_Electronicos_y_MultimediaApiConsumer : BaseApiConsumer,IAparato_Electronicos_y_MultimediaApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Aparato_Electronicos_y_MultimediaApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Aparato_Electronicos_y_Multimedia";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_Multimedia>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_Multimedia>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_Multimedia>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_Multimedia>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_Multimedia>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_Multimedia>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_Multimedia>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_Multimedia>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_Multimedia> GetByKey(short Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_Multimedia>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_Multimedia>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_Multimedia>(false, null);
            }
        }

        public ApiResponse<Aparato_Electronicos_y_MultimediaPagingModel> GetByKeyComplete(short Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_MultimediaPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Aparato_Electronicos_y_Multimedia.Clave='" + Key.ToString() + "'"
                        + "&Order=Aparato_Electronicos_y_Multimedia.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_MultimediaPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_MultimediaPagingModel>(false, new Aparato_Electronicos_y_MultimediaPagingModel() { Aparato_Electronicos_y_Multimedias = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(short Key, Core.Domain.User.GlobalData Aparato_Electronicos_y_MultimediaInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<short> Insert(Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_Multimedia entity, Core.Domain.User.GlobalData Aparato_Electronicos_y_MultimediaInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<short> Update(Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_Multimedia entity, Core.Domain.User.GlobalData Aparato_Electronicos_y_MultimediaInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_Multimedia>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_Multimedia>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_Multimedia>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Aparato_Electronicos_y_MultimediaPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_MultimediaPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_MultimediaPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_MultimediaPagingModel>(false, new Aparato_Electronicos_y_MultimediaPagingModel() { Aparato_Electronicos_y_Multimedias = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_Multimedia>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<short> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<short>(baseApi, ApiControllerUrl + "/Aparato_Electronicos_y_MultimediaGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<short>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<short>(false, -1 );
            }
        }
		
public ApiResponse<short> Update_Datos_Generales(Aparato_Electronicos_y_Multimedia_Datos_Generales entity)
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

        public ApiResponse<Aparato_Electronicos_y_Multimedia_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_Multimedia_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_Multimedia_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_Multimedia_Datos_Generales>(false, null);
            }
        }


    }
}

