using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Datos_Personales_Adicionales_Involucrado;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Datos_Personales_Adicionales_Involucrado
{
    public class Datos_Personales_Adicionales_InvolucradoApiConsumer : BaseApiConsumer,IDatos_Personales_Adicionales_InvolucradoApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Datos_Personales_Adicionales_InvolucradoApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Datos_Personales_Adicionales_Involucrado";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_Involucrado>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_Involucrado>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_Involucrado>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_Involucrado>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_Involucrado>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_Involucrado>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_Involucrado>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_Involucrado>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_Involucrado> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_Involucrado>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_Involucrado>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_Involucrado>(false, null);
            }
        }

        public ApiResponse<Datos_Personales_Adicionales_InvolucradoPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_InvolucradoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Datos_Personales_Adicionales_Involucrado.Clave='" + Key.ToString() + "'"
                        + "&Order=Datos_Personales_Adicionales_Involucrado.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_InvolucradoPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_InvolucradoPagingModel>(false, new Datos_Personales_Adicionales_InvolucradoPagingModel() { Datos_Personales_Adicionales_Involucrados = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Datos_Personales_Adicionales_InvolucradoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_Involucrado entity, Core.Domain.User.GlobalData Datos_Personales_Adicionales_InvolucradoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_Involucrado entity, Core.Domain.User.GlobalData Datos_Personales_Adicionales_InvolucradoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_Involucrado>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_Involucrado>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_Involucrado>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Datos_Personales_Adicionales_InvolucradoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_InvolucradoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_InvolucradoPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_InvolucradoPagingModel>(false, new Datos_Personales_Adicionales_InvolucradoPagingModel() { Datos_Personales_Adicionales_Involucrados = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_Involucrado>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Datos_Personales_Adicionales_InvolucradoGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Datos_Personales_Adicionales_Involucrado_Datos_Generales entity)
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

        public ApiResponse<Datos_Personales_Adicionales_Involucrado_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_Involucrado_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_Involucrado_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Datos_Personales_Adicionales_Involucrado.Datos_Personales_Adicionales_Involucrado_Datos_Generales>(false, null);
            }
        }


    }
}

