using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Catalogo_Motivo_de_Intervencion_CC
{
    public interface ICatalogo_Motivo_de_Intervencion_CCApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Catalogo_Motivo_de_Intervencion_CC.Catalogo_Motivo_de_Intervencion_CC>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Catalogo_Motivo_de_Intervencion_CC.Catalogo_Motivo_de_Intervencion_CC>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Catalogo_Motivo_de_Intervencion_CC.Catalogo_Motivo_de_Intervencion_CC> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Catalogo_Motivo_de_Intervencion_CC.Catalogo_Motivo_de_Intervencion_CCPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Catalogo_Motivo_de_Intervencion_CCInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Catalogo_Motivo_de_Intervencion_CC.Catalogo_Motivo_de_Intervencion_CC entity, Spartane.Core.Domain.User.GlobalData Catalogo_Motivo_de_Intervencion_CCInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Catalogo_Motivo_de_Intervencion_CC.Catalogo_Motivo_de_Intervencion_CC entity, Spartane.Core.Domain.User.GlobalData Catalogo_Motivo_de_Intervencion_CCInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Catalogo_Motivo_de_Intervencion_CC.Catalogo_Motivo_de_Intervencion_CC>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Catalogo_Motivo_de_Intervencion_CC.Catalogo_Motivo_de_Intervencion_CC>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Catalogo_Motivo_de_Intervencion_CC.Catalogo_Motivo_de_Intervencion_CC>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Catalogo_Motivo_de_Intervencion_CC.Catalogo_Motivo_de_Intervencion_CCPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Catalogo_Motivo_de_Intervencion_CC.Catalogo_Motivo_de_Intervencion_CC>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Catalogo_Motivo_de_Intervencion_CC.Catalogo_Motivo_de_Intervencion_CC_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Catalogo_Motivo_de_Intervencion_CC.Catalogo_Motivo_de_Intervencion_CC_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

