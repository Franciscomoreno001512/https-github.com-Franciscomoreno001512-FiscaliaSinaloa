using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Datos_de_los_Hechos_PC;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Datos_de_los_Hechos_PC
{
    public class Datos_de_los_Hechos_PCApiConsumer : BaseApiConsumer,IDatos_de_los_Hechos_PCApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Datos_de_los_Hechos_PCApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Datos_de_los_Hechos_PC";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC>(false, null);
            }
        }

        public ApiResponse<Datos_de_los_Hechos_PCPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PCPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Datos_de_los_Hechos_PC.Clave='" + Key.ToString() + "'"
                        + "&Order=Datos_de_los_Hechos_PC.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PCPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PCPagingModel>(false, new Datos_de_los_Hechos_PCPagingModel() { Datos_de_los_Hechos_PCs = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Datos_de_los_Hechos_PCInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC entity, Core.Domain.User.GlobalData Datos_de_los_Hechos_PCInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC entity, Core.Domain.User.GlobalData Datos_de_los_Hechos_PCInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Datos_de_los_Hechos_PCPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PCPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PCPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PCPagingModel>(false, new Datos_de_los_Hechos_PCPagingModel() { Datos_de_los_Hechos_PCs = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Datos_de_los_Hechos_PCGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_de_los_hechos(Datos_de_los_Hechos_PC_Datos_de_los_hechos entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Datos_de_los_hechos",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Datos_de_los_Hechos_PC_Datos_de_los_hechos> Get_Datos_de_los_hechos(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC_Datos_de_los_hechos>(baseApi, ApiControllerUrl + "/Get_Datos_de_los_hechos?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC_Datos_de_los_hechos>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC_Datos_de_los_hechos>(false, null);
            }
        }

public ApiResponse<int> Update_Lugar_de_los_Hechos(Datos_de_los_Hechos_PC_Lugar_de_los_Hechos entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Lugar_de_los_Hechos",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Datos_de_los_Hechos_PC_Lugar_de_los_Hechos> Get_Lugar_de_los_Hechos(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC_Lugar_de_los_Hechos>(baseApi, ApiControllerUrl + "/Get_Lugar_de_los_Hechos?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC_Lugar_de_los_Hechos>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC_Lugar_de_los_Hechos>(false, null);
            }
        }


    }
}

