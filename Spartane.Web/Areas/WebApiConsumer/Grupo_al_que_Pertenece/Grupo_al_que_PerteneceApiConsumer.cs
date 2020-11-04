using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Grupo_al_que_Pertenece;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Grupo_al_que_Pertenece
{
    public class Grupo_al_que_PerteneceApiConsumer : BaseApiConsumer,IGrupo_al_que_PerteneceApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Grupo_al_que_PerteneceApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Grupo_al_que_Pertenece";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_Pertenece>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_Pertenece>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_Pertenece>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_Pertenece>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_Pertenece>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_Pertenece>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_Pertenece>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_Pertenece>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_Pertenece> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_Pertenece>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_Pertenece>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_Pertenece>(false, null);
            }
        }

        public ApiResponse<Grupo_al_que_PertenecePagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_PertenecePagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Grupo_al_que_Pertenece.Clave='" + Key.ToString() + "'"
                        + "&Order=Grupo_al_que_Pertenece.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_PertenecePagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_PertenecePagingModel>(false, new Grupo_al_que_PertenecePagingModel() { Grupo_al_que_Perteneces = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Grupo_al_que_PerteneceInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_Pertenece entity, Core.Domain.User.GlobalData Grupo_al_que_PerteneceInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_Pertenece entity, Core.Domain.User.GlobalData Grupo_al_que_PerteneceInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_Pertenece>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_Pertenece>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_Pertenece>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Grupo_al_que_PertenecePagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_PertenecePagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_PertenecePagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_PertenecePagingModel>(false, new Grupo_al_que_PertenecePagingModel() { Grupo_al_que_Perteneces = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_Pertenece>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Grupo_al_que_PerteneceGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Grupo_al_que_Pertenece_Datos_Generales entity)
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

        public ApiResponse<Grupo_al_que_Pertenece_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_Pertenece_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_Pertenece_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Grupo_al_que_Pertenece.Grupo_al_que_Pertenece_Datos_Generales>(false, null);
            }
        }


    }
}

