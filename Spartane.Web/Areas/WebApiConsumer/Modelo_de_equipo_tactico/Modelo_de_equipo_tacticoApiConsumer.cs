using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Modelo_de_equipo_tactico;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Modelo_de_equipo_tactico
{
    public class Modelo_de_equipo_tacticoApiConsumer : BaseApiConsumer,IModelo_de_equipo_tacticoApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Modelo_de_equipo_tacticoApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Modelo_de_equipo_tactico";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico> GetByKey(short Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico>(false, null);
            }
        }

        public ApiResponse<Modelo_de_equipo_tacticoPagingModel> GetByKeyComplete(short Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tacticoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Modelo_de_equipo_tactico.Clave='" + Key.ToString() + "'"
                        + "&Order=Modelo_de_equipo_tactico.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tacticoPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tacticoPagingModel>(false, new Modelo_de_equipo_tacticoPagingModel() { Modelo_de_equipo_tacticos = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(short Key, Core.Domain.User.GlobalData Modelo_de_equipo_tacticoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<short> Insert(Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico entity, Core.Domain.User.GlobalData Modelo_de_equipo_tacticoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<short> Update(Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico entity, Core.Domain.User.GlobalData Modelo_de_equipo_tacticoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Modelo_de_equipo_tacticoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tacticoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tacticoPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tacticoPagingModel>(false, new Modelo_de_equipo_tacticoPagingModel() { Modelo_de_equipo_tacticos = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<short> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<short>(baseApi, ApiControllerUrl + "/Modelo_de_equipo_tacticoGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<short>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<short>(false, -1 );
            }
        }
		
public ApiResponse<short> Update_Datos_Generales(Modelo_de_equipo_tactico_Datos_Generales entity)
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

        public ApiResponse<Modelo_de_equipo_tactico_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Modelo_de_equipo_tactico.Modelo_de_equipo_tactico_Datos_Generales>(false, null);
            }
        }


    }
}

