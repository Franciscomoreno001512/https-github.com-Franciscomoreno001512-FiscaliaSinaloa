using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Servicio_del_Vehiculo;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Servicio_del_Vehiculo
{
    public class Servicio_del_VehiculoApiConsumer : BaseApiConsumer,IServicio_del_VehiculoApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Servicio_del_VehiculoApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Servicio_del_Vehiculo";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Servicio_del_Vehiculo.Servicio_del_Vehiculo>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Servicio_del_Vehiculo.Servicio_del_Vehiculo>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Servicio_del_Vehiculo.Servicio_del_Vehiculo>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Servicio_del_Vehiculo.Servicio_del_Vehiculo>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Servicio_del_Vehiculo.Servicio_del_Vehiculo>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Servicio_del_Vehiculo.Servicio_del_Vehiculo>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Servicio_del_Vehiculo.Servicio_del_Vehiculo>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Servicio_del_Vehiculo.Servicio_del_Vehiculo>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Servicio_del_Vehiculo.Servicio_del_Vehiculo> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Servicio_del_Vehiculo.Servicio_del_Vehiculo>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Servicio_del_Vehiculo.Servicio_del_Vehiculo>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Servicio_del_Vehiculo.Servicio_del_Vehiculo>(false, null);
            }
        }

        public ApiResponse<Servicio_del_VehiculoPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Servicio_del_Vehiculo.Servicio_del_VehiculoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Servicio_del_Vehiculo.Clave='" + Key.ToString() + "'"
                        + "&Order=Servicio_del_Vehiculo.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Servicio_del_Vehiculo.Servicio_del_VehiculoPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Servicio_del_Vehiculo.Servicio_del_VehiculoPagingModel>(false, new Servicio_del_VehiculoPagingModel() { Servicio_del_Vehiculos = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Servicio_del_VehiculoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Servicio_del_Vehiculo.Servicio_del_Vehiculo entity, Core.Domain.User.GlobalData Servicio_del_VehiculoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Servicio_del_Vehiculo.Servicio_del_Vehiculo entity, Core.Domain.User.GlobalData Servicio_del_VehiculoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Servicio_del_Vehiculo.Servicio_del_Vehiculo>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Servicio_del_Vehiculo.Servicio_del_Vehiculo>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Servicio_del_Vehiculo.Servicio_del_Vehiculo>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Servicio_del_VehiculoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Servicio_del_Vehiculo.Servicio_del_VehiculoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Servicio_del_Vehiculo.Servicio_del_VehiculoPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Servicio_del_Vehiculo.Servicio_del_VehiculoPagingModel>(false, new Servicio_del_VehiculoPagingModel() { Servicio_del_Vehiculos = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Servicio_del_Vehiculo.Servicio_del_Vehiculo>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Servicio_del_VehiculoGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Servicio_del_Vehiculo_Datos_Generales entity)
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

        public ApiResponse<Servicio_del_Vehiculo_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Servicio_del_Vehiculo.Servicio_del_Vehiculo_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Servicio_del_Vehiculo.Servicio_del_Vehiculo_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Servicio_del_Vehiculo.Servicio_del_Vehiculo_Datos_Generales>(false, null);
            }
        }


    }
}

