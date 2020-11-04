using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Discapacidades_Psicosociales;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Discapacidades_Psicosociales
{
    public class Discapacidades_PsicosocialesApiConsumer : BaseApiConsumer,IDiscapacidades_PsicosocialesApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Discapacidades_PsicosocialesApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Discapacidades_Psicosociales";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Discapacidades_Psicosociales.Discapacidades_Psicosociales>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Discapacidades_Psicosociales.Discapacidades_Psicosociales>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Discapacidades_Psicosociales.Discapacidades_Psicosociales>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Discapacidades_Psicosociales.Discapacidades_Psicosociales>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Discapacidades_Psicosociales.Discapacidades_Psicosociales>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Discapacidades_Psicosociales.Discapacidades_Psicosociales>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Discapacidades_Psicosociales.Discapacidades_Psicosociales>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Discapacidades_Psicosociales.Discapacidades_Psicosociales>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Discapacidades_Psicosociales.Discapacidades_Psicosociales> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Discapacidades_Psicosociales.Discapacidades_Psicosociales>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Discapacidades_Psicosociales.Discapacidades_Psicosociales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Discapacidades_Psicosociales.Discapacidades_Psicosociales>(false, null);
            }
        }

        public ApiResponse<Discapacidades_PsicosocialesPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Discapacidades_Psicosociales.Discapacidades_PsicosocialesPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Discapacidades_Psicosociales.Clave='" + Key.ToString() + "'"
                        + "&Order=Discapacidades_Psicosociales.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Discapacidades_Psicosociales.Discapacidades_PsicosocialesPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Discapacidades_Psicosociales.Discapacidades_PsicosocialesPagingModel>(false, new Discapacidades_PsicosocialesPagingModel() { Discapacidades_Psicosocialess = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Discapacidades_PsicosocialesInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Discapacidades_Psicosociales.Discapacidades_Psicosociales entity, Core.Domain.User.GlobalData Discapacidades_PsicosocialesInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Discapacidades_Psicosociales.Discapacidades_Psicosociales entity, Core.Domain.User.GlobalData Discapacidades_PsicosocialesInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Discapacidades_Psicosociales.Discapacidades_Psicosociales>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Discapacidades_Psicosociales.Discapacidades_Psicosociales>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Discapacidades_Psicosociales.Discapacidades_Psicosociales>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Discapacidades_PsicosocialesPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Discapacidades_Psicosociales.Discapacidades_PsicosocialesPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Discapacidades_Psicosociales.Discapacidades_PsicosocialesPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Discapacidades_Psicosociales.Discapacidades_PsicosocialesPagingModel>(false, new Discapacidades_PsicosocialesPagingModel() { Discapacidades_Psicosocialess = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Discapacidades_Psicosociales.Discapacidades_Psicosociales>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Discapacidades_PsicosocialesGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Discapacidades_Psicosociales_Datos_Generales entity)
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

        public ApiResponse<Discapacidades_Psicosociales_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Discapacidades_Psicosociales.Discapacidades_Psicosociales_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Discapacidades_Psicosociales.Discapacidades_Psicosociales_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Discapacidades_Psicosociales.Discapacidades_Psicosociales_Datos_Generales>(false, null);
            }
        }


    }
}

