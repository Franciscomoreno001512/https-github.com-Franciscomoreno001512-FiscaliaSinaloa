using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Spartan_Record_Detail_Management;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Spartan_Record_Detail_Management
{
    public class Spartan_Record_Detail_ManagementApiConsumer : BaseApiConsumer,ISpartan_Record_Detail_ManagementApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Spartan_Record_Detail_ManagementApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Spartan_Record_Detail_Management";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management>(false, null);
            }
        }

        public ApiResponse<Spartan_Record_Detail_ManagementPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_ManagementPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Spartan_Record_Detail_Management.Process_Id='" + Key.ToString() + "'"
                        + "&Order=Spartan_Record_Detail_Management.Process_Id ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_ManagementPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_ManagementPagingModel>(false, new Spartan_Record_Detail_ManagementPagingModel() { Spartan_Record_Detail_Managements = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Spartan_Record_Detail_ManagementInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management entity, Core.Domain.User.GlobalData Spartan_Record_Detail_ManagementInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management entity, Core.Domain.User.GlobalData Spartan_Record_Detail_ManagementInformation, DataLayerFieldsBitacora DataReference)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put?Id=" + entity.Process_Id,
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<IList<Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Spartan_Record_Detail_ManagementPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_ManagementPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_ManagementPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_ManagementPagingModel>(false, new Spartan_Record_Detail_ManagementPagingModel() { Spartan_Record_Detail_Managements = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Spartan_Record_Detail_ManagementGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Spartan_Record_Detail_Management_Datos_Generales entity)
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

        public ApiResponse<Spartan_Record_Detail_Management_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management_Datos_Generales>(false, null);
            }
        }

public ApiResponse<int> Update_Busqueda(Spartan_Record_Detail_Management_Busqueda entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Busqueda",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Spartan_Record_Detail_Management_Busqueda> Get_Busqueda(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management_Busqueda>(baseApi, ApiControllerUrl + "/Get_Busqueda?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management_Busqueda>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management_Busqueda>(false, null);
            }
        }

public ApiResponse<int> Update_Informacion_General(Spartan_Record_Detail_Management_Informacion_General entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Informacion_General",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Spartan_Record_Detail_Management_Informacion_General> Get_Informacion_General(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management_Informacion_General>(baseApi, ApiControllerUrl + "/Get_Informacion_General?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management_Informacion_General>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management_Informacion_General>(false, null);
            }
        }

public ApiResponse<int> Update_Operaciones(Spartan_Record_Detail_Management_Operaciones entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Operaciones",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Spartan_Record_Detail_Management_Operaciones> Get_Operaciones(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management_Operaciones>(baseApi, ApiControllerUrl + "/Get_Operaciones?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management_Operaciones>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Spartan_Record_Detail_Management.Spartan_Record_Detail_Management_Operaciones>(false, null);
            }
        }


    }
}

