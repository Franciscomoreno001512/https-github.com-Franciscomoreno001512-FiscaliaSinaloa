using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Clasificacion_de_Artefacto_y_Explosivo
{
    public class Clasificacion_de_Artefacto_y_ExplosivoApiConsumer : BaseApiConsumer,IClasificacion_de_Artefacto_y_ExplosivoApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Clasificacion_de_Artefacto_y_ExplosivoApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Clasificacion_de_Artefacto_y_Explosivo";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo> GetByKey(short Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo>(false, null);
            }
        }

        public ApiResponse<Clasificacion_de_Artefacto_y_ExplosivoPagingModel> GetByKeyComplete(short Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_ExplosivoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Clasificacion_de_Artefacto_y_Explosivo.Clave='" + Key.ToString() + "'"
                        + "&Order=Clasificacion_de_Artefacto_y_Explosivo.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_ExplosivoPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_ExplosivoPagingModel>(false, new Clasificacion_de_Artefacto_y_ExplosivoPagingModel() { Clasificacion_de_Artefacto_y_Explosivos = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(short Key, Core.Domain.User.GlobalData Clasificacion_de_Artefacto_y_ExplosivoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<short> Insert(Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo entity, Core.Domain.User.GlobalData Clasificacion_de_Artefacto_y_ExplosivoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<short> Update(Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo entity, Core.Domain.User.GlobalData Clasificacion_de_Artefacto_y_ExplosivoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Clasificacion_de_Artefacto_y_ExplosivoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_ExplosivoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_ExplosivoPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_ExplosivoPagingModel>(false, new Clasificacion_de_Artefacto_y_ExplosivoPagingModel() { Clasificacion_de_Artefacto_y_Explosivos = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<short> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<short>(baseApi, ApiControllerUrl + "/Clasificacion_de_Artefacto_y_ExplosivoGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<short>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<short>(false, -1 );
            }
        }
		
public ApiResponse<short> Update_Datos_Generales(Clasificacion_de_Artefacto_y_Explosivo_Datos_Generales entity)
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

        public ApiResponse<Clasificacion_de_Artefacto_y_Explosivo_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo_Datos_Generales>(false, null);
            }
        }


    }
}

