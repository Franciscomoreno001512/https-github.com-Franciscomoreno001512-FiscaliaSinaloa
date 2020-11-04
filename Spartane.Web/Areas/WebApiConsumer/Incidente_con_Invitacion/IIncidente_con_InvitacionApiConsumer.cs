using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Incidente_con_Invitacion
{
    public interface IIncidente_con_InvitacionApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Incidente_con_Invitacion.Incidente_con_Invitacion>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Incidente_con_Invitacion.Incidente_con_Invitacion>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Incidente_con_Invitacion.Incidente_con_Invitacion> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Incidente_con_Invitacion.Incidente_con_InvitacionPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Incidente_con_InvitacionInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Incidente_con_Invitacion.Incidente_con_Invitacion entity, Spartane.Core.Domain.User.GlobalData Incidente_con_InvitacionInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Incidente_con_Invitacion.Incidente_con_Invitacion entity, Spartane.Core.Domain.User.GlobalData Incidente_con_InvitacionInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Incidente_con_Invitacion.Incidente_con_Invitacion>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Incidente_con_Invitacion.Incidente_con_Invitacion>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Incidente_con_Invitacion.Incidente_con_Invitacion>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Incidente_con_Invitacion.Incidente_con_InvitacionPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Incidente_con_Invitacion.Incidente_con_Invitacion>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Incidente_con_Invitacion.Incidente_con_Invitacion_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Incidente_con_Invitacion.Incidente_con_Invitacion_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

