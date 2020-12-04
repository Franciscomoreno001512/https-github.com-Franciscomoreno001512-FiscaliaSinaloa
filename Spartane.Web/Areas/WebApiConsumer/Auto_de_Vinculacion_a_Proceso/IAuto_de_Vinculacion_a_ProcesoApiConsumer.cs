﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Auto_de_Vinculacion_a_Proceso
{
    public interface IAuto_de_Vinculacion_a_ProcesoApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Auto_de_Vinculacion_a_Proceso.Auto_de_Vinculacion_a_Proceso>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Auto_de_Vinculacion_a_Proceso.Auto_de_Vinculacion_a_Proceso>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Auto_de_Vinculacion_a_Proceso.Auto_de_Vinculacion_a_Proceso> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Auto_de_Vinculacion_a_Proceso.Auto_de_Vinculacion_a_ProcesoPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Auto_de_Vinculacion_a_ProcesoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Auto_de_Vinculacion_a_Proceso.Auto_de_Vinculacion_a_Proceso entity, Spartane.Core.Domain.User.GlobalData Auto_de_Vinculacion_a_ProcesoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Auto_de_Vinculacion_a_Proceso.Auto_de_Vinculacion_a_Proceso entity, Spartane.Core.Domain.User.GlobalData Auto_de_Vinculacion_a_ProcesoInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Auto_de_Vinculacion_a_Proceso.Auto_de_Vinculacion_a_Proceso>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Auto_de_Vinculacion_a_Proceso.Auto_de_Vinculacion_a_Proceso>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Auto_de_Vinculacion_a_Proceso.Auto_de_Vinculacion_a_Proceso>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Auto_de_Vinculacion_a_Proceso.Auto_de_Vinculacion_a_ProcesoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Auto_de_Vinculacion_a_Proceso.Auto_de_Vinculacion_a_Proceso>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Auto_de_Vinculacion_a_Proceso.Auto_de_Vinculacion_a_Proceso_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Auto_de_Vinculacion_a_Proceso.Auto_de_Vinculacion_a_Proceso_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

