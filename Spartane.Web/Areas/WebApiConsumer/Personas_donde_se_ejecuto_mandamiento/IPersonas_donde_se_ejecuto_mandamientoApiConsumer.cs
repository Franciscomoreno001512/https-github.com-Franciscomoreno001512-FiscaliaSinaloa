using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Personas_donde_se_ejecuto_mandamiento
{
    public interface IPersonas_donde_se_ejecuto_mandamientoApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamientoPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Personas_donde_se_ejecuto_mandamientoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento entity, Spartane.Core.Domain.User.GlobalData Personas_donde_se_ejecuto_mandamientoInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento entity, Spartane.Core.Domain.User.GlobalData Personas_donde_se_ejecuto_mandamientoInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamientoPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

