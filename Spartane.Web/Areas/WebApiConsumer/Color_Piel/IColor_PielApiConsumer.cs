using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Color_Piel
{
    public interface IColor_PielApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Color_Piel.Color_Piel>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Color_Piel.Color_Piel>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Color_Piel.Color_Piel> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Color_Piel.Color_PielPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Color_PielInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Color_Piel.Color_Piel entity, Spartane.Core.Domain.User.GlobalData Color_PielInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Color_Piel.Color_Piel entity, Spartane.Core.Domain.User.GlobalData Color_PielInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Color_Piel.Color_Piel>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Color_Piel.Color_Piel>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Color_Piel.Color_Piel>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Color_Piel.Color_PielPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Color_Piel.Color_Piel>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Color_Piel.Color_Piel_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Color_Piel.Color_Piel_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

