using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Detalle_Solicitud_Disponibles_Configuracion
{
    public interface IDetalle_Solicitud_Disponibles_ConfiguracionApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Detalle_Solicitud_Disponibles_Configuracion.Detalle_Solicitud_Disponibles_Configuracion>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_Solicitud_Disponibles_Configuracion.Detalle_Solicitud_Disponibles_Configuracion>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Detalle_Solicitud_Disponibles_Configuracion.Detalle_Solicitud_Disponibles_Configuracion> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Detalle_Solicitud_Disponibles_Configuracion.Detalle_Solicitud_Disponibles_ConfiguracionPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_Solicitud_Disponibles_ConfiguracionInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Detalle_Solicitud_Disponibles_Configuracion.Detalle_Solicitud_Disponibles_Configuracion entity, Spartane.Core.Domain.User.GlobalData Detalle_Solicitud_Disponibles_ConfiguracionInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Detalle_Solicitud_Disponibles_Configuracion.Detalle_Solicitud_Disponibles_Configuracion entity, Spartane.Core.Domain.User.GlobalData Detalle_Solicitud_Disponibles_ConfiguracionInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Detalle_Solicitud_Disponibles_Configuracion.Detalle_Solicitud_Disponibles_Configuracion>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_Solicitud_Disponibles_Configuracion.Detalle_Solicitud_Disponibles_Configuracion>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_Solicitud_Disponibles_Configuracion.Detalle_Solicitud_Disponibles_Configuracion>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Detalle_Solicitud_Disponibles_Configuracion.Detalle_Solicitud_Disponibles_ConfiguracionPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_Solicitud_Disponibles_Configuracion.Detalle_Solicitud_Disponibles_Configuracion>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Detalle_Solicitud_Disponibles_Configuracion.Detalle_Solicitud_Disponibles_Configuracion_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Detalle_Solicitud_Disponibles_Configuracion.Detalle_Solicitud_Disponibles_Configuracion_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

