using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Spartan_Attribute_Bypass
{
    public interface ISpartan_Attribute_BypassApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Spartan_Attribute_Bypass.Spartan_Attribute_Bypass>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Spartan_Attribute_Bypass.Spartan_Attribute_Bypass>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Spartan_Attribute_Bypass.Spartan_Attribute_Bypass> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Spartan_Attribute_Bypass.Spartan_Attribute_BypassPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Spartan_Attribute_BypassInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Spartan_Attribute_Bypass.Spartan_Attribute_Bypass entity, Spartane.Core.Domain.User.GlobalData Spartan_Attribute_BypassInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Spartan_Attribute_Bypass.Spartan_Attribute_Bypass entity, Spartane.Core.Domain.User.GlobalData Spartan_Attribute_BypassInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Spartan_Attribute_Bypass.Spartan_Attribute_Bypass>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Spartan_Attribute_Bypass.Spartan_Attribute_Bypass>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Spartan_Attribute_Bypass.Spartan_Attribute_Bypass>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Spartan_Attribute_Bypass.Spartan_Attribute_BypassPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Spartan_Attribute_Bypass.Spartan_Attribute_Bypass>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Spartan_Attribute_Bypass.Spartan_Attribute_Bypass_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Spartan_Attribute_Bypass.Spartan_Attribute_Bypass_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

