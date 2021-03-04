using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Detalle_subareas_responsable_servicio_apoyo
{
    public interface IDetalle_subareas_responsable_servicio_apoyoApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Detalle_subareas_responsable_servicio_apoyo.Detalle_subareas_responsable_servicio_apoyo>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_subareas_responsable_servicio_apoyo.Detalle_subareas_responsable_servicio_apoyo>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Detalle_subareas_responsable_servicio_apoyo.Detalle_subareas_responsable_servicio_apoyo> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Detalle_subareas_responsable_servicio_apoyo.Detalle_subareas_responsable_servicio_apoyoPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_subareas_responsable_servicio_apoyoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Detalle_subareas_responsable_servicio_apoyo.Detalle_subareas_responsable_servicio_apoyo entity, Spartane.Core.Domain.User.GlobalData Detalle_subareas_responsable_servicio_apoyoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Detalle_subareas_responsable_servicio_apoyo.Detalle_subareas_responsable_servicio_apoyo entity, Spartane.Core.Domain.User.GlobalData Detalle_subareas_responsable_servicio_apoyoInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Detalle_subareas_responsable_servicio_apoyo.Detalle_subareas_responsable_servicio_apoyo>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_subareas_responsable_servicio_apoyo.Detalle_subareas_responsable_servicio_apoyo>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_subareas_responsable_servicio_apoyo.Detalle_subareas_responsable_servicio_apoyo>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Detalle_subareas_responsable_servicio_apoyo.Detalle_subareas_responsable_servicio_apoyoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_subareas_responsable_servicio_apoyo.Detalle_subareas_responsable_servicio_apoyo>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Detalle_subareas_responsable_servicio_apoyo.Detalle_subareas_responsable_servicio_apoyo_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Detalle_subareas_responsable_servicio_apoyo.Detalle_subareas_responsable_servicio_apoyo_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

