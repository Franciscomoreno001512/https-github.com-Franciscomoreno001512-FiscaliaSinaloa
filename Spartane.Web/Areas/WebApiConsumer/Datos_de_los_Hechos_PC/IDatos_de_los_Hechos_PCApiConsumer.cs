using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Datos_de_los_Hechos_PC
{
    public interface IDatos_de_los_Hechos_PCApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PCPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Datos_de_los_Hechos_PCInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC entity, Spartane.Core.Domain.User.GlobalData Datos_de_los_Hechos_PCInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC entity, Spartane.Core.Domain.User.GlobalData Datos_de_los_Hechos_PCInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PCPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_de_los_hechos(Spartane.Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC_Datos_de_los_hechos entity);
		ApiResponse<Spartane.Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC_Datos_de_los_hechos> Get_Datos_de_los_hechos(string Key);

		ApiResponse<int> Update_Lugar_de_los_Hechos(Spartane.Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC_Lugar_de_los_Hechos entity);
		ApiResponse<Spartane.Core.Domain.Datos_de_los_Hechos_PC.Datos_de_los_Hechos_PC_Lugar_de_los_Hechos> Get_Lugar_de_los_Hechos(string Key);


    }
}

