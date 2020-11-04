using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Razon_de
{
    public interface IRazon_deApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Razon_de.Razon_de>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Razon_de.Razon_de>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Razon_de.Razon_de> GetByKey(short Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Razon_de.Razon_dePagingModel> GetByKeyComplete(short Key);
        ApiResponse<bool> Delete(short Key, Spartane.Core.Domain.User.GlobalData Razon_deInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int16> Insert(Spartane.Core.Domain.Razon_de.Razon_de entity, Spartane.Core.Domain.User.GlobalData Razon_deInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int16> Update(Spartane.Core.Domain.Razon_de.Razon_de entity, Spartane.Core.Domain.User.GlobalData Razon_deInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Razon_de.Razon_de>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Razon_de.Razon_de>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Razon_de.Razon_de>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Razon_de.Razon_dePagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Razon_de.Razon_de>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<short> GenerateID();
		ApiResponse<short> Update_Datos_Generales(Spartane.Core.Domain.Razon_de.Razon_de_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Razon_de.Razon_de_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

