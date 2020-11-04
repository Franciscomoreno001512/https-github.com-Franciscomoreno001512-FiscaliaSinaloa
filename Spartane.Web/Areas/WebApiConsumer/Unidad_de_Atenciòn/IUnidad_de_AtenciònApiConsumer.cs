using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Unidad_de_Atenciòn
{
    public interface IUnidad_de_AtenciònApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Unidad_de_Atenciòn.Unidad_de_AtenciònPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Unidad_de_AtenciònInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn entity, Spartane.Core.Domain.User.GlobalData Unidad_de_AtenciònInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn entity, Spartane.Core.Domain.User.GlobalData Unidad_de_AtenciònInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Unidad_de_Atenciòn.Unidad_de_AtenciònPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

