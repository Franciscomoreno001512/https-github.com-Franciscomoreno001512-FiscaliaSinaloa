using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Relacion_Unidad_Usuario;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Relacion_Unidad_Usuario
{
    public class Relacion_Unidad_UsuarioApiConsumer : BaseApiConsumer,IRelacion_Unidad_UsuarioApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Relacion_Unidad_UsuarioApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Relacion_Unidad_Usuario";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario>(false, null);
            }
        }

        public ApiResponse<Relacion_Unidad_UsuarioPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_UsuarioPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Relacion_Unidad_Usuario.Clave='" + Key.ToString() + "'"
                        + "&Order=Relacion_Unidad_Usuario.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_UsuarioPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_UsuarioPagingModel>(false, new Relacion_Unidad_UsuarioPagingModel() { Relacion_Unidad_Usuarios = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Relacion_Unidad_UsuarioInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario entity, Core.Domain.User.GlobalData Relacion_Unidad_UsuarioInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario entity, Core.Domain.User.GlobalData Relacion_Unidad_UsuarioInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Relacion_Unidad_UsuarioPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_UsuarioPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_UsuarioPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_UsuarioPagingModel>(false, new Relacion_Unidad_UsuarioPagingModel() { Relacion_Unidad_Usuarios = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Relacion_Unidad_UsuarioGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Relacion_Unidad_Usuario_Datos_Generales entity)
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

        public ApiResponse<Relacion_Unidad_Usuario_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario_Datos_Generales>(false, null);
            }
        }


    }
}

