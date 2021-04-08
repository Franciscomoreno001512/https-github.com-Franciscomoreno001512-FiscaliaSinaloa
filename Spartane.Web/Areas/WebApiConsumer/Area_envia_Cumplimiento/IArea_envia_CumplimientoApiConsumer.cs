using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Area_envia_Cumplimiento
{
    public interface IArea_envia_CumplimientoApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Area_envia_Cumplimiento.Area_envia_CumplimientoPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Area_envia_CumplimientoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento entity, Spartane.Core.Domain.User.GlobalData Area_envia_CumplimientoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento entity, Spartane.Core.Domain.User.GlobalData Area_envia_CumplimientoInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Area_envia_Cumplimiento.Area_envia_CumplimientoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

