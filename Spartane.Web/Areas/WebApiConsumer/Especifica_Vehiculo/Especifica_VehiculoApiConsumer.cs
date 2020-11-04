using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Especifica_Vehiculo;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Especifica_Vehiculo
{
    public class Especifica_VehiculoApiConsumer : BaseApiConsumer,IEspecifica_VehiculoApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Especifica_VehiculoApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Especifica_Vehiculo";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Especifica_Vehiculo.Especifica_Vehiculo>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Especifica_Vehiculo.Especifica_Vehiculo>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Especifica_Vehiculo.Especifica_Vehiculo>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Especifica_Vehiculo.Especifica_Vehiculo>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Especifica_Vehiculo.Especifica_Vehiculo>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Especifica_Vehiculo.Especifica_Vehiculo>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Especifica_Vehiculo.Especifica_Vehiculo>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Especifica_Vehiculo.Especifica_Vehiculo>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Especifica_Vehiculo.Especifica_Vehiculo> GetByKey(short Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Especifica_Vehiculo.Especifica_Vehiculo>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Especifica_Vehiculo.Especifica_Vehiculo>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Especifica_Vehiculo.Especifica_Vehiculo>(false, null);
            }
        }

        public ApiResponse<Especifica_VehiculoPagingModel> GetByKeyComplete(short Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Especifica_Vehiculo.Especifica_VehiculoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Especifica_Vehiculo.Clave='" + Key.ToString() + "'"
                        + "&Order=Especifica_Vehiculo.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Especifica_Vehiculo.Especifica_VehiculoPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Especifica_Vehiculo.Especifica_VehiculoPagingModel>(false, new Especifica_VehiculoPagingModel() { Especifica_Vehiculos = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(short Key, Core.Domain.User.GlobalData Especifica_VehiculoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<short> Insert(Core.Domain.Especifica_Vehiculo.Especifica_Vehiculo entity, Core.Domain.User.GlobalData Especifica_VehiculoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<short> Update(Core.Domain.Especifica_Vehiculo.Especifica_Vehiculo entity, Core.Domain.User.GlobalData Especifica_VehiculoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Especifica_Vehiculo.Especifica_Vehiculo>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Especifica_Vehiculo.Especifica_Vehiculo>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Especifica_Vehiculo.Especifica_Vehiculo>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Especifica_VehiculoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Especifica_Vehiculo.Especifica_VehiculoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Especifica_Vehiculo.Especifica_VehiculoPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Especifica_Vehiculo.Especifica_VehiculoPagingModel>(false, new Especifica_VehiculoPagingModel() { Especifica_Vehiculos = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Especifica_Vehiculo.Especifica_Vehiculo>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<short> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<short>(baseApi, ApiControllerUrl + "/Especifica_VehiculoGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<short>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<short>(false, -1 );
            }
        }
		
public ApiResponse<short> Update_Datos_Generales(Especifica_Vehiculo_Datos_Generales entity)
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

        public ApiResponse<Especifica_Vehiculo_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Especifica_Vehiculo.Especifica_Vehiculo_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Especifica_Vehiculo.Especifica_Vehiculo_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Especifica_Vehiculo.Especifica_Vehiculo_Datos_Generales>(false, null);
            }
        }


    }
}

