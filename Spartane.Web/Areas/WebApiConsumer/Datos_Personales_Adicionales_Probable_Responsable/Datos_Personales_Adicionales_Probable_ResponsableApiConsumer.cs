using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Datos_Personales_Adicionales_Probable_Responsable;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Datos_Personales_Adicionales_Probable_Responsable
{
    public class Datos_Personales_Adicionales_Probable_ResponsableApiConsumer : BaseApiConsumer,IDatos_Personales_Adicionales_Probable_ResponsableApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Datos_Personales_Adicionales_Probable_ResponsableApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Datos_Personales_Adicionales_Probable_Responsable";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Datos_Personales_Adicionales_Probable_Responsable.Datos_Personales_Adicionales_Probable_Responsable>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Datos_Personales_Adicionales_Probable_Responsable.Datos_Personales_Adicionales_Probable_Responsable>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Datos_Personales_Adicionales_Probable_Responsable.Datos_Personales_Adicionales_Probable_Responsable>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Datos_Personales_Adicionales_Probable_Responsable.Datos_Personales_Adicionales_Probable_Responsable>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Datos_Personales_Adicionales_Probable_Responsable.Datos_Personales_Adicionales_Probable_Responsable>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Datos_Personales_Adicionales_Probable_Responsable.Datos_Personales_Adicionales_Probable_Responsable>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Datos_Personales_Adicionales_Probable_Responsable.Datos_Personales_Adicionales_Probable_Responsable>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Datos_Personales_Adicionales_Probable_Responsable.Datos_Personales_Adicionales_Probable_Responsable>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Datos_Personales_Adicionales_Probable_Responsable.Datos_Personales_Adicionales_Probable_Responsable> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Datos_Personales_Adicionales_Probable_Responsable.Datos_Personales_Adicionales_Probable_Responsable>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Datos_Personales_Adicionales_Probable_Responsable.Datos_Personales_Adicionales_Probable_Responsable>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Datos_Personales_Adicionales_Probable_Responsable.Datos_Personales_Adicionales_Probable_Responsable>(false, null);
            }
        }

        public ApiResponse<Datos_Personales_Adicionales_Probable_ResponsablePagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Datos_Personales_Adicionales_Probable_Responsable.Datos_Personales_Adicionales_Probable_ResponsablePagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Datos_Personales_Adicionales_Probable_Responsable.Clave='" + Key.ToString() + "'"
                        + "&Order=Datos_Personales_Adicionales_Probable_Responsable.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Datos_Personales_Adicionales_Probable_Responsable.Datos_Personales_Adicionales_Probable_ResponsablePagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Datos_Personales_Adicionales_Probable_Responsable.Datos_Personales_Adicionales_Probable_ResponsablePagingModel>(false, new Datos_Personales_Adicionales_Probable_ResponsablePagingModel() { Datos_Personales_Adicionales_Probable_Responsables = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Datos_Personales_Adicionales_Probable_ResponsableInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Datos_Personales_Adicionales_Probable_Responsable.Datos_Personales_Adicionales_Probable_Responsable entity, Core.Domain.User.GlobalData Datos_Personales_Adicionales_Probable_ResponsableInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Datos_Personales_Adicionales_Probable_Responsable.Datos_Personales_Adicionales_Probable_Responsable entity, Core.Domain.User.GlobalData Datos_Personales_Adicionales_Probable_ResponsableInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Datos_Personales_Adicionales_Probable_Responsable.Datos_Personales_Adicionales_Probable_Responsable>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Datos_Personales_Adicionales_Probable_Responsable.Datos_Personales_Adicionales_Probable_Responsable>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Datos_Personales_Adicionales_Probable_Responsable.Datos_Personales_Adicionales_Probable_Responsable>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Datos_Personales_Adicionales_Probable_ResponsablePagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Datos_Personales_Adicionales_Probable_Responsable.Datos_Personales_Adicionales_Probable_ResponsablePagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Datos_Personales_Adicionales_Probable_Responsable.Datos_Personales_Adicionales_Probable_ResponsablePagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Datos_Personales_Adicionales_Probable_Responsable.Datos_Personales_Adicionales_Probable_ResponsablePagingModel>(false, new Datos_Personales_Adicionales_Probable_ResponsablePagingModel() { Datos_Personales_Adicionales_Probable_Responsables = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Datos_Personales_Adicionales_Probable_Responsable.Datos_Personales_Adicionales_Probable_Responsable>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Datos_Personales_Adicionales_Probable_ResponsableGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Datos_Personales_Adicionales_Probable_Responsable_Datos_Generales entity)
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

        public ApiResponse<Datos_Personales_Adicionales_Probable_Responsable_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Datos_Personales_Adicionales_Probable_Responsable.Datos_Personales_Adicionales_Probable_Responsable_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Datos_Personales_Adicionales_Probable_Responsable.Datos_Personales_Adicionales_Probable_Responsable_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Datos_Personales_Adicionales_Probable_Responsable.Datos_Personales_Adicionales_Probable_Responsable_Datos_Generales>(false, null);
            }
        }


    }
}

