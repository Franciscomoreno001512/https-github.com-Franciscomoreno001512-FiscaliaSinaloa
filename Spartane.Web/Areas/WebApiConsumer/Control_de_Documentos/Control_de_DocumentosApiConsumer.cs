using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Control_de_Documentos;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Control_de_Documentos
{
    public class Control_de_DocumentosApiConsumer : BaseApiConsumer,IControl_de_DocumentosApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Control_de_DocumentosApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Control_de_Documentos";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Control_de_Documentos.Control_de_Documentos>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Control_de_Documentos.Control_de_Documentos>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Control_de_Documentos.Control_de_Documentos>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Control_de_Documentos.Control_de_Documentos>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Control_de_Documentos.Control_de_Documentos>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Control_de_Documentos.Control_de_Documentos>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Control_de_Documentos.Control_de_Documentos>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Control_de_Documentos.Control_de_Documentos>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Control_de_Documentos.Control_de_Documentos> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Control_de_Documentos.Control_de_Documentos>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Control_de_Documentos.Control_de_Documentos>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Control_de_Documentos.Control_de_Documentos>(false, null);
            }
        }

        public ApiResponse<Control_de_DocumentosPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Control_de_Documentos.Control_de_DocumentosPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Control_de_Documentos.Folio='" + Key.ToString() + "'"
                        + "&Order=Control_de_Documentos.Folio ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Control_de_Documentos.Control_de_DocumentosPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Control_de_Documentos.Control_de_DocumentosPagingModel>(false, new Control_de_DocumentosPagingModel() { Control_de_Documentoss = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Control_de_DocumentosInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Control_de_Documentos.Control_de_Documentos entity, Core.Domain.User.GlobalData Control_de_DocumentosInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Control_de_Documentos.Control_de_Documentos entity, Core.Domain.User.GlobalData Control_de_DocumentosInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Control_de_Documentos.Control_de_Documentos>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Control_de_Documentos.Control_de_Documentos>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Control_de_Documentos.Control_de_Documentos>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Control_de_DocumentosPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Control_de_Documentos.Control_de_DocumentosPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Control_de_Documentos.Control_de_DocumentosPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Control_de_Documentos.Control_de_DocumentosPagingModel>(false, new Control_de_DocumentosPagingModel() { Control_de_Documentoss = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Control_de_Documentos.Control_de_Documentos>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Control_de_DocumentosGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Control_de_Documentos_Datos_Generales entity)
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

        public ApiResponse<Control_de_Documentos_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Control_de_Documentos.Control_de_Documentos_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Control_de_Documentos.Control_de_Documentos_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Control_de_Documentos.Control_de_Documentos_Datos_Generales>(false, null);
            }
        }

public ApiResponse<int> Update_Documento(Control_de_Documentos_Documento entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Documento",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Control_de_Documentos_Documento> Get_Documento(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Control_de_Documentos.Control_de_Documentos_Documento>(baseApi, ApiControllerUrl + "/Get_Documento?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Control_de_Documentos.Control_de_Documentos_Documento>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Control_de_Documentos.Control_de_Documentos_Documento>(false, null);
            }
        }

public ApiResponse<int> Update_Secciones(Control_de_Documentos_Secciones entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Secciones",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Control_de_Documentos_Secciones> Get_Secciones(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Control_de_Documentos.Control_de_Documentos_Secciones>(baseApi, ApiControllerUrl + "/Get_Secciones?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Control_de_Documentos.Control_de_Documentos_Secciones>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Control_de_Documentos.Control_de_Documentos_Secciones>(false, null);
            }
        }

public ApiResponse<int> Update_Historial(Control_de_Documentos_Historial entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Historial",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Control_de_Documentos_Historial> Get_Historial(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Control_de_Documentos.Control_de_Documentos_Historial>(baseApi, ApiControllerUrl + "/Get_Historial?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Control_de_Documentos.Control_de_Documentos_Historial>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Control_de_Documentos.Control_de_Documentos_Historial>(false, null);
            }
        }


    }
}

