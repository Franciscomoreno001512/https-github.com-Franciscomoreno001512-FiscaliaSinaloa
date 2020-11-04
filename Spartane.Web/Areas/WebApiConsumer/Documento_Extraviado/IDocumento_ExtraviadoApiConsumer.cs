using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Documento_Extraviado
{
    public interface IDocumento_ExtraviadoApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Documento_Extraviado.Documento_Extraviado>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Documento_Extraviado.Documento_Extraviado>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Documento_Extraviado.Documento_Extraviado> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Documento_Extraviado.Documento_ExtraviadoPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Documento_ExtraviadoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Documento_Extraviado.Documento_Extraviado entity, Spartane.Core.Domain.User.GlobalData Documento_ExtraviadoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Documento_Extraviado.Documento_Extraviado entity, Spartane.Core.Domain.User.GlobalData Documento_ExtraviadoInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Documento_Extraviado.Documento_Extraviado>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Documento_Extraviado.Documento_Extraviado>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Documento_Extraviado.Documento_Extraviado>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Documento_Extraviado.Documento_ExtraviadoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Documento_Extraviado.Documento_Extraviado>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Documento_Extraviado.Documento_Extraviado_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Documento_Extraviado.Documento_Extraviado_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

