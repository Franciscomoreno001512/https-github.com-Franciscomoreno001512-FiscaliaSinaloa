using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Probable_Responsable_PC;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Probable_Responsable_PC
{
    public class Probable_Responsable_PCApiConsumer : BaseApiConsumer,IProbable_Responsable_PCApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Probable_Responsable_PCApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Probable_Responsable_PC";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC>(false, null);
            }
        }

        public ApiResponse<Probable_Responsable_PCPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Probable_Responsable_PC.Probable_Responsable_PCPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Probable_Responsable_PC.Clave='" + Key.ToString() + "'"
                        + "&Order=Probable_Responsable_PC.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Probable_Responsable_PC.Probable_Responsable_PCPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Probable_Responsable_PC.Probable_Responsable_PCPagingModel>(false, new Probable_Responsable_PCPagingModel() { Probable_Responsable_PCs = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Probable_Responsable_PCInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC entity, Core.Domain.User.GlobalData Probable_Responsable_PCInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC entity, Core.Domain.User.GlobalData Probable_Responsable_PCInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Probable_Responsable_PCPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Probable_Responsable_PC.Probable_Responsable_PCPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Probable_Responsable_PC.Probable_Responsable_PCPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Probable_Responsable_PC.Probable_Responsable_PCPagingModel>(false, new Probable_Responsable_PCPagingModel() { Probable_Responsable_PCs = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Probable_Responsable_PCGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Probable_Responsable_PC_Datos_Generales entity)
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

        public ApiResponse<Probable_Responsable_PC_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC_Datos_Generales>(false, null);
            }
        }

public ApiResponse<int> Update_Domicilio(Probable_Responsable_PC_Domicilio entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Domicilio",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Probable_Responsable_PC_Domicilio> Get_Domicilio(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC_Domicilio>(baseApi, ApiControllerUrl + "/Get_Domicilio?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC_Domicilio>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC_Domicilio>(false, null);
            }
        }

public ApiResponse<int> Update_Datos_de_Media_Filiacion(Probable_Responsable_PC_Datos_de_Media_Filiacion entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Datos_de_Media_Filiacion",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Probable_Responsable_PC_Datos_de_Media_Filiacion> Get_Datos_de_Media_Filiacion(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC_Datos_de_Media_Filiacion>(baseApi, ApiControllerUrl + "/Get_Datos_de_Media_Filiacion?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC_Datos_de_Media_Filiacion>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC_Datos_de_Media_Filiacion>(false, null);
            }
        }


    }
}

