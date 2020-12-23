using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Solicitud_de_Denuncia_Ciudadana;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Solicitud_de_Denuncia_Ciudadana
{
    public class Solicitud_de_Denuncia_CiudadanaApiConsumer : BaseApiConsumer,ISolicitud_de_Denuncia_CiudadanaApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Solicitud_de_Denuncia_CiudadanaApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Solicitud_de_Denuncia_Ciudadana";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_Ciudadana>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_Ciudadana>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_Ciudadana>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_Ciudadana>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_Ciudadana>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_Ciudadana>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_Ciudadana>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_Ciudadana>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_Ciudadana> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_Ciudadana>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_Ciudadana>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_Ciudadana>(false, null);
            }
        }

        public ApiResponse<Solicitud_de_Denuncia_CiudadanaPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_CiudadanaPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Solicitud_de_Denuncia_Ciudadana.Clave='" + Key.ToString() + "'"
                        + "&Order=Solicitud_de_Denuncia_Ciudadana.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_CiudadanaPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_CiudadanaPagingModel>(false, new Solicitud_de_Denuncia_CiudadanaPagingModel() { Solicitud_de_Denuncia_Ciudadanas = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Solicitud_de_Denuncia_CiudadanaInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_Ciudadana entity, Core.Domain.User.GlobalData Solicitud_de_Denuncia_CiudadanaInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_Ciudadana entity, Core.Domain.User.GlobalData Solicitud_de_Denuncia_CiudadanaInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_Ciudadana>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_Ciudadana>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_Ciudadana>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Solicitud_de_Denuncia_CiudadanaPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_CiudadanaPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_CiudadanaPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_CiudadanaPagingModel>(false, new Solicitud_de_Denuncia_CiudadanaPagingModel() { Solicitud_de_Denuncia_Ciudadanas = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_Ciudadana>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Solicitud_de_Denuncia_CiudadanaGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_de_la_Solicitud(Solicitud_de_Denuncia_Ciudadana_Datos_de_la_Solicitud entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Datos_de_la_Solicitud",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Solicitud_de_Denuncia_Ciudadana_Datos_de_la_Solicitud> Get_Datos_de_la_Solicitud(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_Ciudadana_Datos_de_la_Solicitud>(baseApi, ApiControllerUrl + "/Get_Datos_de_la_Solicitud?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_Ciudadana_Datos_de_la_Solicitud>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_Ciudadana_Datos_de_la_Solicitud>(false, null);
            }
        }

public ApiResponse<int> Update_Canalizar(Solicitud_de_Denuncia_Ciudadana_Canalizar entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Canalizar",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Solicitud_de_Denuncia_Ciudadana_Canalizar> Get_Canalizar(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_Ciudadana_Canalizar>(baseApi, ApiControllerUrl + "/Get_Canalizar?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_Ciudadana_Canalizar>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Solicitud_de_Denuncia_Ciudadana.Solicitud_de_Denuncia_Ciudadana_Canalizar>(false, null);
            }
        }


    }
}

