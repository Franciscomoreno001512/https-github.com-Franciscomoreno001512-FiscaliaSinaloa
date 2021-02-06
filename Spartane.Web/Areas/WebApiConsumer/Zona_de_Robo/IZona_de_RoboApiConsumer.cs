using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Zona_de_Robo
{
    public interface IZona_de_RoboApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Zona_de_Robo.Zona_de_Robo>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Zona_de_Robo.Zona_de_Robo>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Zona_de_Robo.Zona_de_Robo> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Zona_de_Robo.Zona_de_RoboPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Zona_de_RoboInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Zona_de_Robo.Zona_de_Robo entity, Spartane.Core.Domain.User.GlobalData Zona_de_RoboInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Zona_de_Robo.Zona_de_Robo entity, Spartane.Core.Domain.User.GlobalData Zona_de_RoboInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Zona_de_Robo.Zona_de_Robo>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Zona_de_Robo.Zona_de_Robo>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Zona_de_Robo.Zona_de_Robo>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Zona_de_Robo.Zona_de_RoboPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Zona_de_Robo.Zona_de_Robo>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Zona_de_Robo.Zona_de_Robo_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Zona_de_Robo.Zona_de_Robo_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

