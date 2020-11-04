using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Detalle_Requerido_Acuerdo;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Detalle_Requerido_Acuerdo
{
    public class Detalle_Requerido_AcuerdoApiConsumer : BaseApiConsumer,IDetalle_Requerido_AcuerdoApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Detalle_Requerido_AcuerdoApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Detalle_Requerido_Acuerdo";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Detalle_Requerido_Acuerdo.Detalle_Requerido_Acuerdo>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Detalle_Requerido_Acuerdo.Detalle_Requerido_Acuerdo>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Detalle_Requerido_Acuerdo.Detalle_Requerido_Acuerdo>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Detalle_Requerido_Acuerdo.Detalle_Requerido_Acuerdo>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Detalle_Requerido_Acuerdo.Detalle_Requerido_Acuerdo>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Detalle_Requerido_Acuerdo.Detalle_Requerido_Acuerdo>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Detalle_Requerido_Acuerdo.Detalle_Requerido_Acuerdo>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Detalle_Requerido_Acuerdo.Detalle_Requerido_Acuerdo>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Detalle_Requerido_Acuerdo.Detalle_Requerido_Acuerdo> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Detalle_Requerido_Acuerdo.Detalle_Requerido_Acuerdo>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Detalle_Requerido_Acuerdo.Detalle_Requerido_Acuerdo>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Detalle_Requerido_Acuerdo.Detalle_Requerido_Acuerdo>(false, null);
            }
        }

        public ApiResponse<Detalle_Requerido_AcuerdoPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Detalle_Requerido_Acuerdo.Detalle_Requerido_AcuerdoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Detalle_Requerido_Acuerdo.Folio='" + Key.ToString() + "'"
                        + "&Order=Detalle_Requerido_Acuerdo.Folio ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Detalle_Requerido_Acuerdo.Detalle_Requerido_AcuerdoPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Detalle_Requerido_Acuerdo.Detalle_Requerido_AcuerdoPagingModel>(false, new Detalle_Requerido_AcuerdoPagingModel() { Detalle_Requerido_Acuerdos = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Detalle_Requerido_AcuerdoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Detalle_Requerido_Acuerdo.Detalle_Requerido_Acuerdo entity, Core.Domain.User.GlobalData Detalle_Requerido_AcuerdoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Detalle_Requerido_Acuerdo.Detalle_Requerido_Acuerdo entity, Core.Domain.User.GlobalData Detalle_Requerido_AcuerdoInformation, DataLayerFieldsBitacora DataReference)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put?Id=" + entity.Folio,
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<IList<Core.Domain.Detalle_Requerido_Acuerdo.Detalle_Requerido_Acuerdo>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Detalle_Requerido_Acuerdo.Detalle_Requerido_Acuerdo>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Detalle_Requerido_Acuerdo.Detalle_Requerido_Acuerdo>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Detalle_Requerido_AcuerdoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Detalle_Requerido_Acuerdo.Detalle_Requerido_AcuerdoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Detalle_Requerido_Acuerdo.Detalle_Requerido_AcuerdoPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Detalle_Requerido_Acuerdo.Detalle_Requerido_AcuerdoPagingModel>(false, new Detalle_Requerido_AcuerdoPagingModel() { Detalle_Requerido_Acuerdos = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Detalle_Requerido_Acuerdo.Detalle_Requerido_Acuerdo>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Detalle_Requerido_AcuerdoGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Detalle_Requerido_Acuerdo_Datos_Generales entity)
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

        public ApiResponse<Detalle_Requerido_Acuerdo_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Detalle_Requerido_Acuerdo.Detalle_Requerido_Acuerdo_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Detalle_Requerido_Acuerdo.Detalle_Requerido_Acuerdo_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Detalle_Requerido_Acuerdo.Detalle_Requerido_Acuerdo_Datos_Generales>(false, null);
            }
        }


    }
}

