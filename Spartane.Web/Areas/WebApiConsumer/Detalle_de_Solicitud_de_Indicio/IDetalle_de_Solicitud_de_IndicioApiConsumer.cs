using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Detalle_de_Solicitud_de_Indicio
{
    public interface IDetalle_de_Solicitud_de_IndicioApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Solicitud_de_Indicio.Detalle_de_Solicitud_de_Indicio>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Solicitud_de_Indicio.Detalle_de_Solicitud_de_Indicio>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Detalle_de_Solicitud_de_Indicio.Detalle_de_Solicitud_de_Indicio> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Detalle_de_Solicitud_de_Indicio.Detalle_de_Solicitud_de_IndicioPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_de_Solicitud_de_IndicioInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Detalle_de_Solicitud_de_Indicio.Detalle_de_Solicitud_de_Indicio entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Solicitud_de_IndicioInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Detalle_de_Solicitud_de_Indicio.Detalle_de_Solicitud_de_Indicio entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Solicitud_de_IndicioInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Solicitud_de_Indicio.Detalle_de_Solicitud_de_Indicio>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Solicitud_de_Indicio.Detalle_de_Solicitud_de_Indicio>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Solicitud_de_Indicio.Detalle_de_Solicitud_de_Indicio>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Detalle_de_Solicitud_de_Indicio.Detalle_de_Solicitud_de_IndicioPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Solicitud_de_Indicio.Detalle_de_Solicitud_de_Indicio>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Detalle_de_Solicitud_de_Indicio.Detalle_de_Solicitud_de_Indicio_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Detalle_de_Solicitud_de_Indicio.Detalle_de_Solicitud_de_Indicio_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

