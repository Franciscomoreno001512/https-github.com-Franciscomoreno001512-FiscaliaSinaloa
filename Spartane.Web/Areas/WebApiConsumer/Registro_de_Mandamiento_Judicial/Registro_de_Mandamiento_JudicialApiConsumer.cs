using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Registro_de_Mandamiento_Judicial;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Registro_de_Mandamiento_Judicial
{
    public class Registro_de_Mandamiento_JudicialApiConsumer : BaseApiConsumer,IRegistro_de_Mandamiento_JudicialApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Registro_de_Mandamiento_JudicialApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Registro_de_Mandamiento_Judicial";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial>(false, null);
            }
        }

        public ApiResponse<Registro_de_Mandamiento_JudicialPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_JudicialPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Registro_de_Mandamiento_Judicial.Clave='" + Key.ToString() + "'"
                        + "&Order=Registro_de_Mandamiento_Judicial.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_JudicialPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_JudicialPagingModel>(false, new Registro_de_Mandamiento_JudicialPagingModel() { Registro_de_Mandamiento_Judicials = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Registro_de_Mandamiento_JudicialInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial entity, Core.Domain.User.GlobalData Registro_de_Mandamiento_JudicialInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial entity, Core.Domain.User.GlobalData Registro_de_Mandamiento_JudicialInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Registro_de_Mandamiento_JudicialPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_JudicialPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_JudicialPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_JudicialPagingModel>(false, new Registro_de_Mandamiento_JudicialPagingModel() { Registro_de_Mandamiento_Judicials = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Registro_de_Mandamiento_JudicialGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Registro_de_Mandamiento_Judicial_Datos_Generales entity)
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

        public ApiResponse<Registro_de_Mandamiento_Judicial_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Datos_Generales>(false, null);
            }
        }

public ApiResponse<int> Update_Domicilio(Registro_de_Mandamiento_Judicial_Domicilio entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Domicilio",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Registro_de_Mandamiento_Judicial_Domicilio> Get_Domicilio(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Domicilio>(baseApi, ApiControllerUrl + "/Get_Domicilio?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Domicilio>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Domicilio>(false, null);
            }
        }

public ApiResponse<int> Update_Telefonos(Registro_de_Mandamiento_Judicial_Telefonos entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Telefonos",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Registro_de_Mandamiento_Judicial_Telefonos> Get_Telefonos(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Telefonos>(baseApi, ApiControllerUrl + "/Get_Telefonos?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Telefonos>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Telefonos>(false, null);
            }
        }

public ApiResponse<int> Update_Otros_Nombres(Registro_de_Mandamiento_Judicial_Otros_Nombres entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Otros_Nombres",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Registro_de_Mandamiento_Judicial_Otros_Nombres> Get_Otros_Nombres(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Otros_Nombres>(baseApi, ApiControllerUrl + "/Get_Otros_Nombres?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Otros_Nombres>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Otros_Nombres>(false, null);
            }
        }

public ApiResponse<int> Update_Datos_de_la_Orden(Registro_de_Mandamiento_Judicial_Datos_de_la_Orden entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Datos_de_la_Orden",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Registro_de_Mandamiento_Judicial_Datos_de_la_Orden> Get_Datos_de_la_Orden(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Datos_de_la_Orden>(baseApi, ApiControllerUrl + "/Get_Datos_de_la_Orden?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Datos_de_la_Orden>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Datos_de_la_Orden>(false, null);
            }
        }

public ApiResponse<int> Update_Delito(Registro_de_Mandamiento_Judicial_Delito entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Delito",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Registro_de_Mandamiento_Judicial_Delito> Get_Delito(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Delito>(baseApi, ApiControllerUrl + "/Get_Delito?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Delito>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Delito>(false, null);
            }
        }

public ApiResponse<int> Update_Amparo(Registro_de_Mandamiento_Judicial_Amparo entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Amparo",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Registro_de_Mandamiento_Judicial_Amparo> Get_Amparo(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Amparo>(baseApi, ApiControllerUrl + "/Get_Amparo?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Amparo>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Amparo>(false, null);
            }
        }

public ApiResponse<int> Update_Media_Filiacion(Registro_de_Mandamiento_Judicial_Media_Filiacion entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Media_Filiacion",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Registro_de_Mandamiento_Judicial_Media_Filiacion> Get_Media_Filiacion(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Media_Filiacion>(baseApi, ApiControllerUrl + "/Get_Media_Filiacion?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Media_Filiacion>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Media_Filiacion>(false, null);
            }
        }

public ApiResponse<int> Update_Proceso(Registro_de_Mandamiento_Judicial_Proceso entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Proceso",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Registro_de_Mandamiento_Judicial_Proceso> Get_Proceso(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Proceso>(baseApi, ApiControllerUrl + "/Get_Proceso?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Proceso>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Proceso>(false, null);
            }
        }

public ApiResponse<int> Update_Fotos(Registro_de_Mandamiento_Judicial_Fotos entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Fotos",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Registro_de_Mandamiento_Judicial_Fotos> Get_Fotos(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Fotos>(baseApi, ApiControllerUrl + "/Get_Fotos?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Fotos>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Fotos>(false, null);
            }
        }

public ApiResponse<int> Update_Documentos(Registro_de_Mandamiento_Judicial_Documentos entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Documentos",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Registro_de_Mandamiento_Judicial_Documentos> Get_Documentos(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Documentos>(baseApi, ApiControllerUrl + "/Get_Documentos?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Documentos>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Documentos>(false, null);
            }
        }

public ApiResponse<int> Update_Huellas_Digitales(Registro_de_Mandamiento_Judicial_Huellas_Digitales entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Huellas_Digitales",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Registro_de_Mandamiento_Judicial_Huellas_Digitales> Get_Huellas_Digitales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Huellas_Digitales>(baseApi, ApiControllerUrl + "/Get_Huellas_Digitales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Huellas_Digitales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Registro_de_Mandamiento_Judicial.Registro_de_Mandamiento_Judicial_Huellas_Digitales>(false, null);
            }
        }


    }
}

