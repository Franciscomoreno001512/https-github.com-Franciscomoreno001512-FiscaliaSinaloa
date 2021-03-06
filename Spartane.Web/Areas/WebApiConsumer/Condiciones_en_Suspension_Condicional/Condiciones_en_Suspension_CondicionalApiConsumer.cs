﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Condiciones_en_Suspension_Condicional;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Condiciones_en_Suspension_Condicional
{
    public class Condiciones_en_Suspension_CondicionalApiConsumer : BaseApiConsumer,ICondiciones_en_Suspension_CondicionalApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Condiciones_en_Suspension_CondicionalApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Condiciones_en_Suspension_Condicional";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional>(false, null);
            }
        }

        public ApiResponse<Condiciones_en_Suspension_CondicionalPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_CondicionalPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Condiciones_en_Suspension_Condicional.Clave='" + Key.ToString() + "'"
                        + "&Order=Condiciones_en_Suspension_Condicional.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_CondicionalPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_CondicionalPagingModel>(false, new Condiciones_en_Suspension_CondicionalPagingModel() { Condiciones_en_Suspension_Condicionals = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Condiciones_en_Suspension_CondicionalInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional entity, Core.Domain.User.GlobalData Condiciones_en_Suspension_CondicionalInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional entity, Core.Domain.User.GlobalData Condiciones_en_Suspension_CondicionalInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Condiciones_en_Suspension_CondicionalPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_CondicionalPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_CondicionalPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_CondicionalPagingModel>(false, new Condiciones_en_Suspension_CondicionalPagingModel() { Condiciones_en_Suspension_Condicionals = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Condiciones_en_Suspension_CondicionalGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Condiciones_en_Suspension_Condicional_Datos_Generales entity)
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

        public ApiResponse<Condiciones_en_Suspension_Condicional_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional_Datos_Generales>(false, null);
            }
        }


    }
}

