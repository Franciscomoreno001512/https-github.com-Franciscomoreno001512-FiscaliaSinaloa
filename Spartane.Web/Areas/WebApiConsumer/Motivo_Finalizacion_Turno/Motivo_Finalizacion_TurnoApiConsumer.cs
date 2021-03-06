﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Motivo_Finalizacion_Turno;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Motivo_Finalizacion_Turno
{
    public class Motivo_Finalizacion_TurnoApiConsumer : BaseApiConsumer,IMotivo_Finalizacion_TurnoApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Motivo_Finalizacion_TurnoApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Motivo_Finalizacion_Turno";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno>(false, null);
            }
        }

        public ApiResponse<Motivo_Finalizacion_TurnoPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_TurnoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Motivo_Finalizacion_Turno.Clave='" + Key.ToString() + "'"
                        + "&Order=Motivo_Finalizacion_Turno.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_TurnoPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_TurnoPagingModel>(false, new Motivo_Finalizacion_TurnoPagingModel() { Motivo_Finalizacion_Turnos = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Motivo_Finalizacion_TurnoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno entity, Core.Domain.User.GlobalData Motivo_Finalizacion_TurnoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno entity, Core.Domain.User.GlobalData Motivo_Finalizacion_TurnoInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<IList<Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Motivo_Finalizacion_TurnoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_TurnoPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_TurnoPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_TurnoPagingModel>(false, new Motivo_Finalizacion_TurnoPagingModel() { Motivo_Finalizacion_Turnos = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Motivo_Finalizacion_TurnoGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Motivo_Finalizacion_Turno_Datos_Generales entity)
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

        public ApiResponse<Motivo_Finalizacion_Turno_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno_Datos_Generales>(false, null);
            }
        }


    }
}

