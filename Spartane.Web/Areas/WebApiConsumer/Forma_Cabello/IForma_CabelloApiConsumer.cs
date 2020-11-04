using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Forma_Cabello
{
    public interface IForma_CabelloApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Forma_Cabello.Forma_Cabello>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Forma_Cabello.Forma_Cabello>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Forma_Cabello.Forma_Cabello> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Forma_Cabello.Forma_CabelloPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Forma_CabelloInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Forma_Cabello.Forma_Cabello entity, Spartane.Core.Domain.User.GlobalData Forma_CabelloInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Forma_Cabello.Forma_Cabello entity, Spartane.Core.Domain.User.GlobalData Forma_CabelloInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Forma_Cabello.Forma_Cabello>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Forma_Cabello.Forma_Cabello>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Forma_Cabello.Forma_Cabello>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Forma_Cabello.Forma_CabelloPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Forma_Cabello.Forma_Cabello>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Forma_Cabello.Forma_Cabello_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Forma_Cabello.Forma_Cabello_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

