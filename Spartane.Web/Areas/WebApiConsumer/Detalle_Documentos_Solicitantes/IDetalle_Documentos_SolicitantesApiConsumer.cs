using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Detalle_Documentos_Solicitantes
{
    public interface IDetalle_Documentos_SolicitantesApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Detalle_Documentos_Solicitantes.Detalle_Documentos_Solicitantes>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_Documentos_Solicitantes.Detalle_Documentos_Solicitantes>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Detalle_Documentos_Solicitantes.Detalle_Documentos_Solicitantes> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Detalle_Documentos_Solicitantes.Detalle_Documentos_SolicitantesPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_Documentos_SolicitantesInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Detalle_Documentos_Solicitantes.Detalle_Documentos_Solicitantes entity, Spartane.Core.Domain.User.GlobalData Detalle_Documentos_SolicitantesInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Detalle_Documentos_Solicitantes.Detalle_Documentos_Solicitantes entity, Spartane.Core.Domain.User.GlobalData Detalle_Documentos_SolicitantesInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Detalle_Documentos_Solicitantes.Detalle_Documentos_Solicitantes>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_Documentos_Solicitantes.Detalle_Documentos_Solicitantes>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_Documentos_Solicitantes.Detalle_Documentos_Solicitantes>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Detalle_Documentos_Solicitantes.Detalle_Documentos_SolicitantesPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Detalle_Documentos_Solicitantes.Detalle_Documentos_Solicitantes>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Detalle_Documentos_Solicitantes.Detalle_Documentos_Solicitantes_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Detalle_Documentos_Solicitantes.Detalle_Documentos_Solicitantes_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

