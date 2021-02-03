﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Tipo_de_queja_sugerencia
{
    public interface ITipo_de_queja_sugerenciaApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Tipo_de_queja_sugerencia.Tipo_de_queja_sugerencia>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Tipo_de_queja_sugerencia.Tipo_de_queja_sugerencia>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Tipo_de_queja_sugerencia.Tipo_de_queja_sugerencia> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Tipo_de_queja_sugerencia.Tipo_de_queja_sugerenciaPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Tipo_de_queja_sugerenciaInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Tipo_de_queja_sugerencia.Tipo_de_queja_sugerencia entity, Spartane.Core.Domain.User.GlobalData Tipo_de_queja_sugerenciaInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Tipo_de_queja_sugerencia.Tipo_de_queja_sugerencia entity, Spartane.Core.Domain.User.GlobalData Tipo_de_queja_sugerenciaInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Tipo_de_queja_sugerencia.Tipo_de_queja_sugerencia>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Tipo_de_queja_sugerencia.Tipo_de_queja_sugerencia>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Tipo_de_queja_sugerencia.Tipo_de_queja_sugerencia>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Tipo_de_queja_sugerencia.Tipo_de_queja_sugerenciaPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Tipo_de_queja_sugerencia.Tipo_de_queja_sugerencia>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Tipo_de_queja_sugerencia.Tipo_de_queja_sugerencia_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Tipo_de_queja_sugerencia.Tipo_de_queja_sugerencia_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

