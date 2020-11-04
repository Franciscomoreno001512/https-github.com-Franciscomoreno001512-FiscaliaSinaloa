using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Especialista_de_Justicia_Alternativa;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Especialista_de_Justicia_Alternativa
{
    public class Especialista_de_Justicia_AlternativaApiConsumer : BaseApiConsumer,IEspecialista_de_Justicia_AlternativaApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Especialista_de_Justicia_AlternativaApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Especialista_de_Justicia_Alternativa";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_Alternativa>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_Alternativa>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_Alternativa>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_Alternativa>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_Alternativa>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_Alternativa>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_Alternativa>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_Alternativa>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_Alternativa> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_Alternativa>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_Alternativa>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_Alternativa>(false, null);
            }
        }

        public ApiResponse<Especialista_de_Justicia_AlternativaPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_AlternativaPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Especialista_de_Justicia_Alternativa.Clave='" + Key.ToString() + "'"
                        + "&Order=Especialista_de_Justicia_Alternativa.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_AlternativaPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_AlternativaPagingModel>(false, new Especialista_de_Justicia_AlternativaPagingModel() { Especialista_de_Justicia_Alternativas = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Especialista_de_Justicia_AlternativaInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_Alternativa entity, Core.Domain.User.GlobalData Especialista_de_Justicia_AlternativaInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_Alternativa entity, Core.Domain.User.GlobalData Especialista_de_Justicia_AlternativaInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_Alternativa>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_Alternativa>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_Alternativa>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Especialista_de_Justicia_AlternativaPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_AlternativaPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_AlternativaPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_AlternativaPagingModel>(false, new Especialista_de_Justicia_AlternativaPagingModel() { Especialista_de_Justicia_Alternativas = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_Alternativa>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Especialista_de_Justicia_AlternativaGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Especialista_de_Justicia_Alternativa_Datos_Generales entity)
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

        public ApiResponse<Especialista_de_Justicia_Alternativa_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_Alternativa_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_Alternativa_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_Alternativa_Datos_Generales>(false, null);
            }
        }


    }
}

