using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Detalle_de_Solicitudes_de_Invitaciones
{
    public interface IDetalle_de_Solicitudes_de_InvitacionesApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_InvitacionesPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_de_Solicitudes_de_InvitacionesInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Solicitudes_de_InvitacionesInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Solicitudes_de_InvitacionesInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_InvitacionesPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones_Datos_Generales> Get_Datos_Generales(string Key);

		ApiResponse<int> Update_Resultado_de_Notificacion(Spartane.Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones_Resultado_de_Notificacion entity);
		ApiResponse<Spartane.Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones_Resultado_de_Notificacion> Get_Resultado_de_Notificacion(string Key);


    }
}

