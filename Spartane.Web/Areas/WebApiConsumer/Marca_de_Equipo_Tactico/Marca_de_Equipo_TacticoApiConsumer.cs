using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Marca_de_Equipo_Tactico;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Marca_de_Equipo_Tactico
{
    public class Marca_de_Equipo_TacticoApiConsumer : BaseApiConsumer,IMarca_de_Equipo_TacticoApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Marca_de_Equipo_TacticoApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Marca_de_Equipo_Tactico";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_Tactico>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_Tactico>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_Tactico>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_Tactico>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_Tactico>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_Tactico>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_Tactico>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_Tactico>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_Tactico> GetByKey(short Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_Tactico>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_Tactico>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_Tactico>(false, null);
            }
        }

        public ApiResponse<Marca_de_Equipo_TacticoPagingModel> GetByKeyComplete(short Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_TacticoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Marca_de_Equipo_Tactico.Clave='" + Key.ToString() + "'"
                        + "&Order=Marca_de_Equipo_Tactico.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_TacticoPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_TacticoPagingModel>(false, new Marca_de_Equipo_TacticoPagingModel() { Marca_de_Equipo_Tacticos = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(short Key, Core.Domain.User.GlobalData Marca_de_Equipo_TacticoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<short> Insert(Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_Tactico entity, Core.Domain.User.GlobalData Marca_de_Equipo_TacticoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<short> Update(Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_Tactico entity, Core.Domain.User.GlobalData Marca_de_Equipo_TacticoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_Tactico>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_Tactico>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_Tactico>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Marca_de_Equipo_TacticoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_TacticoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_TacticoPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_TacticoPagingModel>(false, new Marca_de_Equipo_TacticoPagingModel() { Marca_de_Equipo_Tacticos = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_Tactico>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<short> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<short>(baseApi, ApiControllerUrl + "/Marca_de_Equipo_TacticoGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<short>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<short>(false, -1 );
            }
        }
		
public ApiResponse<short> Update_Datos_Generales(Marca_de_Equipo_Tactico_Datos_Generales entity)
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

        public ApiResponse<Marca_de_Equipo_Tactico_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_Tactico_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_Tactico_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Marca_de_Equipo_Tactico.Marca_de_Equipo_Tactico_Datos_Generales>(false, null);
            }
        }


    }
}

