using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Motivo_Finalizacion_Turno
{
    public interface IMotivo_Finalizacion_TurnoApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_TurnoPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Motivo_Finalizacion_TurnoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno entity, Spartane.Core.Domain.User.GlobalData Motivo_Finalizacion_TurnoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno entity, Spartane.Core.Domain.User.GlobalData Motivo_Finalizacion_TurnoInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_TurnoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Motivo_Finalizacion_Turno.Motivo_Finalizacion_Turno_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

