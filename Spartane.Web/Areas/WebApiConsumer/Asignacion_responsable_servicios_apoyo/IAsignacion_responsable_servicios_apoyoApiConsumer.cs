using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Asignacion_responsable_servicios_apoyo
{
    public interface IAsignacion_responsable_servicios_apoyoApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Asignacion_responsable_servicios_apoyo.Asignacion_responsable_servicios_apoyo>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Asignacion_responsable_servicios_apoyo.Asignacion_responsable_servicios_apoyo>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Asignacion_responsable_servicios_apoyo.Asignacion_responsable_servicios_apoyo> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Asignacion_responsable_servicios_apoyo.Asignacion_responsable_servicios_apoyoPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Asignacion_responsable_servicios_apoyoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Asignacion_responsable_servicios_apoyo.Asignacion_responsable_servicios_apoyo entity, Spartane.Core.Domain.User.GlobalData Asignacion_responsable_servicios_apoyoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Asignacion_responsable_servicios_apoyo.Asignacion_responsable_servicios_apoyo entity, Spartane.Core.Domain.User.GlobalData Asignacion_responsable_servicios_apoyoInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Asignacion_responsable_servicios_apoyo.Asignacion_responsable_servicios_apoyo>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Asignacion_responsable_servicios_apoyo.Asignacion_responsable_servicios_apoyo>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Asignacion_responsable_servicios_apoyo.Asignacion_responsable_servicios_apoyo>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Asignacion_responsable_servicios_apoyo.Asignacion_responsable_servicios_apoyoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Asignacion_responsable_servicios_apoyo.Asignacion_responsable_servicios_apoyo>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Asignacion_responsable_servicios_apoyo.Asignacion_responsable_servicios_apoyo_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Asignacion_responsable_servicios_apoyo.Asignacion_responsable_servicios_apoyo_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

