﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Detalle_de_Huellas_Digitales
{
    public interface IDetalle_de_Huellas_DigitalesApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Huellas_Digitales.Detalle_de_Huellas_Digitales>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Huellas_Digitales.Detalle_de_Huellas_Digitales>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Detalle_de_Huellas_Digitales.Detalle_de_Huellas_Digitales> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Detalle_de_Huellas_Digitales.Detalle_de_Huellas_DigitalesPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_de_Huellas_DigitalesInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Detalle_de_Huellas_Digitales.Detalle_de_Huellas_Digitales entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Huellas_DigitalesInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Detalle_de_Huellas_Digitales.Detalle_de_Huellas_Digitales entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Huellas_DigitalesInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Huellas_Digitales.Detalle_de_Huellas_Digitales>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Huellas_Digitales.Detalle_de_Huellas_Digitales>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Huellas_Digitales.Detalle_de_Huellas_Digitales>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Detalle_de_Huellas_Digitales.Detalle_de_Huellas_DigitalesPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Huellas_Digitales.Detalle_de_Huellas_Digitales>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Detalle_de_Huellas_Digitales.Detalle_de_Huellas_Digitales_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Detalle_de_Huellas_Digitales.Detalle_de_Huellas_Digitales_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

