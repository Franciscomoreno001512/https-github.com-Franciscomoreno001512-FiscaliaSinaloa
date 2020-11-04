using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Historial_de_Conversacion
{
    public interface IHistorial_de_ConversacionApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Historial_de_Conversacion.Historial_de_Conversacion>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Historial_de_Conversacion.Historial_de_Conversacion>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Historial_de_Conversacion.Historial_de_Conversacion> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Historial_de_Conversacion.Historial_de_ConversacionPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Historial_de_ConversacionInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Historial_de_Conversacion.Historial_de_Conversacion entity, Spartane.Core.Domain.User.GlobalData Historial_de_ConversacionInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Historial_de_Conversacion.Historial_de_Conversacion entity, Spartane.Core.Domain.User.GlobalData Historial_de_ConversacionInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Historial_de_Conversacion.Historial_de_Conversacion>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Historial_de_Conversacion.Historial_de_Conversacion>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Historial_de_Conversacion.Historial_de_Conversacion>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Historial_de_Conversacion.Historial_de_ConversacionPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Historial_de_Conversacion.Historial_de_Conversacion>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Historial_de_Conversacion.Historial_de_Conversacion_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Historial_de_Conversacion.Historial_de_Conversacion_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

