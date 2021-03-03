﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Solicitud_de_Servicios_de_Apoyo
{
    public interface ISolicitud_de_Servicios_de_ApoyoApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Solicitud_de_Servicios_de_Apoyo.Solicitud_de_Servicios_de_Apoyo>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Solicitud_de_Servicios_de_Apoyo.Solicitud_de_Servicios_de_Apoyo>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Solicitud_de_Servicios_de_Apoyo.Solicitud_de_Servicios_de_Apoyo> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Solicitud_de_Servicios_de_Apoyo.Solicitud_de_Servicios_de_ApoyoPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Solicitud_de_Servicios_de_ApoyoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Solicitud_de_Servicios_de_Apoyo.Solicitud_de_Servicios_de_Apoyo entity, Spartane.Core.Domain.User.GlobalData Solicitud_de_Servicios_de_ApoyoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Solicitud_de_Servicios_de_Apoyo.Solicitud_de_Servicios_de_Apoyo entity, Spartane.Core.Domain.User.GlobalData Solicitud_de_Servicios_de_ApoyoInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Solicitud_de_Servicios_de_Apoyo.Solicitud_de_Servicios_de_Apoyo>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Solicitud_de_Servicios_de_Apoyo.Solicitud_de_Servicios_de_Apoyo>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Solicitud_de_Servicios_de_Apoyo.Solicitud_de_Servicios_de_Apoyo>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Solicitud_de_Servicios_de_Apoyo.Solicitud_de_Servicios_de_ApoyoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Solicitud_de_Servicios_de_Apoyo.Solicitud_de_Servicios_de_Apoyo>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Solicitud_de_Servicios_de_Apoyo.Solicitud_de_Servicios_de_Apoyo_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Solicitud_de_Servicios_de_Apoyo.Solicitud_de_Servicios_de_Apoyo_Datos_Generales> Get_Datos_Generales(string Key);

		ApiResponse<int> Update_Recepcion(Spartane.Core.Domain.Solicitud_de_Servicios_de_Apoyo.Solicitud_de_Servicios_de_Apoyo_Recepcion entity);
		ApiResponse<Spartane.Core.Domain.Solicitud_de_Servicios_de_Apoyo.Solicitud_de_Servicios_de_Apoyo_Recepcion> Get_Recepcion(string Key);

		ApiResponse<int> Update_Asignacion(Spartane.Core.Domain.Solicitud_de_Servicios_de_Apoyo.Solicitud_de_Servicios_de_Apoyo_Asignacion entity);
		ApiResponse<Spartane.Core.Domain.Solicitud_de_Servicios_de_Apoyo.Solicitud_de_Servicios_de_Apoyo_Asignacion> Get_Asignacion(string Key);

		ApiResponse<int> Update_Contestacion(Spartane.Core.Domain.Solicitud_de_Servicios_de_Apoyo.Solicitud_de_Servicios_de_Apoyo_Contestacion entity);
		ApiResponse<Spartane.Core.Domain.Solicitud_de_Servicios_de_Apoyo.Solicitud_de_Servicios_de_Apoyo_Contestacion> Get_Contestacion(string Key);

		ApiResponse<int> Update_Autorizacion(Spartane.Core.Domain.Solicitud_de_Servicios_de_Apoyo.Solicitud_de_Servicios_de_Apoyo_Autorizacion entity);
		ApiResponse<Spartane.Core.Domain.Solicitud_de_Servicios_de_Apoyo.Solicitud_de_Servicios_de_Apoyo_Autorizacion> Get_Autorizacion(string Key);


    }
}

