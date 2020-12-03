using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Detalle_Aseguramiento_de_Cargador_Cartuchos;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Detalle_Aseguramiento_de_Cargador_Cartuchos
{
    public class Detalle_Aseguramiento_de_Cargador_CartuchosApiConsumer : BaseApiConsumer,IDetalle_Aseguramiento_de_Cargador_CartuchosApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Detalle_Aseguramiento_de_Cargador_CartuchosApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Detalle_Aseguramiento_de_Cargador_Cartuchos";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Detalle_Aseguramiento_de_Cargador_Cartuchos.Detalle_Aseguramiento_de_Cargador_Cartuchos>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Detalle_Aseguramiento_de_Cargador_Cartuchos.Detalle_Aseguramiento_de_Cargador_Cartuchos>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Detalle_Aseguramiento_de_Cargador_Cartuchos.Detalle_Aseguramiento_de_Cargador_Cartuchos>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Detalle_Aseguramiento_de_Cargador_Cartuchos.Detalle_Aseguramiento_de_Cargador_Cartuchos>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Detalle_Aseguramiento_de_Cargador_Cartuchos.Detalle_Aseguramiento_de_Cargador_Cartuchos>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Detalle_Aseguramiento_de_Cargador_Cartuchos.Detalle_Aseguramiento_de_Cargador_Cartuchos>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Detalle_Aseguramiento_de_Cargador_Cartuchos.Detalle_Aseguramiento_de_Cargador_Cartuchos>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Detalle_Aseguramiento_de_Cargador_Cartuchos.Detalle_Aseguramiento_de_Cargador_Cartuchos>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Detalle_Aseguramiento_de_Cargador_Cartuchos.Detalle_Aseguramiento_de_Cargador_Cartuchos> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Detalle_Aseguramiento_de_Cargador_Cartuchos.Detalle_Aseguramiento_de_Cargador_Cartuchos>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Detalle_Aseguramiento_de_Cargador_Cartuchos.Detalle_Aseguramiento_de_Cargador_Cartuchos>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Detalle_Aseguramiento_de_Cargador_Cartuchos.Detalle_Aseguramiento_de_Cargador_Cartuchos>(false, null);
            }
        }

        public ApiResponse<Detalle_Aseguramiento_de_Cargador_CartuchosPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Detalle_Aseguramiento_de_Cargador_Cartuchos.Detalle_Aseguramiento_de_Cargador_CartuchosPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Detalle_Aseguramiento_de_Cargador_Cartuchos.Clave='" + Key.ToString() + "'"
                        + "&Order=Detalle_Aseguramiento_de_Cargador_Cartuchos.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Detalle_Aseguramiento_de_Cargador_Cartuchos.Detalle_Aseguramiento_de_Cargador_CartuchosPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Detalle_Aseguramiento_de_Cargador_Cartuchos.Detalle_Aseguramiento_de_Cargador_CartuchosPagingModel>(false, new Detalle_Aseguramiento_de_Cargador_CartuchosPagingModel() { Detalle_Aseguramiento_de_Cargador_Cartuchoss = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Detalle_Aseguramiento_de_Cargador_CartuchosInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Detalle_Aseguramiento_de_Cargador_Cartuchos.Detalle_Aseguramiento_de_Cargador_Cartuchos entity, Core.Domain.User.GlobalData Detalle_Aseguramiento_de_Cargador_CartuchosInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Detalle_Aseguramiento_de_Cargador_Cartuchos.Detalle_Aseguramiento_de_Cargador_Cartuchos entity, Core.Domain.User.GlobalData Detalle_Aseguramiento_de_Cargador_CartuchosInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Detalle_Aseguramiento_de_Cargador_Cartuchos.Detalle_Aseguramiento_de_Cargador_Cartuchos>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Detalle_Aseguramiento_de_Cargador_Cartuchos.Detalle_Aseguramiento_de_Cargador_Cartuchos>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Detalle_Aseguramiento_de_Cargador_Cartuchos.Detalle_Aseguramiento_de_Cargador_Cartuchos>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Detalle_Aseguramiento_de_Cargador_CartuchosPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Detalle_Aseguramiento_de_Cargador_Cartuchos.Detalle_Aseguramiento_de_Cargador_CartuchosPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Detalle_Aseguramiento_de_Cargador_Cartuchos.Detalle_Aseguramiento_de_Cargador_CartuchosPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Detalle_Aseguramiento_de_Cargador_Cartuchos.Detalle_Aseguramiento_de_Cargador_CartuchosPagingModel>(false, new Detalle_Aseguramiento_de_Cargador_CartuchosPagingModel() { Detalle_Aseguramiento_de_Cargador_Cartuchoss = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Detalle_Aseguramiento_de_Cargador_Cartuchos.Detalle_Aseguramiento_de_Cargador_Cartuchos>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Detalle_Aseguramiento_de_Cargador_CartuchosGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Detalle_Aseguramiento_de_Cargador_Cartuchos_Datos_Generales entity)
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

        public ApiResponse<Detalle_Aseguramiento_de_Cargador_Cartuchos_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Detalle_Aseguramiento_de_Cargador_Cartuchos.Detalle_Aseguramiento_de_Cargador_Cartuchos_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Detalle_Aseguramiento_de_Cargador_Cartuchos.Detalle_Aseguramiento_de_Cargador_Cartuchos_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Detalle_Aseguramiento_de_Cargador_Cartuchos.Detalle_Aseguramiento_de_Cargador_Cartuchos_Datos_Generales>(false, null);
            }
        }


    }
}

