using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Aseguramientos;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Aseguramientos
{
    public class AseguramientosApiConsumer : BaseApiConsumer,IAseguramientosApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public AseguramientosApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Aseguramientos";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Aseguramientos.Aseguramientos>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Aseguramientos.Aseguramientos>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Aseguramientos.Aseguramientos>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Aseguramientos.Aseguramientos>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Aseguramientos.Aseguramientos>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Aseguramientos.Aseguramientos>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Aseguramientos.Aseguramientos>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Aseguramientos.Aseguramientos>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Aseguramientos.Aseguramientos> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Aseguramientos.Aseguramientos>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Aseguramientos.Aseguramientos>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Aseguramientos.Aseguramientos>(false, null);
            }
        }

        public ApiResponse<AseguramientosPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Aseguramientos.AseguramientosPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Aseguramientos.Clave='" + Key.ToString() + "'"
                        + "&Order=Aseguramientos.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Aseguramientos.AseguramientosPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Aseguramientos.AseguramientosPagingModel>(false, new AseguramientosPagingModel() { Aseguramientoss = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData AseguramientosInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Aseguramientos.Aseguramientos entity, Core.Domain.User.GlobalData AseguramientosInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Aseguramientos.Aseguramientos entity, Core.Domain.User.GlobalData AseguramientosInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Aseguramientos.Aseguramientos>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Aseguramientos.Aseguramientos>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Aseguramientos.Aseguramientos>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<AseguramientosPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Aseguramientos.AseguramientosPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Aseguramientos.AseguramientosPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Aseguramientos.AseguramientosPagingModel>(false, new AseguramientosPagingModel() { Aseguramientoss = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Aseguramientos.Aseguramientos>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/AseguramientosGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Aseguramientos_Datos_Generales entity)
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

        public ApiResponse<Aseguramientos_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Aseguramientos.Aseguramientos_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Aseguramientos.Aseguramientos_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Aseguramientos.Aseguramientos_Datos_Generales>(false, null);
            }
        }

public ApiResponse<int> Update_Medios_de_Transporte_Involucrados(Aseguramientos_Medios_de_Transporte_Involucrados entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Medios_de_Transporte_Involucrados",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Aseguramientos_Medios_de_Transporte_Involucrados> Get_Medios_de_Transporte_Involucrados(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Aseguramientos.Aseguramientos_Medios_de_Transporte_Involucrados>(baseApi, ApiControllerUrl + "/Get_Medios_de_Transporte_Involucrados?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Aseguramientos.Aseguramientos_Medios_de_Transporte_Involucrados>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Aseguramientos.Aseguramientos_Medios_de_Transporte_Involucrados>(false, null);
            }
        }

public ApiResponse<int> Update_Drogas_Involucradas(Aseguramientos_Drogas_Involucradas entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Drogas_Involucradas",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Aseguramientos_Drogas_Involucradas> Get_Drogas_Involucradas(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Aseguramientos.Aseguramientos_Drogas_Involucradas>(baseApi, ApiControllerUrl + "/Get_Drogas_Involucradas?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Aseguramientos.Aseguramientos_Drogas_Involucradas>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Aseguramientos.Aseguramientos_Drogas_Involucradas>(false, null);
            }
        }

public ApiResponse<int> Update_Armas_Involucradas(Aseguramientos_Armas_Involucradas entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Armas_Involucradas",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Aseguramientos_Armas_Involucradas> Get_Armas_Involucradas(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Aseguramientos.Aseguramientos_Armas_Involucradas>(baseApi, ApiControllerUrl + "/Get_Armas_Involucradas?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Aseguramientos.Aseguramientos_Armas_Involucradas>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Aseguramientos.Aseguramientos_Armas_Involucradas>(false, null);
            }
        }

public ApiResponse<int> Update_Objetos_Asegurados(Aseguramientos_Objetos_Asegurados entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Objetos_Asegurados",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Aseguramientos_Objetos_Asegurados> Get_Objetos_Asegurados(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Aseguramientos.Aseguramientos_Objetos_Asegurados>(baseApi, ApiControllerUrl + "/Get_Objetos_Asegurados?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Aseguramientos.Aseguramientos_Objetos_Asegurados>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Aseguramientos.Aseguramientos_Objetos_Asegurados>(false, null);
            }
        }

public ApiResponse<int> Update_Otros_Aseguramientos(Aseguramientos_Otros_Aseguramientos entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Otros_Aseguramientos",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Aseguramientos_Otros_Aseguramientos> Get_Otros_Aseguramientos(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Aseguramientos.Aseguramientos_Otros_Aseguramientos>(baseApi, ApiControllerUrl + "/Get_Otros_Aseguramientos?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Aseguramientos.Aseguramientos_Otros_Aseguramientos>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Aseguramientos.Aseguramientos_Otros_Aseguramientos>(false, null);
            }
        }


    }
}

