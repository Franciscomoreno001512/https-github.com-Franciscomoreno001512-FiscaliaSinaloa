using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Causas_de_Interrupcion
{
    public interface ICausas_de_InterrupcionApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Causas_de_Interrupcion.Causas_de_Interrupcion>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Causas_de_Interrupcion.Causas_de_Interrupcion>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Causas_de_Interrupcion.Causas_de_Interrupcion> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Causas_de_Interrupcion.Causas_de_InterrupcionPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Causas_de_InterrupcionInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Causas_de_Interrupcion.Causas_de_Interrupcion entity, Spartane.Core.Domain.User.GlobalData Causas_de_InterrupcionInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Causas_de_Interrupcion.Causas_de_Interrupcion entity, Spartane.Core.Domain.User.GlobalData Causas_de_InterrupcionInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Causas_de_Interrupcion.Causas_de_Interrupcion>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Causas_de_Interrupcion.Causas_de_Interrupcion>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Causas_de_Interrupcion.Causas_de_Interrupcion>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Causas_de_Interrupcion.Causas_de_InterrupcionPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Causas_de_Interrupcion.Causas_de_Interrupcion>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Causas_de_Interrupcion.Causas_de_Interrupcion_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Causas_de_Interrupcion.Causas_de_Interrupcion_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

