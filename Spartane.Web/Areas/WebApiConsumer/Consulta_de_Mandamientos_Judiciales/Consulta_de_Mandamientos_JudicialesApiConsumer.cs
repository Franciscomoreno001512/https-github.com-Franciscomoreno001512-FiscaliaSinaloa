using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Consulta_de_Mandamientos_Judiciales
{
    public class Consulta_de_Mandamientos_JudicialesApiConsumer : BaseApiConsumer,IConsulta_de_Mandamientos_JudicialesApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Consulta_de_Mandamientos_JudicialesApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Consulta_de_Mandamientos_Judiciales";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales>(false, null);
            }
        }

        public ApiResponse<Consulta_de_Mandamientos_JudicialesPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_JudicialesPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Consulta_de_Mandamientos_Judiciales.Clave='" + Key.ToString() + "'"
                        + "&Order=Consulta_de_Mandamientos_Judiciales.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_JudicialesPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_JudicialesPagingModel>(false, new Consulta_de_Mandamientos_JudicialesPagingModel() { Consulta_de_Mandamientos_Judicialess = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Consulta_de_Mandamientos_JudicialesInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales entity, Core.Domain.User.GlobalData Consulta_de_Mandamientos_JudicialesInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales entity, Core.Domain.User.GlobalData Consulta_de_Mandamientos_JudicialesInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Consulta_de_Mandamientos_JudicialesPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_JudicialesPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_JudicialesPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_JudicialesPagingModel>(false, new Consulta_de_Mandamientos_JudicialesPagingModel() { Consulta_de_Mandamientos_Judicialess = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Consulta_de_Mandamientos_JudicialesGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Consulta_de_Mandamientos_Judiciales_Datos_Generales entity)
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

        public ApiResponse<Consulta_de_Mandamientos_Judiciales_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Consulta_de_Mandamientos_Judiciales.Consulta_de_Mandamientos_Judiciales_Datos_Generales>(false, null);
            }
        }


    }
}

