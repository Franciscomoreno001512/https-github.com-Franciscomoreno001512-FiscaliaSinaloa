using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.PC_CanalizarA
{
    public interface IPC_CanalizarAApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.PC_CanalizarA.PC_CanalizarA>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.PC_CanalizarA.PC_CanalizarA>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.PC_CanalizarA.PC_CanalizarA> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.PC_CanalizarA.PC_CanalizarAPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData PC_CanalizarAInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.PC_CanalizarA.PC_CanalizarA entity, Spartane.Core.Domain.User.GlobalData PC_CanalizarAInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.PC_CanalizarA.PC_CanalizarA entity, Spartane.Core.Domain.User.GlobalData PC_CanalizarAInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.PC_CanalizarA.PC_CanalizarA>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.PC_CanalizarA.PC_CanalizarA>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.PC_CanalizarA.PC_CanalizarA>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.PC_CanalizarA.PC_CanalizarAPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.PC_CanalizarA.PC_CanalizarA>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.PC_CanalizarA.PC_CanalizarA_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.PC_CanalizarA.PC_CanalizarA_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

