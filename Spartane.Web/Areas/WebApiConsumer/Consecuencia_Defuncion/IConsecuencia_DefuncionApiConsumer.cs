﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Consecuencia_Defuncion
{
    public interface IConsecuencia_DefuncionApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Consecuencia_Defuncion.Consecuencia_Defuncion>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Consecuencia_Defuncion.Consecuencia_Defuncion>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Consecuencia_Defuncion.Consecuencia_Defuncion> GetByKey(short Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Consecuencia_Defuncion.Consecuencia_DefuncionPagingModel> GetByKeyComplete(short Key);
        ApiResponse<bool> Delete(short Key, Spartane.Core.Domain.User.GlobalData Consecuencia_DefuncionInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int16> Insert(Spartane.Core.Domain.Consecuencia_Defuncion.Consecuencia_Defuncion entity, Spartane.Core.Domain.User.GlobalData Consecuencia_DefuncionInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int16> Update(Spartane.Core.Domain.Consecuencia_Defuncion.Consecuencia_Defuncion entity, Spartane.Core.Domain.User.GlobalData Consecuencia_DefuncionInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Consecuencia_Defuncion.Consecuencia_Defuncion>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Consecuencia_Defuncion.Consecuencia_Defuncion>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Consecuencia_Defuncion.Consecuencia_Defuncion>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Consecuencia_Defuncion.Consecuencia_DefuncionPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Consecuencia_Defuncion.Consecuencia_Defuncion>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<short> GenerateID();
		ApiResponse<short> Update_Datos_Generales(Spartane.Core.Domain.Consecuencia_Defuncion.Consecuencia_Defuncion_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Consecuencia_Defuncion.Consecuencia_Defuncion_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

