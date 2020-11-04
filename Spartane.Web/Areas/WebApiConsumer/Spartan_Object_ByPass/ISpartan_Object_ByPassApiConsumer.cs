using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Spartan_Object_ByPass
{
    public interface ISpartan_Object_ByPassApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPassPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Spartan_Object_ByPassInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass entity, Spartane.Core.Domain.User.GlobalData Spartan_Object_ByPassInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass entity, Spartane.Core.Domain.User.GlobalData Spartan_Object_ByPassInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPassPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Spartan_Object_ByPass.Spartan_Object_ByPass_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

