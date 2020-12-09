using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Control_de_Folios_por_Especialidad;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Control_de_Folios_por_Especialidad
{
    public class Control_de_Folios_por_EspecialidadApiConsumer : BaseApiConsumer,IControl_de_Folios_por_EspecialidadApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Control_de_Folios_por_EspecialidadApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Control_de_Folios_por_Especialidad";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Control_de_Folios_por_Especialidad.Control_de_Folios_por_Especialidad>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Control_de_Folios_por_Especialidad.Control_de_Folios_por_Especialidad>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Control_de_Folios_por_Especialidad.Control_de_Folios_por_Especialidad>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Control_de_Folios_por_Especialidad.Control_de_Folios_por_Especialidad>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Control_de_Folios_por_Especialidad.Control_de_Folios_por_Especialidad>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Control_de_Folios_por_Especialidad.Control_de_Folios_por_Especialidad>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Control_de_Folios_por_Especialidad.Control_de_Folios_por_Especialidad>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Control_de_Folios_por_Especialidad.Control_de_Folios_por_Especialidad>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Control_de_Folios_por_Especialidad.Control_de_Folios_por_Especialidad> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Control_de_Folios_por_Especialidad.Control_de_Folios_por_Especialidad>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Control_de_Folios_por_Especialidad.Control_de_Folios_por_Especialidad>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Control_de_Folios_por_Especialidad.Control_de_Folios_por_Especialidad>(false, null);
            }
        }

        public ApiResponse<Control_de_Folios_por_EspecialidadPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Control_de_Folios_por_Especialidad.Control_de_Folios_por_EspecialidadPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Control_de_Folios_por_Especialidad.Folio='" + Key.ToString() + "'"
                        + "&Order=Control_de_Folios_por_Especialidad.Folio ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Control_de_Folios_por_Especialidad.Control_de_Folios_por_EspecialidadPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Control_de_Folios_por_Especialidad.Control_de_Folios_por_EspecialidadPagingModel>(false, new Control_de_Folios_por_EspecialidadPagingModel() { Control_de_Folios_por_Especialidads = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Control_de_Folios_por_EspecialidadInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Control_de_Folios_por_Especialidad.Control_de_Folios_por_Especialidad entity, Core.Domain.User.GlobalData Control_de_Folios_por_EspecialidadInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Control_de_Folios_por_Especialidad.Control_de_Folios_por_Especialidad entity, Core.Domain.User.GlobalData Control_de_Folios_por_EspecialidadInformation, DataLayerFieldsBitacora DataReference)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put?Id=" + entity.Folio,
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<IList<Core.Domain.Control_de_Folios_por_Especialidad.Control_de_Folios_por_Especialidad>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Control_de_Folios_por_Especialidad.Control_de_Folios_por_Especialidad>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Control_de_Folios_por_Especialidad.Control_de_Folios_por_Especialidad>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Control_de_Folios_por_EspecialidadPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Control_de_Folios_por_Especialidad.Control_de_Folios_por_EspecialidadPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Control_de_Folios_por_Especialidad.Control_de_Folios_por_EspecialidadPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Control_de_Folios_por_Especialidad.Control_de_Folios_por_EspecialidadPagingModel>(false, new Control_de_Folios_por_EspecialidadPagingModel() { Control_de_Folios_por_Especialidads = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Control_de_Folios_por_Especialidad.Control_de_Folios_por_Especialidad>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Control_de_Folios_por_EspecialidadGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Control_de_Folios_por_Especialidad_Datos_Generales entity)
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

        public ApiResponse<Control_de_Folios_por_Especialidad_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Control_de_Folios_por_Especialidad.Control_de_Folios_por_Especialidad_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Control_de_Folios_por_Especialidad.Control_de_Folios_por_Especialidad_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Control_de_Folios_por_Especialidad.Control_de_Folios_por_Especialidad_Datos_Generales>(false, null);
            }
        }


    }
}

