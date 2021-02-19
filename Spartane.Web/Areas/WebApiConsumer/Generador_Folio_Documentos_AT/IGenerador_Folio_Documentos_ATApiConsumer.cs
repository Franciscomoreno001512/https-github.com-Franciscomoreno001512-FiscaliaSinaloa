using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Generador_Folio_Documentos_AT
{
    public interface IGenerador_Folio_Documentos_ATApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_ATPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Generador_Folio_Documentos_ATInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT entity, Spartane.Core.Domain.User.GlobalData Generador_Folio_Documentos_ATInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT entity, Spartane.Core.Domain.User.GlobalData Generador_Folio_Documentos_ATInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_ATPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

