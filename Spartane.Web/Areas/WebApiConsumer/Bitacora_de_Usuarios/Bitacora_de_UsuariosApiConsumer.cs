using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Bitacora_de_Usuarios;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Bitacora_de_Usuarios
{
    public class Bitacora_de_UsuariosApiConsumer : BaseApiConsumer,IBitacora_de_UsuariosApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Bitacora_de_UsuariosApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Bitacora_de_Usuarios";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios>(false, null);
            }
        }

        public ApiResponse<Bitacora_de_UsuariosPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Bitacora_de_Usuarios.Bitacora_de_UsuariosPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Bitacora_de_Usuarios.Clave='" + Key.ToString() + "'"
                        + "&Order=Bitacora_de_Usuarios.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Bitacora_de_Usuarios.Bitacora_de_UsuariosPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Bitacora_de_Usuarios.Bitacora_de_UsuariosPagingModel>(false, new Bitacora_de_UsuariosPagingModel() { Bitacora_de_Usuarioss = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Bitacora_de_UsuariosInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios entity, Core.Domain.User.GlobalData Bitacora_de_UsuariosInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios entity, Core.Domain.User.GlobalData Bitacora_de_UsuariosInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Bitacora_de_UsuariosPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Bitacora_de_Usuarios.Bitacora_de_UsuariosPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Bitacora_de_Usuarios.Bitacora_de_UsuariosPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Bitacora_de_Usuarios.Bitacora_de_UsuariosPagingModel>(false, new Bitacora_de_UsuariosPagingModel() { Bitacora_de_Usuarioss = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Bitacora_de_UsuariosGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Bitacora_de_Usuarios_Datos_Generales entity)
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

        public ApiResponse<Bitacora_de_Usuarios_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios_Datos_Generales>(false, null);
            }
        }


    }
}

