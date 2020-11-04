using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Catalogo_Unidad_Administrativa_CC
{
    public interface ICatalogo_Unidad_Administrativa_CCApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Catalogo_Unidad_Administrativa_CC.Catalogo_Unidad_Administrativa_CC>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Catalogo_Unidad_Administrativa_CC.Catalogo_Unidad_Administrativa_CC>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Catalogo_Unidad_Administrativa_CC.Catalogo_Unidad_Administrativa_CC> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Catalogo_Unidad_Administrativa_CC.Catalogo_Unidad_Administrativa_CCPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Catalogo_Unidad_Administrativa_CCInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Catalogo_Unidad_Administrativa_CC.Catalogo_Unidad_Administrativa_CC entity, Spartane.Core.Domain.User.GlobalData Catalogo_Unidad_Administrativa_CCInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Catalogo_Unidad_Administrativa_CC.Catalogo_Unidad_Administrativa_CC entity, Spartane.Core.Domain.User.GlobalData Catalogo_Unidad_Administrativa_CCInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Catalogo_Unidad_Administrativa_CC.Catalogo_Unidad_Administrativa_CC>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Catalogo_Unidad_Administrativa_CC.Catalogo_Unidad_Administrativa_CC>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Catalogo_Unidad_Administrativa_CC.Catalogo_Unidad_Administrativa_CC>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Catalogo_Unidad_Administrativa_CC.Catalogo_Unidad_Administrativa_CCPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Catalogo_Unidad_Administrativa_CC.Catalogo_Unidad_Administrativa_CC>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Catalogo_Unidad_Administrativa_CC.Catalogo_Unidad_Administrativa_CC_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Catalogo_Unidad_Administrativa_CC.Catalogo_Unidad_Administrativa_CC_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

