using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Recepcionistas
{
    public interface IRecepcionistasApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Recepcionistas.Recepcionistas>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Recepcionistas.Recepcionistas>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Recepcionistas.Recepcionistas> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Recepcionistas.RecepcionistasPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData RecepcionistasInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Recepcionistas.Recepcionistas entity, Spartane.Core.Domain.User.GlobalData RecepcionistasInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Recepcionistas.Recepcionistas entity, Spartane.Core.Domain.User.GlobalData RecepcionistasInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Recepcionistas.Recepcionistas>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Recepcionistas.Recepcionistas>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Recepcionistas.Recepcionistas>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Recepcionistas.RecepcionistasPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Recepcionistas.Recepcionistas>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Recepcionistas.Recepcionistas_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Recepcionistas.Recepcionistas_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

