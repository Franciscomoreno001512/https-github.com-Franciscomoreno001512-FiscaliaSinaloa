using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Robo_de_Vehiculo_PC
{
    public interface IRobo_de_Vehiculo_PCApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PC>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PC>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PC> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PCPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Robo_de_Vehiculo_PCInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PC entity, Spartane.Core.Domain.User.GlobalData Robo_de_Vehiculo_PCInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PC entity, Spartane.Core.Domain.User.GlobalData Robo_de_Vehiculo_PCInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PC>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PC>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PC>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PCPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PC>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PC_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Robo_de_Vehiculo_PC.Robo_de_Vehiculo_PC_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

