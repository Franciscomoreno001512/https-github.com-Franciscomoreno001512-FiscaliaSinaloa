using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Detalle_Condiciones_Proceso_Penal
{
    public interface IDetalle_Condiciones_Proceso_PenalApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Detalle_Condiciones_Proceso_Penal.Detalle_Condiciones_Proceso_Penal>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_Condiciones_Proceso_Penal.Detalle_Condiciones_Proceso_Penal>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Detalle_Condiciones_Proceso_Penal.Detalle_Condiciones_Proceso_Penal> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Detalle_Condiciones_Proceso_Penal.Detalle_Condiciones_Proceso_PenalPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_Condiciones_Proceso_PenalInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Detalle_Condiciones_Proceso_Penal.Detalle_Condiciones_Proceso_Penal entity, Spartane.Core.Domain.User.GlobalData Detalle_Condiciones_Proceso_PenalInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Detalle_Condiciones_Proceso_Penal.Detalle_Condiciones_Proceso_Penal entity, Spartane.Core.Domain.User.GlobalData Detalle_Condiciones_Proceso_PenalInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Detalle_Condiciones_Proceso_Penal.Detalle_Condiciones_Proceso_Penal>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_Condiciones_Proceso_Penal.Detalle_Condiciones_Proceso_Penal>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_Condiciones_Proceso_Penal.Detalle_Condiciones_Proceso_Penal>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Detalle_Condiciones_Proceso_Penal.Detalle_Condiciones_Proceso_PenalPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_Condiciones_Proceso_Penal.Detalle_Condiciones_Proceso_Penal>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Detalle_Condiciones_Proceso_Penal.Detalle_Condiciones_Proceso_Penal_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Detalle_Condiciones_Proceso_Penal.Detalle_Condiciones_Proceso_Penal_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

