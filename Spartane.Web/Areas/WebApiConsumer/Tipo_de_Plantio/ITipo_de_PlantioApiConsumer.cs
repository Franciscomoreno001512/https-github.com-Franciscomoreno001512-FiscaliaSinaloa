using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Tipo_de_Plantio
{
    public interface ITipo_de_PlantioApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Tipo_de_Plantio.Tipo_de_Plantio>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Tipo_de_Plantio.Tipo_de_Plantio>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Tipo_de_Plantio.Tipo_de_Plantio> GetByKey(short Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Tipo_de_Plantio.Tipo_de_PlantioPagingModel> GetByKeyComplete(short Key);
        ApiResponse<bool> Delete(short Key, Spartane.Core.Domain.User.GlobalData Tipo_de_PlantioInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int16> Insert(Spartane.Core.Domain.Tipo_de_Plantio.Tipo_de_Plantio entity, Spartane.Core.Domain.User.GlobalData Tipo_de_PlantioInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int16> Update(Spartane.Core.Domain.Tipo_de_Plantio.Tipo_de_Plantio entity, Spartane.Core.Domain.User.GlobalData Tipo_de_PlantioInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Tipo_de_Plantio.Tipo_de_Plantio>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Tipo_de_Plantio.Tipo_de_Plantio>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Tipo_de_Plantio.Tipo_de_Plantio>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Tipo_de_Plantio.Tipo_de_PlantioPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Tipo_de_Plantio.Tipo_de_Plantio>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<short> GenerateID();
		ApiResponse<short> Update_Datos_Generales(Spartane.Core.Domain.Tipo_de_Plantio.Tipo_de_Plantio_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Tipo_de_Plantio.Tipo_de_Plantio_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

