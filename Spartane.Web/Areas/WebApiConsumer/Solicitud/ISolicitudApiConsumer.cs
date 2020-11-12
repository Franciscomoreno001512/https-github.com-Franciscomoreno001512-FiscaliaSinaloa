using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Solicitud
{
    public interface ISolicitudApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Solicitud.Solicitud>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Solicitud.Solicitud>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Solicitud.Solicitud> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Solicitud.SolicitudPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData SolicitudInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Solicitud.Solicitud entity, Spartane.Core.Domain.User.GlobalData SolicitudInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Solicitud.Solicitud entity, Spartane.Core.Domain.User.GlobalData SolicitudInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Solicitud.Solicitud>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Solicitud.Solicitud>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Solicitud.Solicitud>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Solicitud.SolicitudPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Solicitud.Solicitud>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Solicitud(Spartane.Core.Domain.Solicitud.Solicitud_Solicitud entity);
		ApiResponse<Spartane.Core.Domain.Solicitud.Solicitud_Solicitud> Get_Solicitud(string Key);

		ApiResponse<int> Update_Control(Spartane.Core.Domain.Solicitud.Solicitud_Control entity);
		ApiResponse<Spartane.Core.Domain.Solicitud.Solicitud_Control> Get_Control(string Key);

		ApiResponse<int> Update_Hechos(Spartane.Core.Domain.Solicitud.Solicitud_Hechos entity);
		ApiResponse<Spartane.Core.Domain.Solicitud.Solicitud_Hechos> Get_Hechos(string Key);

		ApiResponse<int> Update_Cierre(Spartane.Core.Domain.Solicitud.Solicitud_Cierre entity);
		ApiResponse<Spartane.Core.Domain.Solicitud.Solicitud_Cierre> Get_Cierre(string Key);

		ApiResponse<int> Update_Asignacion(Spartane.Core.Domain.Solicitud.Solicitud_Asignacion entity);
		ApiResponse<Spartane.Core.Domain.Solicitud.Solicitud_Asignacion> Get_Asignacion(string Key);

		ApiResponse<int> Update_Bitacora_de_Coincidencias(Spartane.Core.Domain.Solicitud.Solicitud_Bitacora_de_Coincidencias entity);
		ApiResponse<Spartane.Core.Domain.Solicitud.Solicitud_Bitacora_de_Coincidencias> Get_Bitacora_de_Coincidencias(string Key);

		ApiResponse<int> Update_Historial_de_Movimientos(Spartane.Core.Domain.Solicitud.Solicitud_Historial_de_Movimientos entity);
		ApiResponse<Spartane.Core.Domain.Solicitud.Solicitud_Historial_de_Movimientos> Get_Historial_de_Movimientos(string Key);


    }
}

