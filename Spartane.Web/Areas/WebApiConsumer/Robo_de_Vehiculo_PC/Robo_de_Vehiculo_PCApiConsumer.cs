using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Robo_de_Vehiculo_PC;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Robo_de_Vehiculo_PC
{
    public class Robo_de_Vehiculo_PCApiConsumer : BaseApiConsumer,IRobo_de_Vehiculo_PCApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Robo_de_Vehiculo_PCApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Robo_de_Vehiculo_PC";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PC>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PC>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PC>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PC>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PC>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PC>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PC>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PC>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PC> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PC>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PC>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PC>(false, null);
            }
        }

        public ApiResponse<Robo_de_Vehiculo_PCPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PCPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Robo_de_Vehiculo_PC.Clave='" + Key.ToString() + "'"
                        + "&Order=Robo_de_Vehiculo_PC.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PCPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PCPagingModel>(false, new Robo_de_Vehiculo_PCPagingModel() { Robo_de_Vehiculo_PCs = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Robo_de_Vehiculo_PCInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PC entity, Core.Domain.User.GlobalData Robo_de_Vehiculo_PCInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PC entity, Core.Domain.User.GlobalData Robo_de_Vehiculo_PCInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PC>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PC>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PC>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Robo_de_Vehiculo_PCPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PCPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PCPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PCPagingModel>(false, new Robo_de_Vehiculo_PCPagingModel() { Robo_de_Vehiculo_PCs = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PC>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Robo_de_Vehiculo_PCGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Robo_de_Vehiculo_PC_Datos_Generales entity)
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

        public ApiResponse<Robo_de_Vehiculo_PC_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PC_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PC_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PC_Datos_Generales>(false, null);
            }
        }


    }
}

