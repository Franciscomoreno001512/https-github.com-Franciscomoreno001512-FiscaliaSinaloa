﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Detalle_de_Asignacion_de_Especialista
{
    public interface IDetalle_de_Asignacion_de_EspecialistaApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista> GetByKey(short Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_EspecialistaPagingModel> GetByKeyComplete(short Key);
        ApiResponse<bool> Delete(short Key, Spartane.Core.Domain.User.GlobalData Detalle_de_Asignacion_de_EspecialistaInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int16> Insert(Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Asignacion_de_EspecialistaInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int16> Update(Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Asignacion_de_EspecialistaInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_EspecialistaPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<short> GenerateID();
		ApiResponse<short> Update_Datos_Generales(Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Detalle_de_Asignacion_de_Especialista.Detalle_de_Asignacion_de_Especialista_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

