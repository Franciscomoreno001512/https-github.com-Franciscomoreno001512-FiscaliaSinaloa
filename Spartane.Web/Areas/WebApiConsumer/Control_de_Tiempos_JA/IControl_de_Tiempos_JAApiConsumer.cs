using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Control_de_Tiempos_JA
{
    public interface IControl_de_Tiempos_JAApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Control_de_Tiempos_JA.Control_de_Tiempos_JA>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Control_de_Tiempos_JA.Control_de_Tiempos_JA>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Control_de_Tiempos_JA.Control_de_Tiempos_JA> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Control_de_Tiempos_JA.Control_de_Tiempos_JAPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Control_de_Tiempos_JAInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Control_de_Tiempos_JA.Control_de_Tiempos_JA entity, Spartane.Core.Domain.User.GlobalData Control_de_Tiempos_JAInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Control_de_Tiempos_JA.Control_de_Tiempos_JA entity, Spartane.Core.Domain.User.GlobalData Control_de_Tiempos_JAInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Control_de_Tiempos_JA.Control_de_Tiempos_JA>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Control_de_Tiempos_JA.Control_de_Tiempos_JA>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Control_de_Tiempos_JA.Control_de_Tiempos_JA>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Control_de_Tiempos_JA.Control_de_Tiempos_JAPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Control_de_Tiempos_JA.Control_de_Tiempos_JA>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Control_de_Tiempos_JA.Control_de_Tiempos_JA_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Control_de_Tiempos_JA.Control_de_Tiempos_JA_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

