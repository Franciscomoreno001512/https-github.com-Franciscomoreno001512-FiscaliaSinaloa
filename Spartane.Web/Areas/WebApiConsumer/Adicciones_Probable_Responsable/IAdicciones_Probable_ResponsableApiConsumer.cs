using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Adicciones_Probable_Responsable
{
    public interface IAdicciones_Probable_ResponsableApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Adicciones_Probable_Responsable.Adicciones_Probable_Responsable>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Adicciones_Probable_Responsable.Adicciones_Probable_Responsable>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Adicciones_Probable_Responsable.Adicciones_Probable_Responsable> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Adicciones_Probable_Responsable.Adicciones_Probable_ResponsablePagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Adicciones_Probable_ResponsableInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Adicciones_Probable_Responsable.Adicciones_Probable_Responsable entity, Spartane.Core.Domain.User.GlobalData Adicciones_Probable_ResponsableInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Adicciones_Probable_Responsable.Adicciones_Probable_Responsable entity, Spartane.Core.Domain.User.GlobalData Adicciones_Probable_ResponsableInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Adicciones_Probable_Responsable.Adicciones_Probable_Responsable>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Adicciones_Probable_Responsable.Adicciones_Probable_Responsable>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Adicciones_Probable_Responsable.Adicciones_Probable_Responsable>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Adicciones_Probable_Responsable.Adicciones_Probable_ResponsablePagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Adicciones_Probable_Responsable.Adicciones_Probable_Responsable>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Adicciones_Probable_Responsable.Adicciones_Probable_Responsable_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Adicciones_Probable_Responsable.Adicciones_Probable_Responsable_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

