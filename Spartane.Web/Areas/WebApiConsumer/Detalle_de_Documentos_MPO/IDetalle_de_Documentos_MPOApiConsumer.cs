﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Detalle_de_Documentos_MPO
{
    public interface IDetalle_de_Documentos_MPOApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Documentos_MPO.Detalle_de_Documentos_MPO>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Documentos_MPO.Detalle_de_Documentos_MPO>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Detalle_de_Documentos_MPO.Detalle_de_Documentos_MPO> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Detalle_de_Documentos_MPO.Detalle_de_Documentos_MPOPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_de_Documentos_MPOInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Detalle_de_Documentos_MPO.Detalle_de_Documentos_MPO entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Documentos_MPOInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Detalle_de_Documentos_MPO.Detalle_de_Documentos_MPO entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Documentos_MPOInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Documentos_MPO.Detalle_de_Documentos_MPO>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Documentos_MPO.Detalle_de_Documentos_MPO>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Documentos_MPO.Detalle_de_Documentos_MPO>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Detalle_de_Documentos_MPO.Detalle_de_Documentos_MPOPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Documentos_MPO.Detalle_de_Documentos_MPO>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Detalle_de_Documentos_MPO.Detalle_de_Documentos_MPO_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Detalle_de_Documentos_MPO.Detalle_de_Documentos_MPO_Datos_Generales> Get_Datos_Generales(string Key);

		ApiResponse<int> Update_Localizacion(Spartane.Core.Domain.Detalle_de_Documentos_MPO.Detalle_de_Documentos_MPO_Localizacion entity);
		ApiResponse<Spartane.Core.Domain.Detalle_de_Documentos_MPO.Detalle_de_Documentos_MPO_Localizacion> Get_Localizacion(string Key);

		ApiResponse<int> Update_Ente_y_Autoridad(Spartane.Core.Domain.Detalle_de_Documentos_MPO.Detalle_de_Documentos_MPO_Ente_y_Autoridad entity);
		ApiResponse<Spartane.Core.Domain.Detalle_de_Documentos_MPO.Detalle_de_Documentos_MPO_Ente_y_Autoridad> Get_Ente_y_Autoridad(string Key);


    }
}

