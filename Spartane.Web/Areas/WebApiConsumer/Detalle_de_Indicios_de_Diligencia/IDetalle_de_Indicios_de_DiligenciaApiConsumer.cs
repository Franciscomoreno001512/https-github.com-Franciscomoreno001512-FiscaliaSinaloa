using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Detalle_de_Indicios_de_Diligencia
{
    public interface IDetalle_de_Indicios_de_DiligenciaApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Indicios_de_Diligencia.Detalle_de_Indicios_de_Diligencia>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Indicios_de_Diligencia.Detalle_de_Indicios_de_Diligencia>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Detalle_de_Indicios_de_Diligencia.Detalle_de_Indicios_de_Diligencia> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Detalle_de_Indicios_de_Diligencia.Detalle_de_Indicios_de_DiligenciaPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_de_Indicios_de_DiligenciaInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Detalle_de_Indicios_de_Diligencia.Detalle_de_Indicios_de_Diligencia entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Indicios_de_DiligenciaInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Detalle_de_Indicios_de_Diligencia.Detalle_de_Indicios_de_Diligencia entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Indicios_de_DiligenciaInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Indicios_de_Diligencia.Detalle_de_Indicios_de_Diligencia>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Indicios_de_Diligencia.Detalle_de_Indicios_de_Diligencia>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Indicios_de_Diligencia.Detalle_de_Indicios_de_Diligencia>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Detalle_de_Indicios_de_Diligencia.Detalle_de_Indicios_de_DiligenciaPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_de_Indicios_de_Diligencia.Detalle_de_Indicios_de_Diligencia>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Detalle_de_Indicios_de_Diligencia.Detalle_de_Indicios_de_Diligencia_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Detalle_de_Indicios_de_Diligencia.Detalle_de_Indicios_de_Diligencia_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

