using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Razon_de_Incumplimiento
{
    public interface IRazon_de_IncumplimientoApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Razon_de_Incumplimiento.Razon_de_Incumplimiento>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Razon_de_Incumplimiento.Razon_de_Incumplimiento>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Razon_de_Incumplimiento.Razon_de_Incumplimiento> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Razon_de_Incumplimiento.Razon_de_IncumplimientoPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Razon_de_IncumplimientoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Razon_de_Incumplimiento.Razon_de_Incumplimiento entity, Spartane.Core.Domain.User.GlobalData Razon_de_IncumplimientoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Razon_de_Incumplimiento.Razon_de_Incumplimiento entity, Spartane.Core.Domain.User.GlobalData Razon_de_IncumplimientoInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Razon_de_Incumplimiento.Razon_de_Incumplimiento>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Razon_de_Incumplimiento.Razon_de_Incumplimiento>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Razon_de_Incumplimiento.Razon_de_Incumplimiento>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Razon_de_Incumplimiento.Razon_de_IncumplimientoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Razon_de_Incumplimiento.Razon_de_Incumplimiento>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Razon_de_Incumplimiento.Razon_de_Incumplimiento_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Razon_de_Incumplimiento.Razon_de_Incumplimiento_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

