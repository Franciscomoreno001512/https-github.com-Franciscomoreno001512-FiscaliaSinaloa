using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Detalle_Diligencias_Canalizacion
{
    public interface IDetalle_Diligencias_CanalizacionApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Detalle_Diligencias_Canalizacion.Detalle_Diligencias_Canalizacion>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_Diligencias_Canalizacion.Detalle_Diligencias_Canalizacion>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Detalle_Diligencias_Canalizacion.Detalle_Diligencias_Canalizacion> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Detalle_Diligencias_Canalizacion.Detalle_Diligencias_CanalizacionPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_Diligencias_CanalizacionInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Detalle_Diligencias_Canalizacion.Detalle_Diligencias_Canalizacion entity, Spartane.Core.Domain.User.GlobalData Detalle_Diligencias_CanalizacionInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Detalle_Diligencias_Canalizacion.Detalle_Diligencias_Canalizacion entity, Spartane.Core.Domain.User.GlobalData Detalle_Diligencias_CanalizacionInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Detalle_Diligencias_Canalizacion.Detalle_Diligencias_Canalizacion>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_Diligencias_Canalizacion.Detalle_Diligencias_Canalizacion>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_Diligencias_Canalizacion.Detalle_Diligencias_Canalizacion>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Detalle_Diligencias_Canalizacion.Detalle_Diligencias_CanalizacionPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_Diligencias_Canalizacion.Detalle_Diligencias_Canalizacion>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Detalle_Diligencias_Canalizacion.Detalle_Diligencias_Canalizacion_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Detalle_Diligencias_Canalizacion.Detalle_Diligencias_Canalizacion_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

