using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Adicciones_de_Involucrado
{
    public interface IAdicciones_de_InvolucradoApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Adicciones_de_Involucrado.Adicciones_de_Involucrado>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Adicciones_de_Involucrado.Adicciones_de_Involucrado>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Adicciones_de_Involucrado.Adicciones_de_Involucrado> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Adicciones_de_Involucrado.Adicciones_de_InvolucradoPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Adicciones_de_InvolucradoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Adicciones_de_Involucrado.Adicciones_de_Involucrado entity, Spartane.Core.Domain.User.GlobalData Adicciones_de_InvolucradoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Adicciones_de_Involucrado.Adicciones_de_Involucrado entity, Spartane.Core.Domain.User.GlobalData Adicciones_de_InvolucradoInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Adicciones_de_Involucrado.Adicciones_de_Involucrado>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Adicciones_de_Involucrado.Adicciones_de_Involucrado>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Adicciones_de_Involucrado.Adicciones_de_Involucrado>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Adicciones_de_Involucrado.Adicciones_de_InvolucradoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Adicciones_de_Involucrado.Adicciones_de_Involucrado>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Adicciones_de_Involucrado.Adicciones_de_Involucrado_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Adicciones_de_Involucrado.Adicciones_de_Involucrado_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

