using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Tribunal_de_Enjuiciamiento
{
    public interface ITribunal_de_EnjuiciamientoApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_EnjuiciamientoPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Tribunal_de_EnjuiciamientoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento entity, Spartane.Core.Domain.User.GlobalData Tribunal_de_EnjuiciamientoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento entity, Spartane.Core.Domain.User.GlobalData Tribunal_de_EnjuiciamientoInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_EnjuiciamientoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

