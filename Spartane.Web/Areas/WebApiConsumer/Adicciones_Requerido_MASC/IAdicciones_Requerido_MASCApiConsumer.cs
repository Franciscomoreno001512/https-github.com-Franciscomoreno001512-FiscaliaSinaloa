using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Adicciones_Requerido_MASC
{
    public interface IAdicciones_Requerido_MASCApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Adicciones_Requerido_MASC.Adicciones_Requerido_MASC>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Adicciones_Requerido_MASC.Adicciones_Requerido_MASC>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Adicciones_Requerido_MASC.Adicciones_Requerido_MASC> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Adicciones_Requerido_MASC.Adicciones_Requerido_MASCPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Adicciones_Requerido_MASCInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Adicciones_Requerido_MASC.Adicciones_Requerido_MASC entity, Spartane.Core.Domain.User.GlobalData Adicciones_Requerido_MASCInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Adicciones_Requerido_MASC.Adicciones_Requerido_MASC entity, Spartane.Core.Domain.User.GlobalData Adicciones_Requerido_MASCInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Adicciones_Requerido_MASC.Adicciones_Requerido_MASC>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Adicciones_Requerido_MASC.Adicciones_Requerido_MASC>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Adicciones_Requerido_MASC.Adicciones_Requerido_MASC>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Adicciones_Requerido_MASC.Adicciones_Requerido_MASCPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Adicciones_Requerido_MASC.Adicciones_Requerido_MASC>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Adicciones_Requerido_MASC.Adicciones_Requerido_MASC_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Adicciones_Requerido_MASC.Adicciones_Requerido_MASC_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

