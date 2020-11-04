using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Jefes_de_Usuarios_del_Sistema;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Jefes_de_Usuarios_del_Sistema
{
    public class Jefes_de_Usuarios_del_SistemaApiConsumer : BaseApiConsumer,IJefes_de_Usuarios_del_SistemaApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Jefes_de_Usuarios_del_SistemaApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Jefes_de_Usuarios_del_Sistema";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_Sistema>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_Sistema>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_Sistema>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_Sistema>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_Sistema>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_Sistema>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_Sistema>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_Sistema>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_Sistema> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_Sistema>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_Sistema>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_Sistema>(false, null);
            }
        }

        public ApiResponse<Jefes_de_Usuarios_del_SistemaPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_SistemaPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Jefes_de_Usuarios_del_Sistema.Clave='" + Key.ToString() + "'"
                        + "&Order=Jefes_de_Usuarios_del_Sistema.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_SistemaPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_SistemaPagingModel>(false, new Jefes_de_Usuarios_del_SistemaPagingModel() { Jefes_de_Usuarios_del_Sistemas = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Jefes_de_Usuarios_del_SistemaInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_Sistema entity, Core.Domain.User.GlobalData Jefes_de_Usuarios_del_SistemaInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_Sistema entity, Core.Domain.User.GlobalData Jefes_de_Usuarios_del_SistemaInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_Sistema>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_Sistema>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_Sistema>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Jefes_de_Usuarios_del_SistemaPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_SistemaPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_SistemaPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_SistemaPagingModel>(false, new Jefes_de_Usuarios_del_SistemaPagingModel() { Jefes_de_Usuarios_del_Sistemas = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_Sistema>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Jefes_de_Usuarios_del_SistemaGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Jefes_de_Usuarios_del_Sistema_Datos_Generales entity)
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

        public ApiResponse<Jefes_de_Usuarios_del_Sistema_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_Sistema_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_Sistema_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_Sistema_Datos_Generales>(false, null);
            }
        }


    }
}

