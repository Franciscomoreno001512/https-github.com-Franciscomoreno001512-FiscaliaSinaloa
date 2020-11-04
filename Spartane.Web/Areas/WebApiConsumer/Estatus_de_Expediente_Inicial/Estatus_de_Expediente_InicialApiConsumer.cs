using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Estatus_de_Expediente_Inicial;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Estatus_de_Expediente_Inicial
{
    public class Estatus_de_Expediente_InicialApiConsumer : BaseApiConsumer,IEstatus_de_Expediente_InicialApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Estatus_de_Expediente_InicialApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Estatus_de_Expediente_Inicial";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial> GetByKey(short Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial>(false, null);
            }
        }

        public ApiResponse<Estatus_de_Expediente_InicialPagingModel> GetByKeyComplete(short Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_InicialPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Estatus_de_Expediente_Inicial.Clave='" + Key.ToString() + "'"
                        + "&Order=Estatus_de_Expediente_Inicial.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_InicialPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_InicialPagingModel>(false, new Estatus_de_Expediente_InicialPagingModel() { Estatus_de_Expediente_Inicials = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(short Key, Core.Domain.User.GlobalData Estatus_de_Expediente_InicialInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<short> Insert(Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial entity, Core.Domain.User.GlobalData Estatus_de_Expediente_InicialInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<short> Update(Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial entity, Core.Domain.User.GlobalData Estatus_de_Expediente_InicialInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Estatus_de_Expediente_InicialPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_InicialPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_InicialPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_InicialPagingModel>(false, new Estatus_de_Expediente_InicialPagingModel() { Estatus_de_Expediente_Inicials = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<short> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<short>(baseApi, ApiControllerUrl + "/Estatus_de_Expediente_InicialGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<short>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<short>(false, -1 );
            }
        }
		
public ApiResponse<short> Update_Datos_Generales(Estatus_de_Expediente_Inicial_Datos_Generales entity)
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

        public ApiResponse<Estatus_de_Expediente_Inicial_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial_Datos_Generales>(false, null);
            }
        }


    }
}

